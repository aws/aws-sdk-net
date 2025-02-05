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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Connect.Model;
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
namespace Amazon.Connect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteContactFlowVersion Request Marshaller
    /// </summary>       
    public class DeleteContactFlowVersionRequestMarshaller : IMarshaller<IRequest, DeleteContactFlowVersionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteContactFlowVersionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DeleteContactFlowVersionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Connect");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-08-08";
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetContactFlowId())
                throw new AmazonConnectException("Request object does not have required field ContactFlowId set");
            request.AddPathResource("{ContactFlowId}", StringUtils.FromString(publicRequest.ContactFlowId));
            if (!publicRequest.IsSetContactFlowVersion())
                throw new AmazonConnectException("Request object does not have required field ContactFlowVersion set");
            request.AddPathResource("{ContactFlowVersion}", StringUtils.FromLong(publicRequest.ContactFlowVersion));
            if (!publicRequest.IsSetInstanceId())
                throw new AmazonConnectException("Request object does not have required field InstanceId set");
            request.AddPathResource("{InstanceId}", StringUtils.FromString(publicRequest.InstanceId));
            request.ResourcePath = "/contact-flows/{InstanceId}/{ContactFlowId}/version/{ContactFlowVersion}";

            return request;
        }
        private static DeleteContactFlowVersionRequestMarshaller _instance = new DeleteContactFlowVersionRequestMarshaller();        

        internal static DeleteContactFlowVersionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeleteContactFlowVersionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}