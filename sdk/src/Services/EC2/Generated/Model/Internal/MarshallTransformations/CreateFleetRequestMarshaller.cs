/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EC2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateFleet Request Marshaller
    /// </summary>       
    public class CreateFleetRequestMarshaller : IMarshaller<IRequest, CreateFleetRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateFleetRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateFleetRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "CreateFleet");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetClientToken())
                {
                    request.Parameters.Add("ClientToken", StringUtils.FromString(publicRequest.ClientToken));
                }
                if(publicRequest.IsSetExcessCapacityTerminationPolicy())
                {
                    request.Parameters.Add("ExcessCapacityTerminationPolicy", StringUtils.FromString(publicRequest.ExcessCapacityTerminationPolicy));
                }
                if(publicRequest.IsSetLaunchTemplateConfigs())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.LaunchTemplateConfigs)
                    {
                        if(publicRequestlistValue.IsSetLaunchTemplateSpecification())
                        {
                            if(publicRequestlistValue.LaunchTemplateSpecification.IsSetLaunchTemplateId())
                            {
                                request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "LaunchTemplateSpecification" + "." + "LaunchTemplateId", StringUtils.FromString(publicRequestlistValue.LaunchTemplateSpecification.LaunchTemplateId));
                            }
                            if(publicRequestlistValue.LaunchTemplateSpecification.IsSetLaunchTemplateName())
                            {
                                request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "LaunchTemplateSpecification" + "." + "LaunchTemplateName", StringUtils.FromString(publicRequestlistValue.LaunchTemplateSpecification.LaunchTemplateName));
                            }
                            if(publicRequestlistValue.LaunchTemplateSpecification.IsSetVersion())
                            {
                                request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "LaunchTemplateSpecification" + "." + "Version", StringUtils.FromString(publicRequestlistValue.LaunchTemplateSpecification.Version));
                            }
                        }
                        if(publicRequestlistValue.IsSetOverrides())
                        {
                            int publicRequestlistValuelistValueIndex = 1;
                            foreach(var publicRequestlistValuelistValue in publicRequestlistValue.Overrides)
                            {
                                if(publicRequestlistValuelistValue.IsSetAvailabilityZone())
                                {
                                    request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "AvailabilityZone", StringUtils.FromString(publicRequestlistValuelistValue.AvailabilityZone));
                                }
                                if(publicRequestlistValuelistValue.IsSetInstanceType())
                                {
                                    request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceType", StringUtils.FromString(publicRequestlistValuelistValue.InstanceType));
                                }
                                if(publicRequestlistValuelistValue.IsSetMaxPrice())
                                {
                                    request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "MaxPrice", StringUtils.FromString(publicRequestlistValuelistValue.MaxPrice));
                                }
                                if(publicRequestlistValuelistValue.IsSetPlacement())
                                {
                                    if(publicRequestlistValuelistValue.Placement.IsSetAffinity())
                                    {
                                        request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "Placement" + "." + "Affinity", StringUtils.FromString(publicRequestlistValuelistValue.Placement.Affinity));
                                    }
                                    if(publicRequestlistValuelistValue.Placement.IsSetAvailabilityZone())
                                    {
                                        request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "Placement" + "." + "AvailabilityZone", StringUtils.FromString(publicRequestlistValuelistValue.Placement.AvailabilityZone));
                                    }
                                    if(publicRequestlistValuelistValue.Placement.IsSetGroupName())
                                    {
                                        request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "Placement" + "." + "GroupName", StringUtils.FromString(publicRequestlistValuelistValue.Placement.GroupName));
                                    }
                                    if(publicRequestlistValuelistValue.Placement.IsSetHostId())
                                    {
                                        request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "Placement" + "." + "HostId", StringUtils.FromString(publicRequestlistValuelistValue.Placement.HostId));
                                    }
                                    if(publicRequestlistValuelistValue.Placement.IsSetSpreadDomain())
                                    {
                                        request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "Placement" + "." + "SpreadDomain", StringUtils.FromString(publicRequestlistValuelistValue.Placement.SpreadDomain));
                                    }
                                    if(publicRequestlistValuelistValue.Placement.IsSetTenancy())
                                    {
                                        request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "Placement" + "." + "Tenancy", StringUtils.FromString(publicRequestlistValuelistValue.Placement.Tenancy));
                                    }
                                }
                                if(publicRequestlistValuelistValue.IsSetPriority())
                                {
                                    request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "Priority", StringUtils.FromDouble(publicRequestlistValuelistValue.Priority));
                                }
                                if(publicRequestlistValuelistValue.IsSetSubnetId())
                                {
                                    request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "SubnetId", StringUtils.FromString(publicRequestlistValuelistValue.SubnetId));
                                }
                                if(publicRequestlistValuelistValue.IsSetWeightedCapacity())
                                {
                                    request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "WeightedCapacity", StringUtils.FromDouble(publicRequestlistValuelistValue.WeightedCapacity));
                                }
                                publicRequestlistValuelistValueIndex++;
                            }
                        }
                        publicRequestlistValueIndex++;
                    }
                }
                if(publicRequest.IsSetOnDemandOptions())
                {
                    if(publicRequest.OnDemandOptions.IsSetAllocationStrategy())
                    {
                        request.Parameters.Add("OnDemandOptions" + "." + "AllocationStrategy", StringUtils.FromString(publicRequest.OnDemandOptions.AllocationStrategy));
                    }
                    if(publicRequest.OnDemandOptions.IsSetMinTargetCapacity())
                    {
                        request.Parameters.Add("OnDemandOptions" + "." + "MinTargetCapacity", StringUtils.FromInt(publicRequest.OnDemandOptions.MinTargetCapacity));
                    }
                    if(publicRequest.OnDemandOptions.IsSetSingleInstanceType())
                    {
                        request.Parameters.Add("OnDemandOptions" + "." + "SingleInstanceType", StringUtils.FromBool(publicRequest.OnDemandOptions.SingleInstanceType));
                    }
                }
                if(publicRequest.IsSetReplaceUnhealthyInstances())
                {
                    request.Parameters.Add("ReplaceUnhealthyInstances", StringUtils.FromBool(publicRequest.ReplaceUnhealthyInstances));
                }
                if(publicRequest.IsSetSpotOptions())
                {
                    if(publicRequest.SpotOptions.IsSetAllocationStrategy())
                    {
                        request.Parameters.Add("SpotOptions" + "." + "AllocationStrategy", StringUtils.FromString(publicRequest.SpotOptions.AllocationStrategy));
                    }
                    if(publicRequest.SpotOptions.IsSetInstanceInterruptionBehavior())
                    {
                        request.Parameters.Add("SpotOptions" + "." + "InstanceInterruptionBehavior", StringUtils.FromString(publicRequest.SpotOptions.InstanceInterruptionBehavior));
                    }
                    if(publicRequest.SpotOptions.IsSetInstancePoolsToUseCount())
                    {
                        request.Parameters.Add("SpotOptions" + "." + "InstancePoolsToUseCount", StringUtils.FromInt(publicRequest.SpotOptions.InstancePoolsToUseCount));
                    }
                    if(publicRequest.SpotOptions.IsSetMinTargetCapacity())
                    {
                        request.Parameters.Add("SpotOptions" + "." + "MinTargetCapacity", StringUtils.FromInt(publicRequest.SpotOptions.MinTargetCapacity));
                    }
                    if(publicRequest.SpotOptions.IsSetSingleInstanceType())
                    {
                        request.Parameters.Add("SpotOptions" + "." + "SingleInstanceType", StringUtils.FromBool(publicRequest.SpotOptions.SingleInstanceType));
                    }
                }
                if(publicRequest.IsSetTagSpecifications())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.TagSpecifications)
                    {
                        if(publicRequestlistValue.IsSetResourceType())
                        {
                            request.Parameters.Add("TagSpecification" + "." + publicRequestlistValueIndex + "." + "ResourceType", StringUtils.FromString(publicRequestlistValue.ResourceType));
                        }
                        if(publicRequestlistValue.IsSetTags())
                        {
                            int publicRequestlistValuelistValueIndex = 1;
                            foreach(var publicRequestlistValuelistValue in publicRequestlistValue.Tags)
                            {
                                if(publicRequestlistValuelistValue.IsSetKey())
                                {
                                    request.Parameters.Add("TagSpecification" + "." + publicRequestlistValueIndex + "." + "Tag" + "." + publicRequestlistValuelistValueIndex + "." + "Key", StringUtils.FromString(publicRequestlistValuelistValue.Key));
                                }
                                if(publicRequestlistValuelistValue.IsSetValue())
                                {
                                    request.Parameters.Add("TagSpecification" + "." + publicRequestlistValueIndex + "." + "Tag" + "." + publicRequestlistValuelistValueIndex + "." + "Value", StringUtils.FromString(publicRequestlistValuelistValue.Value));
                                }
                                publicRequestlistValuelistValueIndex++;
                            }
                        }
                        publicRequestlistValueIndex++;
                    }
                }
                if(publicRequest.IsSetTargetCapacitySpecification())
                {
                    if(publicRequest.TargetCapacitySpecification.IsSetDefaultTargetCapacityType())
                    {
                        request.Parameters.Add("TargetCapacitySpecification" + "." + "DefaultTargetCapacityType", StringUtils.FromString(publicRequest.TargetCapacitySpecification.DefaultTargetCapacityType));
                    }
                    if(publicRequest.TargetCapacitySpecification.IsSetOnDemandTargetCapacity())
                    {
                        request.Parameters.Add("TargetCapacitySpecification" + "." + "OnDemandTargetCapacity", StringUtils.FromInt(publicRequest.TargetCapacitySpecification.OnDemandTargetCapacity));
                    }
                    if(publicRequest.TargetCapacitySpecification.IsSetSpotTargetCapacity())
                    {
                        request.Parameters.Add("TargetCapacitySpecification" + "." + "SpotTargetCapacity", StringUtils.FromInt(publicRequest.TargetCapacitySpecification.SpotTargetCapacity));
                    }
                    if(publicRequest.TargetCapacitySpecification.IsSetTotalTargetCapacity())
                    {
                        request.Parameters.Add("TargetCapacitySpecification" + "." + "TotalTargetCapacity", StringUtils.FromInt(publicRequest.TargetCapacitySpecification.TotalTargetCapacity));
                    }
                }
                if(publicRequest.IsSetTerminateInstancesWithExpiration())
                {
                    request.Parameters.Add("TerminateInstancesWithExpiration", StringUtils.FromBool(publicRequest.TerminateInstancesWithExpiration));
                }
                if(publicRequest.IsSetType())
                {
                    request.Parameters.Add("Type", StringUtils.FromString(publicRequest.Type));
                }
                if(publicRequest.IsSetValidFromUtc())
                {
                    request.Parameters.Add("ValidFrom", StringUtils.FromDateTimeToISO8601(publicRequest.ValidFromUtc));
                }
                if(publicRequest.IsSetValidUntilUtc())
                {
                    request.Parameters.Add("ValidUntil", StringUtils.FromDateTimeToISO8601(publicRequest.ValidUntilUtc));
                }
            }
            return request;
        }
                    private static CreateFleetRequestMarshaller _instance = new CreateFleetRequestMarshaller();        

        internal static CreateFleetRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateFleetRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}