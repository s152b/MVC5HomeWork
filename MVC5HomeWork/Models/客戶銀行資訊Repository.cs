using System;
using System.Linq;
using System.Collections.Generic;

namespace MVC5HomeWork.Models
{
    public class 客戶銀行資訊Repository : EFRepository<客戶銀行資訊>, I客戶銀行資訊Repository
    {
        public 客戶銀行資訊 Find(int id)
        {
            return this.All().FirstOrDefault(c => c.Id == id);
        }

        public override IQueryable<客戶銀行資訊> All()
        {
            return base.All().Where(c => false == c.是否已刪除);
        }

        public IQueryable<客戶銀行資訊> All(bool showAll)
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

        public override void Delete(客戶銀行資訊 entity)
        {
            entity.是否已刪除 = true;
        }
    }

    public interface I客戶銀行資訊Repository : IRepository<客戶銀行資訊>
    {

    }
}