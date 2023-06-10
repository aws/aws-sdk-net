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
 * Do not modify this file. This file is generated from the codeartifact-2018-09-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CodeArtifact.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CodeArtifact.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PublishPackageVersion Request Marshaller
    /// </summary>       
    public class PublishPackageVersionRequestMarshaller : IMarshaller<IRequest, PublishPackageVersionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PublishPackageVersionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PublishPackageVersionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CodeArtifact");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-09-22";
            request.HttpMethod = "POST";

            
            if (publicRequest.IsSetAssetName())
                request.Parameters.Add("asset", StringUtils.FromString(publicRequest.AssetName));
            
            if (publicRequest.IsSetDomain())
                request.Parameters.Add("domain", StringUtils.FromString(publicRequest.Domain));
            
            if (publicRequest.IsSetDomainOwner())
                request.Parameters.Add("domain-owner", StringUtils.FromString(publicRequest.DomainOwner));
            
            if (publicRequest.IsSetFormat())
                request.Parameters.Add("format", StringUtils.FromString(publicRequest.Format));
            
            if (publicRequest.IsSetNamespace())
                request.Parameters.Add("namespace", StringUtils.FromString(publicRequest.Namespace));
            
            if (publicRequest.IsSetPackage())
                request.Parameters.Add("package", StringUtils.FromString(publicRequest.Package));
            
            if (publicRequest.IsSetPackageVersion())
                request.Parameters.Add("version", StringUtils.FromString(publicRequest.PackageVersion));
            
            if (publicRequest.IsSetRepository())
                request.Parameters.Add("repository", StringUtils.FromString(publicRequest.Repository));
            
            if (publicRequest.IsSetUnfinished())
                request.Parameters.Add("unfinished", StringUtils.FromBool(publicRequest.Unfinished));
            request.ResourcePath = "/v1/package/version/publish";
            request.ContentStream =  publicRequest.AssetContent ?? new MemoryStream();
            request.Headers[Amazon.Util.HeaderKeys.ContentLengthHeader] =
                request.ContentStream.Length.ToString(CultureInfo.InvariantCulture);
            request.Headers[Amazon.Util.HeaderKeys.ContentTypeHeader] = "binary/octet-stream"; 
            if (request.ContentStream != null && request.ContentStream.Length == 0)
            {
                request.Headers.Remove(Amazon.Util.HeaderKeys.ContentTypeHeader);
            }
        
            if (publicRequest.IsSetAssetSHA256()) 
            {
                request.Headers["x-amz-content-sha256"] = publicRequest.AssetSHA256;
            }
            request.UseQueryString = true;

            return request;
        }
        private static PublishPackageVersionRequestMarshaller _instance = new PublishPackageVersionRequestMarshaller();        

        internal static PublishPackageVersionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PublishPackageVersionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}