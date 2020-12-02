using DNP_Assignment3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DNP_Assignment3.Data
{
    public class AdultService : IAdultService
    {
        IList<Adult> Adults { get; set; }
        public async Task<IList<Adult>> GetAdultsAsync()
        {

            List<Adult> adults;
            using (DataContext ctx = new DataContext())
            {
                adults = ctx.Adults.ToList();
                await ctx.SaveChangesAsync();
            }
            return adults;
        }
    }
}
