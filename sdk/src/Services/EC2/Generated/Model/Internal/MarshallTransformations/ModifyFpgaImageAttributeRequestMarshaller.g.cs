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
    /// ModifyFpgaImageAttribute Request Marshaller
    /// </summary>
    public partial class ModifyFpgaImageAttributeRequestMarshaller : IMarshaller<IRequest, ModifyFpgaImageAttributeRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyFpgaImageAttributeRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ModifyFpgaImageAttributeRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "ModifyFpgaImageAttribute");
            request.Parameters.Add("Version", "2016-11-15");

            if (publicRequest.IsSetAttribute())
            {
                request.Parameters.Add("Attribute", StringUtils.FromString(publicRequest.Attribute));
            }
            if (publicRequest.IsSetDescription())
            {
                request.Parameters.Add("Description", StringUtils.FromString(publicRequest.Description));
            }
            if (publicRequest.IsSetDryRun())
            {
                request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun.Value));
            }
            if (publicRequest.IsSetFpgaImageId())
            {
                request.Parameters.Add("FpgaImageId", StringUtils.FromString(publicRequest.FpgaImageId));
            }
            if (publicRequest.IsSetLoadPermission())
            {
                if (publicRequest.LoadPermission.IsSetAdd())
                {
                    if (publicRequest.LoadPermission.Add.Count == 0)
                    {
                        request.Parameters.Add("LoadPermission" + ".Add", "");
                    }
                    else
                    {
                        int index1 = 1;
                        foreach (var item1 in publicRequest.LoadPermission.Add)
                        {
                            if (item1.IsSetGroup())
                            {
                                request.Parameters.Add("LoadPermission" + ".Add" + "." + index1 + ".Group", StringUtils.FromString(item1.Group));
                            }
                            if (item1.IsSetUserId())
                            {
                                request.Parameters.Add("LoadPermission" + ".Add" + "." + index1 + ".UserId", StringUtils.FromString(item1.UserId));
                            }
                            index1++;
                        }
                    }
                }
                if (publicRequest.LoadPermission.IsSetRemove())
                {
                    if (publicRequest.LoadPermission.Remove.Count == 0)
                    {
                        request.Parameters.Add("LoadPermission" + ".Remove", "");
                    }
                    else
                    {
                        int index1 = 1;
                        foreach (var item1 in publicRequest.LoadPermission.Remove)
                        {
                            if (item1.IsSetGroup())
                            {
                                request.Parameters.Add("LoadPermission" + ".Remove" + "." + index1 + ".Group", StringUtils.FromString(item1.Group));
                            }
                            if (item1.IsSetUserId())
                            {
                                request.Parameters.Add("LoadPermission" + ".Remove" + "." + index1 + ".UserId", StringUtils.FromString(item1.UserId));
                            }
                            index1++;
                        }
                    }
                }
            }
            if (publicRequest.IsSetName())
            {
                request.Parameters.Add("Name", StringUtils.FromString(publicRequest.Name));
            }
            if (publicRequest.IsSetOperationType())
            {
                request.Parameters.Add("OperationType", StringUtils.FromString(publicRequest.OperationType));
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

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly ModifyFpgaImageAttributeRequestMarshaller _instance = new();

        internal static ModifyFpgaImageAttributeRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ModifyFpgaImageAttributeRequestMarshaller Instance => _instance;
    }
}
