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

namespace Amazon.MediaLive.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeInputDeviceThumbnail Request Marshaller
    /// </summary>       
    public class DescribeInputDeviceThumbnailRequestMarshaller : IMarshaller<IRequest, DescribeInputDeviceThumbnailRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeInputDeviceThumbnailRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DescribeInputDeviceThumbnailRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MediaLive");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-10-14";            
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetInputDeviceId())
                throw new AmazonMediaLiveException("Request object does not have required field InputDeviceId set");
            request.AddPathResource("{inputDeviceId}", StringUtils.FromString(publicRequest.InputDeviceId));
            request.ResourcePath = "/prod/inputDevices/{inputDeviceId}/thumbnailData";
            request.MarshallerVersion = 2;
        
            if(publicRequest.IsSetAccept())
                request.Headers["accept"] = publicRequest.Accept;

            return request;
        }
        private static DescribeInputDeviceThumbnailRequestMarshaller _instance = new DescribeInputDeviceThumbnailRequestMarshaller();        

        internal static DescribeInputDeviceThumbnailRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeInputDeviceThumbnailRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}