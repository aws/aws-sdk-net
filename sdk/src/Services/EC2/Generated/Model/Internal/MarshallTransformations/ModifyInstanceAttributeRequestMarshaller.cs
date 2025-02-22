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
#pragma warning disable CS0612,CS0618
namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ModifyInstanceAttribute Request Marshaller
    /// </summary>       
    public class ModifyInstanceAttributeRequestMarshaller : IMarshaller<IRequest, ModifyInstanceAttributeRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyInstanceAttributeRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ModifyInstanceAttributeRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "ModifyInstanceAttribute");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetAttribute())
                {
                    request.Parameters.Add("Attribute", StringUtils.FromString(publicRequest.Attribute));
                }
                if(publicRequest.IsSetBlockDeviceMappings())
                {
                    if (publicRequest.BlockDeviceMappings.Count == 0)
                        request.Parameters.Add("BlockDeviceMapping", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.BlockDeviceMappings)
                         {
                            if(publicRequestlistValue.IsSetDeviceName())
                            {
                                request.Parameters.Add("BlockDeviceMapping" + "." + publicRequestlistValueIndex + "." + "DeviceName", StringUtils.FromString(publicRequestlistValue.DeviceName));
                            }
                            if(publicRequestlistValue.IsSetEbs())
                            {
                                if(publicRequestlistValue.Ebs.IsSetDeleteOnTermination())
                                {
                                    request.Parameters.Add("BlockDeviceMapping" + "." + publicRequestlistValueIndex + "." + "Ebs" + "." + "DeleteOnTermination", StringUtils.FromBool(publicRequestlistValue.Ebs.DeleteOnTermination));
                                }
                                if(publicRequestlistValue.Ebs.IsSetVolumeId())
                                {
                                    request.Parameters.Add("BlockDeviceMapping" + "." + publicRequestlistValueIndex + "." + "Ebs" + "." + "VolumeId", StringUtils.FromString(publicRequestlistValue.Ebs.VolumeId));
                                }
                            }
                            if(publicRequestlistValue.IsSetNoDevice())
                            {
                                request.Parameters.Add("BlockDeviceMapping" + "." + publicRequestlistValueIndex + "." + "NoDevice", StringUtils.FromString(publicRequestlistValue.NoDevice));
                            }
                            if(publicRequestlistValue.IsSetVirtualName())
                            {
                                request.Parameters.Add("BlockDeviceMapping" + "." + publicRequestlistValueIndex + "." + "VirtualName", StringUtils.FromString(publicRequestlistValue.VirtualName));
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetDisableApiStop())
                {
                    request.Parameters.Add("DisableApiStop.Value", StringUtils.FromBool(publicRequest.DisableApiStop));
                }
                if(publicRequest.IsSetDisableApiTermination())
                {
                    request.Parameters.Add("DisableApiTermination.Value", StringUtils.FromBool(publicRequest.DisableApiTermination));
                }
                if(publicRequest.IsSetDryRun())
                {
                    request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun));
                }
                if(publicRequest.IsSetEbsOptimized())
                {
                    request.Parameters.Add("EbsOptimized.Value", StringUtils.FromBool(publicRequest.EbsOptimized));
                }
                if(publicRequest.IsSetEnaSupport())
                {
                    request.Parameters.Add("EnaSupport.Value", StringUtils.FromBool(publicRequest.EnaSupport));
                }
                if(publicRequest.IsSetGroups())
                {
                    if (publicRequest.Groups.Count == 0)
                        request.Parameters.Add("GroupId", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.Groups)
                         {
                             request.Parameters.Add("GroupId" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetInstanceId())
                {
                    request.Parameters.Add("InstanceId", StringUtils.FromString(publicRequest.InstanceId));
                }
                if(publicRequest.IsSetInstanceInitiatedShutdownBehavior())
                {
                    request.Parameters.Add("InstanceInitiatedShutdownBehavior.Value", StringUtils.FromString(publicRequest.InstanceInitiatedShutdownBehavior));
                }
                if(publicRequest.IsSetInstanceType())
                {
                    request.Parameters.Add("InstanceType.Value", StringUtils.FromString(publicRequest.InstanceType));
                }
                if(publicRequest.IsSetKernel())
                {
                    request.Parameters.Add("Kernel.Value", StringUtils.FromString(publicRequest.Kernel));
                }
                if(publicRequest.IsSetRamdisk())
                {
                    request.Parameters.Add("Ramdisk.Value", StringUtils.FromString(publicRequest.Ramdisk));
                }
                if(publicRequest.IsSetSourceDestCheck())
                {
                    request.Parameters.Add("SourceDestCheck.Value", StringUtils.FromBool(publicRequest.SourceDestCheck));
                }
                if(publicRequest.IsSetSriovNetSupport())
                {
                    request.Parameters.Add("SriovNetSupport.Value", StringUtils.FromString(publicRequest.SriovNetSupport));
                }
                if(publicRequest.IsSetUserData())
                {
                    request.Parameters.Add("UserData.Value", StringUtils.FromString(publicRequest.UserData));
                }
                if(publicRequest.IsSetValue())
                {
                    request.Parameters.Add("Value", StringUtils.FromString(publicRequest.Value));
                }
            }
            return request;
        }
                    private static ModifyInstanceAttributeRequestMarshaller _instance = new ModifyInstanceAttributeRequestMarshaller();        

        internal static ModifyInstanceAttributeRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ModifyInstanceAttributeRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}