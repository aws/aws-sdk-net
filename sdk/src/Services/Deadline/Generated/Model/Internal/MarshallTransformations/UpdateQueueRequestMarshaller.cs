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
 * Do not modify this file. This file is generated from the deadline-2023-10-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Deadline.Model;
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
namespace Amazon.Deadline.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateQueue Request Marshaller
    /// </summary>       
    public class UpdateQueueRequestMarshaller : IMarshaller<IRequest, UpdateQueueRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateQueueRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateQueueRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Deadline");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-10-12";
            request.HttpMethod = "PATCH";

            if (!publicRequest.IsSetFarmId())
                throw new AmazonDeadlineException("Request object does not have required field FarmId set");
            request.AddPathResource("{farmId}", StringUtils.FromString(publicRequest.FarmId));
            if (!publicRequest.IsSetQueueId())
                throw new AmazonDeadlineException("Request object does not have required field QueueId set");
            request.AddPathResource("{queueId}", StringUtils.FromString(publicRequest.QueueId));
            request.ResourcePath = "/2023-10-12/farms/{farmId}/queues/{queueId}";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAllowedStorageProfileIdsToAdd())
            {
                context.Writer.WritePropertyName("allowedStorageProfileIdsToAdd");
                context.Writer.WriteStartArray();
                foreach(var publicRequestAllowedStorageProfileIdsToAddListValue in publicRequest.AllowedStorageProfileIdsToAdd)
                {
                        context.Writer.WriteStringValue(publicRequestAllowedStorageProfileIdsToAddListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetAllowedStorageProfileIdsToRemove())
            {
                context.Writer.WritePropertyName("allowedStorageProfileIdsToRemove");
                context.Writer.WriteStartArray();
                foreach(var publicRequestAllowedStorageProfileIdsToRemoveListValue in publicRequest.AllowedStorageProfileIdsToRemove)
                {
                        context.Writer.WriteStringValue(publicRequestAllowedStorageProfileIdsToRemoveListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetDefaultBudgetAction())
            {
                context.Writer.WritePropertyName("defaultBudgetAction");
                context.Writer.WriteStringValue(publicRequest.DefaultBudgetAction);
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetDisplayName())
            {
                context.Writer.WritePropertyName("displayName");
                context.Writer.WriteStringValue(publicRequest.DisplayName);
            }

            if(publicRequest.IsSetJobAttachmentSettings())
            {
                context.Writer.WritePropertyName("jobAttachmentSettings");
                context.Writer.WriteStartObject();

                var marshaller = JobAttachmentSettingsMarshaller.Instance;
                marshaller.Marshall(publicRequest.JobAttachmentSettings, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetJobRunAsUser())
            {
                context.Writer.WritePropertyName("jobRunAsUser");
                context.Writer.WriteStartObject();

                var marshaller = JobRunAsUserMarshaller.Instance;
                marshaller.Marshall(publicRequest.JobRunAsUser, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetRequiredFileSystemLocationNamesToAdd())
            {
                context.Writer.WritePropertyName("requiredFileSystemLocationNamesToAdd");
                context.Writer.WriteStartArray();
                foreach(var publicRequestRequiredFileSystemLocationNamesToAddListValue in publicRequest.RequiredFileSystemLocationNamesToAdd)
                {
                        context.Writer.WriteStringValue(publicRequestRequiredFileSystemLocationNamesToAddListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetRequiredFileSystemLocationNamesToRemove())
            {
                context.Writer.WritePropertyName("requiredFileSystemLocationNamesToRemove");
                context.Writer.WriteStartArray();
                foreach(var publicRequestRequiredFileSystemLocationNamesToRemoveListValue in publicRequest.RequiredFileSystemLocationNamesToRemove)
                {
                        context.Writer.WriteStringValue(publicRequestRequiredFileSystemLocationNamesToRemoveListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetRoleArn())
            {
                context.Writer.WritePropertyName("roleArn");
                context.Writer.WriteStringValue(publicRequest.RoleArn);
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            

        
            if (publicRequest.IsSetClientToken()) 
            {
                request.Headers["X-Amz-Client-Token"] = publicRequest.ClientToken;
            }
            
            request.HostPrefix = $"management.";

            return request;
        }
        private static UpdateQueueRequestMarshaller _instance = new UpdateQueueRequestMarshaller();        

        internal static UpdateQueueRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateQueueRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}