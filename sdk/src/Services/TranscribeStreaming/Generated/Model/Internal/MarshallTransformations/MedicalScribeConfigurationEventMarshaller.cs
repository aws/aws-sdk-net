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
 * Do not modify this file. This file is generated from the transcribe-streaming-2017-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.TranscribeStreaming.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.TranscribeStreaming.Model.Internal.MarshallTransformations
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
                context.Writer.WritePropertyName("ChannelDefinitions");
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

            if(requestObject.IsSetEncryptionSettings())
            {
                context.Writer.WritePropertyName("EncryptionSettings");
                context.Writer.WriteStartObject();

                var marshaller = MedicalScribeEncryptionSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.EncryptionSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMedicalScribeContext())
            {
                context.Writer.WritePropertyName("MedicalScribeContext");
                context.Writer.WriteStartObject();

                var marshaller = MedicalScribeContextMarshaller.Instance;
                marshaller.Marshall(requestObject.MedicalScribeContext, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPostStreamAnalyticsSettings())
            {
                context.Writer.WritePropertyName("PostStreamAnalyticsSettings");
                context.Writer.WriteStartObject();

                var marshaller = MedicalScribePostStreamAnalyticsSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.PostStreamAnalyticsSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetResourceAccessRoleArn())
            {
                context.Writer.WritePropertyName("ResourceAccessRoleArn");
                context.Writer.WriteStringValue(requestObject.ResourceAccessRoleArn);
            }

            if(requestObject.IsSetVocabularyFilterMethod())
            {
                context.Writer.WritePropertyName("VocabularyFilterMethod");
                context.Writer.WriteStringValue(requestObject.VocabularyFilterMethod);
            }

            if(requestObject.IsSetVocabularyFilterName())
            {
                context.Writer.WritePropertyName("VocabularyFilterName");
                context.Writer.WriteStringValue(requestObject.VocabularyFilterName);
            }

            if(requestObject.IsSetVocabularyName())
            {
                context.Writer.WritePropertyName("VocabularyName");
                context.Writer.WriteStringValue(requestObject.VocabularyName);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static MedicalScribeConfigurationEventMarshaller Instance = new MedicalScribeConfigurationEventMarshaller();

    }
}