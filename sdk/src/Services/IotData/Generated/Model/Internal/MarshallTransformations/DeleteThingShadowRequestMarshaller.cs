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
    /// DeleteThingShadow Request Marshaller
    /// </summary>       
    public class DeleteThingShadowRequestMarshaller : IMarshaller<IRequest, DeleteThingShadowRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteThingShadowRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DeleteThingShadowRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IotData");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-05-28";
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetThingName())
                throw new AmazonIotDataException("Request object does not have required field ThingName set");
            request.AddPathResource("{thingName}", StringUtils.FromString(publicRequest.ThingName));
            
            if (publicRequest.IsSetShadowName())
                request.Parameters.Add("name", StringUtils.FromString(publicRequest.ShadowName));
            request.ResourcePath = "/things/{thingName}/shadow";
            request.UseQueryString = true;

            return request;
        }
        private static DeleteThingShadowRequestMarshaller _instance = new DeleteThingShadowRequestMarshaller();        

        internal static DeleteThingShadowRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeleteThingShadowRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}