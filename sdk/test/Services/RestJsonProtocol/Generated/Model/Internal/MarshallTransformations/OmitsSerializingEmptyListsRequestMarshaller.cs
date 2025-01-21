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
 * Do not modify this file. This file is generated from the rest-json-protocol-2019-12-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.RestJsonProtocol.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.RestJsonProtocol.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// OmitsSerializingEmptyLists Request Marshaller
    /// </summary>       
    public class OmitsSerializingEmptyListsRequestMarshaller : IMarshaller<IRequest, OmitsSerializingEmptyListsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((OmitsSerializingEmptyListsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(OmitsSerializingEmptyListsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RestJsonProtocol");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-12-16";
            request.HttpMethod = "POST";

            
            if (publicRequest.IsSetQueryBooleanList())
                request.ParameterCollection.Add("BooleanList", publicRequest.QueryBooleanList.ConvertAll<string>(item => StringUtils.FromBool(item)));
            
            if (publicRequest.IsSetQueryDoubleList())
                request.ParameterCollection.Add("DoubleList", publicRequest.QueryDoubleList.ConvertAll<string>(item => StringUtils.FromDouble(item)));
            
            if (publicRequest.IsSetQueryEnumList())
                request.ParameterCollection.Add("EnumList", publicRequest.QueryEnumList);
            
            if (publicRequest.IsSetQueryIntegerEnumList())
                request.ParameterCollection.Add("IntegerEnumList", publicRequest.QueryIntegerEnumList.ConvertAll<string>(item => StringUtils.FromInt(item)));
            
            if (publicRequest.IsSetQueryIntegerList())
                request.ParameterCollection.Add("IntegerList", publicRequest.QueryIntegerList.ConvertAll<string>(item => StringUtils.FromInt(item)));
            
            if (publicRequest.IsSetQueryStringList())
                request.ParameterCollection.Add("StringList", publicRequest.QueryStringList);
            
            if (publicRequest.IsSetQueryTimestampList())
                request.ParameterCollection.Add("TimestampList", publicRequest.QueryTimestampList.ConvertAll<string>(item => StringUtils.FromDateTimeToISO8601WithOptionalMs(item)));
            request.ResourcePath = "/OmitsSerializingEmptyLists";
            request.UseQueryString = true;

            return request;
        }
        private static OmitsSerializingEmptyListsRequestMarshaller _instance = new OmitsSerializingEmptyListsRequestMarshaller();        

        internal static OmitsSerializingEmptyListsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static OmitsSerializingEmptyListsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}