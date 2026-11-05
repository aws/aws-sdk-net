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

using Amazon.RDS.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.RDS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ModifyOptionGroup Request Marshaller
    /// </summary>
    public partial class ModifyOptionGroupRequestMarshaller : IMarshaller<IRequest, ModifyOptionGroupRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyOptionGroupRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ModifyOptionGroupRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RDS");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "ModifyOptionGroup");
            request.Parameters.Add("Version", "2014-10-31");

            if (publicRequest.IsSetApplyImmediately())
            {
                request.Parameters.Add("ApplyImmediately", StringUtils.FromBool(publicRequest.ApplyImmediately.Value));
            }
            if (publicRequest.IsSetOptionGroupName())
            {
                request.Parameters.Add("OptionGroupName", StringUtils.FromString(publicRequest.OptionGroupName));
            }
            if (publicRequest.IsSetOptionsToInclude())
            {
                if (publicRequest.OptionsToInclude.Count == 0)
                {
                    request.Parameters.Add("OptionsToInclude", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.OptionsToInclude)
                    {
                        if (item0.IsSetDBSecurityGroupMemberships())
                        {
                            if (item0.DBSecurityGroupMemberships.Count == 0)
                            {
                                request.Parameters.Add("OptionsToInclude" + ".OptionConfiguration" + "." + index0 + ".DBSecurityGroupMemberships", "");
                            }
                            else
                            {
                                int index1 = 1;
                                foreach (var item1 in item0.DBSecurityGroupMemberships)
                                {
                                    request.Parameters.Add("OptionsToInclude" + ".OptionConfiguration" + "." + index0 + ".DBSecurityGroupMemberships" + ".DBSecurityGroupName" + "." + index1, StringUtils.FromString(item1));
                                    index1++;
                                }
                            }
                        }
                        if (item0.IsSetOptionName())
                        {
                            request.Parameters.Add("OptionsToInclude" + ".OptionConfiguration" + "." + index0 + ".OptionName", StringUtils.FromString(item0.OptionName));
                        }
                        if (item0.IsSetOptionSettings())
                        {
                            if (item0.OptionSettings.Count == 0)
                            {
                                request.Parameters.Add("OptionsToInclude" + ".OptionConfiguration" + "." + index0 + ".OptionSettings", "");
                            }
                            else
                            {
                                int index1 = 1;
                                foreach (var item1 in item0.OptionSettings)
                                {
                                    if (item1.IsSetAllowedValues())
                                    {
                                        request.Parameters.Add("OptionsToInclude" + ".OptionConfiguration" + "." + index0 + ".OptionSettings" + ".OptionSetting" + "." + index1 + ".AllowedValues", StringUtils.FromString(item1.AllowedValues));
                                    }
                                    if (item1.IsSetApplyType())
                                    {
                                        request.Parameters.Add("OptionsToInclude" + ".OptionConfiguration" + "." + index0 + ".OptionSettings" + ".OptionSetting" + "." + index1 + ".ApplyType", StringUtils.FromString(item1.ApplyType));
                                    }
                                    if (item1.IsSetDataType())
                                    {
                                        request.Parameters.Add("OptionsToInclude" + ".OptionConfiguration" + "." + index0 + ".OptionSettings" + ".OptionSetting" + "." + index1 + ".DataType", StringUtils.FromString(item1.DataType));
                                    }
                                    if (item1.IsSetDefaultValue())
                                    {
                                        request.Parameters.Add("OptionsToInclude" + ".OptionConfiguration" + "." + index0 + ".OptionSettings" + ".OptionSetting" + "." + index1 + ".DefaultValue", StringUtils.FromString(item1.DefaultValue));
                                    }
                                    if (item1.IsSetDescription())
                                    {
                                        request.Parameters.Add("OptionsToInclude" + ".OptionConfiguration" + "." + index0 + ".OptionSettings" + ".OptionSetting" + "." + index1 + ".Description", StringUtils.FromString(item1.Description));
                                    }
                                    if (item1.IsSetIsCollection())
                                    {
                                        request.Parameters.Add("OptionsToInclude" + ".OptionConfiguration" + "." + index0 + ".OptionSettings" + ".OptionSetting" + "." + index1 + ".IsCollection", StringUtils.FromBool(item1.IsCollection.Value));
                                    }
                                    if (item1.IsSetIsModifiable())
                                    {
                                        request.Parameters.Add("OptionsToInclude" + ".OptionConfiguration" + "." + index0 + ".OptionSettings" + ".OptionSetting" + "." + index1 + ".IsModifiable", StringUtils.FromBool(item1.IsModifiable.Value));
                                    }
                                    if (item1.IsSetName())
                                    {
                                        request.Parameters.Add("OptionsToInclude" + ".OptionConfiguration" + "." + index0 + ".OptionSettings" + ".OptionSetting" + "." + index1 + ".Name", StringUtils.FromString(item1.Name));
                                    }
                                    if (item1.IsSetValue())
                                    {
                                        request.Parameters.Add("OptionsToInclude" + ".OptionConfiguration" + "." + index0 + ".OptionSettings" + ".OptionSetting" + "." + index1 + ".Value", StringUtils.FromString(item1.Value));
                                    }
                                    index1++;
                                }
                            }
                        }
                        if (item0.IsSetOptionVersion())
                        {
                            request.Parameters.Add("OptionsToInclude" + ".OptionConfiguration" + "." + index0 + ".OptionVersion", StringUtils.FromString(item0.OptionVersion));
                        }
                        if (item0.IsSetPort())
                        {
                            request.Parameters.Add("OptionsToInclude" + ".OptionConfiguration" + "." + index0 + ".Port", StringUtils.FromInt(item0.Port.Value));
                        }
                        if (item0.IsSetVpcSecurityGroupMemberships())
                        {
                            if (item0.VpcSecurityGroupMemberships.Count == 0)
                            {
                                request.Parameters.Add("OptionsToInclude" + ".OptionConfiguration" + "." + index0 + ".VpcSecurityGroupMemberships", "");
                            }
                            else
                            {
                                int index1 = 1;
                                foreach (var item1 in item0.VpcSecurityGroupMemberships)
                                {
                                    request.Parameters.Add("OptionsToInclude" + ".OptionConfiguration" + "." + index0 + ".VpcSecurityGroupMemberships" + ".VpcSecurityGroupId" + "." + index1, StringUtils.FromString(item1));
                                    index1++;
                                }
                            }
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetOptionsToRemove())
            {
                if (publicRequest.OptionsToRemove.Count == 0)
                {
                    request.Parameters.Add("OptionsToRemove", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.OptionsToRemove)
                    {
                        request.Parameters.Add("OptionsToRemove" + ".member" + "." + index0, StringUtils.FromString(item0));
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

        private static readonly ModifyOptionGroupRequestMarshaller _instance = new();

        internal static ModifyOptionGroupRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ModifyOptionGroupRequestMarshaller Instance => _instance;
    }
}
