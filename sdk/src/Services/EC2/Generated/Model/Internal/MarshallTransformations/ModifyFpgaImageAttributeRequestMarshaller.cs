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
    /// ModifyFpgaImageAttribute Request Marshaller
    /// </summary>       
    public class ModifyFpgaImageAttributeRequestMarshaller : IMarshaller<IRequest, ModifyFpgaImageAttributeRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyFpgaImageAttributeRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ModifyFpgaImageAttributeRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "ModifyFpgaImageAttribute");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetAttribute())
                {
                    request.Parameters.Add("Attribute", StringUtils.FromString(publicRequest.Attribute));
                }
                if(publicRequest.IsSetDescription())
                {
                    request.Parameters.Add("Description", StringUtils.FromString(publicRequest.Description));
                }
                if(publicRequest.IsSetDryRun())
                {
                    request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun));
                }
                if(publicRequest.IsSetFpgaImageId())
                {
                    request.Parameters.Add("FpgaImageId", StringUtils.FromString(publicRequest.FpgaImageId));
                }
                if(publicRequest.IsSetLoadPermission())
                {
                    if(publicRequest.LoadPermission.IsSetAdd())
                    {
                        if (publicRequest.LoadPermission.Add.Count == 0)
                            request.Parameters.Add("LoadPermission" + "." + "Add", "");
                        else
                        {
                             int publicRequestLoadPermissionlistValueIndex = 1;
                             foreach(var publicRequestLoadPermissionlistValue in publicRequest.LoadPermission.Add)
                             {
                                if(publicRequestLoadPermissionlistValue.IsSetGroup())
                                {
                                    request.Parameters.Add("LoadPermission" + "." + "Add" + "." + publicRequestLoadPermissionlistValueIndex + "." + "Group", StringUtils.FromString(publicRequestLoadPermissionlistValue.Group));
                                }
                                if(publicRequestLoadPermissionlistValue.IsSetUserId())
                                {
                                    request.Parameters.Add("LoadPermission" + "." + "Add" + "." + publicRequestLoadPermissionlistValueIndex + "." + "UserId", StringUtils.FromString(publicRequestLoadPermissionlistValue.UserId));
                                }
                                 publicRequestLoadPermissionlistValueIndex++;
                             }
                        }
                    }
                    if(publicRequest.LoadPermission.IsSetRemove())
                    {
                        if (publicRequest.LoadPermission.Remove.Count == 0)
                            request.Parameters.Add("LoadPermission" + "." + "Remove", "");
                        else
                        {
                             int publicRequestLoadPermissionlistValueIndex = 1;
                             foreach(var publicRequestLoadPermissionlistValue in publicRequest.LoadPermission.Remove)
                             {
                                if(publicRequestLoadPermissionlistValue.IsSetGroup())
                                {
                                    request.Parameters.Add("LoadPermission" + "." + "Remove" + "." + publicRequestLoadPermissionlistValueIndex + "." + "Group", StringUtils.FromString(publicRequestLoadPermissionlistValue.Group));
                                }
                                if(publicRequestLoadPermissionlistValue.IsSetUserId())
                                {
                                    request.Parameters.Add("LoadPermission" + "." + "Remove" + "." + publicRequestLoadPermissionlistValueIndex + "." + "UserId", StringUtils.FromString(publicRequestLoadPermissionlistValue.UserId));
                                }
                                 publicRequestLoadPermissionlistValueIndex++;
                             }
                        }
                    }
                }
                if(publicRequest.IsSetName())
                {
                    request.Parameters.Add("Name", StringUtils.FromString(publicRequest.Name));
                }
                if(publicRequest.IsSetOperationType())
                {
                    request.Parameters.Add("OperationType", StringUtils.FromString(publicRequest.OperationType));
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
            }
            return request;
        }
                    private static ModifyFpgaImageAttributeRequestMarshaller _instance = new ModifyFpgaImageAttributeRequestMarshaller();        

        internal static ModifyFpgaImageAttributeRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ModifyFpgaImageAttributeRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}