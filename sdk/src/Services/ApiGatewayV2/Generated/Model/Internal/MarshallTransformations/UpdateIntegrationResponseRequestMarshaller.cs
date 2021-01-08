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
 * Do not modify this file. This file is generated from the apigatewayv2-2018-11-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ApiGatewayV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ApiGatewayV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateIntegrationResponse Request Marshaller
    /// </summary>       
    public class UpdateIntegrationResponseRequestMarshaller : IMarshaller<IRequest, UpdateIntegrationResponseRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateIntegrationResponseRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateIntegrationResponseRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ApiGatewayV2");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-29";            
            request.HttpMethod = "PATCH";

            if (!publicRequest.IsSetApiId())
                throw new AmazonApiGatewayV2Exception("Request object does not have required field ApiId set");
            request.AddPathResource("{apiId}", StringUtils.FromString(publicRequest.ApiId));
            if (!publicRequest.IsSetIntegrationId())
                throw new AmazonApiGatewayV2Exception("Request object does not have required field IntegrationId set");
            request.AddPathResource("{integrationId}", StringUtils.FromString(publicRequest.IntegrationId));
            if (!publicRequest.IsSetIntegrationResponseId())
                throw new AmazonApiGatewayV2Exception("Request object does not have required field IntegrationResponseId set");
            request.AddPathResource("{integrationResponseId}", StringUtils.FromString(publicRequest.IntegrationResponseId));
            request.ResourcePath = "/v2/apis/{apiId}/integrations/{integrationId}/integrationresponses/{integrationResponseId}";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetContentHandlingStrategy())
                {
                    context.Writer.WritePropertyName("contentHandlingStrategy");
                    context.Writer.Write(publicRequest.ContentHandlingStrategy);
                }

                if(publicRequest.IsSetIntegrationResponseKey())
                {
                    context.Writer.WritePropertyName("integrationResponseKey");
                    context.Writer.Write(publicRequest.IntegrationResponseKey);
                }

                if(publicRequest.IsSetResponseParameters())
                {
                    context.Writer.WritePropertyName("responseParameters");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestResponseParametersKvp in publicRequest.ResponseParameters)
                    {
                        context.Writer.WritePropertyName(publicRequestResponseParametersKvp.Key);
                        var publicRequestResponseParametersValue = publicRequestResponseParametersKvp.Value;

                            context.Writer.Write(publicRequestResponseParametersValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetResponseTemplates())
                {
                    context.Writer.WritePropertyName("responseTemplates");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestResponseTemplatesKvp in publicRequest.ResponseTemplates)
                    {
                        context.Writer.WritePropertyName(publicRequestResponseTemplatesKvp.Key);
                        var publicRequestResponseTemplatesValue = publicRequestResponseTemplatesKvp.Value;

                            context.Writer.Write(publicRequestResponseTemplatesValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTemplateSelectionExpression())
                {
                    context.Writer.WritePropertyName("templateSelectionExpression");
                    context.Writer.Write(publicRequest.TemplateSelectionExpression);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateIntegrationResponseRequestMarshaller _instance = new UpdateIntegrationResponseRequestMarshaller();        

        internal static UpdateIntegrationResponseRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateIntegrationResponseRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}