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
    /// ModifySpotFleetRequest Request Marshaller
    /// </summary>       
    public class ModifySpotFleetRequestRequestMarshaller : IMarshaller<IRequest, ModifySpotFleetRequestRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifySpotFleetRequestRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ModifySpotFleetRequestRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "ModifySpotFleetRequest");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetContext())
                {
                    request.Parameters.Add("Context", StringUtils.FromString(publicRequest.Context));
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
                                if(publicRequestlistValuelistValue.IsSetPriority())
                                {
                                    request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "Priority", StringUtils.FromDouble(publicRequestlistValuelistValue.Priority));
                                }
                                if(publicRequestlistValuelistValue.IsSetSpotPrice())
                                {
                                    request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "SpotPrice", StringUtils.FromString(publicRequestlistValuelistValue.SpotPrice));
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
                if(publicRequest.IsSetOnDemandTargetCapacity())
                {
                    request.Parameters.Add("OnDemandTargetCapacity", StringUtils.FromInt(publicRequest.OnDemandTargetCapacity));
                }
                if(publicRequest.IsSetSpotFleetRequestId())
                {
                    request.Parameters.Add("SpotFleetRequestId", StringUtils.FromString(publicRequest.SpotFleetRequestId));
                }
                if(publicRequest.IsSetTargetCapacity())
                {
                    request.Parameters.Add("TargetCapacity", StringUtils.FromInt(publicRequest.TargetCapacity));
                }
            }
            return request;
        }
                    private static ModifySpotFleetRequestRequestMarshaller _instance = new ModifySpotFleetRequestRequestMarshaller();        

        internal static ModifySpotFleetRequestRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ModifySpotFleetRequestRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}