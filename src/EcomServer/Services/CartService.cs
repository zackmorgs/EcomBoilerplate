using EcomServer.Data;
using Microsoft.EntityFrameworkCore;

namespace EcomServer.Services
{
    public class CartService {
        private readonly ApplicationDbContext _context;

        public CartService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Cart> GetCartById(int id)
        {
            return await _context.Carts.FindAsync(id);
        }

        public async Task<Cart> AddCart(Cart cart)
        {
            _context.Carts.Add(cart);
            await _context.SaveChangesAsync();
            return cart;
        }

        public async Task<Cart> UpdateCart(Cart cart)
        {
            _context.Carts.Update(cart);
            await _context.SaveChangesAsync();
            return cart;
        }

        public async Task<Cart> DeleteCart(int id)
        {
            var cart = await GetCartById(id);
            if (cart == null)
            {
                return null;
            }

            _context.Carts.Remove(cart);
            await _context.SaveChangesAsync();
            return cart;
        }
    }
}
