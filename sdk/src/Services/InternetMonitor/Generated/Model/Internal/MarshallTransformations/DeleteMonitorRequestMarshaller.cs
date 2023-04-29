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
 * Do not modify this file. This file is generated from the internetmonitor-2021-06-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.InternetMonitor.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.InternetMonitor.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteMonitor Request Marshaller
    /// </summary>       
    public class DeleteMonitorRequestMarshaller : IMarshaller<IRequest, DeleteMonitorRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteMonitorRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DeleteMonitorRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.InternetMonitor");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-06-03";
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetMonitorName())
                throw new AmazonInternetMonitorException("Request object does not have required field MonitorName set");
            request.AddPathResource("{MonitorName}", StringUtils.FromString(publicRequest.MonitorName));
            request.ResourcePath = "/v20210603/Monitors/{MonitorName}";

            return request;
        }
        private static DeleteMonitorRequestMarshaller _instance = new DeleteMonitorRequestMarshaller();        

        internal static DeleteMonitorRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeleteMonitorRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}