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
 * Do not modify this file. This file is generated from the qldb-session-2019-07-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.QLDBSession.Model;
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
namespace Amazon.QLDBSession.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SendCommand Request Marshaller
    /// </summary>       
    public class SendCommandRequestMarshaller : IMarshaller<IRequest, SendCommandRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SendCommandRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(SendCommandRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.QLDBSession");
            string target = "QLDBSession.SendCommand";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-07-11";
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
            if(publicRequest.IsSetAbortTransaction())
            {
                context.Writer.WritePropertyName("AbortTransaction");
                context.Writer.WriteStartObject();

                var marshaller = AbortTransactionRequestMarshaller.Instance;
                marshaller.Marshall(publicRequest.AbortTransaction, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetCommitTransaction())
            {
                context.Writer.WritePropertyName("CommitTransaction");
                context.Writer.WriteStartObject();

                var marshaller = CommitTransactionRequestMarshaller.Instance;
                marshaller.Marshall(publicRequest.CommitTransaction, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetEndSession())
            {
                context.Writer.WritePropertyName("EndSession");
                context.Writer.WriteStartObject();

                var marshaller = EndSessionRequestMarshaller.Instance;
                marshaller.Marshall(publicRequest.EndSession, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetExecuteStatement())
            {
                context.Writer.WritePropertyName("ExecuteStatement");
                context.Writer.WriteStartObject();

                var marshaller = ExecuteStatementRequestMarshaller.Instance;
                marshaller.Marshall(publicRequest.ExecuteStatement, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetFetchPage())
            {
                context.Writer.WritePropertyName("FetchPage");
                context.Writer.WriteStartObject();

                var marshaller = FetchPageRequestMarshaller.Instance;
                marshaller.Marshall(publicRequest.FetchPage, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetSessionToken())
            {
                context.Writer.WritePropertyName("SessionToken");
                context.Writer.WriteStringValue(publicRequest.SessionToken);
            }

            if(publicRequest.IsSetStartSession())
            {
                context.Writer.WritePropertyName("StartSession");
                context.Writer.WriteStartObject();

                var marshaller = StartSessionRequestMarshaller.Instance;
                marshaller.Marshall(publicRequest.StartSession, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetStartTransaction())
            {
                context.Writer.WritePropertyName("StartTransaction");
                context.Writer.WriteStartObject();

                var marshaller = StartTransactionRequestMarshaller.Instance;
                marshaller.Marshall(publicRequest.StartTransaction, context);

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
        private static SendCommandRequestMarshaller _instance = new SendCommandRequestMarshaller();        

        internal static SendCommandRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SendCommandRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}