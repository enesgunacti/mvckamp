using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAboutService
    {
        List<About> GetAboutList();
        void AddAboutBL(About about);
        About GetById(int id);
        void AboutDelete(About about);
        void AboutUpdate(About about);
    }
}
