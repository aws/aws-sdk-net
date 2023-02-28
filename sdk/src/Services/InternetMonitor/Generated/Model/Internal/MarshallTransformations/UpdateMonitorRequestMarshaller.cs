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
    /// UpdateMonitor Request Marshaller
    /// </summary>       
    public class UpdateMonitorRequestMarshaller : IMarshaller<IRequest, UpdateMonitorRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateMonitorRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateMonitorRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.InternetMonitor");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-06-03";
            request.HttpMethod = "PATCH";

            if (!publicRequest.IsSetMonitorName())
                throw new AmazonInternetMonitorException("Request object does not have required field MonitorName set");
            request.AddPathResource("{MonitorName}", StringUtils.FromString(publicRequest.MonitorName));
            request.ResourcePath = "/v20210603/Monitors/{MonitorName}";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetClientToken())
                {
                    context.Writer.WritePropertyName("ClientToken");
                    context.Writer.Write(publicRequest.ClientToken);
                }

                else if(!(publicRequest.IsSetClientToken()))
                {
                    context.Writer.WritePropertyName("ClientToken");
                    context.Writer.Write(Guid.NewGuid().ToString());
                }
                if(publicRequest.IsSetMaxCityNetworksToMonitor())
                {
                    context.Writer.WritePropertyName("MaxCityNetworksToMonitor");
                    context.Writer.Write(publicRequest.MaxCityNetworksToMonitor);
                }

                if(publicRequest.IsSetResourcesToAdd())
                {
                    context.Writer.WritePropertyName("ResourcesToAdd");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestResourcesToAddListValue in publicRequest.ResourcesToAdd)
                    {
                            context.Writer.Write(publicRequestResourcesToAddListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetResourcesToRemove())
                {
                    context.Writer.WritePropertyName("ResourcesToRemove");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestResourcesToRemoveListValue in publicRequest.ResourcesToRemove)
                    {
                            context.Writer.Write(publicRequestResourcesToRemoveListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetStatus())
                {
                    context.Writer.WritePropertyName("Status");
                    context.Writer.Write(publicRequest.Status);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateMonitorRequestMarshaller _instance = new UpdateMonitorRequestMarshaller();        

        internal static UpdateMonitorRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateMonitorRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}