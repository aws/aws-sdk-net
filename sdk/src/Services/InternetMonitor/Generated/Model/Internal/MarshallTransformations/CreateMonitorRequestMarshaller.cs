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
            IRequest request = new DefaultRequest(publicRequest, "Amazon.InternetMonitor");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-06-03";
            request.HttpMethod = "POST";

            request.ResourcePath = "/v20210603/Monitors";
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
                if(publicRequest.IsSetInternetMeasurementsLogDelivery())
                {
                    context.Writer.WritePropertyName("InternetMeasurementsLogDelivery");
                    context.Writer.WriteObjectStart();

                    var marshaller = InternetMeasurementsLogDeliveryMarshaller.Instance;
                    marshaller.Marshall(publicRequest.InternetMeasurementsLogDelivery, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetMaxCityNetworksToMonitor())
                {
                    context.Writer.WritePropertyName("MaxCityNetworksToMonitor");
                    context.Writer.Write(publicRequest.MaxCityNetworksToMonitor);
                }

                if(publicRequest.IsSetMonitorName())
                {
                    context.Writer.WritePropertyName("MonitorName");
                    context.Writer.Write(publicRequest.MonitorName);
                }

                if(publicRequest.IsSetResources())
                {
                    context.Writer.WritePropertyName("Resources");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestResourcesListValue in publicRequest.Resources)
                    {
                            context.Writer.Write(publicRequestResourcesListValue);
                    }
                    context.Writer.WriteArrayEnd();
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