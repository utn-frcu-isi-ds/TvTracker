using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace TvTracker.Series
{
    public class SerieDto : EntityDto<int>
    {
        public string Title { get; set; }
        public string Year { get; set; }
        public string Poster { get; set; }
    }
}