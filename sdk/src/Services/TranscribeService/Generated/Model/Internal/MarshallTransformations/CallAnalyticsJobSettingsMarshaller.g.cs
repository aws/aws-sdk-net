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

using Amazon.TranscribeService.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.TranscribeService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CallAnalyticsJobSettings Marshaller
    /// </summary>
    public partial class CallAnalyticsJobSettingsMarshaller : IRequestMarshaller<CallAnalyticsJobSettings, CborMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(CallAnalyticsJobSettings requestObject, CborMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetContentRedaction())
            {
                context.Writer.WriteTextString("ContentRedaction");
                context.Writer.WriteStartMap(null);

                var marshaller = ContentRedactionMarshaller.Instance;
                marshaller.Marshall(requestObject.ContentRedaction, context);

                context.Writer.WriteEndMap();
            }

            if (requestObject.IsSetLanguageIdSettings())
            {
                context.Writer.WriteTextString("LanguageIdSettings");
                context.Writer.WriteStartMap(null);
                foreach (var requestObjectLanguageIdSettingsKvp in requestObject.LanguageIdSettings)
                {
                    context.Writer.WriteTextString(requestObjectLanguageIdSettingsKvp.Key);
                    var requestObjectLanguageIdSettingsValue = requestObjectLanguageIdSettingsKvp.Value;
                    context.Writer.WriteStartMap(null);

                    var marshaller = LanguageIdSettingsMarshaller.Instance;
                    marshaller.Marshall(requestObjectLanguageIdSettingsValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndMap();
            }

            if (requestObject.IsSetLanguageModelName())
            {
                context.Writer.WriteTextString("LanguageModelName");
                context.Writer.WriteTextString(requestObject.LanguageModelName);
            }

            if (requestObject.IsSetLanguageOptions())
            {
                context.Writer.WriteTextString("LanguageOptions");
                context.Writer.WriteStartArray(requestObject.LanguageOptions.Count);
                foreach (var requestObjectLanguageOptionsListValue in requestObject.LanguageOptions)
                {
                    context.Writer.WriteTextString(requestObjectLanguageOptionsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetSummarization())
            {
                context.Writer.WriteTextString("Summarization");
                context.Writer.WriteStartMap(null);

                var marshaller = SummarizationMarshaller.Instance;
                marshaller.Marshall(requestObject.Summarization, context);

                context.Writer.WriteEndMap();
            }

            if (requestObject.IsSetVocabularyFilterMethod())
            {
                context.Writer.WriteTextString("VocabularyFilterMethod");
                context.Writer.WriteTextString(requestObject.VocabularyFilterMethod);
            }

            if (requestObject.IsSetVocabularyFilterName())
            {
                context.Writer.WriteTextString("VocabularyFilterName");
                context.Writer.WriteTextString(requestObject.VocabularyFilterName);
            }

            if (requestObject.IsSetVocabularyName())
            {
                context.Writer.WriteTextString("VocabularyName");
                context.Writer.WriteTextString(requestObject.VocabularyName);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static CallAnalyticsJobSettingsMarshaller Instance = new CallAnalyticsJobSettingsMarshaller();
    }
}
