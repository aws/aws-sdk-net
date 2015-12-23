using Amazon.Runtime.Internal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServiceClientGenerator;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AWSSDK_DotNet35.UnitTests.TestTools
{
    public abstract class RequestValidator
    {
        public static void Validate(string operation, object request, IRequest marshalledRequest, ServiceModel serviceModel)
        {
            switch (serviceModel.Type)
            {
                //case ServiceType.Json:
                //    break;
                //case ServiceType.Query:
                //    break;
                case ServiceType.Rest_Xml:
                    new RestXmlValidator(operation, request, marshalledRequest, serviceModel).Validate();
                    break;
                case ServiceType.Rest_Json:
                case ServiceType.Json:
                    new RestJsonValidator(operation, request, marshalledRequest, serviceModel).Validate();
                    break;
                default:
                    throw new InvalidOperationException();
            }

        }
    }

    public abstract class RequestValidator<T> : RequestValidator
    {
        protected ServiceModel ServiceModel { get; set; }
        protected object Request { get; set; }
        protected IRequest MarshalledRequest { get; set; }
        protected Operation Operation { get; set; }

        public RequestValidator(string operation, object request, IRequest marshalledRequest, ServiceModel serviceModel)
        {
            this.ServiceModel = serviceModel;
            this.Request = request;
            this.MarshalledRequest = marshalledRequest;
            this.Operation = serviceModel.FindOperation(operation);           
        }

        public virtual void Validate()
        {
            var type = this.Request.GetType();
            ValidateHeaders(type.GetProperties());
            ValidateQueryParameters(type.GetProperties());
            ValidateUriParameters(type.GetProperties());
            ValidateStreamingContent();
            ValidateBody();
        }

        protected abstract T GetMarshalledData(byte[] content);

        protected virtual void ValidateBody()
        {
            var payload = this.Operation.RequestPayloadMember;
            var payloadMarshalled = payload != null && payload.IsStructure;
            if (this.Operation.RequestHasBodyMembers || payloadMarshalled)
            {
                Assert.IsTrue(this.MarshalledRequest.Content.Count() > 0);
                T marshalledData = GetMarshalledData(this.MarshalledRequest.Content);

                var parentType = this.Operation.RequestPayloadMember == null ?
                    this.Request.GetType() :
                    this.Request.GetType().GetProperties().Single(p => p.Name == this.Operation.RequestPayloadMember.PropertyName).PropertyType;

                var parentObject = this.Operation.RequestPayloadMember == null ?
                    this.Request :
                    this.Request.GetType().GetProperties().Single(p => p.Name == this.Operation.RequestPayloadMember.PropertyName).GetValue(this.Request);

                var members = this.Operation.RequestPayloadMember == null ?
                    this.Operation.RequestBodyMembers :
                    this.Operation.RequestPayloadMember.Shape.Members;

                foreach (var property in parentType.GetProperties(BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance))
                {
                    if (this.Operation.RequestHeaderMembers.Any(m=>m.PropertyName == property.Name) ||
                        this.Operation.RequestQueryStringMembers.Any(m => m.PropertyName == property.Name) ||
                        this.Operation.RequestUriMembers.Any(m => m.PropertyName == property.Name))
                    {
                        continue;
                    }

                    if (property.PropertyType.BaseType.FullName == "System.MulticastDelegate")
                    {
                        continue;
                    }

                    var childMember = members.Single(m => m.PropertyName == property.Name);
                    var childValue = property.GetValue(parentObject);
                    var childMarshalledData = GetMarshalledProperty(marshalledData, childMember.MarshallName);
                    Visit(childValue, childMember, childMarshalledData);
                }
            }
            else
            {
                Assert.IsNull(this.MarshalledRequest.Content);
            }
        }

        protected abstract T GetMarshalledProperty(T marshalledData, string propertyName);

        void Visit(object value, Member member, T marshalledData)
        {
            var type = value.GetType();

            if (type.IsPrimitive || type == typeof(string))
            {   
                ValidateProperty(value, member, marshalledData);
            }
            else if (type == typeof(DateTime))
            {
                ValidateProperty(value, member, marshalledData);
            }
            else if (type == typeof(MemoryStream))
            {
                ValidateProperty(value, member, marshalledData);
            }
            else if (type.BaseType.FullName == "Amazon.Runtime.ConstantClass")
            {
                ValidateProperty(value.ToString(), member, marshalledData);
            }
            else if (type.GetInterface("System.Collections.IList") != null)
            {
                var list = value as IList;
                Assert.IsTrue(member.IsList);
                ValidateList(list, member, marshalledData);
                var enumerator = GetMarshalledListItem(marshalledData).GetEnumerator();
                foreach (var item in list)
                {
                    enumerator.MoveNext();
                    var marshalledListData = enumerator.Current;

                    ValidateListMember(item, member.Shape, marshalledListData);                        
                    if (member.Shape.ListShape.IsStructure)
                    {
                        // It's a list of complex type                        
                        foreach (var property in item.GetType().GetProperties(BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance))
                        {
                            var childMember = member.Shape.ListShape.Members.Single(m => m.PropertyName == property.Name);
                            var childValue = property.GetValue(item);
                            var childMarshalledData = GetMarshalledProperty(marshalledListData, childMember.MarshallName);
                            Visit(childValue, childMember, childMarshalledData);
                        }
                    }
                }
            }
            else if (type.GetInterface("System.Collections.IDictionary") != null)
            {
                var map = value as IDictionary;
                Assert.IsTrue(member.IsMap);
                ValidateMap(map, member, marshalledData);
                var enumerator = GetMarshalledMapKey(marshalledData).GetEnumerator();
                foreach (var item in map.Keys)
                {
                    enumerator.MoveNext();
                    var marshalledKey = enumerator.Current;
                    ValidateMapKey(item, member, marshalledKey);

                    var marshalledValue = GetMarshalledMapValue(marshalledData, marshalledKey);
                    var mapValue = map[item];
                    if (member.Shape.ValueShape.IsStructure)
                    {
                        // Map's value is of complex type
                        ValidateMapValue(mapValue, member, marshalledValue);
                        foreach (var property in mapValue.GetType().GetProperties(BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance))
                        {
                            var childMember = member.Shape.ValueShape.Members.Single(m => m.PropertyName == property.Name);
                            var childValue = property.GetValue(mapValue);
                            var childMarshalledData = GetMarshalledProperty(marshalledValue, childMember.MarshallName);
                            Visit(childValue, childMember, childMarshalledData);
                        }
                    }
                    else
                    {
                        ValidateMapValue(mapValue, member, marshalledValue);
                    }
                }
            }
            else
            {
                // It's a complex type
                foreach (var property in type.GetProperties(BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance))
                {
                    var childMember = member.Shape.Members.Single(m => m.PropertyName == property.Name);
                    var childValue = property.GetValue(value);
                    var childMarshalledData = GetMarshalledProperty(marshalledData, childMember.MarshallName);
                    Visit(childValue, childMember, childMarshalledData);
                }
            }
        }

        private void ValidateMap(IDictionary map, Member member, T marshalledData) { }

        protected virtual void ValidateList(IList list, Member member, T marshalledData) { }

        protected virtual void ValidateMapValue(object mapValue, Member member, T marshalledValue) { }

        protected virtual void ValidateMapKey(object item, Member member, object marshalledKey) { }

        protected virtual void ValidateListMember(object item, Shape shapeWrapper, T marshalledListData) { }

        protected virtual void ValidateProperty(object value, Member member, T marshalledData) { }

        protected abstract IEnumerable<T> GetMarshalledListItem(T marshalledData);

        protected abstract IEnumerable<object> GetMarshalledMapKey(T marshalledData);

        protected abstract T GetMarshalledMapValue(T marshalledData, object key);

        private void ValidateStreamingContent()
        {
            var payload = this.Operation.RequestPayloadMember;
            if (payload != null && !payload.IsStructure)
            {
                Assert.IsTrue(this.MarshalledRequest.Headers.ContainsKey("Content-Type"));
                if (!this.Operation.RequestHeaderMembers.Any(h => h.MarshallLocationName.ToLower() == "content-type"))
                {
                    Assert.AreEqual("binary/octet-stream", this.MarshalledRequest.Headers["Content-Type"]);
                }
                Assert.IsNotNull(this.MarshalledRequest.ContentStream);
            }
            else
            {
                Assert.IsNull(this.MarshalledRequest.ContentStream);
            }
        }

        protected void ValidateHeaders(IEnumerable<PropertyInfo> properties)
        {
            foreach (var property in properties)
            {
                if (property.PropertyType.IsPrimitive || property.PropertyType == typeof(string))
                {
                    var member = this.Operation.RequestHeaderMembers.SingleOrDefault(m =>
                        m.PropertyName == property.Name);
                    if (member != null)
                    {
                        Assert.IsTrue(this.MarshalledRequest.Headers.ContainsKey(member.MarshallLocationName));
                        if (member.OverrideDataType == null)
                            Assert.AreEqual(property.GetValue(this.Request), this.MarshalledRequest.Headers[member.MarshallLocationName]);
                    }
                }
            }
        }

        protected void ValidateQueryParameters(IEnumerable<PropertyInfo> properties)
        {
            if (this.Operation.RequestQueryStringMembers.Count() > 0)
            {
                foreach (var property in properties)
                {
                    if (property.PropertyType.IsPrimitive || property.PropertyType == typeof(string))
                    {
                        var member = this.Operation.RequestQueryStringMembers.SingleOrDefault(m =>
                            m.PropertyName == property.Name);
                        if (member == null)
                            continue;
                        Assert.IsTrue(this.MarshalledRequest.Parameters.ContainsKey(member.MarshallLocationName));
                        var value = this.MarshalledRequest.Parameters[member.MarshallLocationName];
                        var convertedValue = Convert.ChangeType(value, property.PropertyType);
                        Assert.AreEqual(property.GetValue(this.Request), convertedValue);
                    }
                }
            }
        }

        protected void ValidateUriParameters(IEnumerable<PropertyInfo> properties)
        {
            if (this.Operation.RequestUriMembers.Count() > 0)
            {
                var uri = this.MarshalledRequest.ResourcePath.Split('?')[0];
                var uriSegments = uri.Split('/');
                var operationUri = this.Operation.RequestUri.Split('?')[0];
                var operationUriSegments = operationUri.Split('/');

                foreach (var property in properties)
                {
                    if (property.PropertyType.IsPrimitive || property.PropertyType == typeof(string))
                    {
                        var member = this.Operation.RequestUriMembers.SingleOrDefault(m =>
                            m.PropertyName == property.Name);
                        if (member != null)
                        {
                            var index = -1;
                            for (int i = 0; i < operationUriSegments.Length; i++)
                            {
                                if (operationUriSegments[i] == string.Format("{{{0}}}", member.MarshallLocationName))
                                {
                                    index = i; break;
                                }
                            }
                            Assert.AreEqual(property.GetValue(this.Request), Convert.ChangeType(uriSegments[index], property.PropertyType));
                        }
                    }
                }
            }
        }
    }
}
