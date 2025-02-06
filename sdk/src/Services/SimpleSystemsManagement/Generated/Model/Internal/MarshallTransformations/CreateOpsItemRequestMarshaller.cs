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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SimpleSystemsManagement.Model;
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
namespace Amazon.SimpleSystemsManagement.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateOpsItem Request Marshaller
    /// </summary>       
    public class CreateOpsItemRequestMarshaller : IMarshaller<IRequest, CreateOpsItemRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateOpsItemRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateOpsItemRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SimpleSystemsManagement");
            string target = "AmazonSSM.CreateOpsItem";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2014-11-06";
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
            if(publicRequest.IsSetAccountId())
            {
                context.Writer.WritePropertyName("AccountId");
                context.Writer.WriteStringValue(publicRequest.AccountId);
            }

            if(publicRequest.IsSetActualEndTime())
            {
                context.Writer.WritePropertyName("ActualEndTime");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(publicRequest.ActualEndTime.Value)));
            }

            if(publicRequest.IsSetActualStartTime())
            {
                context.Writer.WritePropertyName("ActualStartTime");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(publicRequest.ActualStartTime.Value)));
            }

            if(publicRequest.IsSetCategory())
            {
                context.Writer.WritePropertyName("Category");
                context.Writer.WriteStringValue(publicRequest.Category);
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetNotifications())
            {
                context.Writer.WritePropertyName("Notifications");
                context.Writer.WriteStartArray();
                foreach(var publicRequestNotificationsListValue in publicRequest.Notifications)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = OpsItemNotificationMarshaller.Instance;
                    marshaller.Marshall(publicRequestNotificationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetOperationalData())
            {
                context.Writer.WritePropertyName("OperationalData");
                context.Writer.WriteStartObject();
                foreach (var publicRequestOperationalDataKvp in publicRequest.OperationalData)
                {
                    context.Writer.WritePropertyName(publicRequestOperationalDataKvp.Key);
                    var publicRequestOperationalDataValue = publicRequestOperationalDataKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = OpsItemDataValueMarshaller.Instance;
                    marshaller.Marshall(publicRequestOperationalDataValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetOpsItemType())
            {
                context.Writer.WritePropertyName("OpsItemType");
                context.Writer.WriteStringValue(publicRequest.OpsItemType);
            }

            if(publicRequest.IsSetPlannedEndTime())
            {
                context.Writer.WritePropertyName("PlannedEndTime");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(publicRequest.PlannedEndTime.Value)));
            }

            if(publicRequest.IsSetPlannedStartTime())
            {
                context.Writer.WritePropertyName("PlannedStartTime");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(publicRequest.PlannedStartTime.Value)));
            }

            if(publicRequest.IsSetPriority())
            {
                context.Writer.WritePropertyName("Priority");
                context.Writer.WriteNumberValue(publicRequest.Priority.Value);
            }

            if(publicRequest.IsSetRelatedOpsItems())
            {
                context.Writer.WritePropertyName("RelatedOpsItems");
                context.Writer.WriteStartArray();
                foreach(var publicRequestRelatedOpsItemsListValue in publicRequest.RelatedOpsItems)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = RelatedOpsItemMarshaller.Instance;
                    marshaller.Marshall(publicRequestRelatedOpsItemsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetSeverity())
            {
                context.Writer.WritePropertyName("Severity");
                context.Writer.WriteStringValue(publicRequest.Severity);
            }

            if(publicRequest.IsSetSource())
            {
                context.Writer.WritePropertyName("Source");
                context.Writer.WriteStringValue(publicRequest.Source);
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

            if(publicRequest.IsSetTitle())
            {
                context.Writer.WritePropertyName("Title");
                context.Writer.WriteStringValue(publicRequest.Title);
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
        private static CreateOpsItemRequestMarshaller _instance = new CreateOpsItemRequestMarshaller();        

        internal static CreateOpsItemRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateOpsItemRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}