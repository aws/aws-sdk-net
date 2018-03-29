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
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.APIGateway.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.APIGateway.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutMethod Request Marshaller
    /// </summary>       
    public class PutMethodRequestMarshaller : IMarshaller<IRequest, PutMethodRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutMethodRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutMethodRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.APIGateway");
            request.Headers["Content-Type"] = "application/x-amz-json-";
            request.HttpMethod = "PUT";

            string uriResourcePath = "/restapis/{restapi_id}/resources/{resource_id}/methods/{http_method}";
            if (!publicRequest.IsSetHttpMethod())
                throw new AmazonAPIGatewayException("Request object does not have required field HttpMethod set");
            uriResourcePath = uriResourcePath.Replace("{http_method}", StringUtils.FromString(publicRequest.HttpMethod));
            if (!publicRequest.IsSetResourceId())
                throw new AmazonAPIGatewayException("Request object does not have required field ResourceId set");
            uriResourcePath = uriResourcePath.Replace("{resource_id}", StringUtils.FromString(publicRequest.ResourceId));
            if (!publicRequest.IsSetRestApiId())
                throw new AmazonAPIGatewayException("Request object does not have required field RestApiId set");
            uriResourcePath = uriResourcePath.Replace("{restapi_id}", StringUtils.FromString(publicRequest.RestApiId));
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetApiKeyRequired())
                {
                    context.Writer.WritePropertyName("apiKeyRequired");
                    context.Writer.Write(publicRequest.ApiKeyRequired);
                }

                if(publicRequest.IsSetAuthorizationScopes())
                {
                    context.Writer.WritePropertyName("authorizationScopes");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAuthorizationScopesListValue in publicRequest.AuthorizationScopes)
                    {
                            context.Writer.Write(publicRequestAuthorizationScopesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetAuthorizationType())
                {
                    context.Writer.WritePropertyName("authorizationType");
                    context.Writer.Write(publicRequest.AuthorizationType);
                }

                if(publicRequest.IsSetAuthorizerId())
                {
                    context.Writer.WritePropertyName("authorizerId");
                    context.Writer.Write(publicRequest.AuthorizerId);
                }

                if(publicRequest.IsSetOperationName())
                {
                    context.Writer.WritePropertyName("operationName");
                    context.Writer.Write(publicRequest.OperationName);
                }

                if(publicRequest.IsSetRequestModels())
                {
                    context.Writer.WritePropertyName("requestModels");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestRequestModelsKvp in publicRequest.RequestModels)
                    {
                        context.Writer.WritePropertyName(publicRequestRequestModelsKvp.Key);
                        var publicRequestRequestModelsValue = publicRequestRequestModelsKvp.Value;

                            context.Writer.Write(publicRequestRequestModelsValue);
                    }
                    context.Writer.WriteObjectEnd();
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

                if(publicRequest.IsSetRequestValidatorId())
                {
                    context.Writer.WritePropertyName("requestValidatorId");
                    context.Writer.Write(publicRequest.RequestValidatorId);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static PutMethodRequestMarshaller _instance = new PutMethodRequestMarshaller();        

        internal static PutMethodRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutMethodRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}