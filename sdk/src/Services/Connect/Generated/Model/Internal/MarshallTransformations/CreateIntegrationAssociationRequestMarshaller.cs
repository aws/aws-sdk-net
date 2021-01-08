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
using ThirdParty.Json.LitJson;

namespace Amazon.Connect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateIntegrationAssociation Request Marshaller
    /// </summary>       
    public class CreateIntegrationAssociationRequestMarshaller : IMarshaller<IRequest, CreateIntegrationAssociationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateIntegrationAssociationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateIntegrationAssociationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Connect");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-08-08";            
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetInstanceId())
                throw new AmazonConnectException("Request object does not have required field InstanceId set");
            request.AddPathResource("{InstanceId}", StringUtils.FromString(publicRequest.InstanceId));
            request.ResourcePath = "/instance/{InstanceId}/integration-associations";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetIntegrationArn())
                {
                    context.Writer.WritePropertyName("IntegrationArn");
                    context.Writer.Write(publicRequest.IntegrationArn);
                }

                if(publicRequest.IsSetIntegrationType())
                {
                    context.Writer.WritePropertyName("IntegrationType");
                    context.Writer.Write(publicRequest.IntegrationType);
                }

                if(publicRequest.IsSetSourceApplicationName())
                {
                    context.Writer.WritePropertyName("SourceApplicationName");
                    context.Writer.Write(publicRequest.SourceApplicationName);
                }

                if(publicRequest.IsSetSourceApplicationUrl())
                {
                    context.Writer.WritePropertyName("SourceApplicationUrl");
                    context.Writer.Write(publicRequest.SourceApplicationUrl);
                }

                if(publicRequest.IsSetSourceType())
                {
                    context.Writer.WritePropertyName("SourceType");
                    context.Writer.Write(publicRequest.SourceType);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateIntegrationAssociationRequestMarshaller _instance = new CreateIntegrationAssociationRequestMarshaller();        

        internal static CreateIntegrationAssociationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateIntegrationAssociationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}