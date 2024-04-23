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
    /// RegisterImage Request Marshaller
    /// </summary>       
    public class RegisterImageRequestMarshaller : IMarshaller<IRequest, RegisterImageRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RegisterImageRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(RegisterImageRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "RegisterImage");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetArchitecture())
                {
                    request.Parameters.Add("Architecture", StringUtils.FromString(publicRequest.Architecture));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetBillingProducts())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.BillingProducts)
                    {
                        request.Parameters.Add("BillingProduct" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                        publicRequestlistValueIndex++;
                    }
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetBlockDeviceMappings())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.BlockDeviceMappings)
                    {
                        if(publicRequestlistValue.IsSetDeviceName())
                        {
                            request.Parameters.Add("BlockDeviceMapping" + "." + publicRequestlistValueIndex + "." + "DeviceName", StringUtils.FromString(publicRequestlistValue.DeviceName));
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetEbs())
                        {
                            if(publicRequestlistValue.Ebs.IsSetDeleteOnTermination())
                            {
                                request.Parameters.Add("BlockDeviceMapping" + "." + publicRequestlistValueIndex + "." + "Ebs" + "." + "DeleteOnTermination", StringUtils.FromBool(publicRequestlistValue.Ebs.DeleteOnTermination));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestlistValue.Ebs.IsSetEncrypted())
                            {
                                request.Parameters.Add("BlockDeviceMapping" + "." + publicRequestlistValueIndex + "." + "Ebs" + "." + "Encrypted", StringUtils.FromBool(publicRequestlistValue.Ebs.Encrypted));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestlistValue.Ebs.IsSetIops())
                            {
                                request.Parameters.Add("BlockDeviceMapping" + "." + publicRequestlistValueIndex + "." + "Ebs" + "." + "Iops", StringUtils.FromInt(publicRequestlistValue.Ebs.Iops));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestlistValue.Ebs.IsSetKmsKeyId())
                            {
                                request.Parameters.Add("BlockDeviceMapping" + "." + publicRequestlistValueIndex + "." + "Ebs" + "." + "KmsKeyId", StringUtils.FromString(publicRequestlistValue.Ebs.KmsKeyId));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestlistValue.Ebs.IsSetOutpostArn())
                            {
                                request.Parameters.Add("BlockDeviceMapping" + "." + publicRequestlistValueIndex + "." + "Ebs" + "." + "OutpostArn", StringUtils.FromString(publicRequestlistValue.Ebs.OutpostArn));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestlistValue.Ebs.IsSetSnapshotId())
                            {
                                request.Parameters.Add("BlockDeviceMapping" + "." + publicRequestlistValueIndex + "." + "Ebs" + "." + "SnapshotId", StringUtils.FromString(publicRequestlistValue.Ebs.SnapshotId));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestlistValue.Ebs.IsSetThroughput())
                            {
                                request.Parameters.Add("BlockDeviceMapping" + "." + publicRequestlistValueIndex + "." + "Ebs" + "." + "Throughput", StringUtils.FromInt(publicRequestlistValue.Ebs.Throughput));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestlistValue.Ebs.IsSetVolumeSize())
                            {
                                request.Parameters.Add("BlockDeviceMapping" + "." + publicRequestlistValueIndex + "." + "Ebs" + "." + "VolumeSize", StringUtils.FromInt(publicRequestlistValue.Ebs.VolumeSize));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestlistValue.Ebs.IsSetVolumeType())
                            {
                                request.Parameters.Add("BlockDeviceMapping" + "." + publicRequestlistValueIndex + "." + "Ebs" + "." + "VolumeType", StringUtils.FromString(publicRequestlistValue.Ebs.VolumeType));
                            }
#pragma warning restore CS0612,CS0618
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetNoDevice())
                        {
                            request.Parameters.Add("BlockDeviceMapping" + "." + publicRequestlistValueIndex + "." + "NoDevice", StringUtils.FromString(publicRequestlistValue.NoDevice));
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetVirtualName())
                        {
                            request.Parameters.Add("BlockDeviceMapping" + "." + publicRequestlistValueIndex + "." + "VirtualName", StringUtils.FromString(publicRequestlistValue.VirtualName));
                        }
#pragma warning restore CS0612,CS0618
                        publicRequestlistValueIndex++;
                    }
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetBootMode())
                {
                    request.Parameters.Add("BootMode", StringUtils.FromString(publicRequest.BootMode));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetDescription())
                {
                    request.Parameters.Add("Description", StringUtils.FromString(publicRequest.Description));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetEnaSupport())
                {
                    request.Parameters.Add("EnaSupport", StringUtils.FromBool(publicRequest.EnaSupport));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetImageLocation())
                {
                    request.Parameters.Add("ImageLocation", StringUtils.FromString(publicRequest.ImageLocation));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetImdsSupport())
                {
                    request.Parameters.Add("ImdsSupport", StringUtils.FromString(publicRequest.ImdsSupport));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetKernelId())
                {
                    request.Parameters.Add("KernelId", StringUtils.FromString(publicRequest.KernelId));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetName())
                {
                    request.Parameters.Add("Name", StringUtils.FromString(publicRequest.Name));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetRamdiskId())
                {
                    request.Parameters.Add("RamdiskId", StringUtils.FromString(publicRequest.RamdiskId));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetRootDeviceName())
                {
                    request.Parameters.Add("RootDeviceName", StringUtils.FromString(publicRequest.RootDeviceName));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetSriovNetSupport())
                {
                    request.Parameters.Add("SriovNetSupport", StringUtils.FromString(publicRequest.SriovNetSupport));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetTagSpecifications())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.TagSpecifications)
                    {
                        if(publicRequestlistValue.IsSetResourceType())
                        {
                            request.Parameters.Add("TagSpecification" + "." + publicRequestlistValueIndex + "." + "ResourceType", StringUtils.FromString(publicRequestlistValue.ResourceType));
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetTags())
                        {
                            int publicRequestlistValuelistValueIndex = 1;
                            foreach(var publicRequestlistValuelistValue in publicRequestlistValue.Tags)
                            {
                                if(publicRequestlistValuelistValue.IsSetKey())
                                {
                                    request.Parameters.Add("TagSpecification" + "." + publicRequestlistValueIndex + "." + "Tag" + "." + publicRequestlistValuelistValueIndex + "." + "Key", StringUtils.FromString(publicRequestlistValuelistValue.Key));
                                }
#pragma warning restore CS0612,CS0618
                                if(publicRequestlistValuelistValue.IsSetValue())
                                {
                                    request.Parameters.Add("TagSpecification" + "." + publicRequestlistValueIndex + "." + "Tag" + "." + publicRequestlistValuelistValueIndex + "." + "Value", StringUtils.FromString(publicRequestlistValuelistValue.Value));
                                }
#pragma warning restore CS0612,CS0618
                                publicRequestlistValuelistValueIndex++;
                            }
                        }
#pragma warning restore CS0612,CS0618
                        publicRequestlistValueIndex++;
                    }
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetTpmSupport())
                {
                    request.Parameters.Add("TpmSupport", StringUtils.FromString(publicRequest.TpmSupport));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetUefiData())
                {
                    request.Parameters.Add("UefiData", StringUtils.FromString(publicRequest.UefiData));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetVirtualizationType())
                {
                    request.Parameters.Add("VirtualizationType", StringUtils.FromString(publicRequest.VirtualizationType));
                }
#pragma warning restore CS0612,CS0618
            }
            return request;
        }
                    private static RegisterImageRequestMarshaller _instance = new RegisterImageRequestMarshaller();        

        internal static RegisterImageRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RegisterImageRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}