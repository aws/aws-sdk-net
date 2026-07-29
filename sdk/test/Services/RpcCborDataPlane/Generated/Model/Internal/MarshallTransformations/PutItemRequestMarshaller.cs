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
 * Do not modify this file. This file is generated from the rpccbordataplane-1999-12-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.RpcCborDataPlane.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.RpcCborDataPlane.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutItem Request Marshaller
    /// </summary>       
    public class PutItemRequestMarshaller : IMarshaller<IRequest, PutItemRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutItemRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutItemRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RpcCborDataPlane");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.ResourcePath = "service/SmithyRpcV2CborDataPlane/operation/PutItem";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "1999-12-31";
            request.HttpMethod = "POST";

            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetConditionalOperator())
                {
                    context.Writer.WriteTextString("ConditionalOperator");
                    context.Writer.WriteTextString(publicRequest.ConditionalOperator);
                }
                if (publicRequest.IsSetConditionExpression())
                {
                    context.Writer.WriteTextString("ConditionExpression");
                    context.Writer.WriteTextString(publicRequest.ConditionExpression);
                }
                if (publicRequest.IsSetExpected())
                {
                    context.Writer.WriteTextString("Expected");
                    context.Writer.WriteStartMap(null);
                    foreach (var publicRequestExpectedKvp in publicRequest.Expected)
                    {
                        context.Writer.WriteTextString(publicRequestExpectedKvp.Key);
                        var publicRequestExpectedValue = publicRequestExpectedKvp.Value;

                        context.Writer.WriteStartMap(null);

                        var marshaller = ExpectedAttributeValueMarshaller.Instance;
                        marshaller.Marshall(publicRequestExpectedValue, context);

                        context.Writer.WriteEndMap();
                    }
                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetExpressionAttributeNames())
                {
                    context.Writer.WriteTextString("ExpressionAttributeNames");
                    context.Writer.WriteStartMap(null);
                    foreach (var publicRequestExpressionAttributeNamesKvp in publicRequest.ExpressionAttributeNames)
                    {
                        context.Writer.WriteTextString(publicRequestExpressionAttributeNamesKvp.Key);
                        var publicRequestExpressionAttributeNamesValue = publicRequestExpressionAttributeNamesKvp.Value;

                            context.Writer.WriteTextString(publicRequestExpressionAttributeNamesValue);
                    }
                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetExpressionAttributeValues())
                {
                    context.Writer.WriteTextString("ExpressionAttributeValues");
                    context.Writer.WriteStartMap(null);
                    foreach (var publicRequestExpressionAttributeValuesKvp in publicRequest.ExpressionAttributeValues)
                    {
                        context.Writer.WriteTextString(publicRequestExpressionAttributeValuesKvp.Key);
                        var publicRequestExpressionAttributeValuesValue = publicRequestExpressionAttributeValuesKvp.Value;

                        context.Writer.WriteStartMap(null);

                        var marshaller = AttributeValueMarshaller.Instance;
                        marshaller.Marshall(publicRequestExpressionAttributeValuesValue, context);

                        context.Writer.WriteEndMap();
                    }
                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetItem())
                {
                    context.Writer.WriteTextString("Item");
                    context.Writer.WriteStartMap(null);
                    foreach (var publicRequestItemKvp in publicRequest.Item)
                    {
                        context.Writer.WriteTextString(publicRequestItemKvp.Key);
                        var publicRequestItemValue = publicRequestItemKvp.Value;

                        context.Writer.WriteStartMap(null);

                        var marshaller = AttributeValueMarshaller.Instance;
                        marshaller.Marshall(publicRequestItemValue, context);

                        context.Writer.WriteEndMap();
                    }
                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetReturnConsumedCapacity())
                {
                    context.Writer.WriteTextString("ReturnConsumedCapacity");
                    context.Writer.WriteTextString(publicRequest.ReturnConsumedCapacity);
                }
                if (publicRequest.IsSetReturnItemCollectionMetrics())
                {
                    context.Writer.WriteTextString("ReturnItemCollectionMetrics");
                    context.Writer.WriteTextString(publicRequest.ReturnItemCollectionMetrics);
                }
                if (publicRequest.IsSetReturnValues())
                {
                    context.Writer.WriteTextString("ReturnValues");
                    context.Writer.WriteTextString(publicRequest.ReturnValues);
                }
                if (publicRequest.IsSetReturnValuesOnConditionCheckFailure())
                {
                    context.Writer.WriteTextString("ReturnValuesOnConditionCheckFailure");
                    context.Writer.WriteTextString(publicRequest.ReturnValuesOnConditionCheckFailure);
                }
                if (publicRequest.IsSetTableName())
                {
                    context.Writer.WriteTextString("TableName");
                    context.Writer.WriteTextString(publicRequest.TableName);
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
        private static PutItemRequestMarshaller _instance = new PutItemRequestMarshaller();        

        internal static PutItemRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutItemRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}