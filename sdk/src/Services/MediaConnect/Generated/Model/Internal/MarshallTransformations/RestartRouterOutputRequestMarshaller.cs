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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaConnect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.MediaConnect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RestartRouterOutput Request Marshaller
    /// </summary>       
    public class RestartRouterOutputRequestMarshaller : IMarshaller<IRequest, RestartRouterOutputRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RestartRouterOutputRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(RestartRouterOutputRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MediaConnect");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-14";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetArn())
                throw new AmazonMediaConnectException("Request object does not have required field Arn set");
            request.AddPathResource("{Arn}", StringUtils.FromString(publicRequest.Arn));
            request.ResourcePath = "/v1/routerOutput/restart/{Arn}";

            return request;
        }
        private static RestartRouterOutputRequestMarshaller _instance = new RestartRouterOutputRequestMarshaller();        

        internal static RestartRouterOutputRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RestartRouterOutputRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}