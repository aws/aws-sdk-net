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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.GameLift.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.GameLift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateMatchmakingConfiguration Request Marshaller
    /// </summary>       
    public class CreateMatchmakingConfigurationRequestMarshaller : IMarshaller<IRequest, CreateMatchmakingConfigurationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateMatchmakingConfigurationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateMatchmakingConfigurationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.GameLift");
            string target = "GameLift.CreateMatchmakingConfiguration";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-10-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAcceptanceRequired())
            {
                context.Writer.WritePropertyName("AcceptanceRequired");
                context.Writer.WriteBooleanValue(publicRequest.AcceptanceRequired.Value);
            }

            if(publicRequest.IsSetAcceptanceTimeoutSeconds())
            {
                context.Writer.WritePropertyName("AcceptanceTimeoutSeconds");
                context.Writer.WriteNumberValue(publicRequest.AcceptanceTimeoutSeconds.Value);
            }

            if(publicRequest.IsSetAdditionalPlayerCount())
            {
                context.Writer.WritePropertyName("AdditionalPlayerCount");
                context.Writer.WriteNumberValue(publicRequest.AdditionalPlayerCount.Value);
            }

            if(publicRequest.IsSetBackfillMode())
            {
                context.Writer.WritePropertyName("BackfillMode");
                context.Writer.WriteStringValue(publicRequest.BackfillMode);
            }

            if(publicRequest.IsSetCustomEventData())
            {
                context.Writer.WritePropertyName("CustomEventData");
                context.Writer.WriteStringValue(publicRequest.CustomEventData);
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetFlexMatchMode())
            {
                context.Writer.WritePropertyName("FlexMatchMode");
                context.Writer.WriteStringValue(publicRequest.FlexMatchMode);
            }

            if(publicRequest.IsSetGameProperties())
            {
                context.Writer.WritePropertyName("GameProperties");
                context.Writer.WriteStartArray();
                foreach(var publicRequestGamePropertiesListValue in publicRequest.GameProperties)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = GamePropertyMarshaller.Instance;
                    marshaller.Marshall(publicRequestGamePropertiesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetGameSessionData())
            {
                context.Writer.WritePropertyName("GameSessionData");
                context.Writer.WriteStringValue(publicRequest.GameSessionData);
            }

            if(publicRequest.IsSetGameSessionQueueArns())
            {
                context.Writer.WritePropertyName("GameSessionQueueArns");
                context.Writer.WriteStartArray();
                foreach(var publicRequestGameSessionQueueArnsListValue in publicRequest.GameSessionQueueArns)
                {
                        context.Writer.WriteStringValue(publicRequestGameSessionQueueArnsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }

            if(publicRequest.IsSetNotificationTarget())
            {
                context.Writer.WritePropertyName("NotificationTarget");
                context.Writer.WriteStringValue(publicRequest.NotificationTarget);
            }

            if(publicRequest.IsSetRequestTimeoutSeconds())
            {
                context.Writer.WritePropertyName("RequestTimeoutSeconds");
                context.Writer.WriteNumberValue(publicRequest.RequestTimeoutSeconds.Value);
            }

            if(publicRequest.IsSetRuleSetName())
            {
                context.Writer.WritePropertyName("RuleSetName");
                context.Writer.WriteStringValue(publicRequest.RuleSetName);
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("Tags");
                context.Writer.WriteStartArray();
                foreach(var publicRequestTagsListValue in publicRequest.Tags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TagMarshaller.Instance;
                    marshaller.Marshall(publicRequestTagsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static CreateMatchmakingConfigurationRequestMarshaller _instance = new CreateMatchmakingConfigurationRequestMarshaller();        

        internal static CreateMatchmakingConfigurationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateMatchmakingConfigurationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}