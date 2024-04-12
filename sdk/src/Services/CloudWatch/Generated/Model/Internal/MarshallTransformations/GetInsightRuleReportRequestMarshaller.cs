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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudWatch.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.CloudWatch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetInsightRuleReport Request Marshaller
    /// </summary>       
    public class GetInsightRuleReportRequestMarshaller : IMarshaller<IRequest, GetInsightRuleReportRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetInsightRuleReportRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetInsightRuleReportRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudWatch");
            request.Parameters.Add("Action", "GetInsightRuleReport");
            request.Parameters.Add("Version", "2010-08-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetEndTime())
                {
                    request.Parameters.Add("EndTime", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.EndTime));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetMaxContributorCount())
                {
                    request.Parameters.Add("MaxContributorCount", StringUtils.FromInt(publicRequest.MaxContributorCount));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetMetrics())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.Metrics)
                    {
                        request.Parameters.Add("Metrics" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                        publicRequestlistValueIndex++;
                    }
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetOrderBy())
                {
                    request.Parameters.Add("OrderBy", StringUtils.FromString(publicRequest.OrderBy));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetPeriod())
                {
                    request.Parameters.Add("Period", StringUtils.FromInt(publicRequest.Period));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetRuleName())
                {
                    request.Parameters.Add("RuleName", StringUtils.FromString(publicRequest.RuleName));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetStartTime())
                {
                    request.Parameters.Add("StartTime", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.StartTime));
                }
#pragma warning restore CS0612,CS0618
            }
            return request;
        }
                    private static GetInsightRuleReportRequestMarshaller _instance = new GetInsightRuleReportRequestMarshaller();        

        internal static GetInsightRuleReportRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetInsightRuleReportRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}