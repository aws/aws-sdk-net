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
 * Do not modify this file. This file is generated from the nimble-2020-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.NimbleStudio.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.NimbleStudio.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteStreamingImage Request Marshaller
    /// </summary>       
    public class DeleteStreamingImageRequestMarshaller : IMarshaller<IRequest, DeleteStreamingImageRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteStreamingImageRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DeleteStreamingImageRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.NimbleStudio");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-08-01";            
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetStreamingImageId())
                throw new AmazonNimbleStudioException("Request object does not have required field StreamingImageId set");
            request.AddPathResource("{streamingImageId}", StringUtils.FromString(publicRequest.StreamingImageId));
            if (!publicRequest.IsSetStudioId())
                throw new AmazonNimbleStudioException("Request object does not have required field StudioId set");
            request.AddPathResource("{studioId}", StringUtils.FromString(publicRequest.StudioId));
            request.ResourcePath = "/2020-08-01/studios/{studioId}/streaming-images/{streamingImageId}";
        
            if(publicRequest.IsSetClientToken())
                request.Headers["X-Amz-Client-Token"] = publicRequest.ClientToken;

            return request;
        }
        private static DeleteStreamingImageRequestMarshaller _instance = new DeleteStreamingImageRequestMarshaller();        

        internal static DeleteStreamingImageRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeleteStreamingImageRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}