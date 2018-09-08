using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class PageInfo<T>
    {
        public int TotalCount { get; set; }
        public int Size { get; set; }
        public int PageCount { get; set; }
        public IEnumerable<T> List { get; set; }
        
        //private IEnumerable<T> OriginalList { get; set; }
        public PageInfo(IEnumerable<T> list, int page, int size)
        {
            //OriginalList = list;//for a-z filters
            List = list.Skip((page - 1)  * size).Take(size);
            TotalCount = list.Count();
            PageCount = Convert.ToInt32(Math.Ceiling(TotalCount / Convert.ToDouble(size)));
            Size = size;
        }
    }
}
