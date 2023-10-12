using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bb205_tasks
{
    internal class Store
    {
        public string Name { get; set; }
        Phone[] Phones;

        public Store()
        {
            Phones = new Phone[0];
        }
        public void AddPhone(Phone phone)
        {
            Array.Resize(ref Phones, Phones.Length+1);
            Phones[Phones.Length-1] = phone;
        }

        public Phone GetPhone(int id)
        {
            foreach (Phone phone in Phones)
            {
                if(phone.Id == id)
                {
                    return phone;
                }
            }
            return null;
        }
        public void RemovePhone(int id)
        {
            if(GetPhone(id)!=null)
            {
                Phone[] removePhone=new Phone[Phones.Length-1];
                for (int i = 0; i < Phones.Length; i++)
                {
                    if(Phones[i].Id==id)
                    {
                        continue;
                    }
                    removePhone[i] = Phones[i];
                }
                Phones = removePhone;
            }
        }

    }
}
