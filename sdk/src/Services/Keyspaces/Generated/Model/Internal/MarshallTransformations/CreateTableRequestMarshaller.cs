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
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

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
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.ResourcePath = "service/KeyspacesService/operation/CreateTable";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-02-10";
            request.HttpMethod = "POST";

            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetAutoScalingSpecification())
                {
                    context.Writer.WriteTextString("autoScalingSpecification");
                    context.Writer.WriteStartMap(null);

                    var marshaller = AutoScalingSpecificationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.AutoScalingSpecification, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetCapacitySpecification())
                {
                    context.Writer.WriteTextString("capacitySpecification");
                    context.Writer.WriteStartMap(null);

                    var marshaller = CapacitySpecificationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.CapacitySpecification, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetCdcSpecification())
                {
                    context.Writer.WriteTextString("cdcSpecification");
                    context.Writer.WriteStartMap(null);

                    var marshaller = CdcSpecificationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.CdcSpecification, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetClientSideTimestamps())
                {
                    context.Writer.WriteTextString("clientSideTimestamps");
                    context.Writer.WriteStartMap(null);

                    var marshaller = ClientSideTimestampsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ClientSideTimestamps, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetComment())
                {
                    context.Writer.WriteTextString("comment");
                    context.Writer.WriteStartMap(null);

                    var marshaller = CommentMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Comment, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetDefaultTimeToLive())
                {
                    context.Writer.WriteTextString("defaultTimeToLive");
                    context.Writer.WriteInt32(publicRequest.DefaultTimeToLive.Value);
                }
                if (publicRequest.IsSetEncryptionSpecification())
                {
                    context.Writer.WriteTextString("encryptionSpecification");
                    context.Writer.WriteStartMap(null);

                    var marshaller = EncryptionSpecificationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.EncryptionSpecification, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetKeyspaceName())
                {
                    context.Writer.WriteTextString("keyspaceName");
                    context.Writer.WriteTextString(publicRequest.KeyspaceName);
                }
                if (publicRequest.IsSetPointInTimeRecovery())
                {
                    context.Writer.WriteTextString("pointInTimeRecovery");
                    context.Writer.WriteStartMap(null);

                    var marshaller = PointInTimeRecoveryMarshaller.Instance;
                    marshaller.Marshall(publicRequest.PointInTimeRecovery, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetReplicaSpecifications())
                {
                    context.Writer.WriteTextString("replicaSpecifications");
                    context.Writer.WriteStartArray(publicRequest.ReplicaSpecifications.Count);
                    foreach(var publicRequestReplicaSpecificationsListValue in publicRequest.ReplicaSpecifications)
                    {
                        context.Writer.WriteStartMap(null);

                        var marshaller = ReplicaSpecificationMarshaller.Instance;
                        marshaller.Marshall(publicRequestReplicaSpecificationsListValue, context);

                        context.Writer.WriteEndMap();
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetSchemaDefinition())
                {
                    context.Writer.WriteTextString("schemaDefinition");
                    context.Writer.WriteStartMap(null);

                    var marshaller = SchemaDefinitionMarshaller.Instance;
                    marshaller.Marshall(publicRequest.SchemaDefinition, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetTableName())
                {
                    context.Writer.WriteTextString("tableName");
                    context.Writer.WriteTextString(publicRequest.TableName);
                }
                if (publicRequest.IsSetTags())
                {
                    context.Writer.WriteTextString("tags");
                    context.Writer.WriteStartArray(publicRequest.Tags.Count);
                    foreach(var publicRequestTagsListValue in publicRequest.Tags)
                    {
                        context.Writer.WriteStartMap(null);

                        var marshaller = TagMarshaller.Instance;
                        marshaller.Marshall(publicRequestTagsListValue, context);

                        context.Writer.WriteEndMap();
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetTtl())
                {
                    context.Writer.WriteTextString("ttl");
                    context.Writer.WriteStartMap(null);

                    var marshaller = TimeToLiveMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Ttl, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetWarmThroughputSpecification())
                {
                    context.Writer.WriteTextString("warmThroughputSpecification");
                    context.Writer.WriteStartMap(null);

                    var marshaller = WarmThroughputSpecificationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.WarmThroughputSpecification, context);

                    context.Writer.WriteEndMap();
                }
                writer.WriteEndMap();
#if !NETFRAMEWORK
                // Encode directly into a pooled buffer instead of allocating a new byte[] per request.
                // The buffer is pre-sized to writer.BytesWritten so it's rented at the right size up front,
                // avoiding the default-size rent followed by a resize+return.
                var encodedLength = writer.BytesWritten;
                request.ContentStream = new PooledContentStream(encodedLength);
                var bufferWriter = ((PooledContentStream)request.ContentStream).BufferWriter;
                var span = bufferWriter.GetSpan(encodedLength);
                var bytesWritten = writer.Encode(span);
                bufferWriter.Advance(bytesWritten);
#else
                request.Content = writer.Encode();
#endif
            }
            finally
            {
                CborWriterPool.Return(writer);
            }
            
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