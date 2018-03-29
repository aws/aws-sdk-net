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
    /// PutIntegration Request Marshaller
    /// </summary>       
    public class PutIntegrationRequestMarshaller : IMarshaller<IRequest, PutIntegrationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutIntegrationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutIntegrationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.APIGateway");
            request.Headers["Content-Type"] = "application/x-amz-json-";
            request.HttpMethod = "PUT";

            string uriResourcePath = "/restapis/{restapi_id}/resources/{resource_id}/methods/{http_method}/integration";
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
                if(publicRequest.IsSetCacheKeyParameters())
                {
                    context.Writer.WritePropertyName("cacheKeyParameters");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestCacheKeyParametersListValue in publicRequest.CacheKeyParameters)
                    {
                            context.Writer.Write(publicRequestCacheKeyParametersListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetCacheNamespace())
                {
                    context.Writer.WritePropertyName("cacheNamespace");
                    context.Writer.Write(publicRequest.CacheNamespace);
                }

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

                if(publicRequest.IsSetContentHandling())
                {
                    context.Writer.WritePropertyName("contentHandling");
                    context.Writer.Write(publicRequest.ContentHandling);
                }

                if(publicRequest.IsSetCredentials())
                {
                    context.Writer.WritePropertyName("credentials");
                    context.Writer.Write(publicRequest.Credentials);
                }

                if(publicRequest.IsSetIntegrationHttpMethod())
                {
                    context.Writer.WritePropertyName("httpMethod");
                    context.Writer.Write(publicRequest.IntegrationHttpMethod);
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

                if(publicRequest.IsSetTimeoutInMillis())
                {
                    context.Writer.WritePropertyName("timeoutInMillis");
                    context.Writer.Write(publicRequest.TimeoutInMillis);
                }

                if(publicRequest.IsSetType())
                {
                    context.Writer.WritePropertyName("type");
                    context.Writer.Write(publicRequest.Type);
                }

                if(publicRequest.IsSetUri())
                {
                    context.Writer.WritePropertyName("uri");
                    context.Writer.Write(publicRequest.Uri);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static PutIntegrationRequestMarshaller _instance = new PutIntegrationRequestMarshaller();        

        internal static PutIntegrationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutIntegrationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}