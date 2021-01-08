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
 * Do not modify this file. This file is generated from the pinpoint-email-2018-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.PinpointEmail.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.PinpointEmail.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetDeliverabilityTestReport Request Marshaller
    /// </summary>       
    public class GetDeliverabilityTestReportRequestMarshaller : IMarshaller<IRequest, GetDeliverabilityTestReportRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetDeliverabilityTestReportRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetDeliverabilityTestReportRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.PinpointEmail");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-07-26";            
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetReportId())
                throw new AmazonPinpointEmailException("Request object does not have required field ReportId set");
            request.AddPathResource("{ReportId}", StringUtils.FromString(publicRequest.ReportId));
            request.ResourcePath = "/v1/email/deliverability-dashboard/test-reports/{ReportId}";
            request.MarshallerVersion = 2;

            return request;
        }
        private static GetDeliverabilityTestReportRequestMarshaller _instance = new GetDeliverabilityTestReportRequestMarshaller();        

        internal static GetDeliverabilityTestReportRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetDeliverabilityTestReportRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}