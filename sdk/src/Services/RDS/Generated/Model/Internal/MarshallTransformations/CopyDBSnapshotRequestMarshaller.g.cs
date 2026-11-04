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
    /// CopyDBSnapshot Request Marshaller
    /// </summary>
    public partial class CopyDBSnapshotRequestMarshaller : IMarshaller<IRequest, CopyDBSnapshotRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CopyDBSnapshotRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CopyDBSnapshotRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RDS");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "CopyDBSnapshot");
            request.Parameters.Add("Version", "2014-10-31");

            if (publicRequest.IsSetCopyOptionGroup())
            {
                request.Parameters.Add("CopyOptionGroup", StringUtils.FromBool(publicRequest.CopyOptionGroup.Value));
            }
            if (publicRequest.IsSetCopyTags())
            {
                request.Parameters.Add("CopyTags", StringUtils.FromBool(publicRequest.CopyTags.Value));
            }
            if (publicRequest.IsSetKmsKeyId())
            {
                request.Parameters.Add("KmsKeyId", StringUtils.FromString(publicRequest.KmsKeyId));
            }
            if (publicRequest.IsSetOptionGroupName())
            {
                request.Parameters.Add("OptionGroupName", StringUtils.FromString(publicRequest.OptionGroupName));
            }
            if (publicRequest.IsSetPreSignedUrl())
            {
                request.Parameters.Add("PreSignedUrl", StringUtils.FromString(publicRequest.PreSignedUrl));
            }
            if (publicRequest.IsSetSnapshotAvailabilityZone())
            {
                request.Parameters.Add("SnapshotAvailabilityZone", StringUtils.FromString(publicRequest.SnapshotAvailabilityZone));
            }
            if (publicRequest.IsSetSnapshotTarget())
            {
                request.Parameters.Add("SnapshotTarget", StringUtils.FromString(publicRequest.SnapshotTarget));
            }
            if (publicRequest.IsSetSourceDBSnapshotIdentifier())
            {
                request.Parameters.Add("SourceDBSnapshotIdentifier", StringUtils.FromString(publicRequest.SourceDBSnapshotIdentifier));
            }
            if (publicRequest.IsSetTagSpecifications())
            {
                if (publicRequest.TagSpecifications.Count == 0)
                {
                    request.Parameters.Add("TagSpecifications", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.TagSpecifications)
                    {
                        if (item0.IsSetResourceType())
                        {
                            request.Parameters.Add("TagSpecifications" + ".item" + "." + index0 + ".ResourceType", StringUtils.FromString(item0.ResourceType));
                        }
                        if (item0.IsSetTags())
                        {
                            if (item0.Tags.Count == 0)
                            {
                                request.Parameters.Add("TagSpecifications" + ".item" + "." + index0 + ".Tags", "");
                            }
                            else
                            {
                                int index1 = 1;
                                foreach (var item1 in item0.Tags)
                                {
                                    if (item1.IsSetKey())
                                    {
                                        request.Parameters.Add("TagSpecifications" + ".item" + "." + index0 + ".Tags" + ".Tag" + "." + index1 + ".Key", StringUtils.FromString(item1.Key));
                                    }
                                    if (item1.IsSetValue())
                                    {
                                        request.Parameters.Add("TagSpecifications" + ".item" + "." + index0 + ".Tags" + ".Tag" + "." + index1 + ".Value", StringUtils.FromString(item1.Value));
                                    }
                                    index1++;
                                }
                            }
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetTags())
            {
                if (publicRequest.Tags.Count == 0)
                {
                    request.Parameters.Add("Tags", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.Tags)
                    {
                        if (item0.IsSetKey())
                        {
                            request.Parameters.Add("Tags" + ".Tag" + "." + index0 + ".Key", StringUtils.FromString(item0.Key));
                        }
                        if (item0.IsSetValue())
                        {
                            request.Parameters.Add("Tags" + ".Tag" + "." + index0 + ".Value", StringUtils.FromString(item0.Value));
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetTargetCustomAvailabilityZone())
            {
                request.Parameters.Add("TargetCustomAvailabilityZone", StringUtils.FromString(publicRequest.TargetCustomAvailabilityZone));
            }
            if (publicRequest.IsSetTargetDBSnapshotIdentifier())
            {
                request.Parameters.Add("TargetDBSnapshotIdentifier", StringUtils.FromString(publicRequest.TargetDBSnapshotIdentifier));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly CopyDBSnapshotRequestMarshaller _instance = new();

        internal static CopyDBSnapshotRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CopyDBSnapshotRequestMarshaller Instance => _instance;
    }
}
