using Lab5TestTask.Data;
using Lab5TestTask.Models;
using Lab5TestTask.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Lab5TestTask.Services.Implementations;

/// <summary>
/// SessionService implementation.
/// Implement methods here.
/// </summary>
public class SessionService : ISessionService
{
    private static readonly DateTime SessionsThresholdDate = new DateTime(2025, 1, 1);


    private readonly ApplicationDbContext _dbContext;

    public SessionService(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }


    public async Task<Session> GetSessionAsync()
    {
        try
        {
            return await _dbContext.Sessions.OrderByDescending(s => s.StartedAtUTC).FirstOrDefaultAsync() ?? null;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return null;
        }
    }


    public async Task<List<Session>> GetSessionsAsync()
    {
        try
        {
          return await _dbContext.Sessions.Where(s => s.EndedAtUTC < SessionsThresholdDate && _dbContext.Users.Any(u => u.Id == s.UserId && u.Status == Enums.UserStatus.Active)).ToListAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return [];
        }
    }
}
