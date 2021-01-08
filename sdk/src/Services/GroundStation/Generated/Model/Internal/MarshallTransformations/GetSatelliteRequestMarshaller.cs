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
 * Do not modify this file. This file is generated from the groundstation-2019-05-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.GroundStation.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.GroundStation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetSatellite Request Marshaller
    /// </summary>       
    public class GetSatelliteRequestMarshaller : IMarshaller<IRequest, GetSatelliteRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetSatelliteRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetSatelliteRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.GroundStation");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-05-23";            
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetSatelliteId())
                throw new AmazonGroundStationException("Request object does not have required field SatelliteId set");
            request.AddPathResource("{satelliteId}", StringUtils.FromString(publicRequest.SatelliteId));
            request.ResourcePath = "/satellite/{satelliteId}";
            request.MarshallerVersion = 2;

            return request;
        }
        private static GetSatelliteRequestMarshaller _instance = new GetSatelliteRequestMarshaller();        

        internal static GetSatelliteRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetSatelliteRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}