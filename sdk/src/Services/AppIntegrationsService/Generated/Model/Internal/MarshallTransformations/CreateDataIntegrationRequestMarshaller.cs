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
 * Do not modify this file. This file is generated from the appintegrations-2020-07-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AppIntegrationsService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.AppIntegrationsService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateDataIntegration Request Marshaller
    /// </summary>       
    public class CreateDataIntegrationRequestMarshaller : IMarshaller<IRequest, CreateDataIntegrationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateDataIntegrationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateDataIntegrationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AppIntegrationsService");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-07-29";
            request.HttpMethod = "POST";

            request.ResourcePath = "/dataIntegrations";
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
                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("Description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetFileConfiguration())
                {
                    context.Writer.WritePropertyName("FileConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = FileConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.FileConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetKmsKey())
                {
                    context.Writer.WritePropertyName("KmsKey");
                    context.Writer.Write(publicRequest.KmsKey);
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("Name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetObjectConfiguration())
                {
                    context.Writer.WritePropertyName("ObjectConfiguration");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestObjectConfigurationKvp in publicRequest.ObjectConfiguration)
                    {
                        context.Writer.WritePropertyName(publicRequestObjectConfigurationKvp.Key);
                        var publicRequestObjectConfigurationValue = publicRequestObjectConfigurationKvp.Value;

                        context.Writer.WriteObjectStart();
                        foreach (var publicRequestObjectConfigurationValueKvp in publicRequestObjectConfigurationValue)
                        {
                            context.Writer.WritePropertyName(publicRequestObjectConfigurationValueKvp.Key);
                            var publicRequestObjectConfigurationValueValue = publicRequestObjectConfigurationValueKvp.Value;

                            context.Writer.WriteArrayStart();
                            foreach(var publicRequestObjectConfigurationValueValueListValue in publicRequestObjectConfigurationValueValue)
                            {
                                    context.Writer.Write(publicRequestObjectConfigurationValueValueListValue);
                            }
                            context.Writer.WriteArrayEnd();
                        }
                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetScheduleConfig())
                {
                    context.Writer.WritePropertyName("ScheduleConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = ScheduleConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ScheduleConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetSourceURI())
                {
                    context.Writer.WritePropertyName("SourceURI");
                    context.Writer.Write(publicRequest.SourceURI);
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
        private static CreateDataIntegrationRequestMarshaller _instance = new CreateDataIntegrationRequestMarshaller();        

        internal static CreateDataIntegrationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateDataIntegrationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}