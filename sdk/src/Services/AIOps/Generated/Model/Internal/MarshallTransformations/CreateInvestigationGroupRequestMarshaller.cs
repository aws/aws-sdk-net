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
 * Do not modify this file. This file is generated from the aiops-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AIOps.Model;
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
namespace Amazon.AIOps.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateInvestigationGroup Request Marshaller
    /// </summary>       
    public class CreateInvestigationGroupRequestMarshaller : IMarshaller<IRequest, CreateInvestigationGroupRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateInvestigationGroupRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateInvestigationGroupRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AIOps");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";
            request.HttpMethod = "POST";

            request.ResourcePath = "/investigationGroups";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetChatbotNotificationChannel())
            {
                context.Writer.WritePropertyName("chatbotNotificationChannel");
                context.Writer.WriteStartObject();
                foreach (var publicRequestChatbotNotificationChannelKvp in publicRequest.ChatbotNotificationChannel)
                {
                    context.Writer.WritePropertyName(publicRequestChatbotNotificationChannelKvp.Key);
                    var publicRequestChatbotNotificationChannelValue = publicRequestChatbotNotificationChannelKvp.Value;

                    context.Writer.WriteStartArray();
                    foreach(var publicRequestChatbotNotificationChannelValueListValue in publicRequestChatbotNotificationChannelValue)
                    {
                            context.Writer.WriteStringValue(publicRequestChatbotNotificationChannelValueListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetCrossAccountConfigurations())
            {
                context.Writer.WritePropertyName("crossAccountConfigurations");
                context.Writer.WriteStartArray();
                foreach(var publicRequestCrossAccountConfigurationsListValue in publicRequest.CrossAccountConfigurations)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CrossAccountConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequestCrossAccountConfigurationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetEncryptionConfiguration())
            {
                context.Writer.WritePropertyName("encryptionConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = EncryptionConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.EncryptionConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetIsCloudTrailEventHistoryEnabled())
            {
                context.Writer.WritePropertyName("isCloudTrailEventHistoryEnabled");
                context.Writer.WriteBooleanValue(publicRequest.IsCloudTrailEventHistoryEnabled.Value);
            }

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }

            if(publicRequest.IsSetRetentionInDays())
            {
                context.Writer.WritePropertyName("retentionInDays");
                context.Writer.WriteNumberValue(publicRequest.RetentionInDays.Value);
            }

            if(publicRequest.IsSetRoleArn())
            {
                context.Writer.WritePropertyName("roleArn");
                context.Writer.WriteStringValue(publicRequest.RoleArn);
            }

            if(publicRequest.IsSetTagKeyBoundaries())
            {
                context.Writer.WritePropertyName("tagKeyBoundaries");
                context.Writer.WriteStartArray();
                foreach(var publicRequestTagKeyBoundariesListValue in publicRequest.TagKeyBoundaries)
                {
                        context.Writer.WriteStringValue(publicRequestTagKeyBoundariesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("tags");
                context.Writer.WriteStartObject();
                foreach (var publicRequestTagsKvp in publicRequest.Tags)
                {
                    context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                    var publicRequestTagsValue = publicRequestTagsKvp.Value;

                        context.Writer.WriteStringValue(publicRequestTagsValue);
                }
                context.Writer.WriteEndObject();
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
        private static CreateInvestigationGroupRequestMarshaller _instance = new CreateInvestigationGroupRequestMarshaller();        

        internal static CreateInvestigationGroupRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateInvestigationGroupRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}