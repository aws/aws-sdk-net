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

using Amazon.EC2.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ModifyInstanceAttribute Request Marshaller
    /// </summary>
    public partial class ModifyInstanceAttributeRequestMarshaller : IMarshaller<IRequest, ModifyInstanceAttributeRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyInstanceAttributeRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ModifyInstanceAttributeRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "ModifyInstanceAttribute");
            request.Parameters.Add("Version", "2016-11-15");

            if (publicRequest.IsSetAttribute())
            {
                request.Parameters.Add("Attribute", StringUtils.FromString(publicRequest.Attribute));
            }
            if (publicRequest.IsSetBlockDeviceMappings())
            {
                if (publicRequest.BlockDeviceMappings.Count == 0)
                {
                    request.Parameters.Add("BlockDeviceMapping", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.BlockDeviceMappings)
                    {
                        if (item0.IsSetDeviceName())
                        {
                            request.Parameters.Add("BlockDeviceMapping" + "." + index0 + ".DeviceName", StringUtils.FromString(item0.DeviceName));
                        }
                        if (item0.IsSetEbs())
                        {
                            if (item0.Ebs.IsSetDeleteOnTermination())
                            {
                                request.Parameters.Add("BlockDeviceMapping" + "." + index0 + ".Ebs" + ".DeleteOnTermination", StringUtils.FromBool(item0.Ebs.DeleteOnTermination.Value));
                            }
                            if (item0.Ebs.IsSetVolumeId())
                            {
                                request.Parameters.Add("BlockDeviceMapping" + "." + index0 + ".Ebs" + ".VolumeId", StringUtils.FromString(item0.Ebs.VolumeId));
                            }
                        }
                        if (item0.IsSetNoDevice())
                        {
                            request.Parameters.Add("BlockDeviceMapping" + "." + index0 + ".NoDevice", StringUtils.FromString(item0.NoDevice));
                        }
                        if (item0.IsSetVirtualName())
                        {
                            request.Parameters.Add("BlockDeviceMapping" + "." + index0 + ".VirtualName", StringUtils.FromString(item0.VirtualName));
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetDisableApiStop())
            {
                request.Parameters.Add("DisableApiStop.Value", StringUtils.FromBool(publicRequest.DisableApiStop.Value));
            }
            if (publicRequest.IsSetDisableApiTermination())
            {
                request.Parameters.Add("DisableApiTermination.Value", StringUtils.FromBool(publicRequest.DisableApiTermination.Value));
            }
            if (publicRequest.IsSetDryRun())
            {
                request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun.Value));
            }
            if (publicRequest.IsSetEbsOptimized())
            {
                request.Parameters.Add("EbsOptimized.Value", StringUtils.FromBool(publicRequest.EbsOptimized.Value));
            }
            if (publicRequest.IsSetEnaSupport())
            {
                request.Parameters.Add("EnaSupport.Value", StringUtils.FromBool(publicRequest.EnaSupport.Value));
            }
            if (publicRequest.IsSetEnclaveOptions())
            {
                if (publicRequest.EnclaveOptions.IsSetEnabled())
                {
                    request.Parameters.Add("EnclaveOptions" + ".Enabled", StringUtils.FromBool(publicRequest.EnclaveOptions.Enabled.Value));
                }
            }
            if (publicRequest.IsSetGroups())
            {
                if (publicRequest.Groups.Count == 0)
                {
                    request.Parameters.Add("GroupId", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.Groups)
                    {
                        request.Parameters.Add("GroupId" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetInstanceId())
            {
                request.Parameters.Add("InstanceId", StringUtils.FromString(publicRequest.InstanceId));
            }
            if (publicRequest.IsSetInstanceInitiatedShutdownBehavior())
            {
                request.Parameters.Add("InstanceInitiatedShutdownBehavior.Value", StringUtils.FromString(publicRequest.InstanceInitiatedShutdownBehavior));
            }
            if (publicRequest.IsSetInstanceType())
            {
                request.Parameters.Add("InstanceType.Value", StringUtils.FromString(publicRequest.InstanceType));
            }
            if (publicRequest.IsSetKernel())
            {
                request.Parameters.Add("Kernel.Value", StringUtils.FromString(publicRequest.Kernel));
            }
            if (publicRequest.IsSetRamdisk())
            {
                request.Parameters.Add("Ramdisk.Value", StringUtils.FromString(publicRequest.Ramdisk));
            }
            if (publicRequest.IsSetSourceDestCheck())
            {
                request.Parameters.Add("SourceDestCheck.Value", StringUtils.FromBool(publicRequest.SourceDestCheck.Value));
            }
            if (publicRequest.IsSetSriovNetSupport())
            {
                request.Parameters.Add("SriovNetSupport.Value", StringUtils.FromString(publicRequest.SriovNetSupport));
            }
            if (publicRequest.IsSetUserData())
            {
                if (publicRequest.UserData.IsSetValue())
                {
                    request.Parameters.Add("UserData" + ".Value", StringUtils.FromMemoryStream(publicRequest.UserData.Value));
                }
            }
            if (publicRequest.IsSetValue())
            {
                request.Parameters.Add("Value", StringUtils.FromString(publicRequest.Value));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly ModifyInstanceAttributeRequestMarshaller _instance = new();

        internal static ModifyInstanceAttributeRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ModifyInstanceAttributeRequestMarshaller Instance => _instance;
    }
}
