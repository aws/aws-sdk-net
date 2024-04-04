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
 * Do not modify this file. This file is generated from the elasticbeanstalk-2010-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticBeanstalk.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ElasticBeanstalk.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeEvents Request Marshaller
    /// </summary>       
    public class DescribeEventsRequestMarshaller : IMarshaller<IRequest, DescribeEventsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeEventsRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DescribeEventsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElasticBeanstalk");
            request.Parameters.Add("Action", "DescribeEvents");
            request.Parameters.Add("Version", "2010-12-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetApplicationName())
                {
                    request.Parameters.Add("ApplicationName", StringUtils.FromString(publicRequest.ApplicationName));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetEndTimeUtc())
                {
                    request.Parameters.Add("EndTime", StringUtils.FromDateTimeToISO8601(publicRequest.EndTimeUtc));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetEnvironmentId())
                {
                    request.Parameters.Add("EnvironmentId", StringUtils.FromString(publicRequest.EnvironmentId));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetEnvironmentName())
                {
                    request.Parameters.Add("EnvironmentName", StringUtils.FromString(publicRequest.EnvironmentName));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetMaxRecords())
                {
                    request.Parameters.Add("MaxRecords", StringUtils.FromInt(publicRequest.MaxRecords));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetNextToken())
                {
                    request.Parameters.Add("NextToken", StringUtils.FromString(publicRequest.NextToken));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetPlatformArn())
                {
                    request.Parameters.Add("PlatformArn", StringUtils.FromString(publicRequest.PlatformArn));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetRequestId())
                {
                    request.Parameters.Add("RequestId", StringUtils.FromString(publicRequest.RequestId));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetSeverity())
                {
                    request.Parameters.Add("Severity", StringUtils.FromString(publicRequest.Severity));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetStartTimeUtc())
                {
                    request.Parameters.Add("StartTime", StringUtils.FromDateTimeToISO8601(publicRequest.StartTimeUtc));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetTemplateName())
                {
                    request.Parameters.Add("TemplateName", StringUtils.FromString(publicRequest.TemplateName));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetVersionLabel())
                {
                    request.Parameters.Add("VersionLabel", StringUtils.FromString(publicRequest.VersionLabel));
                }
#pragma warning restore CS0612,CS0618
            }
            return request;
        }
                    private static DescribeEventsRequestMarshaller _instance = new DescribeEventsRequestMarshaller();        

        internal static DescribeEventsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeEventsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}