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

using Amazon.SimpleEmailV2.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618

namespace Amazon.SimpleEmailV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Contact Object
    /// </summary>
    public partial class ContactUnmarshaller : IJsonUnmarshaller<Contact, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public Contact Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            var unmarshalledObject = new Contact();
            if (context.IsEmptyResponse) return null;

            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("EmailAddress", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EmailAddress = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("LastUpdatedTimestamp", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastUpdatedTimestamp = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("TopicDefaultPreferences", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<TopicPreference, TopicPreferenceUnmarshaller>(TopicPreferenceUnmarshaller.Instance);
                    unmarshalledObject.TopicDefaultPreferences = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("TopicPreferences", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<TopicPreference, TopicPreferenceUnmarshaller>(TopicPreferenceUnmarshaller.Instance);
                    unmarshalledObject.TopicPreferences = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("UnsubscribeAll", targetDepth, ref reader))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.UnsubscribeAll = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }

        private static ContactUnmarshaller _instance = new ContactUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ContactUnmarshaller Instance => _instance;
    }
}
