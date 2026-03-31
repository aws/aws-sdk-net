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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.QuickSight.Model;
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
namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeAutomationJob Request Marshaller
    /// </summary>       
    public class DescribeAutomationJobRequestMarshaller : IMarshaller<IRequest, DescribeAutomationJobRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeAutomationJobRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DescribeAutomationJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.QuickSight");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-04-01";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetAutomationGroupId())
                throw new AmazonQuickSightException("Request object does not have required field AutomationGroupId set");
            request.AddPathResource("{AutomationGroupId}", StringUtils.FromString(publicRequest.AutomationGroupId));
            if (!publicRequest.IsSetAutomationId())
                throw new AmazonQuickSightException("Request object does not have required field AutomationId set");
            request.AddPathResource("{AutomationId}", StringUtils.FromString(publicRequest.AutomationId));
            if (!publicRequest.IsSetAwsAccountId())
                throw new AmazonQuickSightException("Request object does not have required field AwsAccountId set");
            request.AddPathResource("{AwsAccountId}", StringUtils.FromString(publicRequest.AwsAccountId));
            if (!publicRequest.IsSetJobId())
                throw new AmazonQuickSightException("Request object does not have required field JobId set");
            request.AddPathResource("{JobId}", StringUtils.FromString(publicRequest.JobId));
            
            if (publicRequest.IsSetIncludeInputPayload())
                request.Parameters.Add("includeInputPayload", StringUtils.FromBool(publicRequest.IncludeInputPayload));
            
            if (publicRequest.IsSetIncludeOutputPayload())
                request.Parameters.Add("includeOutputPayload", StringUtils.FromBool(publicRequest.IncludeOutputPayload));
            request.ResourcePath = "/accounts/{AwsAccountId}/automation-groups/{AutomationGroupId}/automations/{AutomationId}/jobs/{JobId}";
            request.UseQueryString = true;

            return request;
        }
        private static DescribeAutomationJobRequestMarshaller _instance = new DescribeAutomationJobRequestMarshaller();        

        internal static DescribeAutomationJobRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeAutomationJobRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}