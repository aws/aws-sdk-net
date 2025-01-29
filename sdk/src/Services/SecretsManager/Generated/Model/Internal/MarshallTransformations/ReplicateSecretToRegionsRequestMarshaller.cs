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
 * Do not modify this file. This file is generated from the secretsmanager-2017-10-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecretsManager.Model;
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
namespace Amazon.SecretsManager.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ReplicateSecretToRegions Request Marshaller
    /// </summary>       
    public class ReplicateSecretToRegionsRequestMarshaller : IMarshaller<IRequest, ReplicateSecretToRegionsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ReplicateSecretToRegionsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ReplicateSecretToRegionsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SecretsManager");
            string target = "secretsmanager.ReplicateSecretToRegions";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-10-17";
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
            if(publicRequest.IsSetAddReplicaRegions())
            {
                context.Writer.WritePropertyName("AddReplicaRegions");
                context.Writer.WriteStartArray();
                foreach(var publicRequestAddReplicaRegionsListValue in publicRequest.AddReplicaRegions)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ReplicaRegionTypeMarshaller.Instance;
                    marshaller.Marshall(publicRequestAddReplicaRegionsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetForceOverwriteReplicaSecret())
            {
                context.Writer.WritePropertyName("ForceOverwriteReplicaSecret");
                context.Writer.WriteBooleanValue(publicRequest.ForceOverwriteReplicaSecret.Value);
            }

            if(publicRequest.IsSetSecretId())
            {
                context.Writer.WritePropertyName("SecretId");
                context.Writer.WriteStringValue(publicRequest.SecretId);
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
        private static ReplicateSecretToRegionsRequestMarshaller _instance = new ReplicateSecretToRegionsRequestMarshaller();        

        internal static ReplicateSecretToRegionsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ReplicateSecretToRegionsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}