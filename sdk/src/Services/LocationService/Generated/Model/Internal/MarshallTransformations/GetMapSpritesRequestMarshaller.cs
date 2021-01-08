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
 * Do not modify this file. This file is generated from the location-2020-11-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LocationService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.LocationService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetMapSprites Request Marshaller
    /// </summary>       
    public class GetMapSpritesRequestMarshaller : IMarshaller<IRequest, GetMapSpritesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetMapSpritesRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetMapSpritesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.LocationService");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-11-19";            
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetFileName())
                throw new AmazonLocationServiceException("Request object does not have required field FileName set");
            request.AddPathResource("{FileName}", StringUtils.FromString(publicRequest.FileName));
            if (!publicRequest.IsSetMapName())
                throw new AmazonLocationServiceException("Request object does not have required field MapName set");
            request.AddPathResource("{MapName}", StringUtils.FromString(publicRequest.MapName));
            request.ResourcePath = "/maps/v0/maps/{MapName}/sprites/{FileName}";
            request.MarshallerVersion = 2;
            
            request.HostPrefix = $"maps.";

            return request;
        }
        private static GetMapSpritesRequestMarshaller _instance = new GetMapSpritesRequestMarshaller();        

        internal static GetMapSpritesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetMapSpritesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}