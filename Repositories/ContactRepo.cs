using System.Collections.Generic;
using ContactApplication.Context;
using System.Linq;
namespace ContactApplication.Models
{
    public class ContactRepo : IRepository<Contact>
    {
        ApplicationDbContext ctx = new ApplicationDbContext();
        public bool Add(Contact sObj)
        {
            bool flag = false;
            if (sObj != null)
            {
                ctx.Contact.Add(sObj);
                ctx.SaveChanges();
                flag = true;
            }
            return flag;

        }


        public bool Delete(int Id)
        {
            bool flag = false;
            Contact rObj = ctx.Contact.FirstOrDefault(p => p.ContactId == Id);
            if (rObj != null)
            {
                ctx.Contact.Remove(rObj);
                flag = true;
                ctx.SaveChanges();
            }

            return flag;
        }

        public IEnumerable<Contact> Get()
        {
            IEnumerable<Contact> res = ctx.Contact.AsEnumerable();
            return res;

        }

        public Contact Show(int Id)
        {
            return ctx.Contact.FirstOrDefault(p => p.ContactId == Id);
        }

        public bool UpDate(int Id, Contact sObj)
        {
            bool flag = false;
            Contact rObj = ctx.Contact.FirstOrDefault(p => p.ContactId == Id);
            if (rObj != null)
            {
                //Passing sobj to rObj
                
                rObj.FirstName = sObj.FirstName;
                rObj.LastName = sObj.LastName;
                rObj.ContactNumber = sObj.ContactNumber;
                rObj.EmailAddress = sObj.EmailAddress;
                rObj.Address = sObj.Address;
              //  rObj.user_id = sObj.user_id;
                flag = true;
                ctx.SaveChanges();
            }
            return flag;
        }
    }
}