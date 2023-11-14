using Cricket_Club_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cricket_Club_Management_System.Repositories
{
    public interface ISSRepository<T>
    {
        SupportStuff SelectSupportStuff(T data);
        void InsertSupportStuff(SupportStuff supportStuff);
        void UpdateSupportStuff(SupportStuff supportStuff);
        void DeleteSupportStuff(T data);
        IEnumerable<SupportStuff> GetAllSupportStuff();
    }


    public class SupportStuffRepository : ISSRepository<int>
    {
        public SupportStuff SelectSupportStuff(int data)
        {
            SupportStuff supportStuff = SupportStuffDB.SupportStuffList.FirstOrDefault(x => x.SupportStufId == data);
            return supportStuff;
        }

        public void InsertSupportStuff(SupportStuff supportStuff)
        {
            SupportStuffDB.SupportStuffList.Add(supportStuff);
        }

        public void UpdateSupportStuff(SupportStuff supportStuff)
        {
            SupportStuff _supportStuff = SupportStuffDB.SupportStuffList.FirstOrDefault(x => x.SupportStufId == supportStuff.SupportStufId);
            if (supportStuff.SupportStufName != null)
            {
                _supportStuff.SupportStufName = supportStuff.SupportStufName;
            }
            
            if (supportStuff.Position != null)
            {
                _supportStuff.Position = supportStuff.Position;
            }
            if (supportStuff.Country != null)
            {
                _supportStuff.Country = supportStuff.Country;
            }
        }

        public void DeleteSupportStuff(int data)
        {
            SupportStuff supportStuff = SupportStuffDB.SupportStuffList.FirstOrDefault(x => x.SupportStufId == data);
            SupportStuffDB.SupportStuffList.Remove(supportStuff);
        }

        public IEnumerable<SupportStuff> GetAllSupportStuff()
        {
            return SupportStuffDB.SupportStuffList;
        }

    }
}
