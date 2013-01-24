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

using Amazon.ElasticMapReduce.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.ElasticMapReduce.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Add Instance Groups Request Marshaller
    /// </summary>       
    public class AddInstanceGroupsRequestMarshaller : IMarshaller<IRequest, AddInstanceGroupsRequest>
    {
        public IRequest Marshall(AddInstanceGroupsRequest addInstanceGroupsRequest)
        {
            IRequest request = new DefaultRequest(addInstanceGroupsRequest, "AmazonElasticMapReduce");
            request.Parameters.Add("Action", "AddInstanceGroups");
            request.Parameters.Add("Version", "2009-03-31");

            if (addInstanceGroupsRequest != null)
            {
                List<InstanceGroupConfig> instanceGroupsList = addInstanceGroupsRequest.InstanceGroups;
                int instanceGroupsListIndex = 1;
                foreach (InstanceGroupConfig instanceGroupsListValue in instanceGroupsList)
                {
                    if (instanceGroupsListValue != null && instanceGroupsListValue.IsSetName())
                    {
                        request.Parameters.Add("InstanceGroups.member." + instanceGroupsListIndex + ".Name", StringUtils.FromString(instanceGroupsListValue.Name));
                    }
                    if (instanceGroupsListValue != null && instanceGroupsListValue.IsSetMarket())
                    {
                        request.Parameters.Add("InstanceGroups.member." + instanceGroupsListIndex + ".Market", StringUtils.FromString(instanceGroupsListValue.Market));
                    }
                    if (instanceGroupsListValue != null && instanceGroupsListValue.IsSetInstanceRole())
                    {
                        request.Parameters.Add("InstanceGroups.member." + instanceGroupsListIndex + ".InstanceRole", StringUtils.FromString(instanceGroupsListValue.InstanceRole));
                    }
                    if (instanceGroupsListValue != null && instanceGroupsListValue.IsSetBidPrice())
                    {
                        request.Parameters.Add("InstanceGroups.member." + instanceGroupsListIndex + ".BidPrice", StringUtils.FromString(instanceGroupsListValue.BidPrice));
                    }
                    if (instanceGroupsListValue != null && instanceGroupsListValue.IsSetInstanceType())
                    {
                        request.Parameters.Add("InstanceGroups.member." + instanceGroupsListIndex + ".InstanceType", StringUtils.FromString(instanceGroupsListValue.InstanceType));
                    }
                    if (instanceGroupsListValue != null && instanceGroupsListValue.IsSetInstanceCount())
                    {
                        request.Parameters.Add("InstanceGroups.member." + instanceGroupsListIndex + ".InstanceCount", StringUtils.FromInt(instanceGroupsListValue.InstanceCount));
                    }

                    instanceGroupsListIndex++;
                }
            }
            if (addInstanceGroupsRequest != null && addInstanceGroupsRequest.IsSetJobFlowId())
            {
                request.Parameters.Add("JobFlowId", StringUtils.FromString(addInstanceGroupsRequest.JobFlowId));
            }

            return request;
        }
    }
}
