/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the rest-xml-protocol-2019-12-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.RestXmlProtocol.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Xml;

#pragma warning disable CS0612,CS0618
namespace Amazon.RestXmlProtocol.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AllQueryStringTypes Request Marshaller
    /// </summary>       
    public partial class AllQueryStringTypesRequestMarshaller : IMarshaller<IRequest, AllQueryStringTypesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((AllQueryStringTypesRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(AllQueryStringTypesRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.RestXmlProtocol");
            request.HttpMethod = "GET";
            if (publicRequest.IsSetQueryBoolean())
            {
                if(request.Parameters.ContainsKey("Boolean"))
                   request.Parameters.Remove("Boolean");
                request.Parameters.Add("Boolean", StringUtils.FromBool(publicRequest.QueryBoolean));
            }
            if (publicRequest.IsSetQueryBooleanList())
            {
                if(request.ParameterCollection.ContainsKey("BooleanList"))
                   request.ParameterCollection.Remove("BooleanList");
                request.ParameterCollection.Add("BooleanList", publicRequest.QueryBooleanList.ConvertAll<string>(item => StringUtils.FromBool(item)));

            }
            if (publicRequest.IsSetQueryByte())
            {
                if(request.Parameters.ContainsKey("Byte"))
                   request.Parameters.Remove("Byte");
                request.Parameters.Add("Byte", StringUtils.FromInt(publicRequest.QueryByte));
            }
            if (publicRequest.IsSetQueryDouble())
            {
                if(request.Parameters.ContainsKey("Double"))
                   request.Parameters.Remove("Double");
                request.Parameters.Add("Double", StringUtils.FromDouble(publicRequest.QueryDouble));
            }
            if (publicRequest.IsSetQueryDoubleList())
            {
                if(request.ParameterCollection.ContainsKey("DoubleList"))
                   request.ParameterCollection.Remove("DoubleList");
                request.ParameterCollection.Add("DoubleList", publicRequest.QueryDoubleList.ConvertAll<string>(item => StringUtils.FromDouble(item)));

            }
            if (publicRequest.IsSetQueryEnum())
            {
                if(request.Parameters.ContainsKey("Enum"))
                   request.Parameters.Remove("Enum");
                request.Parameters.Add("Enum", StringUtils.FromString(publicRequest.QueryEnum));
            }
            if (publicRequest.IsSetQueryEnumList())
            {
                if(request.ParameterCollection.ContainsKey("EnumList"))
                   request.ParameterCollection.Remove("EnumList");
                request.ParameterCollection.Add("EnumList", publicRequest.QueryEnumList);
            }
            if (publicRequest.IsSetQueryFloat())
            {
                if(request.Parameters.ContainsKey("Float"))
                   request.Parameters.Remove("Float");
                request.Parameters.Add("Float", StringUtils.FromFloat(publicRequest.QueryFloat));
            }
            if (publicRequest.IsSetQueryInteger())
            {
                if(request.Parameters.ContainsKey("Integer"))
                   request.Parameters.Remove("Integer");
                request.Parameters.Add("Integer", StringUtils.FromInt(publicRequest.QueryInteger));
            }
            if (publicRequest.IsSetQueryIntegerEnum())
            {
                if(request.Parameters.ContainsKey("IntegerEnum"))
                   request.Parameters.Remove("IntegerEnum");
                request.Parameters.Add("IntegerEnum", StringUtils.FromInt(publicRequest.QueryIntegerEnum));
            }
            if (publicRequest.IsSetQueryIntegerEnumList())
            {
                if(request.ParameterCollection.ContainsKey("IntegerEnumList"))
                   request.ParameterCollection.Remove("IntegerEnumList");
                request.ParameterCollection.Add("IntegerEnumList", publicRequest.QueryIntegerEnumList.ConvertAll<string>(item => StringUtils.FromInt(item)));

            }
            if (publicRequest.IsSetQueryIntegerList())
            {
                if(request.ParameterCollection.ContainsKey("IntegerList"))
                   request.ParameterCollection.Remove("IntegerList");
                request.ParameterCollection.Add("IntegerList", publicRequest.QueryIntegerList.ConvertAll<string>(item => StringUtils.FromInt(item)));

            }
            if (publicRequest.IsSetQueryIntegerSet())
            {
                if(request.ParameterCollection.ContainsKey("IntegerSet"))
                   request.ParameterCollection.Remove("IntegerSet");
                request.ParameterCollection.Add("IntegerSet", publicRequest.QueryIntegerSet.ConvertAll<string>(item => StringUtils.FromInt(item)));

            }
            if (publicRequest.IsSetQueryLong())
            {
                if(request.Parameters.ContainsKey("Long"))
                   request.Parameters.Remove("Long");
                request.Parameters.Add("Long", StringUtils.FromLong(publicRequest.QueryLong));
            }
            if (publicRequest.IsSetQueryParamsMapOfStrings())
            {
                foreach(var kvp in publicRequest.QueryParamsMapOfStrings)
                {
                    if(request.Parameters.ContainsKey(kvp.Key))
                       continue;
                    else
                       request.Parameters.Add(kvp.Key, StringUtils.FromString(kvp.Value));
                }
            }
            if (publicRequest.IsSetQueryShort())
            {
                if(request.Parameters.ContainsKey("Short"))
                   request.Parameters.Remove("Short");
                request.Parameters.Add("Short", StringUtils.FromInt(publicRequest.QueryShort));
            }
            if (publicRequest.IsSetQueryString())
            {
                if(request.Parameters.ContainsKey("String"))
                   request.Parameters.Remove("String");
                request.Parameters.Add("String", StringUtils.FromString(publicRequest.QueryString));
            }
            if (publicRequest.IsSetQueryStringList())
            {
                if(request.ParameterCollection.ContainsKey("StringList"))
                   request.ParameterCollection.Remove("StringList");
                request.ParameterCollection.Add("StringList", publicRequest.QueryStringList);
            }
            if (publicRequest.IsSetQueryStringSet())
            {
                if(request.ParameterCollection.ContainsKey("StringSet"))
                   request.ParameterCollection.Remove("StringSet");
                request.ParameterCollection.Add("StringSet", publicRequest.QueryStringSet);
            }
            if (publicRequest.IsSetQueryTimestamp())
            {
                if(request.Parameters.ContainsKey("Timestamp"))
                   request.Parameters.Remove("Timestamp");
                request.Parameters.Add("Timestamp", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.QueryTimestamp));
            }
            if (publicRequest.IsSetQueryTimestampList())
            {
                if(request.ParameterCollection.ContainsKey("TimestampList"))
                   request.ParameterCollection.Remove("TimestampList");
                request.ParameterCollection.Add("TimestampList", publicRequest.QueryTimestampList.ConvertAll<string>(item => StringUtils.FromDateTimeToISO8601WithOptionalMs(item)));

            }
            request.ResourcePath = "/AllQueryStringTypesInput";


            PostMarshallCustomization(request, publicRequest);
            request.UseQueryString = true;
            return request;
        }
        private static AllQueryStringTypesRequestMarshaller _instance = new AllQueryStringTypesRequestMarshaller();        

        internal static AllQueryStringTypesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AllQueryStringTypesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, AllQueryStringTypesRequest publicRequest);
    }    
}