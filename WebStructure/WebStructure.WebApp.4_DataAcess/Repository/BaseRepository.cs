using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebStructure.WebApp._4_DataAcess.Repository
{
    public class BaseRepository
    {
        public Context _context { get; set; }

        public BaseRepository(Context _context)
        {
            this._context = _context;
        }
    }
}
