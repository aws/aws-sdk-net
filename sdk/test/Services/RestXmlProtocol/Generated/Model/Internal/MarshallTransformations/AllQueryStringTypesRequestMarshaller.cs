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

namespace Amazon.RestXmlProtocol.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AllQueryStringTypes Request Marshaller
    /// </summary>       
    public class AllQueryStringTypesRequestMarshaller : IMarshaller<IRequest, AllQueryStringTypesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
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
                request.Parameters.Add("Boolean", StringUtils.FromBool(publicRequest.QueryBoolean));
            
            if (publicRequest.IsSetQueryBooleanList())
                request.ParameterCollection.Add("BooleanList", publicRequest.QueryBooleanList.ConvertAll<string>(item => StringUtils.FromBool(item)));
            
            if (publicRequest.IsSetQueryByte())
                request.Parameters.Add("Byte", StringUtils.FromInt(publicRequest.QueryByte));
            
            if (publicRequest.IsSetQueryDouble())
                request.Parameters.Add("Double", StringUtils.FromDouble(publicRequest.QueryDouble));
            
            if (publicRequest.IsSetQueryDoubleList())
                request.ParameterCollection.Add("DoubleList", publicRequest.QueryDoubleList.ConvertAll<string>(item => StringUtils.FromDouble(item)));
            
            if (publicRequest.IsSetQueryEnum())
                request.Parameters.Add("Enum", StringUtils.FromString(publicRequest.QueryEnum));
            
            if (publicRequest.IsSetQueryEnumList())
                request.ParameterCollection.Add("EnumList", publicRequest.QueryEnumList);
            
            if (publicRequest.IsSetQueryFloat())
                request.Parameters.Add("Float", StringUtils.FromFloat(publicRequest.QueryFloat));
            
            if (publicRequest.IsSetQueryInteger())
                request.Parameters.Add("Integer", StringUtils.FromInt(publicRequest.QueryInteger));
            
            if (publicRequest.IsSetQueryIntegerEnum())
                request.Parameters.Add("IntegerEnum", StringUtils.FromInt(publicRequest.QueryIntegerEnum));
            
            if (publicRequest.IsSetQueryIntegerEnumList())
                request.ParameterCollection.Add("IntegerEnumList", publicRequest.QueryIntegerEnumList.ConvertAll<string>(item => StringUtils.FromInt(item)));
            
            if (publicRequest.IsSetQueryIntegerList())
                request.ParameterCollection.Add("IntegerList", publicRequest.QueryIntegerList.ConvertAll<string>(item => StringUtils.FromInt(item)));
            
            if (publicRequest.IsSetQueryIntegerSet())
                request.ParameterCollection.Add("IntegerSet", publicRequest.QueryIntegerSet.ConvertAll<string>(item => StringUtils.FromInt(item)));
            
            if (publicRequest.IsSetQueryLong())
                request.Parameters.Add("Long", StringUtils.FromLong(publicRequest.QueryLong));
            
            if (publicRequest.IsSetQueryParamsMapOfStrings())
            {
                foreach(var kvp in publicRequest.QueryParamsMapOfStrings)
                {
                    request.Parameters.Add(kvp.Key, StringUtils.FromString(kvp.Value));
                }
            }
            
            if (publicRequest.IsSetQueryShort())
                request.Parameters.Add("Short", StringUtils.FromInt(publicRequest.QueryShort));
            
            if (publicRequest.IsSetQueryString())
                request.Parameters.Add("String", StringUtils.FromString(publicRequest.QueryString));
            
            if (publicRequest.IsSetQueryStringList())
                request.ParameterCollection.Add("StringList", publicRequest.QueryStringList);
            
            if (publicRequest.IsSetQueryStringSet())
                request.ParameterCollection.Add("StringSet", publicRequest.QueryStringSet);
            
            if (publicRequest.IsSetQueryTimestamp())
                request.Parameters.Add("Timestamp", StringUtils.FromDateTimeToISO8601(publicRequest.QueryTimestamp));
            
            if (publicRequest.IsSetQueryTimestampList())
                request.ParameterCollection.Add("TimestampList", publicRequest.QueryTimestampList.ConvertAll<string>(item => StringUtils.FromDateTimeToISO8601WithOptionalMs(item)));
            request.ResourcePath = "/AllQueryStringTypesInput";


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

    }    
}