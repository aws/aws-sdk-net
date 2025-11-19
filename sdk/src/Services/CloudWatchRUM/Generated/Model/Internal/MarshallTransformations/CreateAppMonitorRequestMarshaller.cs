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
 * Do not modify this file. This file is generated from the rum-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudWatchRUM.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.CloudWatchRUM.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateAppMonitor Request Marshaller
    /// </summary>       
    public class CreateAppMonitorRequestMarshaller : IMarshaller<IRequest, CreateAppMonitorRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateAppMonitorRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateAppMonitorRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudWatchRUM");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";
            request.HttpMethod = "POST";

            request.ResourcePath = "/appmonitor";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAppMonitorConfiguration())
                {
                    context.Writer.WritePropertyName("AppMonitorConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = AppMonitorConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.AppMonitorConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetCustomEvents())
                {
                    context.Writer.WritePropertyName("CustomEvents");
                    context.Writer.WriteObjectStart();

                    var marshaller = CustomEventsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.CustomEvents, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetCwLogEnabled())
                {
                    context.Writer.WritePropertyName("CwLogEnabled");
                    context.Writer.Write(publicRequest.CwLogEnabled);
                }

                if(publicRequest.IsSetDeobfuscationConfiguration())
                {
                    context.Writer.WritePropertyName("DeobfuscationConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = DeobfuscationConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.DeobfuscationConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDomain())
                {
                    context.Writer.WritePropertyName("Domain");
                    context.Writer.Write(publicRequest.Domain);
                }

                if(publicRequest.IsSetDomainList())
                {
                    context.Writer.WritePropertyName("DomainList");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestDomainListListValue in publicRequest.DomainList)
                    {
                            context.Writer.Write(publicRequestDomainListListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("Name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetPlatform())
                {
                    context.Writer.WritePropertyName("Platform");
                    context.Writer.Write(publicRequest.Platform);
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("Tags");
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
        private static CreateAppMonitorRequestMarshaller _instance = new CreateAppMonitorRequestMarshaller();        

        internal static CreateAppMonitorRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateAppMonitorRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}