using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Amazon.Runtime.Internal;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using ServiceClientGenerator;

namespace AWSSDK_DotNet.UnitTests.TestTools
{
    public class EndpointDiscoveryValidator
    {
        public EndpointDiscoveryValidator(EndpointDiscoveryDataBase data, object request, ServiceModel serviceModel, Operation operation)
        {
            this.Data = data;
            this.Request = request;
            this.Model = serviceModel;
            this.Operation = operation;
        }

        EndpointDiscoveryDataBase Data { get; set; }
        object Request { get; set; }
        ServiceModel Model { get; set; }
        Operation Operation { get; set; }

        public void Validate()
        {
            Assert.AreEqual(Data.Required, Operation.IsEndpointDiscoveryRequired);
            var properties = Request.GetType().GetProperties();
            Dictionary<string, PropertyInfo> infoLookup = new Dictionary<string, PropertyInfo>();
            foreach(var info in properties)
            {
                infoLookup.Add(info.Name, info);
            }

            foreach (var identifier in Data.Identifiers)
            {        
                Validate(Operation.RequestEndpointDiscoveryIdMembers, identifier.Key, identifier.Value, infoLookup, Request);
            }
        }

        public void Validate(IList<Member> members, string name, string value, Dictionary<string, PropertyInfo> infoLookup, object owningObject)
        {
            Member useMember = null;
            foreach(var member in members)
            {
                if(member.PropertyName == name)
                {
                    useMember = member;
                    break;
                }
            }

            Assert.IsNotNull(useMember);
            Assert.IsTrue(infoLookup.ContainsKey(name));
            var propertyValue = infoLookup[name].GetMethod.Invoke(owningObject, new object[] { });
            Assert.AreEqual(propertyValue, value);
        }        
    }
}
