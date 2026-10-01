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
using System.IO;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;

using Amazon.MQ.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.MQ.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RebootBroker Request Marshaller
    /// </summary>
    public partial class RebootBrokerRequestMarshaller : IMarshaller<IRequest, RebootBrokerRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RebootBrokerRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(RebootBrokerRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MQ");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-11-27";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetBrokerId())
            {
                throw new AmazonMQException("Request object does not have required field BrokerId set");
            }
            request.AddPathResource("{BrokerId}", StringUtils.FromString(publicRequest.BrokerId));

            request.ResourcePath = "/v1/brokers/{BrokerId}/reboot";

            return request;
        }

        private static readonly RebootBrokerRequestMarshaller _instance = new();

        internal static RebootBrokerRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static RebootBrokerRequestMarshaller Instance => _instance;
    }
}
