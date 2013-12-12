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
    /// Start Instances Request Marshaller
    /// </summary>       
    public class StartInstancesRequestMarshaller : IMarshaller<IRequest, StartInstancesRequest>
    {
        public IRequest Marshall(StartInstancesRequest startInstancesRequest)
        {
            IRequest request = new DefaultRequest(startInstancesRequest, "AmazonEC2");
            request.Parameters.Add("Action", "StartInstances");
            request.Parameters.Add("Version", "2013-10-15");
            if (startInstancesRequest != null)
            {
                List<string> instanceIdsList = startInstancesRequest.InstanceIds;

                int instanceIdsListIndex = 1;
                foreach (string instanceIdsListValue in instanceIdsList)
                { 
                    request.Parameters.Add("InstanceId." + instanceIdsListIndex, StringUtils.FromString(instanceIdsListValue));
                    instanceIdsListIndex++;
                }
            }
            if (startInstancesRequest != null && startInstancesRequest.IsSetAdditionalInfo())
            {
                request.Parameters.Add("AdditionalInfo", StringUtils.FromString(startInstancesRequest.AdditionalInfo));
            }

            return request;
        }
    }
}
