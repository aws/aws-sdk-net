/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

using Amazon.EC2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Modify Snapshot Attribute Request Marshaller
    /// </summary>       
    public class ModifySnapshotAttributeRequestMarshaller : IMarshaller<IRequest, ModifySnapshotAttributeRequest>
    {
        public IRequest Marshall(ModifySnapshotAttributeRequest modifySnapshotAttributeRequest)
        {
            IRequest request = new DefaultRequest(modifySnapshotAttributeRequest, "AmazonEC2");
            request.Parameters.Add("Action", "ModifySnapshotAttribute");
            request.Parameters.Add("Version", "2013-10-15");
            if (modifySnapshotAttributeRequest != null && modifySnapshotAttributeRequest.IsSetSnapshotId())
            {
                request.Parameters.Add("SnapshotId", StringUtils.FromString(modifySnapshotAttributeRequest.SnapshotId));
            }
            if (modifySnapshotAttributeRequest != null && modifySnapshotAttributeRequest.IsSetAttribute())
            {
                request.Parameters.Add("Attribute", StringUtils.FromString(modifySnapshotAttributeRequest.Attribute));
            }
            if (modifySnapshotAttributeRequest != null && modifySnapshotAttributeRequest.IsSetOperationType())
            {
                request.Parameters.Add("OperationType", StringUtils.FromString(modifySnapshotAttributeRequest.OperationType));
            }
            if (modifySnapshotAttributeRequest != null)
            {
                List<string> userIdsList = modifySnapshotAttributeRequest.UserIds;

                int userIdsListIndex = 1;
                foreach (string userIdsListValue in userIdsList)
                { 
                    request.Parameters.Add("UserId." + userIdsListIndex, StringUtils.FromString(userIdsListValue));
                    userIdsListIndex++;
                }
            }
            if (modifySnapshotAttributeRequest != null)
            {
                List<string> groupNamesList = modifySnapshotAttributeRequest.GroupNames;

                int groupNamesListIndex = 1;
                foreach (string groupNamesListValue in groupNamesList)
                { 
                    request.Parameters.Add("UserGroup." + groupNamesListIndex, StringUtils.FromString(groupNamesListValue));
                    groupNamesListIndex++;
                }
            }
            if (modifySnapshotAttributeRequest != null)
            {
                CreateVolumePermissionModifications createVolumePermission = modifySnapshotAttributeRequest.CreateVolumePermission;

                if (createVolumePermission != null)
                {
                    List<CreateVolumePermission> addList = createVolumePermission.Add;
                    int addListIndex = 1;
                    foreach (CreateVolumePermission addListValue in addList)
                    {
                        if (addListValue != null && addListValue.IsSetUserId())
                        {
                            request.Parameters.Add("CreateVolumePermission.Add." + addListIndex + ".UserId", StringUtils.FromString(addListValue.UserId));
                        }
                        if (addListValue != null && addListValue.IsSetGroup())
                        {
                            request.Parameters.Add("CreateVolumePermission.Add." + addListIndex + ".Group", StringUtils.FromString(addListValue.Group));
                        }

                        addListIndex++;
                    }
                }

                if (createVolumePermission != null)
                {
                    List<CreateVolumePermission> removeList = createVolumePermission.Remove;
                    int removeListIndex = 1;
                    foreach (CreateVolumePermission removeListValue in removeList)
                    {
                        if (removeListValue != null && removeListValue.IsSetUserId())
                        {
                            request.Parameters.Add("CreateVolumePermission.Remove." + removeListIndex + ".UserId", StringUtils.FromString(removeListValue.UserId));
                        }
                        if (removeListValue != null && removeListValue.IsSetGroup())
                        {
                            request.Parameters.Add("CreateVolumePermission.Remove." + removeListIndex + ".Group", StringUtils.FromString(removeListValue.Group));
                        }

                        removeListIndex++;
                    }
                }
            }

            return request;
        }
    }
}
