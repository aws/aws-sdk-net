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
 * Do not modify this file. This file is generated from the bedrock-runtime-2023-09-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BedrockRuntime.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockRuntime.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ApplyGuardrail Request Marshaller
    /// </summary>       
    public class ApplyGuardrailRequestMarshaller : IMarshaller<IRequest, ApplyGuardrailRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ApplyGuardrailRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ApplyGuardrailRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.BedrockRuntime");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-09-30";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetGuardrailIdentifier())
                throw new AmazonBedrockRuntimeException("Request object does not have required field GuardrailIdentifier set");
            request.AddPathResource("{guardrailIdentifier}", StringUtils.FromString(publicRequest.GuardrailIdentifier));
            if (!publicRequest.IsSetGuardrailVersion())
                throw new AmazonBedrockRuntimeException("Request object does not have required field GuardrailVersion set");
            request.AddPathResource("{guardrailVersion}", StringUtils.FromString(publicRequest.GuardrailVersion));
            request.ResourcePath = "/guardrail/{guardrailIdentifier}/version/{guardrailVersion}/apply";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetContent())
                {
                    context.Writer.WritePropertyName("content");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestContentListValue in publicRequest.Content)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = GuardrailContentBlockMarshaller.Instance;
                        marshaller.Marshall(publicRequestContentListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetSource())
                {
                    context.Writer.WritePropertyName("source");
                    context.Writer.Write(publicRequest.Source);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static ApplyGuardrailRequestMarshaller _instance = new ApplyGuardrailRequestMarshaller();        

        internal static ApplyGuardrailRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ApplyGuardrailRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}