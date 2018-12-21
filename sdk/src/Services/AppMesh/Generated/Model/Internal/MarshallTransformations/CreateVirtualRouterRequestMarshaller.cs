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
 * Do not modify this file. This file is generated from the appmesh-2018-10-01.normal.json service model.
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
    /// CreateVirtualRouter Request Marshaller
    /// </summary>       
    public class CreateVirtualRouterRequestMarshaller : IMarshaller<IRequest, CreateVirtualRouterRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateVirtualRouterRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateVirtualRouterRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AppMesh");
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-10-01";            
            request.HttpMethod = "PUT";

            string uriResourcePath = "/meshes/{meshName}/virtualRouters";
            if (!publicRequest.IsSetMeshName())
                throw new AmazonAppMeshException("Request object does not have required field MeshName set");
            uriResourcePath = uriResourcePath.Replace("{meshName}", StringUtils.FromStringWithSlashEncoding(publicRequest.MeshName));
            request.ResourcePath = uriResourcePath;
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

                    var marshaller = VirtualRouterSpecMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Spec, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetVirtualRouterName())
                {
                    context.Writer.WritePropertyName("virtualRouterName");
                    context.Writer.Write(publicRequest.VirtualRouterName);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateVirtualRouterRequestMarshaller _instance = new CreateVirtualRouterRequestMarshaller();        

        internal static CreateVirtualRouterRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateVirtualRouterRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}