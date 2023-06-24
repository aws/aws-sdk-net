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
 * Do not modify this file. This file is generated from the simspaceweaver-2022-10-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SimSpaceWeaver.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SimSpaceWeaver.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeSimulation Request Marshaller
    /// </summary>       
    public class DescribeSimulationRequestMarshaller : IMarshaller<IRequest, DescribeSimulationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeSimulationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DescribeSimulationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SimSpaceWeaver");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-10-28";
            request.HttpMethod = "GET";

            
            if (publicRequest.IsSetSimulation())
                request.Parameters.Add("simulation", StringUtils.FromString(publicRequest.Simulation));
            request.ResourcePath = "/describesimulation";
            request.UseQueryString = true;

            return request;
        }
        private static DescribeSimulationRequestMarshaller _instance = new DescribeSimulationRequestMarshaller();        

        internal static DescribeSimulationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeSimulationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}