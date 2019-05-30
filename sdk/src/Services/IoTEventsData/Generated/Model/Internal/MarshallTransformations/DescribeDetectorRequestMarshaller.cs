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
 * Do not modify this file. This file is generated from the iotevents-data-2018-10-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTEventsData.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoTEventsData.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeDetector Request Marshaller
    /// </summary>       
    public class DescribeDetectorRequestMarshaller : IMarshaller<IRequest, DescribeDetectorRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeDetectorRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DescribeDetectorRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoTEventsData");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-10-23";            
            request.HttpMethod = "GET";

            string uriResourcePath = "/detectors/{detectorModelName}/keyValues/";
            if (!publicRequest.IsSetDetectorModelName())
                throw new AmazonIoTEventsDataException("Request object does not have required field DetectorModelName set");
            uriResourcePath = uriResourcePath.Replace("{detectorModelName}", StringUtils.FromStringWithSlashEncoding(publicRequest.DetectorModelName));
            
            if (publicRequest.IsSetKeyValue())
                request.Parameters.Add("keyValue", StringUtils.FromString(publicRequest.KeyValue));
            request.ResourcePath = uriResourcePath;
            request.UseQueryString = true;

            return request;
        }
        private static DescribeDetectorRequestMarshaller _instance = new DescribeDetectorRequestMarshaller();        

        internal static DescribeDetectorRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeDetectorRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}