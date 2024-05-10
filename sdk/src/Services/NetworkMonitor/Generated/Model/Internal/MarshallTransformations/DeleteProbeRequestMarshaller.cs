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
 * Do not modify this file. This file is generated from the networkmonitor-2023-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.NetworkMonitor.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.NetworkMonitor.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteProbe Request Marshaller
    /// </summary>       
    public class DeleteProbeRequestMarshaller : IMarshaller<IRequest, DeleteProbeRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteProbeRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DeleteProbeRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.NetworkMonitor");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-08-01";
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetMonitorName())
                throw new AmazonNetworkMonitorException("Request object does not have required field MonitorName set");
            request.AddPathResource("{monitorName}", StringUtils.FromString(publicRequest.MonitorName));
            if (!publicRequest.IsSetProbeId())
                throw new AmazonNetworkMonitorException("Request object does not have required field ProbeId set");
            request.AddPathResource("{probeId}", StringUtils.FromString(publicRequest.ProbeId));
            request.ResourcePath = "/monitors/{monitorName}/probes/{probeId}";

            return request;
        }
        private static DeleteProbeRequestMarshaller _instance = new DeleteProbeRequestMarshaller();        

        internal static DeleteProbeRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeleteProbeRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}