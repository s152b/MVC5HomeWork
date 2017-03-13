using System;
using System.Linq;
using System.Collections.Generic;
	
namespace MVC5HomeWork.Models
{   
	public  class 客戶資料Repository : EFRepository<客戶資料>, I客戶資料Repository
	{
        public 客戶資料 Find(int id)
        {
            return this.All().FirstOrDefault(c=>c.Id == id);
        }

        public override IQueryable<客戶資料> All()
        {
            return base.All().Where(c => false == c.是否已刪除);
        }

        public IQueryable<客戶資料> All(bool showAll)
        {
            if (showAll)
            {
                return base.All();
            }
            else
            {
                return this.All();
            }
        }

        public override void Delete(客戶資料 entity)
        {
            //this.UnitOfWork.Context.Configuration.ValidateOnSaveEnabled = false;
            entity.是否已刪除 = true;
        }
    }

	public  interface I客戶資料Repository : IRepository<客戶資料>
	{

	}
}