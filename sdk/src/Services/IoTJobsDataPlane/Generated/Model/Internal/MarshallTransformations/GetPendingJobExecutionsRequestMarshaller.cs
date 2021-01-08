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
 * Do not modify this file. This file is generated from the iot-jobs-data-2017-09-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTJobsDataPlane.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoTJobsDataPlane.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetPendingJobExecutions Request Marshaller
    /// </summary>       
    public class GetPendingJobExecutionsRequestMarshaller : IMarshaller<IRequest, GetPendingJobExecutionsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetPendingJobExecutionsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetPendingJobExecutionsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoTJobsDataPlane");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-09-29";            
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetThingName())
                throw new AmazonIoTJobsDataPlaneException("Request object does not have required field ThingName set");
            request.AddPathResource("{thingName}", StringUtils.FromString(publicRequest.ThingName));
            request.ResourcePath = "/things/{thingName}/jobs";
            request.MarshallerVersion = 2;

            return request;
        }
        private static GetPendingJobExecutionsRequestMarshaller _instance = new GetPendingJobExecutionsRequestMarshaller();        

        internal static GetPendingJobExecutionsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetPendingJobExecutionsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}