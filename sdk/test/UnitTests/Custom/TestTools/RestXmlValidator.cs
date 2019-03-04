using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Threading.Tasks;

using ServiceClientGenerator;
using Amazon.Runtime.Internal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;
using System.Xml;
using System.IO;
using System.Collections;

namespace AWSSDK_DotNet35.UnitTests.TestTools
{
    public class RestXmlValidator : RequestValidator<XElement>
    {
        public RestXmlValidator(string operation, object request, IRequest marshalledRequest, ServiceModel serviceModel)
            : base (operation,request,marshalledRequest,serviceModel) { }

        protected override XElement GetMarshalledData(byte[] content)
        {
            return XElement.Load(new MemoryStream(content));
        }

        protected override XElement GetMarshalledProperty(XElement marshalledData, string propertyName)
        {
            var childProp = marshalledData.Elements().SingleOrDefault(x => x.Name.LocalName == propertyName);
            Assert.IsNotNull(childProp);
            return childProp;
        }

        protected override void ValidateProperty(object value, Member member, XElement marshalledData)
        {
            Assert.AreEqual(member.MarshallName, marshalledData.Name.LocalName);
            Assert.AreEqual(this.Operation.XmlNamespace, marshalledData.Name.NamespaceName);
        }

        protected override IEnumerable<XElement> GetMarshalledListItem(XElement marshalledData)
        {
            return marshalledData.Elements();
        }

        protected override void ValidateList(IList list, Member member, XElement marshalledData)
        {
            Assert.AreEqual(member.MarshallName, marshalledData.Name.LocalName);
        }

        protected override void ValidateListMember(object item, Shape shape, XElement marshalledListData)
        {
            Assert.AreEqual(shape.ListMarshallName ?? "member", marshalledListData.Name.LocalName);
            Assert.AreEqual(this.Operation.XmlNamespace, marshalledListData.Name.NamespaceName);
        }

        protected override IEnumerable<object> GetMarshalledMapKey(XElement marshalledData)
        {
            var keys = marshalledData.Descendants().Where(e => e.Name.LocalName == "key").Select(e => e.Value);
            Assert.IsNotNull(keys);
            return keys;
        }

        protected override XElement GetMarshalledMapValue(XElement marshalledData, object key)
        {
            /* Sample format for map entries
            <entry>
                <key>key0</key>
                <value>test-value</value>
            </entry>
            <entry>
                <key>key1</key>
                <value>test-value</value>
            </entry>
            <entry>
                <key>key2</key>
                <value>test-value</value>
            </entry>
            */
            var entryElements = marshalledData.Elements().Select(e => e.Elements().ToDictionary(k => k.Name.LocalName));
            var matchedEntry = entryElements.Single(elementsMap => elementsMap["key"].Value == key.ToString());
            return matchedEntry["value"];
        }

        protected override void ValidateMapValue(object mapValue, Member member, XElement marshalledValue)
        {
            var valueShape = member.Shape.ValueShape;
            if (valueShape.IsStructure || valueShape.IsMap || valueShape.IsList)
            {
                //Implement value checks of these other types
            }
            else
            {
                Assert.AreEqual(mapValue.ToString(), marshalledValue.Value);
            }
        }
    }
}
