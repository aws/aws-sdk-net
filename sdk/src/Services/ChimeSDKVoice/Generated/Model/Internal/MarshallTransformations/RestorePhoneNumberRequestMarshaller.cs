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
 * Do not modify this file. This file is generated from the chime-sdk-voice-2022-08-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ChimeSDKVoice.Model;
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
namespace Amazon.ChimeSDKVoice.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RestorePhoneNumber Request Marshaller
    /// </summary>       
    public class RestorePhoneNumberRequestMarshaller : IMarshaller<IRequest, RestorePhoneNumberRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RestorePhoneNumberRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(RestorePhoneNumberRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ChimeSDKVoice");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-08-03";
            request.HttpMethod = "POST";

            request.AddSubResource("operation", "restore");
            if (!publicRequest.IsSetPhoneNumberId())
                throw new AmazonChimeSDKVoiceException("Request object does not have required field PhoneNumberId set");
            request.AddPathResource("{phoneNumberId}", StringUtils.FromString(publicRequest.PhoneNumberId));
            request.ResourcePath = "/phone-numbers/{phoneNumberId}";

            return request;
        }
        private static RestorePhoneNumberRequestMarshaller _instance = new RestorePhoneNumberRequestMarshaller();        

        internal static RestorePhoneNumberRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RestorePhoneNumberRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}