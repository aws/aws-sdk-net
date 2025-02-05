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
 * Do not modify this file. This file is generated from the iotwireless-2020-11-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTWireless.Model;
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
namespace Amazon.IoTWireless.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListWirelessDevices Request Marshaller
    /// </summary>       
    public class ListWirelessDevicesRequestMarshaller : IMarshaller<IRequest, ListWirelessDevicesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListWirelessDevicesRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListWirelessDevicesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoTWireless");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-11-22";
            request.HttpMethod = "GET";

            
            if (publicRequest.IsSetDestinationName())
                request.Parameters.Add("destinationName", StringUtils.FromString(publicRequest.DestinationName));
            
            if (publicRequest.IsSetDeviceProfileId())
                request.Parameters.Add("deviceProfileId", StringUtils.FromString(publicRequest.DeviceProfileId));
            
            if (publicRequest.IsSetFuotaTaskId())
                request.Parameters.Add("fuotaTaskId", StringUtils.FromString(publicRequest.FuotaTaskId));
            
            if (publicRequest.IsSetMaxResults())
                request.Parameters.Add("maxResults", StringUtils.FromInt(publicRequest.MaxResults));
            
            if (publicRequest.IsSetMulticastGroupId())
                request.Parameters.Add("multicastGroupId", StringUtils.FromString(publicRequest.MulticastGroupId));
            
            if (publicRequest.IsSetNextToken())
                request.Parameters.Add("nextToken", StringUtils.FromString(publicRequest.NextToken));
            
            if (publicRequest.IsSetServiceProfileId())
                request.Parameters.Add("serviceProfileId", StringUtils.FromString(publicRequest.ServiceProfileId));
            
            if (publicRequest.IsSetWirelessDeviceType())
                request.Parameters.Add("wirelessDeviceType", StringUtils.FromString(publicRequest.WirelessDeviceType));
            request.ResourcePath = "/wireless-devices";
            request.UseQueryString = true;

            return request;
        }
        private static ListWirelessDevicesRequestMarshaller _instance = new ListWirelessDevicesRequestMarshaller();        

        internal static ListWirelessDevicesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListWirelessDevicesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}