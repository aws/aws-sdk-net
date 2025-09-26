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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Connect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Connect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateRoutingProfile Request Marshaller
    /// </summary>       
    public class CreateRoutingProfileRequestMarshaller : IMarshaller<IRequest, CreateRoutingProfileRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateRoutingProfileRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateRoutingProfileRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Connect");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-08-08";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetInstanceId())
                throw new AmazonConnectException("Request object does not have required field InstanceId set");
            request.AddPathResource("{InstanceId}", StringUtils.FromString(publicRequest.InstanceId));
            request.ResourcePath = "/routing-profiles/{InstanceId}";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAgentAvailabilityTimer())
                {
                    context.Writer.WritePropertyName("AgentAvailabilityTimer");
                    context.Writer.Write(publicRequest.AgentAvailabilityTimer);
                }

                if(publicRequest.IsSetDefaultOutboundQueueId())
                {
                    context.Writer.WritePropertyName("DefaultOutboundQueueId");
                    context.Writer.Write(publicRequest.DefaultOutboundQueueId);
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("Description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetManualAssignmentQueueConfigs())
                {
                    context.Writer.WritePropertyName("ManualAssignmentQueueConfigs");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestManualAssignmentQueueConfigsListValue in publicRequest.ManualAssignmentQueueConfigs)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = RoutingProfileManualAssignmentQueueConfigMarshaller.Instance;
                        marshaller.Marshall(publicRequestManualAssignmentQueueConfigsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetMediaConcurrencies())
                {
                    context.Writer.WritePropertyName("MediaConcurrencies");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestMediaConcurrenciesListValue in publicRequest.MediaConcurrencies)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = MediaConcurrencyMarshaller.Instance;
                        marshaller.Marshall(publicRequestMediaConcurrenciesListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("Name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetQueueConfigs())
                {
                    context.Writer.WritePropertyName("QueueConfigs");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestQueueConfigsListValue in publicRequest.QueueConfigs)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = RoutingProfileQueueConfigMarshaller.Instance;
                        marshaller.Marshall(publicRequestQueueConfigsListValue, context);

                        context.Writer.WriteObjectEnd();
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
        private static CreateRoutingProfileRequestMarshaller _instance = new CreateRoutingProfileRequestMarshaller();        

        internal static CreateRoutingProfileRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateRoutingProfileRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}