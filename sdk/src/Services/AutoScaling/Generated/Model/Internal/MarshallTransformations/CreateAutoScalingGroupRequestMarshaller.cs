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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AutoScaling.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.AutoScaling.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateAutoScalingGroup Request Marshaller
    /// </summary>       
    public class CreateAutoScalingGroupRequestMarshaller : IMarshaller<IRequest, CreateAutoScalingGroupRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateAutoScalingGroupRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateAutoScalingGroupRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AutoScaling");
            request.Parameters.Add("Action", "CreateAutoScalingGroup");
            request.Parameters.Add("Version", "2011-01-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetAutoScalingGroupName())
                {
                    request.Parameters.Add("AutoScalingGroupName", StringUtils.FromString(publicRequest.AutoScalingGroupName));
                }
                if(publicRequest.IsSetAvailabilityZones())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.AvailabilityZones)
                    {
                        request.Parameters.Add("AvailabilityZones" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                        publicRequestlistValueIndex++;
                    }
                }
                if(publicRequest.IsSetDefaultCooldown())
                {
                    request.Parameters.Add("DefaultCooldown", StringUtils.FromInt(publicRequest.DefaultCooldown));
                }
                if(publicRequest.IsSetDesiredCapacity())
                {
                    request.Parameters.Add("DesiredCapacity", StringUtils.FromInt(publicRequest.DesiredCapacity));
                }
                if(publicRequest.IsSetHealthCheckGracePeriod())
                {
                    request.Parameters.Add("HealthCheckGracePeriod", StringUtils.FromInt(publicRequest.HealthCheckGracePeriod));
                }
                if(publicRequest.IsSetHealthCheckType())
                {
                    request.Parameters.Add("HealthCheckType", StringUtils.FromString(publicRequest.HealthCheckType));
                }
                if(publicRequest.IsSetInstanceId())
                {
                    request.Parameters.Add("InstanceId", StringUtils.FromString(publicRequest.InstanceId));
                }
                if(publicRequest.IsSetLaunchConfigurationName())
                {
                    request.Parameters.Add("LaunchConfigurationName", StringUtils.FromString(publicRequest.LaunchConfigurationName));
                }
                if(publicRequest.IsSetLaunchTemplate())
                {
                    if(publicRequest.LaunchTemplate.IsSetLaunchTemplateId())
                    {
                        request.Parameters.Add("LaunchTemplate" + "." + "LaunchTemplateId", StringUtils.FromString(publicRequest.LaunchTemplate.LaunchTemplateId));
                    }
                    if(publicRequest.LaunchTemplate.IsSetLaunchTemplateName())
                    {
                        request.Parameters.Add("LaunchTemplate" + "." + "LaunchTemplateName", StringUtils.FromString(publicRequest.LaunchTemplate.LaunchTemplateName));
                    }
                    if(publicRequest.LaunchTemplate.IsSetVersion())
                    {
                        request.Parameters.Add("LaunchTemplate" + "." + "Version", StringUtils.FromString(publicRequest.LaunchTemplate.Version));
                    }
                }
                if(publicRequest.IsSetLifecycleHookSpecificationList())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.LifecycleHookSpecificationList)
                    {
                        if(publicRequestlistValue.IsSetDefaultResult())
                        {
                            request.Parameters.Add("LifecycleHookSpecificationList" + "." + "member" + "." + publicRequestlistValueIndex + "." + "DefaultResult", StringUtils.FromString(publicRequestlistValue.DefaultResult));
                        }
                        if(publicRequestlistValue.IsSetHeartbeatTimeout())
                        {
                            request.Parameters.Add("LifecycleHookSpecificationList" + "." + "member" + "." + publicRequestlistValueIndex + "." + "HeartbeatTimeout", StringUtils.FromInt(publicRequestlistValue.HeartbeatTimeout));
                        }
                        if(publicRequestlistValue.IsSetLifecycleHookName())
                        {
                            request.Parameters.Add("LifecycleHookSpecificationList" + "." + "member" + "." + publicRequestlistValueIndex + "." + "LifecycleHookName", StringUtils.FromString(publicRequestlistValue.LifecycleHookName));
                        }
                        if(publicRequestlistValue.IsSetLifecycleTransition())
                        {
                            request.Parameters.Add("LifecycleHookSpecificationList" + "." + "member" + "." + publicRequestlistValueIndex + "." + "LifecycleTransition", StringUtils.FromString(publicRequestlistValue.LifecycleTransition));
                        }
                        if(publicRequestlistValue.IsSetNotificationMetadata())
                        {
                            request.Parameters.Add("LifecycleHookSpecificationList" + "." + "member" + "." + publicRequestlistValueIndex + "." + "NotificationMetadata", StringUtils.FromString(publicRequestlistValue.NotificationMetadata));
                        }
                        if(publicRequestlistValue.IsSetNotificationTargetARN())
                        {
                            request.Parameters.Add("LifecycleHookSpecificationList" + "." + "member" + "." + publicRequestlistValueIndex + "." + "NotificationTargetARN", StringUtils.FromString(publicRequestlistValue.NotificationTargetARN));
                        }
                        if(publicRequestlistValue.IsSetRoleARN())
                        {
                            request.Parameters.Add("LifecycleHookSpecificationList" + "." + "member" + "." + publicRequestlistValueIndex + "." + "RoleARN", StringUtils.FromString(publicRequestlistValue.RoleARN));
                        }
                        publicRequestlistValueIndex++;
                    }
                }
                if(publicRequest.IsSetLoadBalancerNames())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.LoadBalancerNames)
                    {
                        request.Parameters.Add("LoadBalancerNames" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                        publicRequestlistValueIndex++;
                    }
                }
                if(publicRequest.IsSetMaxSize())
                {
                    request.Parameters.Add("MaxSize", StringUtils.FromInt(publicRequest.MaxSize));
                }
                if(publicRequest.IsSetMinSize())
                {
                    request.Parameters.Add("MinSize", StringUtils.FromInt(publicRequest.MinSize));
                }
                if(publicRequest.IsSetNewInstancesProtectedFromScaleIn())
                {
                    request.Parameters.Add("NewInstancesProtectedFromScaleIn", StringUtils.FromBool(publicRequest.NewInstancesProtectedFromScaleIn));
                }
                if(publicRequest.IsSetPlacementGroup())
                {
                    request.Parameters.Add("PlacementGroup", StringUtils.FromString(publicRequest.PlacementGroup));
                }
                if(publicRequest.IsSetServiceLinkedRoleARN())
                {
                    request.Parameters.Add("ServiceLinkedRoleARN", StringUtils.FromString(publicRequest.ServiceLinkedRoleARN));
                }
                if(publicRequest.IsSetTags())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.Tags)
                    {
                        if(publicRequestlistValue.IsSetKey())
                        {
                            request.Parameters.Add("Tags" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Key", StringUtils.FromString(publicRequestlistValue.Key));
                        }
                        if(publicRequestlistValue.IsSetPropagateAtLaunch())
                        {
                            request.Parameters.Add("Tags" + "." + "member" + "." + publicRequestlistValueIndex + "." + "PropagateAtLaunch", StringUtils.FromBool(publicRequestlistValue.PropagateAtLaunch));
                        }
                        if(publicRequestlistValue.IsSetResourceId())
                        {
                            request.Parameters.Add("Tags" + "." + "member" + "." + publicRequestlistValueIndex + "." + "ResourceId", StringUtils.FromString(publicRequestlistValue.ResourceId));
                        }
                        if(publicRequestlistValue.IsSetResourceType())
                        {
                            request.Parameters.Add("Tags" + "." + "member" + "." + publicRequestlistValueIndex + "." + "ResourceType", StringUtils.FromString(publicRequestlistValue.ResourceType));
                        }
                        if(publicRequestlistValue.IsSetValue())
                        {
                            request.Parameters.Add("Tags" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Value", StringUtils.FromString(publicRequestlistValue.Value));
                        }
                        publicRequestlistValueIndex++;
                    }
                }
                if(publicRequest.IsSetTargetGroupARNs())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.TargetGroupARNs)
                    {
                        request.Parameters.Add("TargetGroupARNs" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                        publicRequestlistValueIndex++;
                    }
                }
                if(publicRequest.IsSetTerminationPolicies())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.TerminationPolicies)
                    {
                        request.Parameters.Add("TerminationPolicies" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                        publicRequestlistValueIndex++;
                    }
                }
                if(publicRequest.IsSetVPCZoneIdentifier())
                {
                    request.Parameters.Add("VPCZoneIdentifier", StringUtils.FromString(publicRequest.VPCZoneIdentifier));
                }
            }
            return request;
        }
                    private static CreateAutoScalingGroupRequestMarshaller _instance = new CreateAutoScalingGroupRequestMarshaller();        

        internal static CreateAutoScalingGroupRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateAutoScalingGroupRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}