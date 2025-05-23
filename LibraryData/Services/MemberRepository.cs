using LibraryModel.Entities;
using LibraryModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LibraryData.Services
{
   public class MemberRepository(LibraryContext db) : BaseRepository<Member>(db)
    {
        public IEnumerable<Member> GetAll(Expression<Func<Member, bool>>? where = null,
               Func<IQueryable<Member>?, IOrderedQueryable<Member>>? orderby = null, string includes = "")
        {
            IQueryable<Member> query = db.Set<Member>();

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
        public void Delete(Member member)
        {

            db.Set<Member>().Remove(member);
        }
        public void Save()
        {

            db.SaveChanges();
        }

    }

    public class PermissionRepository(LibraryContext db) : BaseRepository<User>(db)
    {
        public object[] GetAllUserPermissionsByUserId(int id)
        {
            return [];
        }
    }
}
