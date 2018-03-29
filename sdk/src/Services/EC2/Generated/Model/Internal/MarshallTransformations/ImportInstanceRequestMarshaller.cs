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
    /// ImportInstance Request Marshaller
    /// </summary>       
    public class ImportInstanceRequestMarshaller : IMarshaller<IRequest, ImportInstanceRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ImportInstanceRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ImportInstanceRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "ImportInstance");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetDescription())
                {
                    request.Parameters.Add("Description", StringUtils.FromString(publicRequest.Description));
                }
                if(publicRequest.IsSetDiskImages())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.DiskImages)
                    {
                        if(publicRequestlistValue.IsSetDescription())
                        {
                            request.Parameters.Add("DiskImage" + "." + publicRequestlistValueIndex + "." + "Description", StringUtils.FromString(publicRequestlistValue.Description));
                        }
                        if(publicRequestlistValue.IsSetImage())
                        {
                            if(publicRequestlistValue.Image.IsSetBytes())
                            {
                                request.Parameters.Add("DiskImage" + "." + publicRequestlistValueIndex + "." + "Image" + "." + "Bytes", StringUtils.FromLong(publicRequestlistValue.Image.Bytes));
                            }
                            if(publicRequestlistValue.Image.IsSetFormat())
                            {
                                request.Parameters.Add("DiskImage" + "." + publicRequestlistValueIndex + "." + "Image" + "." + "Format", StringUtils.FromString(publicRequestlistValue.Image.Format));
                            }
                            if(publicRequestlistValue.Image.IsSetImportManifestUrl())
                            {
                                request.Parameters.Add("DiskImage" + "." + publicRequestlistValueIndex + "." + "Image" + "." + "ImportManifestUrl", StringUtils.FromString(publicRequestlistValue.Image.ImportManifestUrl));
                            }
                        }
                        if(publicRequestlistValue.IsSetVolume())
                        {
                            if(publicRequestlistValue.Volume.IsSetSize())
                            {
                                request.Parameters.Add("DiskImage" + "." + publicRequestlistValueIndex + "." + "Volume" + "." + "Size", StringUtils.FromLong(publicRequestlistValue.Volume.Size));
                            }
                        }
                        publicRequestlistValueIndex++;
                    }
                }
                if(publicRequest.IsSetLaunchSpecification())
                {
                    if(publicRequest.LaunchSpecification.IsSetAdditionalInfo())
                    {
                        request.Parameters.Add("LaunchSpecification" + "." + "AdditionalInfo", StringUtils.FromString(publicRequest.LaunchSpecification.AdditionalInfo));
                    }
                    if(publicRequest.LaunchSpecification.IsSetArchitecture())
                    {
                        request.Parameters.Add("LaunchSpecification" + "." + "Architecture", StringUtils.FromString(publicRequest.LaunchSpecification.Architecture));
                    }
                    if(publicRequest.LaunchSpecification.IsSetGroupIds())
                    {
                        int publicRequestLaunchSpecificationlistValueIndex = 1;
                        foreach(var publicRequestLaunchSpecificationlistValue in publicRequest.LaunchSpecification.GroupIds)
                        {
                            request.Parameters.Add("LaunchSpecification" + "." + "GroupId" + "." + publicRequestLaunchSpecificationlistValueIndex, StringUtils.FromString(publicRequestLaunchSpecificationlistValue));
                            publicRequestLaunchSpecificationlistValueIndex++;
                        }
                    }
                    if(publicRequest.LaunchSpecification.IsSetGroupNames())
                    {
                        int publicRequestLaunchSpecificationlistValueIndex = 1;
                        foreach(var publicRequestLaunchSpecificationlistValue in publicRequest.LaunchSpecification.GroupNames)
                        {
                            request.Parameters.Add("LaunchSpecification" + "." + "GroupName" + "." + publicRequestLaunchSpecificationlistValueIndex, StringUtils.FromString(publicRequestLaunchSpecificationlistValue));
                            publicRequestLaunchSpecificationlistValueIndex++;
                        }
                    }
                    if(publicRequest.LaunchSpecification.IsSetInstanceInitiatedShutdownBehavior())
                    {
                        request.Parameters.Add("LaunchSpecification" + "." + "InstanceInitiatedShutdownBehavior", StringUtils.FromString(publicRequest.LaunchSpecification.InstanceInitiatedShutdownBehavior));
                    }
                    if(publicRequest.LaunchSpecification.IsSetInstanceType())
                    {
                        request.Parameters.Add("LaunchSpecification" + "." + "InstanceType", StringUtils.FromString(publicRequest.LaunchSpecification.InstanceType));
                    }
                    if(publicRequest.LaunchSpecification.IsSetMonitoring())
                    {
                        request.Parameters.Add("LaunchSpecification" + "." + "Monitoring.Enabled", StringUtils.FromBool(publicRequest.LaunchSpecification.Monitoring));
                    }
                    if(publicRequest.LaunchSpecification.IsSetPlacement())
                    {
                        if(publicRequest.LaunchSpecification.Placement.IsSetAffinity())
                        {
                            request.Parameters.Add("LaunchSpecification" + "." + "Placement" + "." + "Affinity", StringUtils.FromString(publicRequest.LaunchSpecification.Placement.Affinity));
                        }
                        if(publicRequest.LaunchSpecification.Placement.IsSetAvailabilityZone())
                        {
                            request.Parameters.Add("LaunchSpecification" + "." + "Placement" + "." + "AvailabilityZone", StringUtils.FromString(publicRequest.LaunchSpecification.Placement.AvailabilityZone));
                        }
                        if(publicRequest.LaunchSpecification.Placement.IsSetGroupName())
                        {
                            request.Parameters.Add("LaunchSpecification" + "." + "Placement" + "." + "GroupName", StringUtils.FromString(publicRequest.LaunchSpecification.Placement.GroupName));
                        }
                        if(publicRequest.LaunchSpecification.Placement.IsSetHostId())
                        {
                            request.Parameters.Add("LaunchSpecification" + "." + "Placement" + "." + "HostId", StringUtils.FromString(publicRequest.LaunchSpecification.Placement.HostId));
                        }
                        if(publicRequest.LaunchSpecification.Placement.IsSetSpreadDomain())
                        {
                            request.Parameters.Add("LaunchSpecification" + "." + "Placement" + "." + "SpreadDomain", StringUtils.FromString(publicRequest.LaunchSpecification.Placement.SpreadDomain));
                        }
                        if(publicRequest.LaunchSpecification.Placement.IsSetTenancy())
                        {
                            request.Parameters.Add("LaunchSpecification" + "." + "Placement" + "." + "Tenancy", StringUtils.FromString(publicRequest.LaunchSpecification.Placement.Tenancy));
                        }
                    }
                    if(publicRequest.LaunchSpecification.IsSetPrivateIpAddress())
                    {
                        request.Parameters.Add("LaunchSpecification" + "." + "PrivateIpAddress", StringUtils.FromString(publicRequest.LaunchSpecification.PrivateIpAddress));
                    }
                    if(publicRequest.LaunchSpecification.IsSetSubnetId())
                    {
                        request.Parameters.Add("LaunchSpecification" + "." + "SubnetId", StringUtils.FromString(publicRequest.LaunchSpecification.SubnetId));
                    }
                    if(publicRequest.LaunchSpecification.IsSetUserData())
                    {
                        if(publicRequest.LaunchSpecification.UserData.IsSetData())
                        {
                            request.Parameters.Add("LaunchSpecification" + "." + "UserData" + "." + "Data", StringUtils.FromString(publicRequest.LaunchSpecification.UserData.Data));
                        }
                    }
                }
                if(publicRequest.IsSetPlatform())
                {
                    request.Parameters.Add("Platform", StringUtils.FromString(publicRequest.Platform));
                }
            }
            return request;
        }
                    private static ImportInstanceRequestMarshaller _instance = new ImportInstanceRequestMarshaller();        

        internal static ImportInstanceRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ImportInstanceRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}