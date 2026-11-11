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
    /// ModifyImageAttribute Request Marshaller
    /// </summary>
    public partial class ModifyImageAttributeRequestMarshaller : IMarshaller<IRequest, ModifyImageAttributeRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyImageAttributeRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ModifyImageAttributeRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "ModifyImageAttribute");
            request.Parameters.Add("Version", "2016-11-15");

            if (publicRequest.IsSetAttribute())
            {
                request.Parameters.Add("Attribute", StringUtils.FromString(publicRequest.Attribute));
            }
            if (publicRequest.IsSetDescription())
            {
                request.Parameters.Add("Description.Value", StringUtils.FromString(publicRequest.Description));
            }
            if (publicRequest.IsSetDryRun())
            {
                request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun.Value));
            }
            if (publicRequest.IsSetImageId())
            {
                request.Parameters.Add("ImageId", StringUtils.FromString(publicRequest.ImageId));
            }
            if (publicRequest.IsSetImdsSupport())
            {
                request.Parameters.Add("ImdsSupport.Value", StringUtils.FromString(publicRequest.ImdsSupport));
            }
            if (publicRequest.IsSetLaunchPermission())
            {
                if (publicRequest.LaunchPermission.IsSetAdd())
                {
                    if (publicRequest.LaunchPermission.Add.Count == 0)
                    {
                        request.Parameters.Add("LaunchPermission" + ".Add", "");
                    }
                    else
                    {
                        int index1 = 1;
                        foreach (var item1 in publicRequest.LaunchPermission.Add)
                        {
                            if (item1.IsSetGroup())
                            {
                                request.Parameters.Add("LaunchPermission" + ".Add" + "." + index1 + ".Group", StringUtils.FromString(item1.Group));
                            }
                            if (item1.IsSetOrganizationArn())
                            {
                                request.Parameters.Add("LaunchPermission" + ".Add" + "." + index1 + ".OrganizationArn", StringUtils.FromString(item1.OrganizationArn));
                            }
                            if (item1.IsSetOrganizationalUnitArn())
                            {
                                request.Parameters.Add("LaunchPermission" + ".Add" + "." + index1 + ".OrganizationalUnitArn", StringUtils.FromString(item1.OrganizationalUnitArn));
                            }
                            if (item1.IsSetUserId())
                            {
                                request.Parameters.Add("LaunchPermission" + ".Add" + "." + index1 + ".UserId", StringUtils.FromString(item1.UserId));
                            }
                            index1++;
                        }
                    }
                }
                if (publicRequest.LaunchPermission.IsSetRemove())
                {
                    if (publicRequest.LaunchPermission.Remove.Count == 0)
                    {
                        request.Parameters.Add("LaunchPermission" + ".Remove", "");
                    }
                    else
                    {
                        int index1 = 1;
                        foreach (var item1 in publicRequest.LaunchPermission.Remove)
                        {
                            if (item1.IsSetGroup())
                            {
                                request.Parameters.Add("LaunchPermission" + ".Remove" + "." + index1 + ".Group", StringUtils.FromString(item1.Group));
                            }
                            if (item1.IsSetOrganizationArn())
                            {
                                request.Parameters.Add("LaunchPermission" + ".Remove" + "." + index1 + ".OrganizationArn", StringUtils.FromString(item1.OrganizationArn));
                            }
                            if (item1.IsSetOrganizationalUnitArn())
                            {
                                request.Parameters.Add("LaunchPermission" + ".Remove" + "." + index1 + ".OrganizationalUnitArn", StringUtils.FromString(item1.OrganizationalUnitArn));
                            }
                            if (item1.IsSetUserId())
                            {
                                request.Parameters.Add("LaunchPermission" + ".Remove" + "." + index1 + ".UserId", StringUtils.FromString(item1.UserId));
                            }
                            index1++;
                        }
                    }
                }
            }
            if (publicRequest.IsSetOperationType())
            {
                request.Parameters.Add("OperationType", StringUtils.FromString(publicRequest.OperationType));
            }
            if (publicRequest.IsSetOrganizationArns())
            {
                if (publicRequest.OrganizationArns.Count == 0)
                {
                    request.Parameters.Add("OrganizationArn", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.OrganizationArns)
                    {
                        request.Parameters.Add("OrganizationArn" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetOrganizationalUnitArns())
            {
                if (publicRequest.OrganizationalUnitArns.Count == 0)
                {
                    request.Parameters.Add("OrganizationalUnitArn", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.OrganizationalUnitArns)
                    {
                        request.Parameters.Add("OrganizationalUnitArn" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetProductCodes())
            {
                if (publicRequest.ProductCodes.Count == 0)
                {
                    request.Parameters.Add("ProductCode", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.ProductCodes)
                    {
                        request.Parameters.Add("ProductCode" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetUserGroups())
            {
                if (publicRequest.UserGroups.Count == 0)
                {
                    request.Parameters.Add("UserGroup", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.UserGroups)
                    {
                        request.Parameters.Add("UserGroup" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetUserIds())
            {
                if (publicRequest.UserIds.Count == 0)
                {
                    request.Parameters.Add("UserId", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.UserIds)
                    {
                        request.Parameters.Add("UserId" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
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

        private static readonly ModifyImageAttributeRequestMarshaller _instance = new();

        internal static ModifyImageAttributeRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ModifyImageAttributeRequestMarshaller Instance => _instance;
    }
}
