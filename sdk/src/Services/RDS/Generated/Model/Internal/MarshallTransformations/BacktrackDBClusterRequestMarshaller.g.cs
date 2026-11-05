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
    /// BacktrackDBCluster Request Marshaller
    /// </summary>
    public partial class BacktrackDBClusterRequestMarshaller : IMarshaller<IRequest, BacktrackDBClusterRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((BacktrackDBClusterRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(BacktrackDBClusterRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RDS");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "BacktrackDBCluster");
            request.Parameters.Add("Version", "2014-10-31");

            if (publicRequest.IsSetBacktrackTo())
            {
                request.Parameters.Add("BacktrackTo", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.BacktrackTo.Value));
            }
            if (publicRequest.IsSetDBClusterIdentifier())
            {
                request.Parameters.Add("DBClusterIdentifier", StringUtils.FromString(publicRequest.DBClusterIdentifier));
            }
            if (publicRequest.IsSetForce())
            {
                request.Parameters.Add("Force", StringUtils.FromBool(publicRequest.Force.Value));
            }
            if (publicRequest.IsSetUseEarliestTimeOnPointInTimeUnavailable())
            {
                request.Parameters.Add("UseEarliestTimeOnPointInTimeUnavailable", StringUtils.FromBool(publicRequest.UseEarliestTimeOnPointInTimeUnavailable.Value));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly BacktrackDBClusterRequestMarshaller _instance = new();

        internal static BacktrackDBClusterRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static BacktrackDBClusterRequestMarshaller Instance => _instance;
    }
}
