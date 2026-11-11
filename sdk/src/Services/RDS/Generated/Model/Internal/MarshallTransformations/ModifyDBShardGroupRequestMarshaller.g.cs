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
    /// ModifyDBShardGroup Request Marshaller
    /// </summary>
    public partial class ModifyDBShardGroupRequestMarshaller : IMarshaller<IRequest, ModifyDBShardGroupRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyDBShardGroupRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ModifyDBShardGroupRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RDS");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "ModifyDBShardGroup");
            request.Parameters.Add("Version", "2014-10-31");

            if (publicRequest.IsSetComputeRedundancy())
            {
                request.Parameters.Add("ComputeRedundancy", StringUtils.FromInt(publicRequest.ComputeRedundancy.Value));
            }
            if (publicRequest.IsSetDBShardGroupIdentifier())
            {
                request.Parameters.Add("DBShardGroupIdentifier", StringUtils.FromString(publicRequest.DBShardGroupIdentifier));
            }
            if (publicRequest.IsSetMaxACU())
            {
                request.Parameters.Add("MaxACU", StringUtils.FromDouble(publicRequest.MaxACU.Value));
            }
            if (publicRequest.IsSetMinACU())
            {
                request.Parameters.Add("MinACU", StringUtils.FromDouble(publicRequest.MinACU.Value));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly ModifyDBShardGroupRequestMarshaller _instance = new();

        internal static ModifyDBShardGroupRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ModifyDBShardGroupRequestMarshaller Instance => _instance;
    }
}
