/*
 * Copyright 2010-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.AutoScaling.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.AutoScaling.Model.Transform
{
    /// <summary>
    /// Suspend Processes Request Marshaller
    /// </summary>       
    public class SuspendProcessesRequestMarshaller : IMarshaller<IRequest<SuspendProcessesRequest>, SuspendProcessesRequest> 
    {

        public IRequest<SuspendProcessesRequest> Marshall(SuspendProcessesRequest suspendProcessesRequest) 
        {
            IRequest<SuspendProcessesRequest> request = new DefaultRequest<SuspendProcessesRequest>(suspendProcessesRequest, "AmazonAutoScaling");
            request.Parameters.Add("Action", "SuspendProcesses");
            request.Parameters.Add("Version", "2010-08-01");
            if (suspendProcessesRequest != null && suspendProcessesRequest.IsSetAutoScalingGroupName()) 
            {
                request.Parameters.Add("AutoScalingGroupName", StringUtils.FromString(suspendProcessesRequest.AutoScalingGroupName));
            }
            if (suspendProcessesRequest != null) 
            {
                List<string> scalingProcessesList = suspendProcessesRequest.ScalingProcesses;
                int scalingProcessesListIndex = 1;
                foreach (string scalingProcessesListValue in scalingProcessesList) 
                { 
                    request.Parameters.Add("ScalingProcesses.member." + scalingProcessesListIndex, StringUtils.FromString(scalingProcessesListValue));
                    scalingProcessesListIndex++;
                }
            }


            return request;
        }
    }
}
