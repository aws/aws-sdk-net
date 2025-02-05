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
 * Do not modify this file. This file is generated from the networkflowmonitor-2023-04-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.NetworkFlowMonitor.Model;
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
namespace Amazon.NetworkFlowMonitor.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetMonitor Request Marshaller
    /// </summary>       
    public class GetMonitorRequestMarshaller : IMarshaller<IRequest, GetMonitorRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetMonitorRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetMonitorRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.NetworkFlowMonitor");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-04-19";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetMonitorName())
                throw new AmazonNetworkFlowMonitorException("Request object does not have required field MonitorName set");
            request.AddPathResource("{monitorName}", StringUtils.FromString(publicRequest.MonitorName));
            request.ResourcePath = "/monitors/{monitorName}";

            return request;
        }
        private static GetMonitorRequestMarshaller _instance = new GetMonitorRequestMarshaller();        

        internal static GetMonitorRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetMonitorRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}