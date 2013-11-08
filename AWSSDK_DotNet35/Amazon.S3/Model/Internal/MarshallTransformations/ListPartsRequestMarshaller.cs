/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Text;

using Amazon.S3.Model;
using Amazon.S3.Util;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// List Parts Request Marshaller
    /// </summary>       
    public class ListPartsRequestMarshaller : IMarshaller<IRequest, ListPartsRequest>
    {
        
    
        public IRequest Marshall(ListPartsRequest listPartsRequest)
        {
            IRequest request = new DefaultRequest(listPartsRequest, "AmazonS3");



            request.HttpMethod = "GET";
              
            Dictionary<string, string> queryParameters = new Dictionary<string, string>();
            string uriResourcePath = "/{Bucket}/{Key}?uploadId={UploadId};max-parts={MaxParts};part-number-marker={PartNumberMarker}"; 
            uriResourcePath = uriResourcePath.Replace("{Bucket}", listPartsRequest.IsSetBucketName() ? S3Transforms.ToStringValue(listPartsRequest.BucketName) : "" ); 
            uriResourcePath = uriResourcePath.Replace("{Key}", listPartsRequest.IsSetKey() ? S3Transforms.ToStringValue(listPartsRequest.Key) : "" ); 
            uriResourcePath = uriResourcePath.Replace("{MaxParts}", listPartsRequest.IsSetMaxParts() ? S3Transforms.ToStringValue(listPartsRequest.MaxParts) : "" ); 
            uriResourcePath = uriResourcePath.Replace("{PartNumberMarker}", listPartsRequest.IsSetPartNumberMarker() ? S3Transforms.ToStringValue(listPartsRequest.PartNumberMarker) : "" ); 
            uriResourcePath = uriResourcePath.Replace("{UploadId}", listPartsRequest.IsSetUploadId() ? S3Transforms.ToStringValue(listPartsRequest.UploadId) : "" ); 
            string path = uriResourcePath;


            int queryIndex = uriResourcePath.IndexOf("?", StringComparison.OrdinalIgnoreCase);
            if (queryIndex != -1)
            {
                string queryString = uriResourcePath.Substring(queryIndex + 1);
                path = uriResourcePath.Substring(0, queryIndex);

                S3Transforms.BuildQueryParameterMap(request, queryParameters, queryString);
            }
            
            request.CanonicalResource = S3Transforms.GetCanonicalResource(path, queryParameters);
            uriResourcePath = S3Transforms.FormatResourcePath(path, queryParameters);
            
            request.ResourcePath = uriResourcePath;
            
        
            request.UseQueryString = true;
            
            
            return request;
        }
    }
}
    
