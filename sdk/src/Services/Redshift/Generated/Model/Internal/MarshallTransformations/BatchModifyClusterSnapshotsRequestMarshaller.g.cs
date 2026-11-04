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
    /// BatchModifyClusterSnapshots Request Marshaller
    /// </summary>
    public partial class BatchModifyClusterSnapshotsRequestMarshaller : IMarshaller<IRequest, BatchModifyClusterSnapshotsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((BatchModifyClusterSnapshotsRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(BatchModifyClusterSnapshotsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Redshift");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "BatchModifyClusterSnapshots");
            request.Parameters.Add("Version", "2012-12-01");

            if (publicRequest.IsSetForce())
            {
                request.Parameters.Add("Force", StringUtils.FromBool(publicRequest.Force.Value));
            }
            if (publicRequest.IsSetManualSnapshotRetentionPeriod())
            {
                request.Parameters.Add("ManualSnapshotRetentionPeriod", StringUtils.FromInt(publicRequest.ManualSnapshotRetentionPeriod.Value));
            }
            if (publicRequest.IsSetSnapshotIdentifierList())
            {
                if (publicRequest.SnapshotIdentifierList.Count == 0)
                {
                    request.Parameters.Add("SnapshotIdentifierList", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.SnapshotIdentifierList)
                    {
                        request.Parameters.Add("SnapshotIdentifierList" + ".String" + "." + index0, StringUtils.FromString(item0));
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

        private static readonly BatchModifyClusterSnapshotsRequestMarshaller _instance = new();

        internal static BatchModifyClusterSnapshotsRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static BatchModifyClusterSnapshotsRequestMarshaller Instance => _instance;
    }
}
