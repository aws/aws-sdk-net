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
 * Do not modify this file. This file is generated from the panorama-2019-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Panorama.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Panorama.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RegisterPackageVersion Request Marshaller
    /// </summary>       
    public class RegisterPackageVersionRequestMarshaller : IMarshaller<IRequest, RegisterPackageVersionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RegisterPackageVersionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(RegisterPackageVersionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Panorama");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-07-24";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetPackageId())
                throw new AmazonPanoramaException("Request object does not have required field PackageId set");
            request.AddPathResource("{PackageId}", StringUtils.FromString(publicRequest.PackageId));
            if (!publicRequest.IsSetPackageVersion())
                throw new AmazonPanoramaException("Request object does not have required field PackageVersion set");
            request.AddPathResource("{PackageVersion}", StringUtils.FromString(publicRequest.PackageVersion));
            if (!publicRequest.IsSetPatchVersion())
                throw new AmazonPanoramaException("Request object does not have required field PatchVersion set");
            request.AddPathResource("{PatchVersion}", StringUtils.FromString(publicRequest.PatchVersion));
            request.ResourcePath = "/packages/{PackageId}/versions/{PackageVersion}/patch/{PatchVersion}";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetMarkLatest())
                {
                    context.Writer.WritePropertyName("MarkLatest");
                    context.Writer.Write(publicRequest.MarkLatest);
                }

                if(publicRequest.IsSetOwnerAccount())
                {
                    context.Writer.WritePropertyName("OwnerAccount");
                    context.Writer.Write(publicRequest.OwnerAccount);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static RegisterPackageVersionRequestMarshaller _instance = new RegisterPackageVersionRequestMarshaller();        

        internal static RegisterPackageVersionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RegisterPackageVersionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}