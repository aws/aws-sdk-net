/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

using Amazon.ElasticBeanstalk.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.ElasticBeanstalk.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Describe Events Request Marshaller
    /// </summary>       
    public class DescribeEventsRequestMarshaller : IMarshaller<IRequest, DescribeEventsRequest>
    {
        public IRequest Marshall(DescribeEventsRequest describeEventsRequest)
        {
            IRequest request = new DefaultRequest(describeEventsRequest, "AmazonElasticBeanstalk");
            request.Parameters.Add("Action", "DescribeEvents");
            request.Parameters.Add("Version", "2010-12-01");
            if (describeEventsRequest != null && describeEventsRequest.IsSetApplicationName())
            {
                request.Parameters.Add("ApplicationName", StringUtils.FromString(describeEventsRequest.ApplicationName));
            }
            if (describeEventsRequest != null && describeEventsRequest.IsSetVersionLabel())
            {
                request.Parameters.Add("VersionLabel", StringUtils.FromString(describeEventsRequest.VersionLabel));
            }
            if (describeEventsRequest != null && describeEventsRequest.IsSetTemplateName())
            {
                request.Parameters.Add("TemplateName", StringUtils.FromString(describeEventsRequest.TemplateName));
            }
            if (describeEventsRequest != null && describeEventsRequest.IsSetEnvironmentId())
            {
                request.Parameters.Add("EnvironmentId", StringUtils.FromString(describeEventsRequest.EnvironmentId));
            }
            if (describeEventsRequest != null && describeEventsRequest.IsSetEnvironmentName())
            {
                request.Parameters.Add("EnvironmentName", StringUtils.FromString(describeEventsRequest.EnvironmentName));
            }
            if (describeEventsRequest != null && describeEventsRequest.IsSetRequestId())
            {
                request.Parameters.Add("RequestId", StringUtils.FromString(describeEventsRequest.RequestId));
            }
            if (describeEventsRequest != null && describeEventsRequest.IsSetSeverity())
            {
                request.Parameters.Add("Severity", StringUtils.FromString(describeEventsRequest.Severity));
            }
            if (describeEventsRequest != null && describeEventsRequest.IsSetStartTime())
            {
                request.Parameters.Add("StartTime", StringUtils.FromDateTime(describeEventsRequest.StartTime));
            }
            if (describeEventsRequest != null && describeEventsRequest.IsSetEndTime())
            {
                request.Parameters.Add("EndTime", StringUtils.FromDateTime(describeEventsRequest.EndTime));
            }
            if (describeEventsRequest != null && describeEventsRequest.IsSetMaxRecords())
            {
                request.Parameters.Add("MaxRecords", StringUtils.FromInt(describeEventsRequest.MaxRecords));
            }
            if (describeEventsRequest != null && describeEventsRequest.IsSetNextToken())
            {
                request.Parameters.Add("NextToken", StringUtils.FromString(describeEventsRequest.NextToken));
            }

            return request;
        }
    }
}
