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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Lambda.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Lambda.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateFunctionUrlConfig Request Marshaller
    /// </summary>       
    public class CreateFunctionUrlConfigRequestMarshaller : IMarshaller<IRequest, CreateFunctionUrlConfigRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateFunctionUrlConfigRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateFunctionUrlConfigRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Lambda");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-03-31";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetFunctionName())
                throw new AmazonLambdaException("Request object does not have required field FunctionName set");
            request.AddPathResource("{FunctionName}", StringUtils.FromString(publicRequest.FunctionName));
            
            if (publicRequest.IsSetQualifier())
                request.Parameters.Add("Qualifier", StringUtils.FromString(publicRequest.Qualifier));
            request.ResourcePath = "/2021-10-31/functions/{FunctionName}/url";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAuthType())
                {
                    context.Writer.WritePropertyName("AuthType");
                    context.Writer.Write(publicRequest.AuthType);
                }

                if(publicRequest.IsSetCors())
                {
                    context.Writer.WritePropertyName("Cors");
                    context.Writer.WriteObjectStart();

                    var marshaller = CorsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Cors, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetInvokeMode())
                {
                    context.Writer.WritePropertyName("InvokeMode");
                    context.Writer.Write(publicRequest.InvokeMode);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }

            request.UseQueryString = true;

            return request;
        }
        private static CreateFunctionUrlConfigRequestMarshaller _instance = new CreateFunctionUrlConfigRequestMarshaller();        

        internal static CreateFunctionUrlConfigRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateFunctionUrlConfigRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}