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
 * Do not modify this file. This file is generated from the keyspaces-2022-02-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Keyspaces.Model;
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
namespace Amazon.Keyspaces.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateTable Request Marshaller
    /// </summary>       
    public class CreateTableRequestMarshaller : IMarshaller<IRequest, CreateTableRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateTableRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateTableRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Keyspaces");
            string target = "KeyspacesService.CreateTable";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-02-10";
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
            if(publicRequest.IsSetAutoScalingSpecification())
            {
                context.Writer.WritePropertyName("autoScalingSpecification");
                context.Writer.WriteStartObject();

                var marshaller = AutoScalingSpecificationMarshaller.Instance;
                marshaller.Marshall(publicRequest.AutoScalingSpecification, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetCapacitySpecification())
            {
                context.Writer.WritePropertyName("capacitySpecification");
                context.Writer.WriteStartObject();

                var marshaller = CapacitySpecificationMarshaller.Instance;
                marshaller.Marshall(publicRequest.CapacitySpecification, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetCdcSpecification())
            {
                context.Writer.WritePropertyName("cdcSpecification");
                context.Writer.WriteStartObject();

                var marshaller = CdcSpecificationMarshaller.Instance;
                marshaller.Marshall(publicRequest.CdcSpecification, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetClientSideTimestamps())
            {
                context.Writer.WritePropertyName("clientSideTimestamps");
                context.Writer.WriteStartObject();

                var marshaller = ClientSideTimestampsMarshaller.Instance;
                marshaller.Marshall(publicRequest.ClientSideTimestamps, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetComment())
            {
                context.Writer.WritePropertyName("comment");
                context.Writer.WriteStartObject();

                var marshaller = CommentMarshaller.Instance;
                marshaller.Marshall(publicRequest.Comment, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDefaultTimeToLive())
            {
                context.Writer.WritePropertyName("defaultTimeToLive");
                context.Writer.WriteNumberValue(publicRequest.DefaultTimeToLive.Value);
            }

            if(publicRequest.IsSetEncryptionSpecification())
            {
                context.Writer.WritePropertyName("encryptionSpecification");
                context.Writer.WriteStartObject();

                var marshaller = EncryptionSpecificationMarshaller.Instance;
                marshaller.Marshall(publicRequest.EncryptionSpecification, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetKeyspaceName())
            {
                context.Writer.WritePropertyName("keyspaceName");
                context.Writer.WriteStringValue(publicRequest.KeyspaceName);
            }

            if(publicRequest.IsSetPointInTimeRecovery())
            {
                context.Writer.WritePropertyName("pointInTimeRecovery");
                context.Writer.WriteStartObject();

                var marshaller = PointInTimeRecoveryMarshaller.Instance;
                marshaller.Marshall(publicRequest.PointInTimeRecovery, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetReplicaSpecifications())
            {
                context.Writer.WritePropertyName("replicaSpecifications");
                context.Writer.WriteStartArray();
                foreach(var publicRequestReplicaSpecificationsListValue in publicRequest.ReplicaSpecifications)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ReplicaSpecificationMarshaller.Instance;
                    marshaller.Marshall(publicRequestReplicaSpecificationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetSchemaDefinition())
            {
                context.Writer.WritePropertyName("schemaDefinition");
                context.Writer.WriteStartObject();

                var marshaller = SchemaDefinitionMarshaller.Instance;
                marshaller.Marshall(publicRequest.SchemaDefinition, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetTableName())
            {
                context.Writer.WritePropertyName("tableName");
                context.Writer.WriteStringValue(publicRequest.TableName);
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("tags");
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

            if(publicRequest.IsSetTtl())
            {
                context.Writer.WritePropertyName("ttl");
                context.Writer.WriteStartObject();

                var marshaller = TimeToLiveMarshaller.Instance;
                marshaller.Marshall(publicRequest.Ttl, context);

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
        private static CreateTableRequestMarshaller _instance = new CreateTableRequestMarshaller();        

        internal static CreateTableRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateTableRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}