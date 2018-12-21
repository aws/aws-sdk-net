/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// CreateIntegration Request Marshaller
    /// </summary>       
    public class CreateIntegrationRequestMarshaller : IMarshaller<IRequest, CreateIntegrationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateIntegrationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateIntegrationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ApiGatewayV2");
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-29";            
            request.HttpMethod = "POST";

            string uriResourcePath = "/v2/apis/{apiId}/integrations";
            if (!publicRequest.IsSetApiId())
                throw new AmazonApiGatewayV2Exception("Request object does not have required field ApiId set");
            uriResourcePath = uriResourcePath.Replace("{apiId}", StringUtils.FromStringWithSlashEncoding(publicRequest.ApiId));
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetConnectionId())
                {
                    context.Writer.WritePropertyName("connectionId");
                    context.Writer.Write(publicRequest.ConnectionId);
                }

                if(publicRequest.IsSetConnectionType())
                {
                    context.Writer.WritePropertyName("connectionType");
                    context.Writer.Write(publicRequest.ConnectionType);
                }

                if(publicRequest.IsSetContentHandlingStrategy())
                {
                    context.Writer.WritePropertyName("contentHandlingStrategy");
                    context.Writer.Write(publicRequest.ContentHandlingStrategy);
                }

                if(publicRequest.IsSetCredentialsArn())
                {
                    context.Writer.WritePropertyName("credentialsArn");
                    context.Writer.Write(publicRequest.CredentialsArn);
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetIntegrationMethod())
                {
                    context.Writer.WritePropertyName("integrationMethod");
                    context.Writer.Write(publicRequest.IntegrationMethod);
                }

                if(publicRequest.IsSetIntegrationType())
                {
                    context.Writer.WritePropertyName("integrationType");
                    context.Writer.Write(publicRequest.IntegrationType);
                }

                if(publicRequest.IsSetIntegrationUri())
                {
                    context.Writer.WritePropertyName("integrationUri");
                    context.Writer.Write(publicRequest.IntegrationUri);
                }

                if(publicRequest.IsSetPassthroughBehavior())
                {
                    context.Writer.WritePropertyName("passthroughBehavior");
                    context.Writer.Write(publicRequest.PassthroughBehavior);
                }

                if(publicRequest.IsSetRequestParameters())
                {
                    context.Writer.WritePropertyName("requestParameters");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestRequestParametersKvp in publicRequest.RequestParameters)
                    {
                        context.Writer.WritePropertyName(publicRequestRequestParametersKvp.Key);
                        var publicRequestRequestParametersValue = publicRequestRequestParametersKvp.Value;

                            context.Writer.Write(publicRequestRequestParametersValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetRequestTemplates())
                {
                    context.Writer.WritePropertyName("requestTemplates");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestRequestTemplatesKvp in publicRequest.RequestTemplates)
                    {
                        context.Writer.WritePropertyName(publicRequestRequestTemplatesKvp.Key);
                        var publicRequestRequestTemplatesValue = publicRequestRequestTemplatesKvp.Value;

                            context.Writer.Write(publicRequestRequestTemplatesValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTemplateSelectionExpression())
                {
                    context.Writer.WritePropertyName("templateSelectionExpression");
                    context.Writer.Write(publicRequest.TemplateSelectionExpression);
                }

                if(publicRequest.IsSetTimeoutInMillis())
                {
                    context.Writer.WritePropertyName("timeoutInMillis");
                    context.Writer.Write(publicRequest.TimeoutInMillis);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateIntegrationRequestMarshaller _instance = new CreateIntegrationRequestMarshaller();        

        internal static CreateIntegrationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateIntegrationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}