using Lab5TestTask.Data;
using Lab5TestTask.Enums;
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
    private const UserStatus SessionsUserStatusFilter = UserStatus.Active;

    private const DeviceType SessionDeviceFilter = DeviceType.Desktop;

    private readonly ApplicationDbContext _dbContext;

    public SessionService(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    /// <summary>
    /// Get the earliest Desktop Session
    /// </summary>
    /// <returns>The earliest Desktop Session or null in case of exception or if there are no such Session</returns>
    public async Task<Session> GetSessionAsync()
    {
        try
        {
            return await _dbContext.Sessions.Where(s => s.DeviceType == SessionDeviceFilter).OrderBy(s => s.StartedAtUTC).FirstOrDefaultAsync() ?? null;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return null;
        }
    }

    /// <summary>
    /// Get Sessions from Active Users, that were ended before 01.01.2025
    /// </summary>
    /// <returns>The List of Sessions or empty List in case of exception or if there are no such Sessions</returns>
    public async Task<List<Session>> GetSessionsAsync()
    {
        try
        {
          return await _dbContext.Sessions.Where(s => s.EndedAtUTC < SessionsThresholdDate && _dbContext.Users.Any(u => u.Id == s.UserId && u.Status == SessionsUserStatusFilter)).ToListAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return [];
        }
    }
}
