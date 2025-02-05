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
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.Panorama.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeregisterPackageVersion Request Marshaller
    /// </summary>       
    public class DeregisterPackageVersionRequestMarshaller : IMarshaller<IRequest, DeregisterPackageVersionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeregisterPackageVersionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DeregisterPackageVersionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Panorama");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-07-24";
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetPackageId())
                throw new AmazonPanoramaException("Request object does not have required field PackageId set");
            request.AddPathResource("{PackageId}", StringUtils.FromString(publicRequest.PackageId));
            if (!publicRequest.IsSetPackageVersion())
                throw new AmazonPanoramaException("Request object does not have required field PackageVersion set");
            request.AddPathResource("{PackageVersion}", StringUtils.FromString(publicRequest.PackageVersion));
            if (!publicRequest.IsSetPatchVersion())
                throw new AmazonPanoramaException("Request object does not have required field PatchVersion set");
            request.AddPathResource("{PatchVersion}", StringUtils.FromString(publicRequest.PatchVersion));
            
            if (publicRequest.IsSetOwnerAccount())
                request.Parameters.Add("OwnerAccount", StringUtils.FromString(publicRequest.OwnerAccount));
            
            if (publicRequest.IsSetUpdatedLatestPatchVersion())
                request.Parameters.Add("UpdatedLatestPatchVersion", StringUtils.FromString(publicRequest.UpdatedLatestPatchVersion));
            request.ResourcePath = "/packages/{PackageId}/versions/{PackageVersion}/patch/{PatchVersion}";
            request.UseQueryString = true;

            return request;
        }
        private static DeregisterPackageVersionRequestMarshaller _instance = new DeregisterPackageVersionRequestMarshaller();        

        internal static DeregisterPackageVersionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeregisterPackageVersionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}