using Lab5TestTask.Data;
using Lab5TestTask.Enums;
using Lab5TestTask.Models;
using Lab5TestTask.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Lab5TestTask.Services.Implementations;

/// <summary>
/// UserService implementation.
/// Implement methods here.
/// </summary>
public class UserService : IUserService
{
    private const DeviceType UsersDeviceFilter = DeviceType.Mobile;

    private readonly ApplicationDbContext _dbContext;

    public UserService(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<User> GetUserAsync()
    {
        try
        {
            // or return await _dbContext.Users.OrderByDescending(u => _dbContext.Sessions.Where(s => s.UserId == u.Id).Count()).FirstAsync();
            return await _dbContext.Users.OrderByDescending(u => u.Sessions.Count).FirstAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return null;
        }
    }

    public async Task<List<User>> GetUsersAsync()
    {
        try
        {
            return await _dbContext.Users.Where(u => _dbContext.Sessions.Any(s => s.UserId == u.Id && s.DeviceType == UsersDeviceFilter)).ToListAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return [];
        }
    }
}
