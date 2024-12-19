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
    /// Scan Request Marshaller
    /// </summary>       
    public class ScanRequestMarshaller : IMarshaller<IRequest, ScanRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ScanRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ScanRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DynamoDBv2");
            string target = "DynamoDB_20120810.Scan";
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
            if(publicRequest.IsSetAttributesToGet())
            {
                context.Writer.WritePropertyName("AttributesToGet");
                context.Writer.WriteStartArray();
                foreach(var publicRequestAttributesToGetListValue in publicRequest.AttributesToGet)
                {
                        context.Writer.WriteStringValue(publicRequestAttributesToGetListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetConditionalOperator())
            {
                context.Writer.WritePropertyName("ConditionalOperator");
                context.Writer.WriteStringValue(publicRequest.ConditionalOperator);
            }

            if(publicRequest.IsSetConsistentRead())
            {
                context.Writer.WritePropertyName("ConsistentRead");
                context.Writer.WriteBooleanValue(publicRequest.ConsistentRead.Value);
            }

            if(publicRequest.IsSetExclusiveStartKey())
            {
                context.Writer.WritePropertyName("ExclusiveStartKey");
                context.Writer.WriteStartObject();
                foreach (var publicRequestExclusiveStartKeyKvp in publicRequest.ExclusiveStartKey)
                {
                    context.Writer.WritePropertyName(publicRequestExclusiveStartKeyKvp.Key);
                    var publicRequestExclusiveStartKeyValue = publicRequestExclusiveStartKeyKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = AttributeValueMarshaller.Instance;
                    marshaller.Marshall(publicRequestExclusiveStartKeyValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetExpressionAttributeNames())
            {
                context.Writer.WritePropertyName("ExpressionAttributeNames");
                context.Writer.WriteStartObject();
                foreach (var publicRequestExpressionAttributeNamesKvp in publicRequest.ExpressionAttributeNames)
                {
                    context.Writer.WritePropertyName(publicRequestExpressionAttributeNamesKvp.Key);
                    var publicRequestExpressionAttributeNamesValue = publicRequestExpressionAttributeNamesKvp.Value;

                        context.Writer.WriteStringValue(publicRequestExpressionAttributeNamesValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetExpressionAttributeValues())
            {
                context.Writer.WritePropertyName("ExpressionAttributeValues");
                context.Writer.WriteStartObject();
                foreach (var publicRequestExpressionAttributeValuesKvp in publicRequest.ExpressionAttributeValues)
                {
                    context.Writer.WritePropertyName(publicRequestExpressionAttributeValuesKvp.Key);
                    var publicRequestExpressionAttributeValuesValue = publicRequestExpressionAttributeValuesKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = AttributeValueMarshaller.Instance;
                    marshaller.Marshall(publicRequestExpressionAttributeValuesValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetFilterExpression())
            {
                context.Writer.WritePropertyName("FilterExpression");
                context.Writer.WriteStringValue(publicRequest.FilterExpression);
            }

            if(publicRequest.IsSetIndexName())
            {
                context.Writer.WritePropertyName("IndexName");
                context.Writer.WriteStringValue(publicRequest.IndexName);
            }

            if(publicRequest.IsSetLimit())
            {
                context.Writer.WritePropertyName("Limit");
                context.Writer.WriteNumberValue(publicRequest.Limit.Value);
            }

            if(publicRequest.IsSetProjectionExpression())
            {
                context.Writer.WritePropertyName("ProjectionExpression");
                context.Writer.WriteStringValue(publicRequest.ProjectionExpression);
            }

            if(publicRequest.IsSetReturnConsumedCapacity())
            {
                context.Writer.WritePropertyName("ReturnConsumedCapacity");
                context.Writer.WriteStringValue(publicRequest.ReturnConsumedCapacity);
            }

            if(publicRequest.IsSetScanFilter())
            {
                context.Writer.WritePropertyName("ScanFilter");
                context.Writer.WriteStartObject();
                foreach (var publicRequestScanFilterKvp in publicRequest.ScanFilter)
                {
                    context.Writer.WritePropertyName(publicRequestScanFilterKvp.Key);
                    var publicRequestScanFilterValue = publicRequestScanFilterKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = ConditionMarshaller.Instance;
                    marshaller.Marshall(publicRequestScanFilterValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetSegment())
            {
                context.Writer.WritePropertyName("Segment");
                context.Writer.WriteNumberValue(publicRequest.Segment.Value);
            }

            if(publicRequest.IsSetSelect())
            {
                context.Writer.WritePropertyName("Select");
                context.Writer.WriteStringValue(publicRequest.Select);
            }

            if(publicRequest.IsSetTableName())
            {
                context.Writer.WritePropertyName("TableName");
                context.Writer.WriteStringValue(publicRequest.TableName);
            }

            if(publicRequest.IsSetTotalSegments())
            {
                context.Writer.WritePropertyName("TotalSegments");
                context.Writer.WriteNumberValue(publicRequest.TotalSegments.Value);
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
        private static ScanRequestMarshaller _instance = new ScanRequestMarshaller();        

        internal static ScanRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ScanRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}