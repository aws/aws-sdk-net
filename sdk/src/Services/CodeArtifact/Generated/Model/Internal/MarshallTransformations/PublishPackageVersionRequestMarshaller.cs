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
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
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

            if (string.IsNullOrEmpty(publicRequest.AssetName))
                throw new AmazonCodeArtifactException("Request object does not have required field AssetName set");
            
            if (publicRequest.IsSetAssetName())
                request.Parameters.Add("asset", StringUtils.FromString(publicRequest.AssetName));
            if (string.IsNullOrEmpty(publicRequest.Domain))
                throw new AmazonCodeArtifactException("Request object does not have required field Domain set");
            
            if (publicRequest.IsSetDomain())
                request.Parameters.Add("domain", StringUtils.FromString(publicRequest.Domain));
            
            if (publicRequest.IsSetDomainOwner())
                request.Parameters.Add("domain-owner", StringUtils.FromString(publicRequest.DomainOwner));
            if (string.IsNullOrEmpty(publicRequest.Format))
                throw new AmazonCodeArtifactException("Request object does not have required field Format set");
            
            if (publicRequest.IsSetFormat())
                request.Parameters.Add("format", StringUtils.FromString(publicRequest.Format));
            
            if (publicRequest.IsSetNamespace())
                request.Parameters.Add("namespace", StringUtils.FromString(publicRequest.Namespace));
            if (string.IsNullOrEmpty(publicRequest.Package))
                throw new AmazonCodeArtifactException("Request object does not have required field Package set");
            
            if (publicRequest.IsSetPackage())
                request.Parameters.Add("package", StringUtils.FromString(publicRequest.Package));
            if (string.IsNullOrEmpty(publicRequest.PackageVersion))
                throw new AmazonCodeArtifactException("Request object does not have required field PackageVersion set");
            
            if (publicRequest.IsSetPackageVersion())
                request.Parameters.Add("version", StringUtils.FromString(publicRequest.PackageVersion));
            if (string.IsNullOrEmpty(publicRequest.Repository))
                throw new AmazonCodeArtifactException("Request object does not have required field Repository set");
            
            if (publicRequest.IsSetRepository())
                request.Parameters.Add("repository", StringUtils.FromString(publicRequest.Repository));
            
            if (publicRequest.IsSetUnfinished())
                request.Parameters.Add("unfinished", StringUtils.FromBool(publicRequest.Unfinished));
            request.ResourcePath = "/v1/package/version/publish";
            request.ContentStream =  publicRequest.AssetContent ?? new MemoryStream();
            if(request.ContentStream.CanSeek)
            {
                request.ContentStream.Seek(0, SeekOrigin.Begin);
            }
            request.Headers[Amazon.Util.HeaderKeys.ContentLengthHeader] =
                request.ContentStream.Length.ToString(CultureInfo.InvariantCulture);
            request.Headers[Amazon.Util.HeaderKeys.ContentTypeHeader] = "application/octet-stream";
        
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