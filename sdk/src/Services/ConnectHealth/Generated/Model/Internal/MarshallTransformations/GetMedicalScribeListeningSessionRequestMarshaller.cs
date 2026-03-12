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
 * Do not modify this file. This file is generated from the connecthealth-2025-01-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ConnectHealth.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.ConnectHealth.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetMedicalScribeListeningSession Request Marshaller
    /// </summary>       
    public class GetMedicalScribeListeningSessionRequestMarshaller : IMarshaller<IRequest, GetMedicalScribeListeningSessionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetMedicalScribeListeningSessionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetMedicalScribeListeningSessionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ConnectHealth");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2025-01-29";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetDomainId())
                throw new AmazonConnectHealthException("Request object does not have required field DomainId set");
            request.AddPathResource("{domainId}", StringUtils.FromString(publicRequest.DomainId));
            if (!publicRequest.IsSetSessionId())
                throw new AmazonConnectHealthException("Request object does not have required field SessionId set");
            request.AddPathResource("{sessionId}", StringUtils.FromString(publicRequest.SessionId));
            if (!publicRequest.IsSetSubscriptionId())
                throw new AmazonConnectHealthException("Request object does not have required field SubscriptionId set");
            request.AddPathResource("{subscriptionId}", StringUtils.FromString(publicRequest.SubscriptionId));
            request.ResourcePath = "/medical-scribe-stream/domain/{domainId}/subscription/{subscriptionId}/session/{sessionId}";
            
            request.HostPrefix = $"streaming.";

            return request;
        }
        private static GetMedicalScribeListeningSessionRequestMarshaller _instance = new GetMedicalScribeListeningSessionRequestMarshaller();        

        internal static GetMedicalScribeListeningSessionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetMedicalScribeListeningSessionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}