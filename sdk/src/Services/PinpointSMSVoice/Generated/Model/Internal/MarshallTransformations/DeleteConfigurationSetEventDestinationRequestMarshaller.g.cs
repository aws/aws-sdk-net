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

using Amazon.PinpointSMSVoice.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.PinpointSMSVoice.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteConfigurationSetEventDestination Request Marshaller
    /// </summary>
    public partial class DeleteConfigurationSetEventDestinationRequestMarshaller : IMarshaller<IRequest, DeleteConfigurationSetEventDestinationRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteConfigurationSetEventDestinationRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(DeleteConfigurationSetEventDestinationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.PinpointSMSVoice");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-09-05";
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetConfigurationSetName())
            {
                throw new AmazonPinpointSMSVoiceException("Request object does not have required field ConfigurationSetName set");
            }
            request.AddPathResource("{ConfigurationSetName}", StringUtils.FromString(publicRequest.ConfigurationSetName));

            if (!publicRequest.IsSetEventDestinationName())
            {
                throw new AmazonPinpointSMSVoiceException("Request object does not have required field EventDestinationName set");
            }
            request.AddPathResource("{EventDestinationName}", StringUtils.FromString(publicRequest.EventDestinationName));

            request.ResourcePath = "/v1/sms-voice/configuration-sets/{ConfigurationSetName}/event-destinations/{EventDestinationName}";

            return request;
        }

        private static readonly DeleteConfigurationSetEventDestinationRequestMarshaller _instance = new();

        internal static DeleteConfigurationSetEventDestinationRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DeleteConfigurationSetEventDestinationRequestMarshaller Instance => _instance;
    }
}
