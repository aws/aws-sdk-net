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
 * Do not modify this file. This file is generated from the mediastore-data-2017-09-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaStoreData.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.MediaStoreData.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutObject Request Marshaller
    /// </summary>       
    public class PutObjectRequestMarshaller : IMarshaller<IRequest, PutObjectRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutObjectRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutObjectRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MediaStoreData");
            request.Headers["Content-Type"] = "application/x-amz-json-";
            request.HttpMethod = "PUT";

            string uriResourcePath = "/{Path+}";
            if (!publicRequest.IsSetPath())
                throw new AmazonMediaStoreDataException("Request object does not have required field Path set");
            uriResourcePath = uriResourcePath.Replace("{Path+}", StringUtils.FromString(publicRequest.Path.TrimStart('/')));
            request.ResourcePath = uriResourcePath;
            request.ContentStream =  publicRequest.Body ?? new MemoryStream();
            request.Headers[Amazon.Util.HeaderKeys.ContentLengthHeader] =  
                request.ContentStream.Length.ToString(CultureInfo.InvariantCulture);
            request.Headers[Amazon.Util.HeaderKeys.ContentTypeHeader] = "binary/octet-stream";
        
            if(publicRequest.IsSetCacheControl())
                request.Headers["Cache-Control"] = publicRequest.CacheControl;
        
            if(publicRequest.IsSetContentType())
                request.Headers["Content-Type"] = publicRequest.ContentType;
        
            if(publicRequest.IsSetStorageClass())
                request.Headers["x-amz-storage-class"] = publicRequest.StorageClass;

            return request;
        }
        private static PutObjectRequestMarshaller _instance = new PutObjectRequestMarshaller();        

        internal static PutObjectRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutObjectRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}