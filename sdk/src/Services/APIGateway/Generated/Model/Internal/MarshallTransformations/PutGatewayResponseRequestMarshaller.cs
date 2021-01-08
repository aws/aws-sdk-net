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
    /// PutGatewayResponse Request Marshaller
    /// </summary>       
    public class PutGatewayResponseRequestMarshaller : IMarshaller<IRequest, PutGatewayResponseRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutGatewayResponseRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutGatewayResponseRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.APIGateway");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-07-09";            
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetResponseType())
                throw new AmazonAPIGatewayException("Request object does not have required field ResponseType set");
            request.AddPathResource("{response_type}", StringUtils.FromString(publicRequest.ResponseType));
            if (!publicRequest.IsSetRestApiId())
                throw new AmazonAPIGatewayException("Request object does not have required field RestApiId set");
            request.AddPathResource("{restapi_id}", StringUtils.FromString(publicRequest.RestApiId));
            request.ResourcePath = "/restapis/{restapi_id}/gatewayresponses/{response_type}";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
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

                if(publicRequest.IsSetStatusCode())
                {
                    context.Writer.WritePropertyName("statusCode");
                    context.Writer.Write(publicRequest.StatusCode);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static PutGatewayResponseRequestMarshaller _instance = new PutGatewayResponseRequestMarshaller();        

        internal static PutGatewayResponseRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutGatewayResponseRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}