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
#pragma warning disable CS0612,CS0618
namespace Amazon.ChimeSDKVoice.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Termination Marshaller
    /// </summary>
    public class TerminationMarshaller : IRequestMarshaller<Termination, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Termination requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCallingRegions())
            {
                context.Writer.WritePropertyName("CallingRegions");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCallingRegionsListValue in requestObject.CallingRegions)
                {
                        context.Writer.WriteStringValue(requestObjectCallingRegionsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetCidrAllowedList())
            {
                context.Writer.WritePropertyName("CidrAllowedList");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCidrAllowedListListValue in requestObject.CidrAllowedList)
                {
                        context.Writer.WriteStringValue(requestObjectCidrAllowedListListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetCpsLimit())
            {
                context.Writer.WritePropertyName("CpsLimit");
                context.Writer.WriteNumberValue(requestObject.CpsLimit.Value);
            }

            if(requestObject.IsSetDefaultPhoneNumber())
            {
                context.Writer.WritePropertyName("DefaultPhoneNumber");
                context.Writer.WriteStringValue(requestObject.DefaultPhoneNumber);
            }

            if(requestObject.IsSetDisabled())
            {
                context.Writer.WritePropertyName("Disabled");
                context.Writer.WriteBooleanValue(requestObject.Disabled.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static TerminationMarshaller Instance = new TerminationMarshaller();

    }
}