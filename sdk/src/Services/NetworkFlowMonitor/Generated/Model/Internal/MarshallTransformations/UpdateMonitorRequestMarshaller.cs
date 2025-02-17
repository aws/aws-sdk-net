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
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.NetworkFlowMonitor.Model.Internal.MarshallTransformations
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
            IRequest request = new DefaultRequest(publicRequest, "Amazon.NetworkFlowMonitor");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-04-19";
            request.HttpMethod = "PATCH";

            if (!publicRequest.IsSetMonitorName())
                throw new AmazonNetworkFlowMonitorException("Request object does not have required field MonitorName set");
            request.AddPathResource("{monitorName}", StringUtils.FromString(publicRequest.MonitorName));
            request.ResourcePath = "/monitors/{monitorName}";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetClientToken())
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(publicRequest.ClientToken);
                }

                else if(!(publicRequest.IsSetClientToken()))
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(Guid.NewGuid().ToString());
                }
                if(publicRequest.IsSetLocalResourcesToAdd())
                {
                    context.Writer.WritePropertyName("localResourcesToAdd");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestLocalResourcesToAddListValue in publicRequest.LocalResourcesToAdd)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = MonitorLocalResourceMarshaller.Instance;
                        marshaller.Marshall(publicRequestLocalResourcesToAddListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetLocalResourcesToRemove())
                {
                    context.Writer.WritePropertyName("localResourcesToRemove");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestLocalResourcesToRemoveListValue in publicRequest.LocalResourcesToRemove)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = MonitorLocalResourceMarshaller.Instance;
                        marshaller.Marshall(publicRequestLocalResourcesToRemoveListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetRemoteResourcesToAdd())
                {
                    context.Writer.WritePropertyName("remoteResourcesToAdd");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestRemoteResourcesToAddListValue in publicRequest.RemoteResourcesToAdd)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = MonitorRemoteResourceMarshaller.Instance;
                        marshaller.Marshall(publicRequestRemoteResourcesToAddListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetRemoteResourcesToRemove())
                {
                    context.Writer.WritePropertyName("remoteResourcesToRemove");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestRemoteResourcesToRemoveListValue in publicRequest.RemoteResourcesToRemove)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = MonitorRemoteResourceMarshaller.Instance;
                        marshaller.Marshall(publicRequestRemoteResourcesToRemoveListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
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