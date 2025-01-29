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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LexModelsV2.Model;
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
namespace Amazon.LexModelsV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateResourcePolicyStatement Request Marshaller
    /// </summary>       
    public class CreateResourcePolicyStatementRequestMarshaller : IMarshaller<IRequest, CreateResourcePolicyStatementRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateResourcePolicyStatementRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateResourcePolicyStatementRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.LexModelsV2");
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-08-07";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetResourceArn())
                throw new AmazonLexModelsV2Exception("Request object does not have required field ResourceArn set");
            request.AddPathResource("{resourceArn}", StringUtils.FromString(publicRequest.ResourceArn));
            
            if (publicRequest.IsSetExpectedRevisionId())
                request.Parameters.Add("expectedRevisionId", StringUtils.FromString(publicRequest.ExpectedRevisionId));
            request.ResourcePath = "/policy/{resourceArn}/statements/";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAction())
            {
                context.Writer.WritePropertyName("action");
                context.Writer.WriteStartArray();
                foreach(var publicRequestActionListValue in publicRequest.Action)
                {
                        context.Writer.WriteStringValue(publicRequestActionListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetCondition())
            {
                context.Writer.WritePropertyName("condition");
                context.Writer.WriteStartObject();
                foreach (var publicRequestConditionKvp in publicRequest.Condition)
                {
                    context.Writer.WritePropertyName(publicRequestConditionKvp.Key);
                    var publicRequestConditionValue = publicRequestConditionKvp.Value;

                    context.Writer.WriteStartObject();
                    foreach (var publicRequestConditionValueKvp in publicRequestConditionValue)
                    {
                        context.Writer.WritePropertyName(publicRequestConditionValueKvp.Key);
                        var publicRequestConditionValueValue = publicRequestConditionValueKvp.Value;

                            context.Writer.WriteStringValue(publicRequestConditionValueValue);
                    }
                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetEffect())
            {
                context.Writer.WritePropertyName("effect");
                context.Writer.WriteStringValue(publicRequest.Effect);
            }

            if(publicRequest.IsSetPrincipal())
            {
                context.Writer.WritePropertyName("principal");
                context.Writer.WriteStartArray();
                foreach(var publicRequestPrincipalListValue in publicRequest.Principal)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = PrincipalMarshaller.Instance;
                    marshaller.Marshall(publicRequestPrincipalListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetStatementId())
            {
                context.Writer.WritePropertyName("statementId");
                context.Writer.WriteStringValue(publicRequest.StatementId);
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            

            request.UseQueryString = true;

            return request;
        }
        private static CreateResourcePolicyStatementRequestMarshaller _instance = new CreateResourcePolicyStatementRequestMarshaller();        

        internal static CreateResourcePolicyStatementRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateResourcePolicyStatementRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}