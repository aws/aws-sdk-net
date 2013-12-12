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

using Amazon.EC2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Report Instance Status Request Marshaller
    /// </summary>       
    public class ReportInstanceStatusRequestMarshaller : IMarshaller<IRequest, ReportInstanceStatusRequest>
    {
        public IRequest Marshall(ReportInstanceStatusRequest reportInstanceStatusRequest)
        {
            IRequest request = new DefaultRequest(reportInstanceStatusRequest, "AmazonEC2");
            request.Parameters.Add("Action", "ReportInstanceStatus");
            request.Parameters.Add("Version", "2013-10-15");
            if (reportInstanceStatusRequest != null)
            {
                List<string> instancesList = reportInstanceStatusRequest.Instances;

                int instancesListIndex = 1;
                foreach (string instancesListValue in instancesList)
                { 
                    request.Parameters.Add("InstanceId." + instancesListIndex, StringUtils.FromString(instancesListValue));
                    instancesListIndex++;
                }
            }
            if (reportInstanceStatusRequest != null && reportInstanceStatusRequest.IsSetStatus())
            {
                request.Parameters.Add("Status", StringUtils.FromString(reportInstanceStatusRequest.Status));
            }
            if (reportInstanceStatusRequest != null && reportInstanceStatusRequest.IsSetStartTime())
            {
                request.Parameters.Add("StartTime", StringUtils.FromDateTime(reportInstanceStatusRequest.StartTime));
            }
            if (reportInstanceStatusRequest != null && reportInstanceStatusRequest.IsSetEndTime())
            {
                request.Parameters.Add("EndTime", StringUtils.FromDateTime(reportInstanceStatusRequest.EndTime));
            }
            if (reportInstanceStatusRequest != null)
            {
                List<string> reasonCodesList = reportInstanceStatusRequest.ReasonCodes;

                int reasonCodesListIndex = 1;
                foreach (string reasonCodesListValue in reasonCodesList)
                { 
                    request.Parameters.Add("ReasonCode." + reasonCodesListIndex, StringUtils.FromString(reasonCodesListValue));
                    reasonCodesListIndex++;
                }
            }
            if (reportInstanceStatusRequest != null && reportInstanceStatusRequest.IsSetDescription())
            {
                request.Parameters.Add("Description", StringUtils.FromString(reportInstanceStatusRequest.Description));
            }

            return request;
        }
    }
}
