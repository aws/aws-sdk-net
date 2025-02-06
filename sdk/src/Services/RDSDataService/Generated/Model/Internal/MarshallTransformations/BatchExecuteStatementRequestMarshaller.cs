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
 * Do not modify this file. This file is generated from the rds-data-2018-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.RDSDataService.Model;
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
namespace Amazon.RDSDataService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// BatchExecuteStatement Request Marshaller
    /// </summary>       
    public class BatchExecuteStatementRequestMarshaller : IMarshaller<IRequest, BatchExecuteStatementRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((BatchExecuteStatementRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(BatchExecuteStatementRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RDSDataService");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-08-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "/BatchExecute";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetDatabase())
            {
                context.Writer.WritePropertyName("database");
                context.Writer.WriteStringValue(publicRequest.Database);
            }

            if(publicRequest.IsSetParameterSets())
            {
                context.Writer.WritePropertyName("parameterSets");
                context.Writer.WriteStartArray();
                foreach(var publicRequestParameterSetsListValue in publicRequest.ParameterSets)
                {
                    context.Writer.WriteStartArray();
                    foreach(var publicRequestParameterSetsListValueListValue in publicRequestParameterSetsListValue)
                    {
                        context.Writer.WriteStartObject();

                        var marshaller = SqlParameterMarshaller.Instance;
                        marshaller.Marshall(publicRequestParameterSetsListValueListValue, context);

                        context.Writer.WriteEndObject();
                    }
                    context.Writer.WriteEndArray();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetResourceArn())
            {
                context.Writer.WritePropertyName("resourceArn");
                context.Writer.WriteStringValue(publicRequest.ResourceArn);
            }

            if(publicRequest.IsSetSchema())
            {
                context.Writer.WritePropertyName("schema");
                context.Writer.WriteStringValue(publicRequest.Schema);
            }

            if(publicRequest.IsSetSecretArn())
            {
                context.Writer.WritePropertyName("secretArn");
                context.Writer.WriteStringValue(publicRequest.SecretArn);
            }

            if(publicRequest.IsSetSql())
            {
                context.Writer.WritePropertyName("sql");
                context.Writer.WriteStringValue(publicRequest.Sql);
            }

            if(publicRequest.IsSetTransactionId())
            {
                context.Writer.WritePropertyName("transactionId");
                context.Writer.WriteStringValue(publicRequest.TransactionId);
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
        private static BatchExecuteStatementRequestMarshaller _instance = new BatchExecuteStatementRequestMarshaller();        

        internal static BatchExecuteStatementRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static BatchExecuteStatementRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}