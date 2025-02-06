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
 * Do not modify this file. This file is generated from the iotevents-2018-07-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTEvents.Model;
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
namespace Amazon.IoTEvents.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeDetectorModel Request Marshaller
    /// </summary>       
    public class DescribeDetectorModelRequestMarshaller : IMarshaller<IRequest, DescribeDetectorModelRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeDetectorModelRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DescribeDetectorModelRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoTEvents");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-07-27";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetDetectorModelName())
                throw new AmazonIoTEventsException("Request object does not have required field DetectorModelName set");
            request.AddPathResource("{detectorModelName}", StringUtils.FromString(publicRequest.DetectorModelName));
            
            if (publicRequest.IsSetDetectorModelVersion())
                request.Parameters.Add("version", StringUtils.FromString(publicRequest.DetectorModelVersion));
            request.ResourcePath = "/detector-models/{detectorModelName}";
            request.UseQueryString = true;

            return request;
        }
        private static DescribeDetectorModelRequestMarshaller _instance = new DescribeDetectorModelRequestMarshaller();        

        internal static DescribeDetectorModelRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeDetectorModelRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}