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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

using Amazon.AutoScaling.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.AutoScaling.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateLaunchConfiguration Request Marshaller
    /// </summary>
    public partial class CreateLaunchConfigurationRequestMarshaller : IMarshaller<IRequest, CreateLaunchConfigurationRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateLaunchConfigurationRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateLaunchConfigurationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AutoScaling");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "CreateLaunchConfiguration");
            request.Parameters.Add("Version", "2011-01-01");

            if (publicRequest.IsSetAssociatePublicIpAddress())
            {
                request.Parameters.Add("AssociatePublicIpAddress", StringUtils.FromBool(publicRequest.AssociatePublicIpAddress.Value));
            }
            if (publicRequest.IsSetBlockDeviceMappings())
            {
                if (publicRequest.BlockDeviceMappings.Count == 0)
                {
                    request.Parameters.Add("BlockDeviceMappings", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.BlockDeviceMappings)
                    {
                        if (item0.IsSetDeviceName())
                        {
                            request.Parameters.Add("BlockDeviceMappings" + ".member" + "." + index0 + ".DeviceName", StringUtils.FromString(item0.DeviceName));
                        }
                        if (item0.IsSetEbs())
                        {
                            if (item0.Ebs.IsSetDeleteOnTermination())
                            {
                                request.Parameters.Add("BlockDeviceMappings" + ".member" + "." + index0 + ".Ebs" + ".DeleteOnTermination", StringUtils.FromBool(item0.Ebs.DeleteOnTermination.Value));
                            }
                            if (item0.Ebs.IsSetEncrypted())
                            {
                                request.Parameters.Add("BlockDeviceMappings" + ".member" + "." + index0 + ".Ebs" + ".Encrypted", StringUtils.FromBool(item0.Ebs.Encrypted.Value));
                            }
                            if (item0.Ebs.IsSetIops())
                            {
                                request.Parameters.Add("BlockDeviceMappings" + ".member" + "." + index0 + ".Ebs" + ".Iops", StringUtils.FromInt(item0.Ebs.Iops.Value));
                            }
                            if (item0.Ebs.IsSetSnapshotId())
                            {
                                request.Parameters.Add("BlockDeviceMappings" + ".member" + "." + index0 + ".Ebs" + ".SnapshotId", StringUtils.FromString(item0.Ebs.SnapshotId));
                            }
                            if (item0.Ebs.IsSetThroughput())
                            {
                                request.Parameters.Add("BlockDeviceMappings" + ".member" + "." + index0 + ".Ebs" + ".Throughput", StringUtils.FromInt(item0.Ebs.Throughput.Value));
                            }
                            if (item0.Ebs.IsSetVolumeSize())
                            {
                                request.Parameters.Add("BlockDeviceMappings" + ".member" + "." + index0 + ".Ebs" + ".VolumeSize", StringUtils.FromInt(item0.Ebs.VolumeSize.Value));
                            }
                            if (item0.Ebs.IsSetVolumeType())
                            {
                                request.Parameters.Add("BlockDeviceMappings" + ".member" + "." + index0 + ".Ebs" + ".VolumeType", StringUtils.FromString(item0.Ebs.VolumeType));
                            }
                        }
                        if (item0.IsSetNoDevice())
                        {
                            request.Parameters.Add("BlockDeviceMappings" + ".member" + "." + index0 + ".NoDevice", StringUtils.FromBool(item0.NoDevice.Value));
                        }
                        if (item0.IsSetVirtualName())
                        {
                            request.Parameters.Add("BlockDeviceMappings" + ".member" + "." + index0 + ".VirtualName", StringUtils.FromString(item0.VirtualName));
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetClassicLinkVPCId())
            {
                request.Parameters.Add("ClassicLinkVPCId", StringUtils.FromString(publicRequest.ClassicLinkVPCId));
            }
            if (publicRequest.IsSetClassicLinkVPCSecurityGroups())
            {
                if (publicRequest.ClassicLinkVPCSecurityGroups.Count == 0)
                {
                    request.Parameters.Add("ClassicLinkVPCSecurityGroups", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.ClassicLinkVPCSecurityGroups)
                    {
                        request.Parameters.Add("ClassicLinkVPCSecurityGroups" + ".member" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetEbsOptimized())
            {
                request.Parameters.Add("EbsOptimized", StringUtils.FromBool(publicRequest.EbsOptimized.Value));
            }
            if (publicRequest.IsSetIamInstanceProfile())
            {
                request.Parameters.Add("IamInstanceProfile", StringUtils.FromString(publicRequest.IamInstanceProfile));
            }
            if (publicRequest.IsSetImageId())
            {
                request.Parameters.Add("ImageId", StringUtils.FromString(publicRequest.ImageId));
            }
            if (publicRequest.IsSetInstanceId())
            {
                request.Parameters.Add("InstanceId", StringUtils.FromString(publicRequest.InstanceId));
            }
            if (publicRequest.IsSetInstanceMonitoring())
            {
                if (publicRequest.InstanceMonitoring.IsSetEnabled())
                {
                    request.Parameters.Add("InstanceMonitoring" + ".Enabled", StringUtils.FromBool(publicRequest.InstanceMonitoring.Enabled.Value));
                }
            }
            if (publicRequest.IsSetInstanceType())
            {
                request.Parameters.Add("InstanceType", StringUtils.FromString(publicRequest.InstanceType));
            }
            if (publicRequest.IsSetKernelId())
            {
                request.Parameters.Add("KernelId", StringUtils.FromString(publicRequest.KernelId));
            }
            if (publicRequest.IsSetKeyName())
            {
                request.Parameters.Add("KeyName", StringUtils.FromString(publicRequest.KeyName));
            }
            if (publicRequest.IsSetLaunchConfigurationName())
            {
                request.Parameters.Add("LaunchConfigurationName", StringUtils.FromString(publicRequest.LaunchConfigurationName));
            }
            if (publicRequest.IsSetMetadataOptions())
            {
                if (publicRequest.MetadataOptions.IsSetHttpEndpoint())
                {
                    request.Parameters.Add("MetadataOptions" + ".HttpEndpoint", StringUtils.FromString(publicRequest.MetadataOptions.HttpEndpoint));
                }
                if (publicRequest.MetadataOptions.IsSetHttpPutResponseHopLimit())
                {
                    request.Parameters.Add("MetadataOptions" + ".HttpPutResponseHopLimit", StringUtils.FromInt(publicRequest.MetadataOptions.HttpPutResponseHopLimit.Value));
                }
                if (publicRequest.MetadataOptions.IsSetHttpTokens())
                {
                    request.Parameters.Add("MetadataOptions" + ".HttpTokens", StringUtils.FromString(publicRequest.MetadataOptions.HttpTokens));
                }
            }
            if (publicRequest.IsSetPlacementTenancy())
            {
                request.Parameters.Add("PlacementTenancy", StringUtils.FromString(publicRequest.PlacementTenancy));
            }
            if (publicRequest.IsSetRamdiskId())
            {
                request.Parameters.Add("RamdiskId", StringUtils.FromString(publicRequest.RamdiskId));
            }
            if (publicRequest.IsSetSecurityGroups())
            {
                if (publicRequest.SecurityGroups.Count == 0)
                {
                    request.Parameters.Add("SecurityGroups", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.SecurityGroups)
                    {
                        request.Parameters.Add("SecurityGroups" + ".member" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetSpotPrice())
            {
                request.Parameters.Add("SpotPrice", StringUtils.FromString(publicRequest.SpotPrice));
            }
            if (publicRequest.IsSetUserData())
            {
                request.Parameters.Add("UserData", StringUtils.FromString(publicRequest.UserData));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly CreateLaunchConfigurationRequestMarshaller _instance = new();

        internal static CreateLaunchConfigurationRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateLaunchConfigurationRequestMarshaller Instance => _instance;
    }
}
