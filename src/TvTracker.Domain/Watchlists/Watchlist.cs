using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TvTracker.Series;
using Volo.Abp.Domain.Entities;

namespace TvTracker.Watchlists
{
    public class Watchlist : AggregateRoot<int>
    {        
        public List<Serie> Series { get; set; }

        public Watchlist()
        {
            Series = new List<Serie>();
        }
    }
}
