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
    /// RestoreTable Request Marshaller
    /// </summary>       
    public class RestoreTableRequestMarshaller : IMarshaller<IRequest, RestoreTableRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RestoreTableRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(RestoreTableRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Keyspaces");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.ResourcePath = "service/KeyspacesService/operation/RestoreTable";
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
                if (publicRequest.IsSetCapacitySpecificationOverride())
                {
                    context.Writer.WriteTextString("capacitySpecificationOverride");
                    context.Writer.WriteStartMap(null);

                    var marshaller = CapacitySpecificationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.CapacitySpecificationOverride, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetEncryptionSpecificationOverride())
                {
                    context.Writer.WriteTextString("encryptionSpecificationOverride");
                    context.Writer.WriteStartMap(null);

                    var marshaller = EncryptionSpecificationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.EncryptionSpecificationOverride, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetPointInTimeRecoveryOverride())
                {
                    context.Writer.WriteTextString("pointInTimeRecoveryOverride");
                    context.Writer.WriteStartMap(null);

                    var marshaller = PointInTimeRecoveryMarshaller.Instance;
                    marshaller.Marshall(publicRequest.PointInTimeRecoveryOverride, context);

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
                if (publicRequest.IsSetRestoreTimestamp())
                {
                    context.Writer.WriteTextString("restoreTimestamp");
                    context.Writer.WriteDateTime(publicRequest.RestoreTimestamp.Value);
                }
                if (publicRequest.IsSetSourceKeyspaceName())
                {
                    context.Writer.WriteTextString("sourceKeyspaceName");
                    context.Writer.WriteTextString(publicRequest.SourceKeyspaceName);
                }
                if (publicRequest.IsSetSourceTableName())
                {
                    context.Writer.WriteTextString("sourceTableName");
                    context.Writer.WriteTextString(publicRequest.SourceTableName);
                }
                if (publicRequest.IsSetTagsOverride())
                {
                    context.Writer.WriteTextString("tagsOverride");
                    context.Writer.WriteStartArray(publicRequest.TagsOverride.Count);
                    foreach(var publicRequestTagsOverrideListValue in publicRequest.TagsOverride)
                    {
                        context.Writer.WriteStartMap(null);

                        var marshaller = TagMarshaller.Instance;
                        marshaller.Marshall(publicRequestTagsOverrideListValue, context);

                        context.Writer.WriteEndMap();
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetTargetKeyspaceName())
                {
                    context.Writer.WriteTextString("targetKeyspaceName");
                    context.Writer.WriteTextString(publicRequest.TargetKeyspaceName);
                }
                if (publicRequest.IsSetTargetTableName())
                {
                    context.Writer.WriteTextString("targetTableName");
                    context.Writer.WriteTextString(publicRequest.TargetTableName);
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
        private static RestoreTableRequestMarshaller _instance = new RestoreTableRequestMarshaller();        

        internal static RestoreTableRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RestoreTableRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}