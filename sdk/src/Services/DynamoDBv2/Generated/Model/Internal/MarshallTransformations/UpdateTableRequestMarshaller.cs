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
 * Do not modify this file. This file is generated from the dynamodb-2012-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DynamoDBv2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;
#pragma warning disable CS0612,CS0618
namespace Amazon.DynamoDBv2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateTable Request Marshaller
    /// </summary>       
    public class UpdateTableRequestMarshaller : IMarshaller<IRequest, UpdateTableRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateTableRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateTableRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DynamoDBv2");
            string target = "DynamoDB_20120810.UpdateTable";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2012-08-10";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
#if NETCOREAPP3_1_OR_GREATER
            ArrayBufferWriter<byte> arrayBufferWriter = new ArrayBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAttributeDefinitions())
            {
                context.Writer.WritePropertyName("AttributeDefinitions");
                context.Writer.WriteStartArray();
                foreach(var publicRequestAttributeDefinitionsListValue in publicRequest.AttributeDefinitions)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AttributeDefinitionMarshaller.Instance;
                    marshaller.Marshall(publicRequestAttributeDefinitionsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetBillingMode())
            {
                context.Writer.WritePropertyName("BillingMode");
                context.Writer.WriteStringValue(publicRequest.BillingMode);
            }

            if(publicRequest.IsSetDeletionProtectionEnabled())
            {
                context.Writer.WritePropertyName("DeletionProtectionEnabled");
                context.Writer.WriteBooleanValue(publicRequest.DeletionProtectionEnabled.Value);
            }

            if(publicRequest.IsSetGlobalSecondaryIndexUpdates())
            {
                context.Writer.WritePropertyName("GlobalSecondaryIndexUpdates");
                context.Writer.WriteStartArray();
                foreach(var publicRequestGlobalSecondaryIndexUpdatesListValue in publicRequest.GlobalSecondaryIndexUpdates)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = GlobalSecondaryIndexUpdateMarshaller.Instance;
                    marshaller.Marshall(publicRequestGlobalSecondaryIndexUpdatesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetOnDemandThroughput())
            {
                context.Writer.WritePropertyName("OnDemandThroughput");
                context.Writer.WriteStartObject();

                var marshaller = OnDemandThroughputMarshaller.Instance;
                marshaller.Marshall(publicRequest.OnDemandThroughput, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetProvisionedThroughput())
            {
                context.Writer.WritePropertyName("ProvisionedThroughput");
                context.Writer.WriteStartObject();

                var marshaller = ProvisionedThroughputMarshaller.Instance;
                marshaller.Marshall(publicRequest.ProvisionedThroughput, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetReplicaUpdates())
            {
                context.Writer.WritePropertyName("ReplicaUpdates");
                context.Writer.WriteStartArray();
                foreach(var publicRequestReplicaUpdatesListValue in publicRequest.ReplicaUpdates)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ReplicationGroupUpdateMarshaller.Instance;
                    marshaller.Marshall(publicRequestReplicaUpdatesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetSSESpecification())
            {
                context.Writer.WritePropertyName("SSESpecification");
                context.Writer.WriteStartObject();

                var marshaller = SSESpecificationMarshaller.Instance;
                marshaller.Marshall(publicRequest.SSESpecification, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetStreamSpecification())
            {
                context.Writer.WritePropertyName("StreamSpecification");
                context.Writer.WriteStartObject();

                var marshaller = StreamSpecificationMarshaller.Instance;
                marshaller.Marshall(publicRequest.StreamSpecification, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetTableClass())
            {
                context.Writer.WritePropertyName("TableClass");
                context.Writer.WriteStringValue(publicRequest.TableClass);
            }

            if(publicRequest.IsSetTableName())
            {
                context.Writer.WritePropertyName("TableName");
                context.Writer.WriteStringValue(publicRequest.TableName);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETCOREAPP3_1_OR_GREATER
            request.Content = arrayBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static UpdateTableRequestMarshaller _instance = new UpdateTableRequestMarshaller();        

        internal static UpdateTableRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateTableRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}