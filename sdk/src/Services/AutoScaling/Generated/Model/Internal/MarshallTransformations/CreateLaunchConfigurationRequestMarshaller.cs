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
#pragma warning disable CS0612,CS0618
namespace Amazon.AutoScaling.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateLaunchConfiguration Request Marshaller
    /// </summary>       
    public class CreateLaunchConfigurationRequestMarshaller : IMarshaller<IRequest, CreateLaunchConfigurationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateLaunchConfigurationRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateLaunchConfigurationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AutoScaling");
            request.Parameters.Add("Action", "CreateLaunchConfiguration");
            request.Parameters.Add("Version", "2011-01-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetAssociatePublicIpAddress())
                {
                    request.Parameters.Add("AssociatePublicIpAddress", StringUtils.FromBool(publicRequest.AssociatePublicIpAddress));
                }
                if(publicRequest.IsSetBlockDeviceMappings())
                {
                    if (publicRequest.BlockDeviceMappings.Count == 0)
                        request.Parameters.Add("BlockDeviceMappings", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.BlockDeviceMappings)
                         {
                            if(publicRequestlistValue.IsSetDeviceName())
                            {
                                request.Parameters.Add("BlockDeviceMappings" + "." + "member" + "." + publicRequestlistValueIndex + "." + "DeviceName", StringUtils.FromString(publicRequestlistValue.DeviceName));
                            }
                            if(publicRequestlistValue.IsSetEbs())
                            {
                                if(publicRequestlistValue.Ebs.IsSetDeleteOnTermination())
                                {
                                    request.Parameters.Add("BlockDeviceMappings" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Ebs" + "." + "DeleteOnTermination", StringUtils.FromBool(publicRequestlistValue.Ebs.DeleteOnTermination));
                                }
                                if(publicRequestlistValue.Ebs.IsSetEncrypted())
                                {
                                    request.Parameters.Add("BlockDeviceMappings" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Ebs" + "." + "Encrypted", StringUtils.FromBool(publicRequestlistValue.Ebs.Encrypted));
                                }
                                if(publicRequestlistValue.Ebs.IsSetIops())
                                {
                                    request.Parameters.Add("BlockDeviceMappings" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Ebs" + "." + "Iops", StringUtils.FromInt(publicRequestlistValue.Ebs.Iops));
                                }
                                if(publicRequestlistValue.Ebs.IsSetSnapshotId())
                                {
                                    request.Parameters.Add("BlockDeviceMappings" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Ebs" + "." + "SnapshotId", StringUtils.FromString(publicRequestlistValue.Ebs.SnapshotId));
                                }
                                if(publicRequestlistValue.Ebs.IsSetThroughput())
                                {
                                    request.Parameters.Add("BlockDeviceMappings" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Ebs" + "." + "Throughput", StringUtils.FromInt(publicRequestlistValue.Ebs.Throughput));
                                }
                                if(publicRequestlistValue.Ebs.IsSetVolumeSize())
                                {
                                    request.Parameters.Add("BlockDeviceMappings" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Ebs" + "." + "VolumeSize", StringUtils.FromInt(publicRequestlistValue.Ebs.VolumeSize));
                                }
                                if(publicRequestlistValue.Ebs.IsSetVolumeType())
                                {
                                    request.Parameters.Add("BlockDeviceMappings" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Ebs" + "." + "VolumeType", StringUtils.FromString(publicRequestlistValue.Ebs.VolumeType));
                                }
                            }
                            if(publicRequestlistValue.IsSetNoDevice())
                            {
                                request.Parameters.Add("BlockDeviceMappings" + "." + "member" + "." + publicRequestlistValueIndex + "." + "NoDevice", StringUtils.FromBool(publicRequestlistValue.NoDevice));
                            }
                            if(publicRequestlistValue.IsSetVirtualName())
                            {
                                request.Parameters.Add("BlockDeviceMappings" + "." + "member" + "." + publicRequestlistValueIndex + "." + "VirtualName", StringUtils.FromString(publicRequestlistValue.VirtualName));
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetClassicLinkVPCId())
                {
                    request.Parameters.Add("ClassicLinkVPCId", StringUtils.FromString(publicRequest.ClassicLinkVPCId));
                }
                if(publicRequest.IsSetClassicLinkVPCSecurityGroups())
                {
                    if (publicRequest.ClassicLinkVPCSecurityGroups.Count == 0)
                        request.Parameters.Add("ClassicLinkVPCSecurityGroups", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.ClassicLinkVPCSecurityGroups)
                         {
                             request.Parameters.Add("ClassicLinkVPCSecurityGroups" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetEbsOptimized())
                {
                    request.Parameters.Add("EbsOptimized", StringUtils.FromBool(publicRequest.EbsOptimized));
                }
                if(publicRequest.IsSetIamInstanceProfile())
                {
                    request.Parameters.Add("IamInstanceProfile", StringUtils.FromString(publicRequest.IamInstanceProfile));
                }
                if(publicRequest.IsSetImageId())
                {
                    request.Parameters.Add("ImageId", StringUtils.FromString(publicRequest.ImageId));
                }
                if(publicRequest.IsSetInstanceId())
                {
                    request.Parameters.Add("InstanceId", StringUtils.FromString(publicRequest.InstanceId));
                }
                if(publicRequest.IsSetInstanceMonitoring())
                {
                    if(publicRequest.InstanceMonitoring.IsSetEnabled())
                    {
                        request.Parameters.Add("InstanceMonitoring" + "." + "Enabled", StringUtils.FromBool(publicRequest.InstanceMonitoring.Enabled));
                    }
                }
                if(publicRequest.IsSetInstanceType())
                {
                    request.Parameters.Add("InstanceType", StringUtils.FromString(publicRequest.InstanceType));
                }
                if(publicRequest.IsSetKernelId())
                {
                    request.Parameters.Add("KernelId", StringUtils.FromString(publicRequest.KernelId));
                }
                if(publicRequest.IsSetKeyName())
                {
                    request.Parameters.Add("KeyName", StringUtils.FromString(publicRequest.KeyName));
                }
                if(publicRequest.IsSetLaunchConfigurationName())
                {
                    request.Parameters.Add("LaunchConfigurationName", StringUtils.FromString(publicRequest.LaunchConfigurationName));
                }
                if(publicRequest.IsSetMetadataOptions())
                {
                    if(publicRequest.MetadataOptions.IsSetHttpEndpoint())
                    {
                        request.Parameters.Add("MetadataOptions" + "." + "HttpEndpoint", StringUtils.FromString(publicRequest.MetadataOptions.HttpEndpoint));
                    }
                    if(publicRequest.MetadataOptions.IsSetHttpPutResponseHopLimit())
                    {
                        request.Parameters.Add("MetadataOptions" + "." + "HttpPutResponseHopLimit", StringUtils.FromInt(publicRequest.MetadataOptions.HttpPutResponseHopLimit));
                    }
                    if(publicRequest.MetadataOptions.IsSetHttpTokens())
                    {
                        request.Parameters.Add("MetadataOptions" + "." + "HttpTokens", StringUtils.FromString(publicRequest.MetadataOptions.HttpTokens));
                    }
                }
                if(publicRequest.IsSetPlacementTenancy())
                {
                    request.Parameters.Add("PlacementTenancy", StringUtils.FromString(publicRequest.PlacementTenancy));
                }
                if(publicRequest.IsSetRamdiskId())
                {
                    request.Parameters.Add("RamdiskId", StringUtils.FromString(publicRequest.RamdiskId));
                }
                if(publicRequest.IsSetSecurityGroups())
                {
                    if (publicRequest.SecurityGroups.Count == 0)
                        request.Parameters.Add("SecurityGroups", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.SecurityGroups)
                         {
                             request.Parameters.Add("SecurityGroups" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetSpotPrice())
                {
                    request.Parameters.Add("SpotPrice", StringUtils.FromString(publicRequest.SpotPrice));
                }
                if(publicRequest.IsSetUserData())
                {
                    request.Parameters.Add("UserData", StringUtils.FromString(publicRequest.UserData));
                }
            }
            return request;
        }
                    private static CreateLaunchConfigurationRequestMarshaller _instance = new CreateLaunchConfigurationRequestMarshaller();        

        internal static CreateLaunchConfigurationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateLaunchConfigurationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}