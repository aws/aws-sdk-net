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
    /// Modify Instance Groups Request Marshaller
    /// </summary>       
    public class ModifyInstanceGroupsRequestMarshaller : IMarshaller<IRequest, ModifyInstanceGroupsRequest>
    {
        public IRequest Marshall(ModifyInstanceGroupsRequest modifyInstanceGroupsRequest)
        {
            IRequest request = new DefaultRequest(modifyInstanceGroupsRequest, "AmazonElasticMapReduce");
            request.Parameters.Add("Action", "ModifyInstanceGroups");
            request.Parameters.Add("Version", "2009-03-31");

            if (modifyInstanceGroupsRequest != null)
            {
                List<InstanceGroupModifyConfig> instanceGroupsList = modifyInstanceGroupsRequest.InstanceGroups;
                int instanceGroupsListIndex = 1;
                foreach (InstanceGroupModifyConfig instanceGroupsListValue in instanceGroupsList)
                {
                    if (instanceGroupsListValue != null && instanceGroupsListValue.IsSetInstanceGroupId())
                    {
                        request.Parameters.Add("InstanceGroups.member." + instanceGroupsListIndex + ".InstanceGroupId", StringUtils.FromString(instanceGroupsListValue.InstanceGroupId));
                    }
                    if (instanceGroupsListValue != null && instanceGroupsListValue.IsSetInstanceCount())
                    {
                        request.Parameters.Add("InstanceGroups.member." + instanceGroupsListIndex + ".InstanceCount", StringUtils.FromInt(instanceGroupsListValue.InstanceCount));
                    }

                    instanceGroupsListIndex++;
                }
            }

            return request;
        }
    }
}
