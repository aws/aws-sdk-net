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
    /// DeleteViewVersion Request Marshaller
    /// </summary>       
    public class DeleteViewVersionRequestMarshaller : IMarshaller<IRequest, DeleteViewVersionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteViewVersionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DeleteViewVersionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Connect");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-08-08";
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetInstanceId())
                throw new AmazonConnectException("Request object does not have required field InstanceId set");
            request.AddPathResource("{InstanceId}", StringUtils.FromString(publicRequest.InstanceId));
            if (!publicRequest.IsSetViewId())
                throw new AmazonConnectException("Request object does not have required field ViewId set");
            request.AddPathResource("{ViewId}", StringUtils.FromString(publicRequest.ViewId));
            if (!publicRequest.IsSetViewVersion())
                throw new AmazonConnectException("Request object does not have required field ViewVersion set");
            request.AddPathResource("{ViewVersion}", StringUtils.FromInt(publicRequest.ViewVersion));
            request.ResourcePath = "/views/{InstanceId}/{ViewId}/versions/{ViewVersion}";

            return request;
        }
        private static DeleteViewVersionRequestMarshaller _instance = new DeleteViewVersionRequestMarshaller();        

        internal static DeleteViewVersionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeleteViewVersionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}