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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Bedrock.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Bedrock.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GuardrailWordPolicyConfig Marshaller
    /// </summary>
    public class GuardrailWordPolicyConfigMarshaller : IRequestMarshaller<GuardrailWordPolicyConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(GuardrailWordPolicyConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetManagedWordListsConfig())
            {
                context.Writer.WritePropertyName("managedWordListsConfig");
                context.Writer.WriteStartArray();
                foreach(var requestObjectManagedWordListsConfigListValue in requestObject.ManagedWordListsConfig)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = GuardrailManagedWordsConfigMarshaller.Instance;
                    marshaller.Marshall(requestObjectManagedWordListsConfigListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetWordsConfig())
            {
                context.Writer.WritePropertyName("wordsConfig");
                context.Writer.WriteStartArray();
                foreach(var requestObjectWordsConfigListValue in requestObject.WordsConfig)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = GuardrailWordConfigMarshaller.Instance;
                    marshaller.Marshall(requestObjectWordsConfigListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static GuardrailWordPolicyConfigMarshaller Instance = new GuardrailWordPolicyConfigMarshaller();

    }
}