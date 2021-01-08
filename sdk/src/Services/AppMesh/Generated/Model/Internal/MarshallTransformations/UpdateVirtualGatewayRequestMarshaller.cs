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
 * Do not modify this file. This file is generated from the appmesh-2019-01-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AppMesh.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.AppMesh.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateVirtualGateway Request Marshaller
    /// </summary>       
    public class UpdateVirtualGatewayRequestMarshaller : IMarshaller<IRequest, UpdateVirtualGatewayRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateVirtualGatewayRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateVirtualGatewayRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AppMesh");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-01-25";            
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetMeshName())
                throw new AmazonAppMeshException("Request object does not have required field MeshName set");
            request.AddPathResource("{meshName}", StringUtils.FromString(publicRequest.MeshName));
            if (!publicRequest.IsSetVirtualGatewayName())
                throw new AmazonAppMeshException("Request object does not have required field VirtualGatewayName set");
            request.AddPathResource("{virtualGatewayName}", StringUtils.FromString(publicRequest.VirtualGatewayName));
            
            if (publicRequest.IsSetMeshOwner())
                request.Parameters.Add("meshOwner", StringUtils.FromString(publicRequest.MeshOwner));
            request.ResourcePath = "/v20190125/meshes/{meshName}/virtualGateways/{virtualGatewayName}";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetClientToken())
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(publicRequest.ClientToken);
                }

                else if(!(publicRequest.IsSetClientToken()))
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(Guid.NewGuid().ToString());                                                
                }
                if(publicRequest.IsSetSpec())
                {
                    context.Writer.WritePropertyName("spec");
                    context.Writer.WriteObjectStart();

                    var marshaller = VirtualGatewaySpecMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Spec, context);

                    context.Writer.WriteObjectEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }

            request.UseQueryString = true;

            return request;
        }
        private static UpdateVirtualGatewayRequestMarshaller _instance = new UpdateVirtualGatewayRequestMarshaller();        

        internal static UpdateVirtualGatewayRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateVirtualGatewayRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}