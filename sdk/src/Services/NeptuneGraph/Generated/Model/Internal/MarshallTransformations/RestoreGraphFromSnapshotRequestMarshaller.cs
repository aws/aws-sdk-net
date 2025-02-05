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
 * Do not modify this file. This file is generated from the neptune-graph-2023-11-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.NeptuneGraph.Model;
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
namespace Amazon.NeptuneGraph.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RestoreGraphFromSnapshot Request Marshaller
    /// </summary>       
    public class RestoreGraphFromSnapshotRequestMarshaller : IMarshaller<IRequest, RestoreGraphFromSnapshotRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RestoreGraphFromSnapshotRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(RestoreGraphFromSnapshotRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.NeptuneGraph");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-11-29";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetSnapshotIdentifier())
                throw new AmazonNeptuneGraphException("Request object does not have required field SnapshotIdentifier set");
            request.AddPathResource("{snapshotIdentifier}", StringUtils.FromString(publicRequest.SnapshotIdentifier));
            request.ResourcePath = "/snapshots/{snapshotIdentifier}/restore";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetDeletionProtection())
            {
                context.Writer.WritePropertyName("deletionProtection");
                context.Writer.WriteBooleanValue(publicRequest.DeletionProtection.Value);
            }

            if(publicRequest.IsSetGraphName())
            {
                context.Writer.WritePropertyName("graphName");
                context.Writer.WriteStringValue(publicRequest.GraphName);
            }

            if(publicRequest.IsSetProvisionedMemory())
            {
                context.Writer.WritePropertyName("provisionedMemory");
                context.Writer.WriteNumberValue(publicRequest.ProvisionedMemory.Value);
            }

            if(publicRequest.IsSetPublicConnectivity())
            {
                context.Writer.WritePropertyName("publicConnectivity");
                context.Writer.WriteBooleanValue(publicRequest.PublicConnectivity.Value);
            }

            if(publicRequest.IsSetReplicaCount())
            {
                context.Writer.WritePropertyName("replicaCount");
                context.Writer.WriteNumberValue(publicRequest.ReplicaCount.Value);
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
        private static RestoreGraphFromSnapshotRequestMarshaller _instance = new RestoreGraphFromSnapshotRequestMarshaller();        

        internal static RestoreGraphFromSnapshotRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RestoreGraphFromSnapshotRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}