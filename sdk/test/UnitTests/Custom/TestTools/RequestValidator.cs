using Amazon.Runtime.Internal;
using Amazon.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServiceClientGenerator;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
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
            // we override standard host prefix logic for S3 and S3 Control
            if (ServiceModel.ServiceId != "S3" && ServiceModel.ServiceId != "S3 Control")
            {
                ValidateHostPrefixParameters(type.GetProperties());
            }
            ValidateStreamingContent();
            ValidateBody();
        }

        protected abstract T GetMarshalledData(byte[] content);

        protected virtual void ValidateBody()
        {
            var payload = this.Operation.RequestPayloadMember;
            var payloadMarshalled = payload != null && !payload.IsMemoryStream && !payload.ModelShape.IsString;
            if (this.Operation.RequestHasBodyMembers || payloadMarshalled)
            {
                Assert.IsTrue(this.MarshalledRequest.Content.Count() > 0);
                T marshalledData = GetMarshalledData(this.MarshalledRequest.Content);

                if (payload != null)
                {
                    var parentObject = this.Request.GetType().GetProperties().Single(p => p.Name == payload.PropertyName).GetValue(this.Request);

                    Visit(parentObject, payload, marshalledData, new TypeCircularReference<Type>());
                }
                else
                {
                    var properties = this.Request.GetType().GetProperties(BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance);
                    foreach (var childMember in this.Operation.RequestBodyMembers)
                    {
                        var property = properties.Single(p => childMember.PropertyName == p.Name);
                        if (this.Operation.RequestHeaderMembers.Any(m => m.PropertyName == property.Name) ||
                            this.Operation.RequestQueryStringMembers.Any(m => m.PropertyName == property.Name) ||
                            this.Operation.RequestUriMembers.Any(m => m.PropertyName == property.Name))
                        {
                            continue;
                        }

                        if (property.PropertyType.BaseType.FullName == "System.MulticastDelegate")
                        {
                            continue;
                        }

                        var childValue = property.GetValue(this.Request);
                        var childMarshalledData = GetMarshalledProperty(marshalledData, childMember.MarshallName);

                        Visit(childValue, childMember, childMarshalledData, new TypeCircularReference<Type>());
                    }
                }
            }
            else if (payload?.ModelShape.IsString == true)
            {
                Assert.IsTrue(this.MarshalledRequest.Content.Any());

                var marshalledData = Encoding.UTF8.GetString(this.MarshalledRequest.Content);

                var requestData = 
                    this.Request
                        .GetType()
                        .GetProperties()
                        .Single(p => p.Name == payload.PropertyName)
                        .GetValue(this.Request);

                Assert.AreEqual(requestData, marshalledData);
            }
            else
            {
                Assert.IsNull(this.MarshalledRequest.Content);
            }
        }

        protected abstract T GetMarshalledProperty(T marshalledData, string propertyName);

        void Visit(object value, Member member, T marshalledData, TypeCircularReference<Type> tcr)
        {
            var type = value.GetType();
            var pushed = false;
            if (!type.FullName.StartsWith("System."))
            {
                pushed = tcr.Push(type);
                if (!pushed)
                    return;
            }

            try
            {
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
                    var innerListType = type.GenericTypeArguments[0];
                    if (null != innerListType && !innerListType.FullName.StartsWith("System."))
                    {
                        pushed = tcr.Push(innerListType);
                        if (!pushed)
                            return;
                    }

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
                            var properties = item.GetType().GetProperties(BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance);
                            foreach (var childMember in member.Shape.ListShape.Members)
                            {
                                var property = properties.Single(p => childMember.PropertyName == p.Name);

                                // Make sure we aren't encountering a recursive property
                                if (tcr.Contains(property.PropertyType))
                                    continue;

                                // or a List of recursive properties
                                if (typeof(ICollection).IsAssignableFrom(property.PropertyType) &&
                                    property.PropertyType.IsGenericType &&
                                    tcr.Contains(property.PropertyType.GenericTypeArguments[0]))
                                {
                                    continue;
                                }

                                // or a Dictionary of recursive properties
                                var isDictionary = typeof(IDictionary).IsAssignableFrom(property.PropertyType) &&
                                    property.PropertyType.IsGenericType;
                                var isKeyRecursive = isDictionary && property.PropertyType.GenericTypeArguments.Length > 0 &&
                                    tcr.Contains(property.PropertyType.GenericTypeArguments[0]);
                                var isValueRecursive = isDictionary && property.PropertyType.GenericTypeArguments.Length > 1 &&
                                    tcr.Contains(property.PropertyType.GenericTypeArguments[1]);
                                if (isKeyRecursive || isValueRecursive)
                                {
                                    continue;
                                }

                                var childValue = property.GetValue(item);
                                var childMarshalledData = GetMarshalledProperty(marshalledListData, childMember.MarshallName);
                                Visit(childValue, childMember, childMarshalledData, tcr);
                            }
                        }
                    }
                }
                else if (type.GetInterface("System.Collections.IDictionary") != null)
                {
                    // Include both key and value to the tcr if they aren't CLR types
                    // to allow skipping of nested type
                    var innerKeyType = type.GenericTypeArguments[0];
                    if (null != innerKeyType && !innerKeyType.FullName.StartsWith("System."))
                    {
                        pushed = tcr.Push(innerKeyType);
                        if (!pushed)
                            return;
                    }

                    var innerValueType = type.GenericTypeArguments[1];
                    if (null != innerValueType && !innerValueType.FullName.StartsWith("System."))
                    {
                        pushed = tcr.Push(innerValueType);
                        if (!pushed)
                            return;
                    }

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
                            var properties = mapValue.GetType().GetProperties(BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance);
                            foreach (var childMember in member.Shape.ValueShape.Members)
                            {
                                var property = properties.Single(p => childMember.PropertyName == p.Name);

                                // Make sure we aren't encountering a recursive property
                                if (tcr.Contains(property.PropertyType))
                                    continue;

                                // or a List of recursive properties
                                if (typeof(ICollection).IsAssignableFrom(property.PropertyType) &&
                                    property.PropertyType.IsGenericType &&
                                    tcr.Contains(property.PropertyType.GenericTypeArguments[0]))
                                {
                                    continue;
                                }

                                // or a Dictionary of recursive properties
                                var isDictionary = typeof(IDictionary).IsAssignableFrom(property.PropertyType) && 
                                    property.PropertyType.IsGenericType;
                                var isKeyRecursive = isDictionary && property.PropertyType.GenericTypeArguments.Length > 0 &&
                                    tcr.Contains(property.PropertyType.GenericTypeArguments[0]);
                                var isValueRecursive = isDictionary && property.PropertyType.GenericTypeArguments.Length > 1 &&
                                    tcr.Contains(property.PropertyType.GenericTypeArguments[1]);
                                if (isKeyRecursive || isValueRecursive)
                                {
                                    continue;
                                }

                                var childValue = property.GetValue(mapValue);
                                var childMarshalledData = GetMarshalledProperty(marshalledValue, childMember.MarshallName);
                                Visit(childValue, childMember, childMarshalledData, tcr);
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
                    var properties = type.GetProperties(BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance);
                    foreach (var childMember in member.Shape.Members)
                    {
                        var property = properties.Single(p => childMember.PropertyName == p.Name);

                        // Check that the child type and any of its generic type arguments types haven't been visited already.
                        // InstantiateClassGenerator also uses TypeCircularReference to make sure it doesn't recurse infinitely.
                        var typesToCheck = new List<Type>() { property.PropertyType };
                        typesToCheck.AddRange(property.PropertyType.GetGenericArguments());

                        if (!typesToCheck.Exists(childType => tcr.Contains(childType)))
                        {
                            var childValue = property.GetValue(value);
                            var childMarshalledData = GetMarshalledProperty(marshalledData, childMember.MarshallName);
                            Visit(childValue, childMember, childMarshalledData, tcr);
                        }
                    }
                }
            }
            finally
            {
                if (pushed)
                    tcr.Pop();
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
            if (payload != null && payload.IsMemoryStream)
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
                if (property.PropertyType.IsPrimitive || property.PropertyType == typeof(string) ||
                    property.PropertyType == typeof(DateTime))
                {
                    var member = this.Operation.RequestHeaderMembers.SingleOrDefault(m =>
                        m.PropertyName == property.Name);
                    if (member != null)
                    {
                        Assert.IsTrue(this.MarshalledRequest.Headers.ContainsKey(member.MarshallLocationName));
                        if (member.OverrideDataType == null)
                        {
                            if (member.IsJsonValue)
                            {
                                var encodedValue = Convert.ToBase64String(Encoding.UTF8.GetBytes((string)property.GetValue(this.Request)));
                                Assert.AreEqual(encodedValue, this.MarshalledRequest.Headers[member.MarshallLocationName]);
                            }
                            else if(member.IsDateTime)
                            {
                                var value = ParseUsingFormat(this.MarshalledRequest.Headers[member.MarshallLocationName], member.TimestampFormat);
                                Assert.AreEqual(((DateTime)property.GetValue(this.Request)).ToUniversalTime(), value.ToUniversalTime());
                            }
                            else if(member.Shape.IsString)
                            {
                                Assert.AreEqual(property.GetValue(this.Request), this.MarshalledRequest.Headers[member.MarshallLocationName]);
                            }
                            else
                            {
                                var value = this.MarshalledRequest.Headers[member.MarshallLocationName];
                                var convertedValue = Convert.ChangeType(value, property.PropertyType);
                                Assert.AreEqual(property.GetValue(this.Request), convertedValue);
                            }
                        }
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
                    var member = this.Operation.RequestQueryStringMembers.SingleOrDefault(m =>
                            m.PropertyName == property.Name);
                    if (member == null)
                        continue;
                    if (property.PropertyType.IsPrimitive || property.PropertyType == typeof(string))
                    {   
                        Assert.IsTrue(this.MarshalledRequest.Parameters.ContainsKey(member.MarshallLocationName));
                        var value = this.MarshalledRequest.Parameters[member.MarshallLocationName];
                        var convertedValue = Convert.ChangeType(value, property.PropertyType);
                        Assert.AreEqual(property.GetValue(this.Request), convertedValue);
                    }
                    else if(property.PropertyType == typeof(DateTime))
                    {
                        Assert.IsTrue(this.MarshalledRequest.Parameters.ContainsKey(member.MarshallLocationName));
                        var value = ParseUsingFormat(this.MarshalledRequest.Parameters[member.MarshallLocationName],
                            member.TimestampFormat);
                        Assert.AreEqual(((DateTime)property.GetValue(this.Request)).ToUniversalTime(), value.ToUniversalTime());
                    }
                }
            }
        }

        protected void ValidateUriParameters(IEnumerable<PropertyInfo> properties)
        {
            if (this.Operation.RequestUriMembers.Count() > 0)
            {   
                var splitSegments = this.MarshalledRequest.ResourcePath.Split('?')[0].Split('/');
                var uriSegments = new List<string>(splitSegments.Select(
                    segment => this.MarshalledRequest?.PathResources.ContainsKey(segment) == true 
                        ? this.MarshalledRequest.PathResources[segment] 
                        : segment
                ));

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
                                // Determines if a given member should be treated as a greedy path, meaning
                                // that the resource path contains {MEMBER_NAME+} instead of simply {MEMBER_NAME}.
                                if ((operationUriSegments[i] == string.Format("{{{0}}}", member.MarshallLocationName))|| (operationUriSegments[i] == string.Format("{{{0}+}}", member.MarshallLocationName)))
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

        protected void ValidateHostPrefixParameters(IEnumerable<PropertyInfo> properties)
        {
            if (!string.IsNullOrEmpty(this.Operation.EndpointHostPrefix))
            {
                var hostPrefix = this.MarshalledRequest.HostPrefix;
                var hostPrefixTemplate = this.Operation.EndpointHostPrefix;
                
                foreach (var property in properties)
                {
                    if (property.PropertyType.IsPrimitive || property.PropertyType == typeof(string))
                    {
                        var member = this.Operation.RequestHostPrefixMembers.SingleOrDefault(m =>
                            m.PropertyName == property.Name);
                        if (member != null)
                        {
                            // special case for host prefixes such as {AccountId}
                            if (string.Equals($"{{{member.ModelShape}}}.", hostPrefixTemplate))
                            {
                                hostPrefixTemplate = hostPrefixTemplate.Replace(string.Format("{{{0}}}", member.ModelShape), (string)property.GetValue(this.Request));
                            }
                            else
                            {
                                hostPrefixTemplate = hostPrefixTemplate.Replace(string.Format("{{{0}}}", member.MarshallLocationName), (string)property.GetValue(this.Request));
                            }                           
                        }
                    }
                }

                Assert.AreEqual(hostPrefix, hostPrefixTemplate);
                Assert.AreEqual(hostPrefixTemplate.IndexOfAny(new char[] { '{', '}' }), -1);
            }
        }

        private DateTime ParseUsingFormat(string text, TimestampFormat timestampFormat)
        {
            if (timestampFormat == TimestampFormat.ISO8601 ||
                        timestampFormat == TimestampFormat.RFC822)
            {
                return DateTime.Parse(text, CultureInfo.InvariantCulture);
            }
            else if (timestampFormat == TimestampFormat.UnixTimestamp)
            {
                var epochSeconds = Double.Parse(text, NumberStyles.Any, CultureInfo.InvariantCulture);
                return AWSSDKUtils.EPOCH_START.AddSeconds(epochSeconds);

            }
            else
            {
                throw new InvalidOperationException("Cannot parse for format " + timestampFormat);
            }
        }
    }
}
