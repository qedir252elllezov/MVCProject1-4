using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Concrete.Repository;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class CatagoryManager
    {
        GenericRepository<Catagory> repo = new GenericRepository<Catagory>();

        public List<Catagory> GettALLDl()
        {
            return repo.List();
        }
        public void CatagoryADDBl(Catagory p)
            {
            if(p.CatagoryName=="" || p.CatagoryName.Length<=3 ||
                p.CatagoryDescription=="" || p.CatagoryName.Length>=51) {
                //Hata
            }
            else 
            {
                repo.Insert(p);
            }
        }
    }
}
