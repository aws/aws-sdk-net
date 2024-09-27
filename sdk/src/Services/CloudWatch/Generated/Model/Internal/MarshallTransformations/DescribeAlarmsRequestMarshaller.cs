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
    /// DescribeAlarms Request Marshaller
    /// </summary>       
    public class DescribeAlarmsRequestMarshaller : IMarshaller<IRequest, DescribeAlarmsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeAlarmsRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DescribeAlarmsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudWatch");
            request.Parameters.Add("Action", "DescribeAlarms");
            request.Parameters.Add("Version", "2010-08-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetActionPrefix())
                {
                    request.Parameters.Add("ActionPrefix", StringUtils.FromString(publicRequest.ActionPrefix));
                }
                if(publicRequest.IsSetAlarmNamePrefix())
                {
                    request.Parameters.Add("AlarmNamePrefix", StringUtils.FromString(publicRequest.AlarmNamePrefix));
                }
                if(publicRequest.IsSetAlarmNames())
                {
                    if (publicRequest.AlarmNames.Count == 0)
                        request.Parameters.Add("AlarmNames", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.AlarmNames)
                         {
                             request.Parameters.Add("AlarmNames" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
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
                if(publicRequest.IsSetChildrenOfAlarmName())
                {
                    request.Parameters.Add("ChildrenOfAlarmName", StringUtils.FromString(publicRequest.ChildrenOfAlarmName));
                }
                if(publicRequest.IsSetMaxRecords())
                {
                    request.Parameters.Add("MaxRecords", StringUtils.FromInt(publicRequest.MaxRecords));
                }
                if(publicRequest.IsSetNextToken())
                {
                    request.Parameters.Add("NextToken", StringUtils.FromString(publicRequest.NextToken));
                }
                if(publicRequest.IsSetParentsOfAlarmName())
                {
                    request.Parameters.Add("ParentsOfAlarmName", StringUtils.FromString(publicRequest.ParentsOfAlarmName));
                }
                if(publicRequest.IsSetStateValue())
                {
                    request.Parameters.Add("StateValue", StringUtils.FromString(publicRequest.StateValue));
                }
            }
            return request;
        }
                    private static DescribeAlarmsRequestMarshaller _instance = new DescribeAlarmsRequestMarshaller();        

        internal static DescribeAlarmsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeAlarmsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}