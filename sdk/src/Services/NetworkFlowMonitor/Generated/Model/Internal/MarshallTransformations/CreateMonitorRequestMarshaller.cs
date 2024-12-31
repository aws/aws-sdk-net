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
    /// CreateMonitor Request Marshaller
    /// </summary>       
    public class CreateMonitorRequestMarshaller : IMarshaller<IRequest, CreateMonitorRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateMonitorRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateMonitorRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.NetworkFlowMonitor");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-04-19";
            request.HttpMethod = "POST";

            request.ResourcePath = "/monitors";
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
                if(publicRequest.IsSetLocalResources())
                {
                    context.Writer.WritePropertyName("localResources");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestLocalResourcesListValue in publicRequest.LocalResources)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = MonitorLocalResourceMarshaller.Instance;
                        marshaller.Marshall(publicRequestLocalResourcesListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetMonitorName())
                {
                    context.Writer.WritePropertyName("monitorName");
                    context.Writer.Write(publicRequest.MonitorName);
                }

                if(publicRequest.IsSetRemoteResources())
                {
                    context.Writer.WritePropertyName("remoteResources");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestRemoteResourcesListValue in publicRequest.RemoteResources)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = MonitorRemoteResourceMarshaller.Instance;
                        marshaller.Marshall(publicRequestRemoteResourcesListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetScopeArn())
                {
                    context.Writer.WritePropertyName("scopeArn");
                    context.Writer.Write(publicRequest.ScopeArn);
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("tags");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestTagsKvp in publicRequest.Tags)
                    {
                        context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                        var publicRequestTagsValue = publicRequestTagsKvp.Value;

                            context.Writer.Write(publicRequestTagsValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateMonitorRequestMarshaller _instance = new CreateMonitorRequestMarshaller();        

        internal static CreateMonitorRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateMonitorRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}