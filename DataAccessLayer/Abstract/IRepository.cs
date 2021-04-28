using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T>
    {
        List<T> List();
        void Delete(T p);
        void Insert(T p);
        void Update(T p);
        List<T> List(Expression<Func<T, bool>> filter);
        //burdaki filter sozu bizim qoydugumuz addir
        //bu ifade bize hemin o T deki istediyimiz deyerleri cagirmagimiza komey edir
        // meselen yazar adi qedir olan setirleri capa cixarsin
     
    }
}
