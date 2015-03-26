using Amazon.Runtime.Internal;
using Json.LitJson;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServiceClientGenerator;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AWSSDK_DotNet35.UnitTests.TestTools
{
    public class RestJsonValidator : RequestValidator<JsonData>
    {
        public RestJsonValidator(string operation, object request, IRequest marshalledRequest, ServiceModel serviceModel)
            : base(operation, request, marshalledRequest, serviceModel)
        {
        }

        protected override JsonData GetMarshalledData(byte[] content)
        {
            return JsonMapper.ToObject(new JsonReader(UTF8Encoding.UTF8.GetString(content)));
        }

        protected override JsonData GetMarshalledProperty(JsonData marshalledData, string propertyName)
        {
            var childData = marshalledData[propertyName];
            Assert.IsNotNull(childData);
            return childData;
        }

        protected override IEnumerable<JsonData> GetMarshalledListItem(JsonData marshalledData)
        {
            Assert.IsTrue(marshalledData.IsArray);
            for (int i = 0; i < marshalledData.Count; i++)
            {
                yield return marshalledData[i];
            }
        }

        protected override IEnumerable<object> GetMarshalledMapKey(JsonData marshalledData)
        {
            return marshalledData.PropertyNames;
        }

        protected override JsonData GetMarshalledMapValue(JsonData marshalledData, object key)
        {
            var value = marshalledData[key.ToString()];
            Assert.IsNotNull(value);
            return value;
        }
    }
}