using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using LibraryModel;
namespace LibraryData.Services
{
    public abstract class BaseRepository<TEntity>(LibraryContext db) :
        IBaseRepository<TEntity> where TEntity : class
    {
        public void Delete(TEntity entity)
        {

            db.Set<TEntity>().Remove(entity);
        }
        public void Delete(object Id)
        {
            var entity = GetById(Id);
            if (entity != null)
            { Delete(entity); }
            else
            {
                throw new Exception();
            }
        }
        public IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>>? where = null,
            Func<IQueryable<TEntity>?, IOrderedQueryable<TEntity>>? orderby = null, string includes = "")
        {
            IQueryable<TEntity> query = db.Set<TEntity>();

            if (where != null)
            {
                query = query.Where(where);
            }
            if (orderby != null)
            {
                query = orderby(query);
            }
            if (includes != "")
            {
                foreach (string include in includes.Split(','))
                {

                  //  query = query.Include(include);
                }
            }
            return [.. query];
            //var str = "salam";
            //var sub1 = str[1..];// str.substring(1);

        }


        public TEntity? GetById(object Id)
        {

            return db.Set<TEntity>().Find(Id);
        }

        public void Insert(TEntity entity)
        {
            #region  old code
            //if (entity.GetType() == typeof(Members))
            //{
            //    var nationalCode = entity.GetType().GetProperty(nameof(Members.NationalCode)).GetValue(entity, null).ToString();
            //    if (db.Set<Members>().Any(r => r.NationalCode.Trim() == nationalCode.Trim()))
            //    {
            //        throw new Exception("کد ملی تکراری است");
            //    }
            #endregion
            db.Add(entity);
        }
    }
}
