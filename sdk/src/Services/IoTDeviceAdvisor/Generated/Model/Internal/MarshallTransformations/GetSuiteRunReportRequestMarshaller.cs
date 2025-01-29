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
 * Do not modify this file. This file is generated from the iotdeviceadvisor-2020-09-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTDeviceAdvisor.Model;
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
namespace Amazon.IoTDeviceAdvisor.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetSuiteRunReport Request Marshaller
    /// </summary>       
    public class GetSuiteRunReportRequestMarshaller : IMarshaller<IRequest, GetSuiteRunReportRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetSuiteRunReportRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetSuiteRunReportRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoTDeviceAdvisor");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-09-18";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetSuiteDefinitionId())
                throw new AmazonIoTDeviceAdvisorException("Request object does not have required field SuiteDefinitionId set");
            request.AddPathResource("{suiteDefinitionId}", StringUtils.FromString(publicRequest.SuiteDefinitionId));
            if (!publicRequest.IsSetSuiteRunId())
                throw new AmazonIoTDeviceAdvisorException("Request object does not have required field SuiteRunId set");
            request.AddPathResource("{suiteRunId}", StringUtils.FromString(publicRequest.SuiteRunId));
            request.ResourcePath = "/suiteDefinitions/{suiteDefinitionId}/suiteRuns/{suiteRunId}/report";

            return request;
        }
        private static GetSuiteRunReportRequestMarshaller _instance = new GetSuiteRunReportRequestMarshaller();        

        internal static GetSuiteRunReportRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetSuiteRunReportRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}