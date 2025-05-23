using LibraryModel;
using LibraryModel.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LibraryData.Services
{ 
     public class UserRepository(LibraryContext db) : BaseRepository<User>(db)
    {
        public IEnumerable<User> GetAll(Expression<Func<User, bool>>? where = null,
                 Func<IQueryable<User>?, IOrderedQueryable<User>>? orderby = null, string includes = "")
        {
            IQueryable<User> query = db.Set<User>();

            if (where != null)
            {
                query = query?.Where(where);
            }
            if (orderby != null)
            {
                query = orderby(query);
            }
            if (includes != "")
            {
                foreach (string include in includes.Split(','))
                {

                    query = query.Include(include);

                }
            }
            return query.ToList();
        }


  
        //public List<Member> GetAllDeactivatedMembers()
        //{
        //    return [];
        //}
        public void Delete(User user)
        {
          
            db.Set<User>().Remove(user);
        }
        public void Save ()
        {
            db.SaveChanges();     }

    }

}
