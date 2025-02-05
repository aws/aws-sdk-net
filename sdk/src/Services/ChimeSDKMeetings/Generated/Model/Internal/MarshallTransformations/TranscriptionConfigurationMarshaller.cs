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
 * Do not modify this file. This file is generated from the chime-sdk-meetings-2021-07-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ChimeSDKMeetings.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ChimeSDKMeetings.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// TranscriptionConfiguration Marshaller
    /// </summary>
    public class TranscriptionConfigurationMarshaller : IRequestMarshaller<TranscriptionConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(TranscriptionConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetEngineTranscribeMedicalSettings())
            {
                context.Writer.WritePropertyName("EngineTranscribeMedicalSettings");
                context.Writer.WriteStartObject();

                var marshaller = EngineTranscribeMedicalSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.EngineTranscribeMedicalSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetEngineTranscribeSettings())
            {
                context.Writer.WritePropertyName("EngineTranscribeSettings");
                context.Writer.WriteStartObject();

                var marshaller = EngineTranscribeSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.EngineTranscribeSettings, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static TranscriptionConfigurationMarshaller Instance = new TranscriptionConfigurationMarshaller();

    }
}