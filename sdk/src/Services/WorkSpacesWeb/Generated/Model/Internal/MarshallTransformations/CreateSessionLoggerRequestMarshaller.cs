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
 * Do not modify this file. This file is generated from the workspaces-web-2020-07-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.WorkSpacesWeb.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.WorkSpacesWeb.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateSessionLogger Request Marshaller
    /// </summary>       
    public class CreateSessionLoggerRequestMarshaller : IMarshaller<IRequest, CreateSessionLoggerRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateSessionLoggerRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateSessionLoggerRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.WorkSpacesWeb");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-07-08";
            request.HttpMethod = "POST";

            request.ResourcePath = "/sessionLoggers";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAdditionalEncryptionContext())
                {
                    context.Writer.WritePropertyName("additionalEncryptionContext");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestAdditionalEncryptionContextKvp in publicRequest.AdditionalEncryptionContext)
                    {
                        context.Writer.WritePropertyName(publicRequestAdditionalEncryptionContextKvp.Key);
                        var publicRequestAdditionalEncryptionContextValue = publicRequestAdditionalEncryptionContextKvp.Value;

                            context.Writer.Write(publicRequestAdditionalEncryptionContextValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

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
                if(publicRequest.IsSetCustomerManagedKey())
                {
                    context.Writer.WritePropertyName("customerManagedKey");
                    context.Writer.Write(publicRequest.CustomerManagedKey);
                }

                if(publicRequest.IsSetDisplayName())
                {
                    context.Writer.WritePropertyName("displayName");
                    context.Writer.Write(publicRequest.DisplayName);
                }

                if(publicRequest.IsSetEventFilter())
                {
                    context.Writer.WritePropertyName("eventFilter");
                    context.Writer.WriteObjectStart();

                    var marshaller = EventFilterMarshaller.Instance;
                    marshaller.Marshall(publicRequest.EventFilter, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetLogConfiguration())
                {
                    context.Writer.WritePropertyName("logConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = LogConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.LogConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("tags");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTagsListValue in publicRequest.Tags)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = TagMarshaller.Instance;
                        marshaller.Marshall(publicRequestTagsListValue, context);

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
        private static CreateSessionLoggerRequestMarshaller _instance = new CreateSessionLoggerRequestMarshaller();        

        internal static CreateSessionLoggerRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateSessionLoggerRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}