using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class PageInfo<T>
    {
        public int TotalCount { get; private set; }
        public int Size { get; private set; }
        public int PageCount { get; private set; }
        public IEnumerable<T> List { get; private set; }
        public IEnumerable<string> Chars { get; set; }
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
