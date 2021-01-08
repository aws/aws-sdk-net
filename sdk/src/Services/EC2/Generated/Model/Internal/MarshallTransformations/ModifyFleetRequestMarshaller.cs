/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// ModifyFleet Request Marshaller
    /// </summary>       
    public class ModifyFleetRequestMarshaller : IMarshaller<IRequest, ModifyFleetRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyFleetRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ModifyFleetRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "ModifyFleet");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetExcessCapacityTerminationPolicy())
                {
                    request.Parameters.Add("ExcessCapacityTerminationPolicy", StringUtils.FromString(publicRequest.ExcessCapacityTerminationPolicy));
                }
                if(publicRequest.IsSetFleetId())
                {
                    request.Parameters.Add("FleetId", StringUtils.FromString(publicRequest.FleetId));
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
                                request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "LaunchTemplateSpecification" + "." + "LaunchTemplateId", StringUtils.FromString(publicRequestlistValue.LaunchTemplateSpecification.LaunchTemplateId));
                            }
                            if(publicRequestlistValue.LaunchTemplateSpecification.IsSetLaunchTemplateName())
                            {
                                request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "LaunchTemplateSpecification" + "." + "LaunchTemplateName", StringUtils.FromString(publicRequestlistValue.LaunchTemplateSpecification.LaunchTemplateName));
                            }
                            if(publicRequestlistValue.LaunchTemplateSpecification.IsSetVersion())
                            {
                                request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "LaunchTemplateSpecification" + "." + "Version", StringUtils.FromString(publicRequestlistValue.LaunchTemplateSpecification.Version));
                            }
                        }
                        if(publicRequestlistValue.IsSetOverrides())
                        {
                            int publicRequestlistValuelistValueIndex = 1;
                            foreach(var publicRequestlistValuelistValue in publicRequestlistValue.Overrides)
                            {
                                if(publicRequestlistValuelistValue.IsSetAvailabilityZone())
                                {
                                    request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "AvailabilityZone", StringUtils.FromString(publicRequestlistValuelistValue.AvailabilityZone));
                                }
                                if(publicRequestlistValuelistValue.IsSetInstanceType())
                                {
                                    request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceType", StringUtils.FromString(publicRequestlistValuelistValue.InstanceType));
                                }
                                if(publicRequestlistValuelistValue.IsSetMaxPrice())
                                {
                                    request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "MaxPrice", StringUtils.FromString(publicRequestlistValuelistValue.MaxPrice));
                                }
                                if(publicRequestlistValuelistValue.IsSetPlacement())
                                {
                                    if(publicRequestlistValuelistValue.Placement.IsSetAffinity())
                                    {
                                        request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "Placement" + "." + "Affinity", StringUtils.FromString(publicRequestlistValuelistValue.Placement.Affinity));
                                    }
                                    if(publicRequestlistValuelistValue.Placement.IsSetAvailabilityZone())
                                    {
                                        request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "Placement" + "." + "AvailabilityZone", StringUtils.FromString(publicRequestlistValuelistValue.Placement.AvailabilityZone));
                                    }
                                    if(publicRequestlistValuelistValue.Placement.IsSetGroupName())
                                    {
                                        request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "Placement" + "." + "GroupName", StringUtils.FromString(publicRequestlistValuelistValue.Placement.GroupName));
                                    }
                                    if(publicRequestlistValuelistValue.Placement.IsSetHostId())
                                    {
                                        request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "Placement" + "." + "HostId", StringUtils.FromString(publicRequestlistValuelistValue.Placement.HostId));
                                    }
                                    if(publicRequestlistValuelistValue.Placement.IsSetHostResourceGroupArn())
                                    {
                                        request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "Placement" + "." + "HostResourceGroupArn", StringUtils.FromString(publicRequestlistValuelistValue.Placement.HostResourceGroupArn));
                                    }
                                    if(publicRequestlistValuelistValue.Placement.IsSetPartitionNumber())
                                    {
                                        request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "Placement" + "." + "PartitionNumber", StringUtils.FromInt(publicRequestlistValuelistValue.Placement.PartitionNumber));
                                    }
                                    if(publicRequestlistValuelistValue.Placement.IsSetSpreadDomain())
                                    {
                                        request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "Placement" + "." + "SpreadDomain", StringUtils.FromString(publicRequestlistValuelistValue.Placement.SpreadDomain));
                                    }
                                    if(publicRequestlistValuelistValue.Placement.IsSetTenancy())
                                    {
                                        request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "Placement" + "." + "Tenancy", StringUtils.FromString(publicRequestlistValuelistValue.Placement.Tenancy));
                                    }
                                }
                                if(publicRequestlistValuelistValue.IsSetPriority())
                                {
                                    request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "Priority", StringUtils.FromDouble(publicRequestlistValuelistValue.Priority));
                                }
                                if(publicRequestlistValuelistValue.IsSetSubnetId())
                                {
                                    request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "SubnetId", StringUtils.FromString(publicRequestlistValuelistValue.SubnetId));
                                }
                                if(publicRequestlistValuelistValue.IsSetWeightedCapacity())
                                {
                                    request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "WeightedCapacity", StringUtils.FromDouble(publicRequestlistValuelistValue.WeightedCapacity));
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
            }
            return request;
        }
                    private static ModifyFleetRequestMarshaller _instance = new ModifyFleetRequestMarshaller();        

        internal static ModifyFleetRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ModifyFleetRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}