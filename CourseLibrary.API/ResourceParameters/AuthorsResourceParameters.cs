using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseLibrary.API.ResourceParameters
{
    public class AuthorsResourceParameters
    {
        const int maxPageSize = 20;
        const int defaultPageNumber = 1;

        private int _pageSize = 10;
        private int _pageNumber = 1;

        public string MainCategory { get; set; }
        public string SearchQuery { get; set; }

        public int PageNumber
        {
            get => _pageNumber;
            set => _pageNumber = (value < 1) ? defaultPageNumber : value;
        }
        public int PageSize
        {
            get => _pageSize;
            set => _pageSize = (value > maxPageSize) ? maxPageSize : value;
        }

        public string OrderBy { get; set; } = "Name";
    }
}
