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

using Amazon.AutoScaling.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.AutoScaling.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Resume Processes Request Marshaller
    /// </summary>       
    public class ResumeProcessesRequestMarshaller : IMarshaller<IRequest, ResumeProcessesRequest>
    {
        public IRequest Marshall(ResumeProcessesRequest resumeProcessesRequest)
        {
            IRequest request = new DefaultRequest(resumeProcessesRequest, "AmazonAutoScaling");
            request.Parameters.Add("Action", "ResumeProcesses");
            request.Parameters.Add("Version", "2011-01-01");
            if (resumeProcessesRequest != null && resumeProcessesRequest.IsSetAutoScalingGroupName())
            {
                request.Parameters.Add("AutoScalingGroupName", StringUtils.FromString(resumeProcessesRequest.AutoScalingGroupName));
            }
            if (resumeProcessesRequest != null)
            {
                List<string> scalingProcessesList = resumeProcessesRequest.ScalingProcesses;

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
