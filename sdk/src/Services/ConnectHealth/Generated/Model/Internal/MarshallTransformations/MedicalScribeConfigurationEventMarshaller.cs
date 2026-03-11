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
 * Do not modify this file. This file is generated from the connecthealth-2025-01-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ConnectHealth.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ConnectHealth.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// MedicalScribeConfigurationEvent Marshaller
    /// </summary>
    public class MedicalScribeConfigurationEventMarshaller : IRequestMarshaller<MedicalScribeConfigurationEvent, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(MedicalScribeConfigurationEvent requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetChannelDefinitions())
            {
                context.Writer.WritePropertyName("channelDefinitions");
                context.Writer.WriteStartArray();
                foreach(var requestObjectChannelDefinitionsListValue in requestObject.ChannelDefinitions)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = MedicalScribeChannelDefinitionMarshaller.Instance;
                    marshaller.Marshall(requestObjectChannelDefinitionsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetEncounterContext())
            {
                context.Writer.WritePropertyName("encounterContext");
                context.Writer.WriteStartObject();

                var marshaller = EncounterContextMarshaller.Instance;
                marshaller.Marshall(requestObject.EncounterContext, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPostStreamActionSettings())
            {
                context.Writer.WritePropertyName("postStreamActionSettings");
                context.Writer.WriteStartObject();

                var marshaller = MedicalScribePostStreamActionSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.PostStreamActionSettings, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static MedicalScribeConfigurationEventMarshaller Instance = new MedicalScribeConfigurationEventMarshaller();

    }
}