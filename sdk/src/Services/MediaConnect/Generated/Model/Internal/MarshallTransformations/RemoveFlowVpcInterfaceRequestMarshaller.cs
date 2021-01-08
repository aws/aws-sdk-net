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

namespace Amazon.MediaConnect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RemoveFlowVpcInterface Request Marshaller
    /// </summary>       
    public class RemoveFlowVpcInterfaceRequestMarshaller : IMarshaller<IRequest, RemoveFlowVpcInterfaceRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RemoveFlowVpcInterfaceRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(RemoveFlowVpcInterfaceRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MediaConnect");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-14";            
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetFlowArn())
                throw new AmazonMediaConnectException("Request object does not have required field FlowArn set");
            request.AddPathResource("{flowArn}", StringUtils.FromString(publicRequest.FlowArn));
            if (!publicRequest.IsSetVpcInterfaceName())
                throw new AmazonMediaConnectException("Request object does not have required field VpcInterfaceName set");
            request.AddPathResource("{vpcInterfaceName}", StringUtils.FromString(publicRequest.VpcInterfaceName));
            request.ResourcePath = "/v1/flows/{flowArn}/vpcInterfaces/{vpcInterfaceName}";
            request.MarshallerVersion = 2;

            return request;
        }
        private static RemoveFlowVpcInterfaceRequestMarshaller _instance = new RemoveFlowVpcInterfaceRequestMarshaller();        

        internal static RemoveFlowVpcInterfaceRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RemoveFlowVpcInterfaceRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}