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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Rekognition.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Rekognition.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateFaceLivenessSessionRequestSettings Marshaller
    /// </summary>
    public class CreateFaceLivenessSessionRequestSettingsMarshaller : IRequestMarshaller<CreateFaceLivenessSessionRequestSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CreateFaceLivenessSessionRequestSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAuditImagesLimit())
            {
                context.Writer.WritePropertyName("AuditImagesLimit");
                context.Writer.WriteNumberValue(requestObject.AuditImagesLimit.Value);
            }

            if(requestObject.IsSetChallengePreferences())
            {
                context.Writer.WritePropertyName("ChallengePreferences");
                context.Writer.WriteStartArray();
                foreach(var requestObjectChallengePreferencesListValue in requestObject.ChallengePreferences)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ChallengePreferenceMarshaller.Instance;
                    marshaller.Marshall(requestObjectChallengePreferencesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetOutputConfig())
            {
                context.Writer.WritePropertyName("OutputConfig");
                context.Writer.WriteStartObject();

                var marshaller = LivenessOutputConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.OutputConfig, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CreateFaceLivenessSessionRequestSettingsMarshaller Instance = new CreateFaceLivenessSessionRequestSettingsMarshaller();

    }
}