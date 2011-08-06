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
    /// Delete Scheduled Action Request Marshaller
    /// </summary>       
    public class DeleteScheduledActionRequestMarshaller : IMarshaller<IRequest<DeleteScheduledActionRequest>, DeleteScheduledActionRequest> 
    {

        public IRequest<DeleteScheduledActionRequest> Marshall(DeleteScheduledActionRequest deleteScheduledActionRequest) 
        {
            IRequest<DeleteScheduledActionRequest> request = new DefaultRequest<DeleteScheduledActionRequest>(deleteScheduledActionRequest, "AmazonAutoScaling");
            request.Parameters.Add("Action", "DeleteScheduledAction");
            request.Parameters.Add("Version", "2011-01-01");
            if (deleteScheduledActionRequest != null && deleteScheduledActionRequest.IsSetAutoScalingGroupName()) 
            {
                request.Parameters.Add("AutoScalingGroupName", StringUtils.FromString(deleteScheduledActionRequest.AutoScalingGroupName));
            }
            if (deleteScheduledActionRequest != null && deleteScheduledActionRequest.IsSetScheduledActionName()) 
            {
                request.Parameters.Add("ScheduledActionName", StringUtils.FromString(deleteScheduledActionRequest.ScheduledActionName));
            }


            return request;
        }
    }
}
