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
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.S3.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Xml;

#pragma warning disable CS0612,CS0618
namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetObjectAttributes Request Marshaller
    /// </summary>       
    public partial class GetObjectAttributesRequestMarshaller : IMarshaller<IRequest, GetObjectAttributesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetObjectAttributesRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetObjectAttributesRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.S3");
            request.HttpMethod = "GET";
            request.AddSubResource("attributes");
        
            if (publicRequest.IsSetExpectedBucketOwner()) 
            {
                request.Headers["x-amz-expected-bucket-owner"] = publicRequest.ExpectedBucketOwner;
            }
        
            if (publicRequest.IsSetMaxParts()) 
            {
                request.Headers["x-amz-max-parts"] = StringUtils.FromInt(publicRequest.MaxParts);
            }
        
            if (publicRequest.IsSetObjectAttributes()) 
            {
                        request.Headers["x-amz-object-attributes"] = StringUtils.FromList(publicRequest.ObjectAttributes);
            }
        
            if (publicRequest.IsSetPartNumberMarker()) 
            {
                request.Headers["x-amz-part-number-marker"] = StringUtils.FromInt(publicRequest.PartNumberMarker);
            }
        
            if (publicRequest.IsSetRequestPayer()) 
            {
                request.Headers["x-amz-request-payer"] = publicRequest.RequestPayer;
            }
        
            if (publicRequest.IsSetSSECustomerAlgorithm()) 
            {
                request.Headers["x-amz-server-side-encryption-customer-algorithm"] = publicRequest.SSECustomerAlgorithm;
            }
        
            if (publicRequest.IsSetSSECustomerKey()) 
            {
                request.Headers["x-amz-server-side-encryption-customer-key"] = publicRequest.SSECustomerKey;
            }
        
            if (publicRequest.IsSetSSECustomerKeyMD5()) 
            {
                request.Headers["x-amz-server-side-encryption-customer-key-MD5"] = publicRequest.SSECustomerKeyMD5;
            }
            if (!publicRequest.IsSetBucketName())
                throw new AmazonS3Exception("Request object does not have required field BucketName set");
            if (!publicRequest.IsSetKey())
                throw new AmazonS3Exception("Request object does not have required field Key set");
            request.AddPathResource("{Key+}", StringUtils.FromString(publicRequest.Key));
            
            if (publicRequest.IsSetVersionId())
                request.AddSubResource("versionId", StringUtils.FromString(publicRequest.VersionId));
            request.ResourcePath = "/{Key+}";

            PostMarshallCustomization(request, publicRequest);
            request.UseQueryString = true;
            return request;
        }
        private static GetObjectAttributesRequestMarshaller _instance = new GetObjectAttributesRequestMarshaller();        

        internal static GetObjectAttributesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetObjectAttributesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, GetObjectAttributesRequest publicRequest);
    }    
}