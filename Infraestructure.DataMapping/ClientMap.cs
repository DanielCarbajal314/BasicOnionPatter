using Domain.Entities;
using Services.Interfaces.Requests;
using Services.Interfaces.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.DataMapping
{
    public static class ClientMap
    {
        static public Client ToEntity(this CreateClient createClient)
        {
            if (isNotValidType(createClient.Type))
                throw new Exception("Client type is not recoignizeW");

            return new Client()
            {
                ClienType = createClient.Type.Equals("Natural") ? ClientType.Person : ClientType.Company,
                Address = createClient.Address,
                Name = createClient.Name,
                DocumentNumber = createClient.DocumentNumber,
                Email = createClient.Email,
                Phone = createClient.Phone
            };
        }

        private static bool isNotValidType(string type)
        {
            return !type.Equals("Natural") && !type.Equals("Juridico");
        }

        static public RegisteredClient ToDTO(this Client client)
        {
            return new RegisteredClient()
            {
                Id = client.Id,
                Name = client.Name,
                Address = client.Address,
                DocumentNumber = client.DocumentNumber,
                Email = client.Email,
                Phone = client.Phone,
                Type = client.ClienType.Equals(ClientType.Person)?"Natural": "Juridico"
            };
        }
    }
}
