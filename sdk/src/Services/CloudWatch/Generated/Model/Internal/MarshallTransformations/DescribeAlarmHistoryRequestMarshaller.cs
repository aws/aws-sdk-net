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
    /// DescribeAlarmHistory Request Marshaller
    /// </summary>       
    public class DescribeAlarmHistoryRequestMarshaller : IMarshaller<IRequest, DescribeAlarmHistoryRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeAlarmHistoryRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DescribeAlarmHistoryRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudWatch");
            request.Parameters.Add("Action", "DescribeAlarmHistory");
            request.Parameters.Add("Version", "2010-08-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetAlarmContributorId())
                {
                    request.Parameters.Add("AlarmContributorId", StringUtils.FromString(publicRequest.AlarmContributorId));
                }
                if(publicRequest.IsSetAlarmName())
                {
                    request.Parameters.Add("AlarmName", StringUtils.FromString(publicRequest.AlarmName));
                }
                if(publicRequest.IsSetAlarmTypes())
                {
                    if (publicRequest.AlarmTypes.Count == 0)
                        request.Parameters.Add("AlarmTypes", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.AlarmTypes)
                         {
                             request.Parameters.Add("AlarmTypes" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetEndDate())
                {
                    request.Parameters.Add("EndDate", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.EndDate));
                }
                if(publicRequest.IsSetHistoryItemType())
                {
                    request.Parameters.Add("HistoryItemType", StringUtils.FromString(publicRequest.HistoryItemType));
                }
                if(publicRequest.IsSetMaxRecords())
                {
                    request.Parameters.Add("MaxRecords", StringUtils.FromInt(publicRequest.MaxRecords));
                }
                if(publicRequest.IsSetNextToken())
                {
                    request.Parameters.Add("NextToken", StringUtils.FromString(publicRequest.NextToken));
                }
                if(publicRequest.IsSetScanBy())
                {
                    request.Parameters.Add("ScanBy", StringUtils.FromString(publicRequest.ScanBy));
                }
                if(publicRequest.IsSetStartDate())
                {
                    request.Parameters.Add("StartDate", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.StartDate));
                }
            }
            return request;
        }
                    private static DescribeAlarmHistoryRequestMarshaller _instance = new DescribeAlarmHistoryRequestMarshaller();        

        internal static DescribeAlarmHistoryRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeAlarmHistoryRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}