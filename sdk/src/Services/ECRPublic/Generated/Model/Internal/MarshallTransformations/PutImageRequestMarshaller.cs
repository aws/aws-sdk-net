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
 * Do not modify this file. This file is generated from the ecr-public-2020-10-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ECRPublic.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ECRPublic.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutImage Request Marshaller
    /// </summary>       
    public class PutImageRequestMarshaller : IMarshaller<IRequest, PutImageRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutImageRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutImageRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ECRPublic");
            string target = "SpencerFrontendService.PutImage";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-10-30";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetImageDigest())
                {
                    context.Writer.WritePropertyName("imageDigest");
                    context.Writer.Write(publicRequest.ImageDigest);
                }

                if(publicRequest.IsSetImageManifest())
                {
                    context.Writer.WritePropertyName("imageManifest");
                    context.Writer.Write(publicRequest.ImageManifest);
                }

                if(publicRequest.IsSetImageManifestMediaType())
                {
                    context.Writer.WritePropertyName("imageManifestMediaType");
                    context.Writer.Write(publicRequest.ImageManifestMediaType);
                }

                if(publicRequest.IsSetImageTag())
                {
                    context.Writer.WritePropertyName("imageTag");
                    context.Writer.Write(publicRequest.ImageTag);
                }

                if(publicRequest.IsSetRegistryId())
                {
                    context.Writer.WritePropertyName("registryId");
                    context.Writer.Write(publicRequest.RegistryId);
                }

                if(publicRequest.IsSetRepositoryName())
                {
                    context.Writer.WritePropertyName("repositoryName");
                    context.Writer.Write(publicRequest.RepositoryName);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static PutImageRequestMarshaller _instance = new PutImageRequestMarshaller();        

        internal static PutImageRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutImageRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}