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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CustomerProfiles.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.CustomerProfiles.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// EngagementPreferences Marshaller
    /// </summary>
    public class EngagementPreferencesMarshaller : IRequestMarshaller<EngagementPreferences, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(EngagementPreferences requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetEmail())
            {
                context.Writer.WritePropertyName("Email");
                context.Writer.WriteStartArray();
                foreach(var requestObjectEmailListValue in requestObject.Email)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ContactPreferenceMarshaller.Instance;
                    marshaller.Marshall(requestObjectEmailListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetPhone())
            {
                context.Writer.WritePropertyName("Phone");
                context.Writer.WriteStartArray();
                foreach(var requestObjectPhoneListValue in requestObject.Phone)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ContactPreferenceMarshaller.Instance;
                    marshaller.Marshall(requestObjectPhoneListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static EngagementPreferencesMarshaller Instance = new EngagementPreferencesMarshaller();

    }
}