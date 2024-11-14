using EcomServer.Data;
using EcomServer.Models;
using Microsoft.EntityFrameworkCore;

namespace EcomServer.Services
{

    public class UserService
    {
        private readonly ApplicationDbContext _context;

        public UserService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Review>> GetReviewsByUserId(int Id)
        {
            return await _context.Reviews.Where(r => r.Id == Id).ToListAsync();
        }
    }
}