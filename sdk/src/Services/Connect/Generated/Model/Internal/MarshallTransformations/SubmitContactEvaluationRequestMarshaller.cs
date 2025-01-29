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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Connect.Model;
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
namespace Amazon.Connect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SubmitContactEvaluation Request Marshaller
    /// </summary>       
    public class SubmitContactEvaluationRequestMarshaller : IMarshaller<IRequest, SubmitContactEvaluationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SubmitContactEvaluationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(SubmitContactEvaluationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Connect");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-08-08";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetEvaluationId())
                throw new AmazonConnectException("Request object does not have required field EvaluationId set");
            request.AddPathResource("{EvaluationId}", StringUtils.FromString(publicRequest.EvaluationId));
            if (!publicRequest.IsSetInstanceId())
                throw new AmazonConnectException("Request object does not have required field InstanceId set");
            request.AddPathResource("{InstanceId}", StringUtils.FromString(publicRequest.InstanceId));
            request.ResourcePath = "/contact-evaluations/{InstanceId}/{EvaluationId}/submit";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAnswers())
            {
                context.Writer.WritePropertyName("Answers");
                context.Writer.WriteStartObject();
                foreach (var publicRequestAnswersKvp in publicRequest.Answers)
                {
                    context.Writer.WritePropertyName(publicRequestAnswersKvp.Key);
                    var publicRequestAnswersValue = publicRequestAnswersKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = EvaluationAnswerInputMarshaller.Instance;
                    marshaller.Marshall(publicRequestAnswersValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetNotes())
            {
                context.Writer.WritePropertyName("Notes");
                context.Writer.WriteStartObject();
                foreach (var publicRequestNotesKvp in publicRequest.Notes)
                {
                    context.Writer.WritePropertyName(publicRequestNotesKvp.Key);
                    var publicRequestNotesValue = publicRequestNotesKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = EvaluationNoteMarshaller.Instance;
                    marshaller.Marshall(publicRequestNotesValue, context);

                    context.Writer.WriteEndObject();
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
        private static SubmitContactEvaluationRequestMarshaller _instance = new SubmitContactEvaluationRequestMarshaller();        

        internal static SubmitContactEvaluationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SubmitContactEvaluationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}