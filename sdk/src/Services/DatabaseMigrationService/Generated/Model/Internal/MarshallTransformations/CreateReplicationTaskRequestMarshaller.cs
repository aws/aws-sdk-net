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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DatabaseMigrationService.Model;
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
namespace Amazon.DatabaseMigrationService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateReplicationTask Request Marshaller
    /// </summary>       
    public class CreateReplicationTaskRequestMarshaller : IMarshaller<IRequest, CreateReplicationTaskRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateReplicationTaskRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateReplicationTaskRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DatabaseMigrationService");
            string target = "AmazonDMSv20160101.CreateReplicationTask";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-01-01";
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
            if(publicRequest.IsSetCdcStartPosition())
            {
                context.Writer.WritePropertyName("CdcStartPosition");
                context.Writer.WriteStringValue(publicRequest.CdcStartPosition);
            }

            if(publicRequest.IsSetCdcStartTime())
            {
                context.Writer.WritePropertyName("CdcStartTime");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(publicRequest.CdcStartTime.Value)));
            }

            if(publicRequest.IsSetCdcStopPosition())
            {
                context.Writer.WritePropertyName("CdcStopPosition");
                context.Writer.WriteStringValue(publicRequest.CdcStopPosition);
            }

            if(publicRequest.IsSetMigrationType())
            {
                context.Writer.WritePropertyName("MigrationType");
                context.Writer.WriteStringValue(publicRequest.MigrationType);
            }

            if(publicRequest.IsSetReplicationInstanceArn())
            {
                context.Writer.WritePropertyName("ReplicationInstanceArn");
                context.Writer.WriteStringValue(publicRequest.ReplicationInstanceArn);
            }

            if(publicRequest.IsSetReplicationTaskIdentifier())
            {
                context.Writer.WritePropertyName("ReplicationTaskIdentifier");
                context.Writer.WriteStringValue(publicRequest.ReplicationTaskIdentifier);
            }

            if(publicRequest.IsSetReplicationTaskSettings())
            {
                context.Writer.WritePropertyName("ReplicationTaskSettings");
                context.Writer.WriteStringValue(publicRequest.ReplicationTaskSettings);
            }

            if(publicRequest.IsSetResourceIdentifier())
            {
                context.Writer.WritePropertyName("ResourceIdentifier");
                context.Writer.WriteStringValue(publicRequest.ResourceIdentifier);
            }

            if(publicRequest.IsSetSourceEndpointArn())
            {
                context.Writer.WritePropertyName("SourceEndpointArn");
                context.Writer.WriteStringValue(publicRequest.SourceEndpointArn);
            }

            if(publicRequest.IsSetTableMappings())
            {
                context.Writer.WritePropertyName("TableMappings");
                context.Writer.WriteStringValue(publicRequest.TableMappings);
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

            if(publicRequest.IsSetTargetEndpointArn())
            {
                context.Writer.WritePropertyName("TargetEndpointArn");
                context.Writer.WriteStringValue(publicRequest.TargetEndpointArn);
            }

            if(publicRequest.IsSetTaskData())
            {
                context.Writer.WritePropertyName("TaskData");
                context.Writer.WriteStringValue(publicRequest.TaskData);
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
        private static CreateReplicationTaskRequestMarshaller _instance = new CreateReplicationTaskRequestMarshaller();        

        internal static CreateReplicationTaskRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateReplicationTaskRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}