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

using Amazon.Redshift.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.Redshift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeClusterSnapshots Request Marshaller
    /// </summary>
    public partial class DescribeClusterSnapshotsRequestMarshaller : IMarshaller<IRequest, DescribeClusterSnapshotsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeClusterSnapshotsRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(DescribeClusterSnapshotsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Redshift");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "DescribeClusterSnapshots");
            request.Parameters.Add("Version", "2012-12-01");

            if (publicRequest.IsSetClusterExists())
            {
                request.Parameters.Add("ClusterExists", StringUtils.FromBool(publicRequest.ClusterExists.Value));
            }
            if (publicRequest.IsSetClusterIdentifier())
            {
                request.Parameters.Add("ClusterIdentifier", StringUtils.FromString(publicRequest.ClusterIdentifier));
            }
            if (publicRequest.IsSetEndTime())
            {
                request.Parameters.Add("EndTime", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.EndTime.Value));
            }
            if (publicRequest.IsSetMarker())
            {
                request.Parameters.Add("Marker", StringUtils.FromString(publicRequest.Marker));
            }
            if (publicRequest.IsSetMaxRecords())
            {
                request.Parameters.Add("MaxRecords", StringUtils.FromInt(publicRequest.MaxRecords.Value));
            }
            if (publicRequest.IsSetOwnerAccount())
            {
                request.Parameters.Add("OwnerAccount", StringUtils.FromString(publicRequest.OwnerAccount));
            }
            if (publicRequest.IsSetSnapshotArn())
            {
                request.Parameters.Add("SnapshotArn", StringUtils.FromString(publicRequest.SnapshotArn));
            }
            if (publicRequest.IsSetSnapshotIdentifier())
            {
                request.Parameters.Add("SnapshotIdentifier", StringUtils.FromString(publicRequest.SnapshotIdentifier));
            }
            if (publicRequest.IsSetSnapshotType())
            {
                request.Parameters.Add("SnapshotType", StringUtils.FromString(publicRequest.SnapshotType));
            }
            if (publicRequest.IsSetSortingEntities())
            {
                if (publicRequest.SortingEntities.Count == 0)
                {
                    request.Parameters.Add("SortingEntities", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.SortingEntities)
                    {
                        if (item0.IsSetAttribute())
                        {
                            request.Parameters.Add("SortingEntities" + ".SnapshotSortingEntity" + "." + index0 + ".Attribute", StringUtils.FromString(item0.Attribute));
                        }
                        if (item0.IsSetSortOrder())
                        {
                            request.Parameters.Add("SortingEntities" + ".SnapshotSortingEntity" + "." + index0 + ".SortOrder", StringUtils.FromString(item0.SortOrder));
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetStartTime())
            {
                request.Parameters.Add("StartTime", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.StartTime.Value));
            }
            if (publicRequest.IsSetTagKeys())
            {
                if (publicRequest.TagKeys.Count == 0)
                {
                    request.Parameters.Add("TagKeys", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.TagKeys)
                    {
                        request.Parameters.Add("TagKeys" + ".TagKey" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetTagValues())
            {
                if (publicRequest.TagValues.Count == 0)
                {
                    request.Parameters.Add("TagValues", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.TagValues)
                    {
                        request.Parameters.Add("TagValues" + ".TagValue" + "." + index0, StringUtils.FromString(item0));
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

        private static readonly DescribeClusterSnapshotsRequestMarshaller _instance = new();

        internal static DescribeClusterSnapshotsRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DescribeClusterSnapshotsRequestMarshaller Instance => _instance;
    }
}
