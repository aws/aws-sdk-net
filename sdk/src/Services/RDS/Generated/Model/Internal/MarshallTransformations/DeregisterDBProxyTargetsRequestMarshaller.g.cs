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
    /// DeregisterDBProxyTargets Request Marshaller
    /// </summary>
    public partial class DeregisterDBProxyTargetsRequestMarshaller : IMarshaller<IRequest, DeregisterDBProxyTargetsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeregisterDBProxyTargetsRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(DeregisterDBProxyTargetsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RDS");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "DeregisterDBProxyTargets");
            request.Parameters.Add("Version", "2014-10-31");

            if (publicRequest.IsSetDBClusterIdentifiers())
            {
                if (publicRequest.DBClusterIdentifiers.Count == 0)
                {
                    request.Parameters.Add("DBClusterIdentifiers", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.DBClusterIdentifiers)
                    {
                        request.Parameters.Add("DBClusterIdentifiers" + ".member" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetDBInstanceIdentifiers())
            {
                if (publicRequest.DBInstanceIdentifiers.Count == 0)
                {
                    request.Parameters.Add("DBInstanceIdentifiers", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.DBInstanceIdentifiers)
                    {
                        request.Parameters.Add("DBInstanceIdentifiers" + ".member" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetDBProxyName())
            {
                request.Parameters.Add("DBProxyName", StringUtils.FromString(publicRequest.DBProxyName));
            }
            if (publicRequest.IsSetTargetGroupName())
            {
                request.Parameters.Add("TargetGroupName", StringUtils.FromString(publicRequest.TargetGroupName));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly DeregisterDBProxyTargetsRequestMarshaller _instance = new();

        internal static DeregisterDBProxyTargetsRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DeregisterDBProxyTargetsRequestMarshaller Instance => _instance;
    }
}
