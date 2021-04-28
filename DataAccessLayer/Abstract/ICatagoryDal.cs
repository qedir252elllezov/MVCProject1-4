using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface ICatagoryDal
    {
        //CRUD
        List<Catagory> List();
        void Delete(Catagory p);
        void Update(Catagory p);
        void Insert(Catagory p);

    }
}
