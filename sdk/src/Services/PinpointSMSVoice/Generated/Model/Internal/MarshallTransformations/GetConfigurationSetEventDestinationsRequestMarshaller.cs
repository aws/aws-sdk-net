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
 * Do not modify this file. This file is generated from the sms-voice-2018-09-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.PinpointSMSVoice.Model;
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
namespace Amazon.PinpointSMSVoice.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetConfigurationSetEventDestinations Request Marshaller
    /// </summary>       
    public class GetConfigurationSetEventDestinationsRequestMarshaller : IMarshaller<IRequest, GetConfigurationSetEventDestinationsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetConfigurationSetEventDestinationsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetConfigurationSetEventDestinationsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.PinpointSMSVoice");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-09-05";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetConfigurationSetName())
                throw new AmazonPinpointSMSVoiceException("Request object does not have required field ConfigurationSetName set");
            request.AddPathResource("{ConfigurationSetName}", StringUtils.FromString(publicRequest.ConfigurationSetName));
            request.ResourcePath = "/v1/sms-voice/configuration-sets/{ConfigurationSetName}/event-destinations";

            return request;
        }
        private static GetConfigurationSetEventDestinationsRequestMarshaller _instance = new GetConfigurationSetEventDestinationsRequestMarshaller();        

        internal static GetConfigurationSetEventDestinationsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetConfigurationSetEventDestinationsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}