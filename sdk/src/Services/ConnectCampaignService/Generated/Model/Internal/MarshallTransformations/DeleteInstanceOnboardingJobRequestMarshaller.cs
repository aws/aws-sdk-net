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
 * Do not modify this file. This file is generated from the connectcampaigns-2021-01-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ConnectCampaignService.Model;
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
namespace Amazon.ConnectCampaignService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteInstanceOnboardingJob Request Marshaller
    /// </summary>       
    public class DeleteInstanceOnboardingJobRequestMarshaller : IMarshaller<IRequest, DeleteInstanceOnboardingJobRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteInstanceOnboardingJobRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DeleteInstanceOnboardingJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ConnectCampaignService");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-01-30";
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetConnectInstanceId())
                throw new AmazonConnectCampaignServiceException("Request object does not have required field ConnectInstanceId set");
            request.AddPathResource("{connectInstanceId}", StringUtils.FromString(publicRequest.ConnectInstanceId));
            request.ResourcePath = "/connect-instance/{connectInstanceId}/onboarding";

            return request;
        }
        private static DeleteInstanceOnboardingJobRequestMarshaller _instance = new DeleteInstanceOnboardingJobRequestMarshaller();        

        internal static DeleteInstanceOnboardingJobRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeleteInstanceOnboardingJobRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}