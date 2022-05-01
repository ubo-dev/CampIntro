using InterfaceAbstractDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MernisServiceReference;

namespace InterfaceAbstractDemo.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            TCKimlikNoDogrulaRequestBody body = new TCKimlikNoDogrulaRequestBody()
            {
                Ad = customer.FirstName.ToUpper(),
                Soyad = customer.LastName.ToUpper(),
                DogumYili = customer.DateOfBirth.Year,
                TCKimlikNo = Convert.ToInt64(customer.NationalityId)
            };
            
        }

        public void Save(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
