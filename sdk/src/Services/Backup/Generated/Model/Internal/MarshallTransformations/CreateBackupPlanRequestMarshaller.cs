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
 * Do not modify this file. This file is generated from the backup-2018-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Backup.Model;
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
namespace Amazon.Backup.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateBackupPlan Request Marshaller
    /// </summary>       
    public class CreateBackupPlanRequestMarshaller : IMarshaller<IRequest, CreateBackupPlanRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateBackupPlanRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateBackupPlanRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Backup");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-15";
            request.HttpMethod = "PUT";

            request.ResourcePath = "/backup/plans/";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetBackupPlan())
            {
                context.Writer.WritePropertyName("BackupPlan");
                context.Writer.WriteStartObject();

                var marshaller = BackupPlanInputMarshaller.Instance;
                marshaller.Marshall(publicRequest.BackupPlan, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetBackupPlanTags())
            {
                context.Writer.WritePropertyName("BackupPlanTags");
                context.Writer.WriteStartObject();
                foreach (var publicRequestBackupPlanTagsKvp in publicRequest.BackupPlanTags)
                {
                    context.Writer.WritePropertyName(publicRequestBackupPlanTagsKvp.Key);
                    var publicRequestBackupPlanTagsValue = publicRequestBackupPlanTagsKvp.Value;

                        context.Writer.WriteStringValue(publicRequestBackupPlanTagsValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetCreatorRequestId())
            {
                context.Writer.WritePropertyName("CreatorRequestId");
                context.Writer.WriteStringValue(publicRequest.CreatorRequestId);
            }

            else if(!(publicRequest.IsSetCreatorRequestId()))
            {
                context.Writer.WritePropertyName("CreatorRequestId");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
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
        private static CreateBackupPlanRequestMarshaller _instance = new CreateBackupPlanRequestMarshaller();        

        internal static CreateBackupPlanRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateBackupPlanRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}