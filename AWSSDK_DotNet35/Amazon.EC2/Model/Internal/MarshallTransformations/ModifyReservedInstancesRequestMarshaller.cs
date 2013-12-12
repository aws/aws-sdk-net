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
    /// Modify Reserved Instances Request Marshaller
    /// </summary>       
    public class ModifyReservedInstancesRequestMarshaller : IMarshaller<IRequest, ModifyReservedInstancesRequest>
    {
        public IRequest Marshall(ModifyReservedInstancesRequest modifyReservedInstancesRequest)
        {
            IRequest request = new DefaultRequest(modifyReservedInstancesRequest, "AmazonEC2");
            request.Parameters.Add("Action", "ModifyReservedInstances");
            request.Parameters.Add("Version", "2013-10-15");
            if (modifyReservedInstancesRequest != null && modifyReservedInstancesRequest.IsSetClientToken())
            {
                request.Parameters.Add("ClientToken", StringUtils.FromString(modifyReservedInstancesRequest.ClientToken));
            }
            if (modifyReservedInstancesRequest != null)
            {
                List<string> reservedInstancesIdsList = modifyReservedInstancesRequest.ReservedInstancesIds;

                int reservedInstancesIdsListIndex = 1;
                foreach (string reservedInstancesIdsListValue in reservedInstancesIdsList)
                { 
                    request.Parameters.Add("ReservedInstancesId." + reservedInstancesIdsListIndex, StringUtils.FromString(reservedInstancesIdsListValue));
                    reservedInstancesIdsListIndex++;
                }
            }

            if (modifyReservedInstancesRequest != null)
            {
                List<ReservedInstancesConfiguration> targetConfigurationsList = modifyReservedInstancesRequest.TargetConfigurations;
                int targetConfigurationsListIndex = 1;
                foreach (ReservedInstancesConfiguration targetConfigurationsListValue in targetConfigurationsList)
                {
                    if (targetConfigurationsListValue != null && targetConfigurationsListValue.IsSetAvailabilityZone())
                    {
                        request.Parameters.Add("ReservedInstancesConfigurationSetItemType." + targetConfigurationsListIndex + ".AvailabilityZone", StringUtils.FromString(targetConfigurationsListValue.AvailabilityZone));
                    }
                    if (targetConfigurationsListValue != null && targetConfigurationsListValue.IsSetPlatform())
                    {
                        request.Parameters.Add("ReservedInstancesConfigurationSetItemType." + targetConfigurationsListIndex + ".Platform", StringUtils.FromString(targetConfigurationsListValue.Platform));
                    }
                    if (targetConfigurationsListValue != null && targetConfigurationsListValue.IsSetInstanceCount())
                    {
                        request.Parameters.Add("ReservedInstancesConfigurationSetItemType." + targetConfigurationsListIndex + ".InstanceCount", StringUtils.FromInt(targetConfigurationsListValue.InstanceCount));
                    }
                    if (targetConfigurationsListValue != null && targetConfigurationsListValue.IsSetInstanceType())
                    {
                        request.Parameters.Add("ReservedInstancesConfigurationSetItemType." + targetConfigurationsListIndex + ".InstanceType", StringUtils.FromString(targetConfigurationsListValue.InstanceType));
                    }

                    targetConfigurationsListIndex++;
                }
            }

            return request;
        }
    }
}
