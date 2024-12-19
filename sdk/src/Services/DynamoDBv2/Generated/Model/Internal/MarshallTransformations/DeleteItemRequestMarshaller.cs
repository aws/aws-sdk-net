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
    /// DeleteItem Request Marshaller
    /// </summary>       
    public class DeleteItemRequestMarshaller : IMarshaller<IRequest, DeleteItemRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteItemRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DeleteItemRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DynamoDBv2");
            string target = "DynamoDB_20120810.DeleteItem";
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
            if(publicRequest.IsSetConditionalOperator())
            {
                context.Writer.WritePropertyName("ConditionalOperator");
                context.Writer.WriteStringValue(publicRequest.ConditionalOperator);
            }

            if(publicRequest.IsSetConditionExpression())
            {
                context.Writer.WritePropertyName("ConditionExpression");
                context.Writer.WriteStringValue(publicRequest.ConditionExpression);
            }

            if(publicRequest.IsSetExpected())
            {
                context.Writer.WritePropertyName("Expected");
                context.Writer.WriteStartObject();
                foreach (var publicRequestExpectedKvp in publicRequest.Expected)
                {
                    context.Writer.WritePropertyName(publicRequestExpectedKvp.Key);
                    var publicRequestExpectedValue = publicRequestExpectedKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = ExpectedAttributeValueMarshaller.Instance;
                    marshaller.Marshall(publicRequestExpectedValue, context);

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

            if(publicRequest.IsSetKey())
            {
                context.Writer.WritePropertyName("Key");
                context.Writer.WriteStartObject();
                foreach (var publicRequestKeyKvp in publicRequest.Key)
                {
                    context.Writer.WritePropertyName(publicRequestKeyKvp.Key);
                    var publicRequestKeyValue = publicRequestKeyKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = AttributeValueMarshaller.Instance;
                    marshaller.Marshall(publicRequestKeyValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetReturnConsumedCapacity())
            {
                context.Writer.WritePropertyName("ReturnConsumedCapacity");
                context.Writer.WriteStringValue(publicRequest.ReturnConsumedCapacity);
            }

            if(publicRequest.IsSetReturnItemCollectionMetrics())
            {
                context.Writer.WritePropertyName("ReturnItemCollectionMetrics");
                context.Writer.WriteStringValue(publicRequest.ReturnItemCollectionMetrics);
            }

            if(publicRequest.IsSetReturnValues())
            {
                context.Writer.WritePropertyName("ReturnValues");
                context.Writer.WriteStringValue(publicRequest.ReturnValues);
            }

            if(publicRequest.IsSetReturnValuesOnConditionCheckFailure())
            {
                context.Writer.WritePropertyName("ReturnValuesOnConditionCheckFailure");
                context.Writer.WriteStringValue(publicRequest.ReturnValuesOnConditionCheckFailure);
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
        private static DeleteItemRequestMarshaller _instance = new DeleteItemRequestMarshaller();        

        internal static DeleteItemRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeleteItemRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}