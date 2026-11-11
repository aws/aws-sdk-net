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
    /// ModifyCurrentDBClusterCapacity Request Marshaller
    /// </summary>
    public partial class ModifyCurrentDBClusterCapacityRequestMarshaller : IMarshaller<IRequest, ModifyCurrentDBClusterCapacityRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyCurrentDBClusterCapacityRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ModifyCurrentDBClusterCapacityRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RDS");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "ModifyCurrentDBClusterCapacity");
            request.Parameters.Add("Version", "2014-10-31");

            if (publicRequest.IsSetCapacity())
            {
                request.Parameters.Add("Capacity", StringUtils.FromInt(publicRequest.Capacity.Value));
            }
            if (publicRequest.IsSetDBClusterIdentifier())
            {
                request.Parameters.Add("DBClusterIdentifier", StringUtils.FromString(publicRequest.DBClusterIdentifier));
            }
            if (publicRequest.IsSetSecondsBeforeTimeout())
            {
                request.Parameters.Add("SecondsBeforeTimeout", StringUtils.FromInt(publicRequest.SecondsBeforeTimeout.Value));
            }
            if (publicRequest.IsSetTimeoutAction())
            {
                request.Parameters.Add("TimeoutAction", StringUtils.FromString(publicRequest.TimeoutAction));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly ModifyCurrentDBClusterCapacityRequestMarshaller _instance = new();

        internal static ModifyCurrentDBClusterCapacityRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ModifyCurrentDBClusterCapacityRequestMarshaller Instance => _instance;
    }
}
