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
    /// GetClusterCredentials Request Marshaller
    /// </summary>
    public partial class GetClusterCredentialsRequestMarshaller : IMarshaller<IRequest, GetClusterCredentialsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetClusterCredentialsRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetClusterCredentialsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Redshift");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "GetClusterCredentials");
            request.Parameters.Add("Version", "2012-12-01");

            if (publicRequest.IsSetAutoCreate())
            {
                request.Parameters.Add("AutoCreate", StringUtils.FromBool(publicRequest.AutoCreate.Value));
            }
            if (publicRequest.IsSetClusterIdentifier())
            {
                request.Parameters.Add("ClusterIdentifier", StringUtils.FromString(publicRequest.ClusterIdentifier));
            }
            if (publicRequest.IsSetCustomDomainName())
            {
                request.Parameters.Add("CustomDomainName", StringUtils.FromString(publicRequest.CustomDomainName));
            }
            if (publicRequest.IsSetDbGroups())
            {
                if (publicRequest.DbGroups.Count == 0)
                {
                    request.Parameters.Add("DbGroups", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.DbGroups)
                    {
                        request.Parameters.Add("DbGroups" + ".DbGroup" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetDbName())
            {
                request.Parameters.Add("DbName", StringUtils.FromString(publicRequest.DbName));
            }
            if (publicRequest.IsSetDbUser())
            {
                request.Parameters.Add("DbUser", StringUtils.FromString(publicRequest.DbUser));
            }
            if (publicRequest.IsSetDurationSeconds())
            {
                request.Parameters.Add("DurationSeconds", StringUtils.FromInt(publicRequest.DurationSeconds.Value));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly GetClusterCredentialsRequestMarshaller _instance = new();

        internal static GetClusterCredentialsRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetClusterCredentialsRequestMarshaller Instance => _instance;
    }
}
