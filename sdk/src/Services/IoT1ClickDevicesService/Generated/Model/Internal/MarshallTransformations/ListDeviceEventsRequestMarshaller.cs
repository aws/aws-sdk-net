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
 * Do not modify this file. This file is generated from the iot1click-devices-2018-05-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoT1ClickDevicesService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoT1ClickDevicesService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListDeviceEvents Request Marshaller
    /// </summary>       
    public class ListDeviceEventsRequestMarshaller : IMarshaller<IRequest, ListDeviceEventsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListDeviceEventsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListDeviceEventsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoT1ClickDevicesService");
            request.HttpMethod = "GET";

            string uriResourcePath = "/devices/{deviceId}/events";
            if (!publicRequest.IsSetDeviceId())
                throw new AmazonIoT1ClickDevicesServiceException("Request object does not have required field DeviceId set");
            uriResourcePath = uriResourcePath.Replace("{deviceId}", StringUtils.FromString(publicRequest.DeviceId));
            
            if (publicRequest.IsSetFromTimeStamp())
                request.Parameters.Add("fromTimeStamp", StringUtils.FromDateTime(publicRequest.FromTimeStamp));
            
            if (publicRequest.IsSetMaxResults())
                request.Parameters.Add("maxResults", StringUtils.FromInt(publicRequest.MaxResults));
            
            if (publicRequest.IsSetNextToken())
                request.Parameters.Add("nextToken", StringUtils.FromString(publicRequest.NextToken));
            
            if (publicRequest.IsSetToTimeStamp())
                request.Parameters.Add("toTimeStamp", StringUtils.FromDateTime(publicRequest.ToTimeStamp));
            request.ResourcePath = uriResourcePath;
            request.UseQueryString = true;

            return request;
        }
        private static ListDeviceEventsRequestMarshaller _instance = new ListDeviceEventsRequestMarshaller();        

        internal static ListDeviceEventsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListDeviceEventsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}