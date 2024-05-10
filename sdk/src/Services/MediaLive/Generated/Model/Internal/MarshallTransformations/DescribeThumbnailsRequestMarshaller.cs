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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaLive.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.MediaLive.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeThumbnails Request Marshaller
    /// </summary>       
    public class DescribeThumbnailsRequestMarshaller : IMarshaller<IRequest, DescribeThumbnailsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeThumbnailsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DescribeThumbnailsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MediaLive");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-10-14";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetChannelId())
                throw new AmazonMediaLiveException("Request object does not have required field ChannelId set");
            request.AddPathResource("{channelId}", StringUtils.FromString(publicRequest.ChannelId));
            
            if (publicRequest.IsSetPipelineId())
                request.Parameters.Add("pipelineId", StringUtils.FromString(publicRequest.PipelineId));
            
            if (publicRequest.IsSetThumbnailType())
                request.Parameters.Add("thumbnailType", StringUtils.FromString(publicRequest.ThumbnailType));
            request.ResourcePath = "/prod/channels/{channelId}/thumbnails";
            request.UseQueryString = true;

            return request;
        }
        private static DescribeThumbnailsRequestMarshaller _instance = new DescribeThumbnailsRequestMarshaller();        

        internal static DescribeThumbnailsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeThumbnailsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}