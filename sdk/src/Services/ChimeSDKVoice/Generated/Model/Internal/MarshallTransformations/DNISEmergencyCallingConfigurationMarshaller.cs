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
using ThirdParty.Json.LitJson;

namespace Amazon.ChimeSDKVoice.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DNISEmergencyCallingConfiguration Marshaller
    /// </summary>
    public class DNISEmergencyCallingConfigurationMarshaller : IRequestMarshaller<DNISEmergencyCallingConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DNISEmergencyCallingConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetCallingCountry())
            {
                context.Writer.WritePropertyName("CallingCountry");
                context.Writer.Write(requestObject.CallingCountry);
            }

            if(requestObject.IsSetEmergencyPhoneNumber())
            {
                context.Writer.WritePropertyName("EmergencyPhoneNumber");
                context.Writer.Write(requestObject.EmergencyPhoneNumber);
            }

            if(requestObject.IsSetTestPhoneNumber())
            {
                context.Writer.WritePropertyName("TestPhoneNumber");
                context.Writer.Write(requestObject.TestPhoneNumber);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DNISEmergencyCallingConfigurationMarshaller Instance = new DNISEmergencyCallingConfigurationMarshaller();

    }
}