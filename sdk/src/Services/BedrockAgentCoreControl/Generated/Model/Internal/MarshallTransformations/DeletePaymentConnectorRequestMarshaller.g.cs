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

using Amazon.BedrockAgentCoreControl.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.BedrockAgentCoreControl.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeletePaymentConnector Request Marshaller
    /// </summary>
    public partial class DeletePaymentConnectorRequestMarshaller : IMarshaller<IRequest, DeletePaymentConnectorRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeletePaymentConnectorRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(DeletePaymentConnectorRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.BedrockAgentCoreControl");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-06-05";
            request.HttpMethod = "DELETE";

            if (publicRequest.IsSetClientToken())
            {
                request.Parameters.Add("clientToken", StringUtils.FromString(publicRequest.ClientToken));
            }
            else
            {
                request.Parameters.Add("clientToken", Guid.NewGuid().ToString());
            }

            if (!publicRequest.IsSetPaymentConnectorId())
            {
                throw new AmazonBedrockAgentCoreControlException("Request object does not have required field PaymentConnectorId set");
            }
            request.AddPathResource("{paymentConnectorId}", StringUtils.FromString(publicRequest.PaymentConnectorId));

            if (!publicRequest.IsSetPaymentManagerId())
            {
                throw new AmazonBedrockAgentCoreControlException("Request object does not have required field PaymentManagerId set");
            }
            request.AddPathResource("{paymentManagerId}", StringUtils.FromString(publicRequest.PaymentManagerId));

            request.ResourcePath = "/payments/managers/{paymentManagerId}/connectors/{paymentConnectorId}";

            request.UseQueryString = true;

            return request;
        }

        private static readonly DeletePaymentConnectorRequestMarshaller _instance = new();

        internal static DeletePaymentConnectorRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DeletePaymentConnectorRequestMarshaller Instance => _instance;
    }
}
