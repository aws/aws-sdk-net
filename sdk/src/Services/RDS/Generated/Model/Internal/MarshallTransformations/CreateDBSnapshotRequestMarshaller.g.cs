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
    /// CreateDBSnapshot Request Marshaller
    /// </summary>
    public partial class CreateDBSnapshotRequestMarshaller : IMarshaller<IRequest, CreateDBSnapshotRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateDBSnapshotRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateDBSnapshotRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RDS");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "CreateDBSnapshot");
            request.Parameters.Add("Version", "2014-10-31");

            if (publicRequest.IsSetDBInstanceIdentifier())
            {
                request.Parameters.Add("DBInstanceIdentifier", StringUtils.FromString(publicRequest.DBInstanceIdentifier));
            }
            if (publicRequest.IsSetDBSnapshotIdentifier())
            {
                request.Parameters.Add("DBSnapshotIdentifier", StringUtils.FromString(publicRequest.DBSnapshotIdentifier));
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

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly CreateDBSnapshotRequestMarshaller _instance = new();

        internal static CreateDBSnapshotRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateDBSnapshotRequestMarshaller Instance => _instance;
    }
}
