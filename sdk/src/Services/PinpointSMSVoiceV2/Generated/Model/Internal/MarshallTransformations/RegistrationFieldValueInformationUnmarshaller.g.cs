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
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.PinpointSMSVoiceV2.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618

namespace Amazon.PinpointSMSVoiceV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for RegistrationFieldValueInformation Object
    /// </summary>
    public partial class RegistrationFieldValueInformationUnmarshaller : IJsonUnmarshaller<RegistrationFieldValueInformation, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public RegistrationFieldValueInformation Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            var unmarshalledObject = new RegistrationFieldValueInformation();
            if (context.IsEmptyResponse) return null;

            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("DeniedReason", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DeniedReason = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("Feedback", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Feedback = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("FieldPath", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FieldPath = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("RegistrationAttachmentId", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RegistrationAttachmentId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("SelectChoices", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.SelectChoices = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("TextValue", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TextValue = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }

        private static RegistrationFieldValueInformationUnmarshaller _instance = new RegistrationFieldValueInformationUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static RegistrationFieldValueInformationUnmarshaller Instance => _instance;
    }
}
