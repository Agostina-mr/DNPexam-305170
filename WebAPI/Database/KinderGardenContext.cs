using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.Database
{
    public class KinderGardenContext: DbContext
    {
        public DbSet<Child> Children { private get; set; }
        public DbSet<Toy> Toy { private get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(
                @"Data Source = C:\Users\agosm\RiderProjects\DNPexam-305170\WebAPI\KinderGardenDatabase.db");
        }

        public async Task<Child> AddChild(Child child)
        {
            await Children.AddAsync(child);
            await SaveChangesAsync();
            return child;
        }

        public async Task<List<Child>> GetAllChildren()
        {
            var children = await Children.Include(c=>c.Toys).ToListAsync();
            return children;
        }

        public async Task<Toy> AddToy(int childId, Toy toy)
        {
            var childToUpdate = await Children.Include(c => c.Toys).FirstOrDefaultAsync(c => c.ChildId == childId);
            childToUpdate.Toys.Add(toy);
            Update(childToUpdate);
            await SaveChangesAsync();
            return toy;
        }

        public async Task DeleteToy(int toyId)
        {
            Console.WriteLine(toyId);
            var toyToDelete = await Toy.FirstOrDefaultAsync(t => t.ToyId == toyId);
            Console.WriteLine(toyToDelete.Color);
            
            if (toyToDelete!=null)
            {
                Toy.Remove(toyToDelete);
                await SaveChangesAsync();

            }
            else
            {
                throw new Exception("Not found");
            }
            
        }
    }
}