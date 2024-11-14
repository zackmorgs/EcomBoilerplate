using EcomServer.Data;
using Microsoft.EntityFrameworkCore;

namespace EcomServer.Services
{

    public class ReviewService
    {
        private readonly ApplicationDbContext _context;

        public ReviewService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Review> GetReviewById(int id)
        {
            var review = await _context.Reviews.FindAsync(id);
            if (review == null)
            {
                throw new Exception($"Review with id {id} not found.");
            }
            return review;
        }

        public async Task<IEnumerable<Review>> GetReviewsByUser(User User)
        {
            return await _context.Reviews.Where(r => r.User == User).ToListAsync();
        }
    }
}