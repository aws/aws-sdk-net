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
 * Do not modify this file. This file is generated from the iot-data-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IotData.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;
#pragma warning disable CS0612,CS0618
namespace Amazon.IotData.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListNamedShadowsForThing Request Marshaller
    /// </summary>       
    public class ListNamedShadowsForThingRequestMarshaller : IMarshaller<IRequest, ListNamedShadowsForThingRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListNamedShadowsForThingRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListNamedShadowsForThingRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IotData");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-05-28";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetThingName())
                throw new AmazonIotDataException("Request object does not have required field ThingName set");
            request.AddPathResource("{thingName}", StringUtils.FromString(publicRequest.ThingName));
            
            if (publicRequest.IsSetNextToken())
                request.Parameters.Add("nextToken", StringUtils.FromString(publicRequest.NextToken));
            
            if (publicRequest.IsSetPageSize())
                request.Parameters.Add("pageSize", StringUtils.FromInt(publicRequest.PageSize));
            request.ResourcePath = "/api/things/shadow/ListNamedShadowsForThing/{thingName}";
            request.UseQueryString = true;

            return request;
        }
        private static ListNamedShadowsForThingRequestMarshaller _instance = new ListNamedShadowsForThingRequestMarshaller();        

        internal static ListNamedShadowsForThingRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListNamedShadowsForThingRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}