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
    /// DescribeMultiplexProgram Request Marshaller
    /// </summary>       
    public class DescribeMultiplexProgramRequestMarshaller : IMarshaller<IRequest, DescribeMultiplexProgramRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeMultiplexProgramRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DescribeMultiplexProgramRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MediaLive");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-10-14";            
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetMultiplexId())
                throw new AmazonMediaLiveException("Request object does not have required field MultiplexId set");
            request.AddPathResource("{multiplexId}", StringUtils.FromString(publicRequest.MultiplexId));
            if (!publicRequest.IsSetProgramName())
                throw new AmazonMediaLiveException("Request object does not have required field ProgramName set");
            request.AddPathResource("{programName}", StringUtils.FromString(publicRequest.ProgramName));
            request.ResourcePath = "/prod/multiplexes/{multiplexId}/programs/{programName}";
            request.MarshallerVersion = 2;

            return request;
        }
        private static DescribeMultiplexProgramRequestMarshaller _instance = new DescribeMultiplexProgramRequestMarshaller();        

        internal static DescribeMultiplexProgramRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeMultiplexProgramRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}