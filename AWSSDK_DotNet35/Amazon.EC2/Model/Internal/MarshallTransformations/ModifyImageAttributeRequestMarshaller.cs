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
    /// Modify Image Attribute Request Marshaller
    /// </summary>       
    public class ModifyImageAttributeRequestMarshaller : IMarshaller<IRequest, ModifyImageAttributeRequest>
    {
        public IRequest Marshall(ModifyImageAttributeRequest modifyImageAttributeRequest)
        {
            IRequest request = new DefaultRequest(modifyImageAttributeRequest, "AmazonEC2");
            request.Parameters.Add("Action", "ModifyImageAttribute");
            request.Parameters.Add("Version", "2013-10-15");
            if (modifyImageAttributeRequest != null && modifyImageAttributeRequest.IsSetImageId())
            {
                request.Parameters.Add("ImageId", StringUtils.FromString(modifyImageAttributeRequest.ImageId));
            }
            if (modifyImageAttributeRequest != null && modifyImageAttributeRequest.IsSetAttribute())
            {
                request.Parameters.Add("Attribute", StringUtils.FromString(modifyImageAttributeRequest.Attribute));
            }
            if (modifyImageAttributeRequest != null && modifyImageAttributeRequest.IsSetOperationType())
            {
                request.Parameters.Add("OperationType", StringUtils.FromString(modifyImageAttributeRequest.OperationType));
            }
            if (modifyImageAttributeRequest != null)
            {
                List<string> userIdsList = modifyImageAttributeRequest.UserIds;

                int userIdsListIndex = 1;
                foreach (string userIdsListValue in userIdsList)
                { 
                    request.Parameters.Add("UserId." + userIdsListIndex, StringUtils.FromString(userIdsListValue));
                    userIdsListIndex++;
                }
            }
            if (modifyImageAttributeRequest != null)
            {
                List<string> userGroupsList = modifyImageAttributeRequest.UserGroups;

                int userGroupsListIndex = 1;
                foreach (string userGroupsListValue in userGroupsList)
                { 
                    request.Parameters.Add("UserGroup." + userGroupsListIndex, StringUtils.FromString(userGroupsListValue));
                    userGroupsListIndex++;
                }
            }
            if (modifyImageAttributeRequest != null)
            {
                List<string> productCodesList = modifyImageAttributeRequest.ProductCodes;

                int productCodesListIndex = 1;
                foreach (string productCodesListValue in productCodesList)
                { 
                    request.Parameters.Add("ProductCode." + productCodesListIndex, StringUtils.FromString(productCodesListValue));
                    productCodesListIndex++;
                }
            }
            if (modifyImageAttributeRequest != null && modifyImageAttributeRequest.IsSetValue())
            {
                request.Parameters.Add("Value", StringUtils.FromString(modifyImageAttributeRequest.Value));
            }
            if (modifyImageAttributeRequest != null)
            {
                LaunchPermissionModifications launchPermission = modifyImageAttributeRequest.LaunchPermission;

                if (launchPermission != null)
                {
                    List<LaunchPermission> addList = launchPermission.Add;
                    int addListIndex = 1;
                    foreach (LaunchPermission addListValue in addList)
                    {
                        if (addListValue != null && addListValue.IsSetUserId())
                        {
                            request.Parameters.Add("LaunchPermission.Add." + addListIndex + ".UserId", StringUtils.FromString(addListValue.UserId));
                        }
                        if (addListValue != null && addListValue.IsSetGroup())
                        {
                            request.Parameters.Add("LaunchPermission.Add." + addListIndex + ".Group", StringUtils.FromString(addListValue.Group));
                        }

                        addListIndex++;
                    }
                }

                if (launchPermission != null)
                {
                    List<LaunchPermission> removeList = launchPermission.Remove;
                    int removeListIndex = 1;
                    foreach (LaunchPermission removeListValue in removeList)
                    {
                        if (removeListValue != null && removeListValue.IsSetUserId())
                        {
                            request.Parameters.Add("LaunchPermission.Remove." + removeListIndex + ".UserId", StringUtils.FromString(removeListValue.UserId));
                        }
                        if (removeListValue != null && removeListValue.IsSetGroup())
                        {
                            request.Parameters.Add("LaunchPermission.Remove." + removeListIndex + ".Group", StringUtils.FromString(removeListValue.Group));
                        }

                        removeListIndex++;
                    }
                }
            }
            if (modifyImageAttributeRequest != null && modifyImageAttributeRequest.IsSetDescription())
            {
                request.Parameters.Add("Description.Value", StringUtils.FromString(modifyImageAttributeRequest.Description));
            }

            return request;
        }
    }
}
