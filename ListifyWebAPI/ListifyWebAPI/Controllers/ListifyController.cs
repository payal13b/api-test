using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ListifyWebAPI.Controllers
{
    public class ListifyController : ApiController
    {
        [HttpGet]
        [Route("listify/{begin}/{end}/{index}")]
        public int GetSequenceIndex(int begin, int end, int index)
        {
            var list = GetRangeArray(begin, end);
            var val = list[50];
            return val;
        }

        public IEnumerable<int> GetSequence(int start, int end)
        {
            var seq = Enumerable.Range(start, end);
            return seq;
        }

        public IList<int> GetRangeArray(int start, int end)
        {
            var arr = GetSequence(start, end).ToArray();
            return arr;
        }
        
    }
}
