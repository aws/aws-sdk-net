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
 * Do not modify this file. This file is generated from the connectcampaignsv2-2024-04-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ConnectCampaignsV2.Model;
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
namespace Amazon.ConnectCampaignsV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetInstanceOnboardingJobStatus Request Marshaller
    /// </summary>       
    public class GetInstanceOnboardingJobStatusRequestMarshaller : IMarshaller<IRequest, GetInstanceOnboardingJobStatusRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetInstanceOnboardingJobStatusRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetInstanceOnboardingJobStatusRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ConnectCampaignsV2");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2024-04-23";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetConnectInstanceId())
                throw new AmazonConnectCampaignsV2Exception("Request object does not have required field ConnectInstanceId set");
            request.AddPathResource("{connectInstanceId}", StringUtils.FromString(publicRequest.ConnectInstanceId));
            request.ResourcePath = "/v2/connect-instance/{connectInstanceId}/onboarding";

            return request;
        }
        private static GetInstanceOnboardingJobStatusRequestMarshaller _instance = new GetInstanceOnboardingJobStatusRequestMarshaller();        

        internal static GetInstanceOnboardingJobStatusRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetInstanceOnboardingJobStatusRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}