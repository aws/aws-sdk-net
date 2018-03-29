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
    /// ModifySnapshotAttribute Request Marshaller
    /// </summary>       
    public class ModifySnapshotAttributeRequestMarshaller : IMarshaller<IRequest, ModifySnapshotAttributeRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifySnapshotAttributeRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ModifySnapshotAttributeRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "ModifySnapshotAttribute");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetAttribute())
                {
                    request.Parameters.Add("Attribute", StringUtils.FromString(publicRequest.Attribute));
                }
                if(publicRequest.IsSetCreateVolumePermission())
                {
                    if(publicRequest.CreateVolumePermission.IsSetAdd())
                    {
                        int publicRequestCreateVolumePermissionlistValueIndex = 1;
                        foreach(var publicRequestCreateVolumePermissionlistValue in publicRequest.CreateVolumePermission.Add)
                        {
                            if(publicRequestCreateVolumePermissionlistValue.IsSetGroup())
                            {
                                request.Parameters.Add("CreateVolumePermission" + "." + "Add" + "." + publicRequestCreateVolumePermissionlistValueIndex + "." + "Group", StringUtils.FromString(publicRequestCreateVolumePermissionlistValue.Group));
                            }
                            if(publicRequestCreateVolumePermissionlistValue.IsSetUserId())
                            {
                                request.Parameters.Add("CreateVolumePermission" + "." + "Add" + "." + publicRequestCreateVolumePermissionlistValueIndex + "." + "UserId", StringUtils.FromString(publicRequestCreateVolumePermissionlistValue.UserId));
                            }
                            publicRequestCreateVolumePermissionlistValueIndex++;
                        }
                    }
                    if(publicRequest.CreateVolumePermission.IsSetRemove())
                    {
                        int publicRequestCreateVolumePermissionlistValueIndex = 1;
                        foreach(var publicRequestCreateVolumePermissionlistValue in publicRequest.CreateVolumePermission.Remove)
                        {
                            if(publicRequestCreateVolumePermissionlistValue.IsSetGroup())
                            {
                                request.Parameters.Add("CreateVolumePermission" + "." + "Remove" + "." + publicRequestCreateVolumePermissionlistValueIndex + "." + "Group", StringUtils.FromString(publicRequestCreateVolumePermissionlistValue.Group));
                            }
                            if(publicRequestCreateVolumePermissionlistValue.IsSetUserId())
                            {
                                request.Parameters.Add("CreateVolumePermission" + "." + "Remove" + "." + publicRequestCreateVolumePermissionlistValueIndex + "." + "UserId", StringUtils.FromString(publicRequestCreateVolumePermissionlistValue.UserId));
                            }
                            publicRequestCreateVolumePermissionlistValueIndex++;
                        }
                    }
                }
                if(publicRequest.IsSetGroupNames())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.GroupNames)
                    {
                        request.Parameters.Add("UserGroup" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                        publicRequestlistValueIndex++;
                    }
                }
                if(publicRequest.IsSetOperationType())
                {
                    request.Parameters.Add("OperationType", StringUtils.FromString(publicRequest.OperationType));
                }
                if(publicRequest.IsSetSnapshotId())
                {
                    request.Parameters.Add("SnapshotId", StringUtils.FromString(publicRequest.SnapshotId));
                }
                if(publicRequest.IsSetUserIds())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.UserIds)
                    {
                        request.Parameters.Add("UserId" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                        publicRequestlistValueIndex++;
                    }
                }
            }
            return request;
        }
                    private static ModifySnapshotAttributeRequestMarshaller _instance = new ModifySnapshotAttributeRequestMarshaller();        

        internal static ModifySnapshotAttributeRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ModifySnapshotAttributeRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}