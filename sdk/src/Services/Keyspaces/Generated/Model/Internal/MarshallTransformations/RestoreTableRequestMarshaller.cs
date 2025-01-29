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
            string target = "KeyspacesService.RestoreTable";
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

            if(publicRequest.IsSetCapacitySpecificationOverride())
            {
                context.Writer.WritePropertyName("capacitySpecificationOverride");
                context.Writer.WriteStartObject();

                var marshaller = CapacitySpecificationMarshaller.Instance;
                marshaller.Marshall(publicRequest.CapacitySpecificationOverride, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetEncryptionSpecificationOverride())
            {
                context.Writer.WritePropertyName("encryptionSpecificationOverride");
                context.Writer.WriteStartObject();

                var marshaller = EncryptionSpecificationMarshaller.Instance;
                marshaller.Marshall(publicRequest.EncryptionSpecificationOverride, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetPointInTimeRecoveryOverride())
            {
                context.Writer.WritePropertyName("pointInTimeRecoveryOverride");
                context.Writer.WriteStartObject();

                var marshaller = PointInTimeRecoveryMarshaller.Instance;
                marshaller.Marshall(publicRequest.PointInTimeRecoveryOverride, context);

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

            if(publicRequest.IsSetRestoreTimestamp())
            {
                context.Writer.WritePropertyName("restoreTimestamp");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(publicRequest.RestoreTimestamp.Value)));
            }

            if(publicRequest.IsSetSourceKeyspaceName())
            {
                context.Writer.WritePropertyName("sourceKeyspaceName");
                context.Writer.WriteStringValue(publicRequest.SourceKeyspaceName);
            }

            if(publicRequest.IsSetSourceTableName())
            {
                context.Writer.WritePropertyName("sourceTableName");
                context.Writer.WriteStringValue(publicRequest.SourceTableName);
            }

            if(publicRequest.IsSetTagsOverride())
            {
                context.Writer.WritePropertyName("tagsOverride");
                context.Writer.WriteStartArray();
                foreach(var publicRequestTagsOverrideListValue in publicRequest.TagsOverride)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TagMarshaller.Instance;
                    marshaller.Marshall(publicRequestTagsOverrideListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetTargetKeyspaceName())
            {
                context.Writer.WritePropertyName("targetKeyspaceName");
                context.Writer.WriteStringValue(publicRequest.TargetKeyspaceName);
            }

            if(publicRequest.IsSetTargetTableName())
            {
                context.Writer.WritePropertyName("targetTableName");
                context.Writer.WriteStringValue(publicRequest.TargetTableName);
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