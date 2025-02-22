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
    /// ModifyImageAttribute Request Marshaller
    /// </summary>       
    public class ModifyImageAttributeRequestMarshaller : IMarshaller<IRequest, ModifyImageAttributeRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyImageAttributeRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ModifyImageAttributeRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "ModifyImageAttribute");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetAttribute())
                {
                    request.Parameters.Add("Attribute", StringUtils.FromString(publicRequest.Attribute));
                }
                if(publicRequest.IsSetDescription())
                {
                    request.Parameters.Add("Description.Value", StringUtils.FromString(publicRequest.Description));
                }
                if(publicRequest.IsSetDryRun())
                {
                    request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun));
                }
                if(publicRequest.IsSetImageId())
                {
                    request.Parameters.Add("ImageId", StringUtils.FromString(publicRequest.ImageId));
                }
                if(publicRequest.IsSetImdsSupport())
                {
                    request.Parameters.Add("ImdsSupport.Value", StringUtils.FromString(publicRequest.ImdsSupport));
                }
                if(publicRequest.IsSetLaunchPermission())
                {
                    if(publicRequest.LaunchPermission.IsSetAdd())
                    {
                        if (publicRequest.LaunchPermission.Add.Count == 0)
                            request.Parameters.Add("LaunchPermission" + "." + "Add", "");
                        else
                        {
                             int publicRequestLaunchPermissionlistValueIndex = 1;
                             foreach(var publicRequestLaunchPermissionlistValue in publicRequest.LaunchPermission.Add)
                             {
                                if(publicRequestLaunchPermissionlistValue.IsSetGroup())
                                {
                                    request.Parameters.Add("LaunchPermission" + "." + "Add" + "." + publicRequestLaunchPermissionlistValueIndex + "." + "Group", StringUtils.FromString(publicRequestLaunchPermissionlistValue.Group));
                                }
                                if(publicRequestLaunchPermissionlistValue.IsSetOrganizationalUnitArn())
                                {
                                    request.Parameters.Add("LaunchPermission" + "." + "Add" + "." + publicRequestLaunchPermissionlistValueIndex + "." + "OrganizationalUnitArn", StringUtils.FromString(publicRequestLaunchPermissionlistValue.OrganizationalUnitArn));
                                }
                                if(publicRequestLaunchPermissionlistValue.IsSetOrganizationArn())
                                {
                                    request.Parameters.Add("LaunchPermission" + "." + "Add" + "." + publicRequestLaunchPermissionlistValueIndex + "." + "OrganizationArn", StringUtils.FromString(publicRequestLaunchPermissionlistValue.OrganizationArn));
                                }
                                if(publicRequestLaunchPermissionlistValue.IsSetUserId())
                                {
                                    request.Parameters.Add("LaunchPermission" + "." + "Add" + "." + publicRequestLaunchPermissionlistValueIndex + "." + "UserId", StringUtils.FromString(publicRequestLaunchPermissionlistValue.UserId));
                                }
                                 publicRequestLaunchPermissionlistValueIndex++;
                             }
                        }
                    }
                    if(publicRequest.LaunchPermission.IsSetRemove())
                    {
                        if (publicRequest.LaunchPermission.Remove.Count == 0)
                            request.Parameters.Add("LaunchPermission" + "." + "Remove", "");
                        else
                        {
                             int publicRequestLaunchPermissionlistValueIndex = 1;
                             foreach(var publicRequestLaunchPermissionlistValue in publicRequest.LaunchPermission.Remove)
                             {
                                if(publicRequestLaunchPermissionlistValue.IsSetGroup())
                                {
                                    request.Parameters.Add("LaunchPermission" + "." + "Remove" + "." + publicRequestLaunchPermissionlistValueIndex + "." + "Group", StringUtils.FromString(publicRequestLaunchPermissionlistValue.Group));
                                }
                                if(publicRequestLaunchPermissionlistValue.IsSetOrganizationalUnitArn())
                                {
                                    request.Parameters.Add("LaunchPermission" + "." + "Remove" + "." + publicRequestLaunchPermissionlistValueIndex + "." + "OrganizationalUnitArn", StringUtils.FromString(publicRequestLaunchPermissionlistValue.OrganizationalUnitArn));
                                }
                                if(publicRequestLaunchPermissionlistValue.IsSetOrganizationArn())
                                {
                                    request.Parameters.Add("LaunchPermission" + "." + "Remove" + "." + publicRequestLaunchPermissionlistValueIndex + "." + "OrganizationArn", StringUtils.FromString(publicRequestLaunchPermissionlistValue.OrganizationArn));
                                }
                                if(publicRequestLaunchPermissionlistValue.IsSetUserId())
                                {
                                    request.Parameters.Add("LaunchPermission" + "." + "Remove" + "." + publicRequestLaunchPermissionlistValueIndex + "." + "UserId", StringUtils.FromString(publicRequestLaunchPermissionlistValue.UserId));
                                }
                                 publicRequestLaunchPermissionlistValueIndex++;
                             }
                        }
                    }
                }
                if(publicRequest.IsSetOperationType())
                {
                    request.Parameters.Add("OperationType", StringUtils.FromString(publicRequest.OperationType));
                }
                if(publicRequest.IsSetOrganizationalUnitArns())
                {
                    if (publicRequest.OrganizationalUnitArns.Count == 0)
                        request.Parameters.Add("OrganizationalUnitArn", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.OrganizationalUnitArns)
                         {
                             request.Parameters.Add("OrganizationalUnitArn" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetOrganizationArns())
                {
                    if (publicRequest.OrganizationArns.Count == 0)
                        request.Parameters.Add("OrganizationArn", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.OrganizationArns)
                         {
                             request.Parameters.Add("OrganizationArn" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetProductCodes())
                {
                    if (publicRequest.ProductCodes.Count == 0)
                        request.Parameters.Add("ProductCode", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.ProductCodes)
                         {
                             request.Parameters.Add("ProductCode" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetUserGroups())
                {
                    if (publicRequest.UserGroups.Count == 0)
                        request.Parameters.Add("UserGroup", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.UserGroups)
                         {
                             request.Parameters.Add("UserGroup" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetUserIds())
                {
                    if (publicRequest.UserIds.Count == 0)
                        request.Parameters.Add("UserId", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.UserIds)
                         {
                             request.Parameters.Add("UserId" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetValue())
                {
                    request.Parameters.Add("Value", StringUtils.FromString(publicRequest.Value));
                }
            }
            return request;
        }
                    private static ModifyImageAttributeRequestMarshaller _instance = new ModifyImageAttributeRequestMarshaller();        

        internal static ModifyImageAttributeRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ModifyImageAttributeRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}