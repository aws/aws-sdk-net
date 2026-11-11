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
    /// CreateMacSystemIntegrityProtectionModificationTask Request Marshaller
    /// </summary>
    public partial class CreateMacSystemIntegrityProtectionModificationTaskRequestMarshaller : IMarshaller<IRequest, CreateMacSystemIntegrityProtectionModificationTaskRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateMacSystemIntegrityProtectionModificationTaskRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateMacSystemIntegrityProtectionModificationTaskRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "CreateMacSystemIntegrityProtectionModificationTask");
            request.Parameters.Add("Version", "2016-11-15");

            if (publicRequest.IsSetClientToken())
            {
                request.Parameters.Add("ClientToken", StringUtils.FromString(publicRequest.ClientToken));
            }
            else
            {
                request.Parameters.Add("ClientToken", StringUtils.FromString(Guid.NewGuid().ToString()));
            }
            if (publicRequest.IsSetDryRun())
            {
                request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun.Value));
            }
            if (publicRequest.IsSetInstanceId())
            {
                request.Parameters.Add("InstanceId", StringUtils.FromString(publicRequest.InstanceId));
            }
            if (publicRequest.IsSetMacCredentials())
            {
                request.Parameters.Add("MacCredentials", StringUtils.FromString(publicRequest.MacCredentials));
            }
            if (publicRequest.IsSetMacSystemIntegrityProtectionConfiguration())
            {
                if (publicRequest.MacSystemIntegrityProtectionConfiguration.IsSetAppleInternal())
                {
                    request.Parameters.Add("MacSystemIntegrityProtectionConfiguration" + ".AppleInternal", StringUtils.FromString(publicRequest.MacSystemIntegrityProtectionConfiguration.AppleInternal));
                }
                if (publicRequest.MacSystemIntegrityProtectionConfiguration.IsSetBaseSystem())
                {
                    request.Parameters.Add("MacSystemIntegrityProtectionConfiguration" + ".BaseSystem", StringUtils.FromString(publicRequest.MacSystemIntegrityProtectionConfiguration.BaseSystem));
                }
                if (publicRequest.MacSystemIntegrityProtectionConfiguration.IsSetDTraceRestrictions())
                {
                    request.Parameters.Add("MacSystemIntegrityProtectionConfiguration" + ".DTraceRestrictions", StringUtils.FromString(publicRequest.MacSystemIntegrityProtectionConfiguration.DTraceRestrictions));
                }
                if (publicRequest.MacSystemIntegrityProtectionConfiguration.IsSetDebuggingRestrictions())
                {
                    request.Parameters.Add("MacSystemIntegrityProtectionConfiguration" + ".DebuggingRestrictions", StringUtils.FromString(publicRequest.MacSystemIntegrityProtectionConfiguration.DebuggingRestrictions));
                }
                if (publicRequest.MacSystemIntegrityProtectionConfiguration.IsSetFilesystemProtections())
                {
                    request.Parameters.Add("MacSystemIntegrityProtectionConfiguration" + ".FilesystemProtections", StringUtils.FromString(publicRequest.MacSystemIntegrityProtectionConfiguration.FilesystemProtections));
                }
                if (publicRequest.MacSystemIntegrityProtectionConfiguration.IsSetKextSigning())
                {
                    request.Parameters.Add("MacSystemIntegrityProtectionConfiguration" + ".KextSigning", StringUtils.FromString(publicRequest.MacSystemIntegrityProtectionConfiguration.KextSigning));
                }
                if (publicRequest.MacSystemIntegrityProtectionConfiguration.IsSetNvramProtections())
                {
                    request.Parameters.Add("MacSystemIntegrityProtectionConfiguration" + ".NvramProtections", StringUtils.FromString(publicRequest.MacSystemIntegrityProtectionConfiguration.NvramProtections));
                }
            }
            if (publicRequest.IsSetMacSystemIntegrityProtectionStatus())
            {
                request.Parameters.Add("MacSystemIntegrityProtectionStatus", StringUtils.FromString(publicRequest.MacSystemIntegrityProtectionStatus));
            }
            if (publicRequest.IsSetTagSpecifications())
            {
                if (publicRequest.TagSpecifications.Count == 0)
                {
                    request.Parameters.Add("TagSpecification", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.TagSpecifications)
                    {
                        if (item0.IsSetResourceType())
                        {
                            request.Parameters.Add("TagSpecification" + "." + index0 + ".ResourceType", StringUtils.FromString(item0.ResourceType));
                        }
                        if (item0.IsSetTags())
                        {
                            if (item0.Tags.Count == 0)
                            {
                                request.Parameters.Add("TagSpecification" + "." + index0 + ".Tag", "");
                            }
                            else
                            {
                                int index1 = 1;
                                foreach (var item1 in item0.Tags)
                                {
                                    if (item1.IsSetKey())
                                    {
                                        request.Parameters.Add("TagSpecification" + "." + index0 + ".Tag" + "." + index1 + ".Key", StringUtils.FromString(item1.Key));
                                    }
                                    if (item1.IsSetValue())
                                    {
                                        request.Parameters.Add("TagSpecification" + "." + index0 + ".Tag" + "." + index1 + ".Value", StringUtils.FromString(item1.Value));
                                    }
                                    index1++;
                                }
                            }
                        }
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

        private static readonly CreateMacSystemIntegrityProtectionModificationTaskRequestMarshaller _instance = new();

        internal static CreateMacSystemIntegrityProtectionModificationTaskRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateMacSystemIntegrityProtectionModificationTaskRequestMarshaller Instance => _instance;
    }
}
