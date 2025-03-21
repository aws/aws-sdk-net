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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BedrockAgent.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockAgent.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PromptVariant Marshaller
    /// </summary>
    public class PromptVariantMarshaller : IRequestMarshaller<PromptVariant, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(PromptVariant requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAdditionalModelRequestFields())
            {
                context.Writer.WritePropertyName("additionalModelRequestFields");
                Amazon.Runtime.Documents.Internal.Transform.DocumentMarshaller.Instance.Write(context.Writer, requestObject.AdditionalModelRequestFields);
            }

            if(requestObject.IsSetGenAiResource())
            {
                context.Writer.WritePropertyName("genAiResource");
                context.Writer.WriteObjectStart();

                var marshaller = PromptGenAiResourceMarshaller.Instance;
                marshaller.Marshall(requestObject.GenAiResource, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetInferenceConfiguration())
            {
                context.Writer.WritePropertyName("inferenceConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = PromptInferenceConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.InferenceConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetMetadata())
            {
                context.Writer.WritePropertyName("metadata");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectMetadataListValue in requestObject.Metadata)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = PromptMetadataEntryMarshaller.Instance;
                    marshaller.Marshall(requestObjectMetadataListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetModelId())
            {
                context.Writer.WritePropertyName("modelId");
                context.Writer.Write(requestObject.ModelId);
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.Write(requestObject.Name);
            }

            if(requestObject.IsSetTemplateConfiguration())
            {
                context.Writer.WritePropertyName("templateConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = PromptTemplateConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.TemplateConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTemplateType())
            {
                context.Writer.WritePropertyName("templateType");
                context.Writer.Write(requestObject.TemplateType);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static PromptVariantMarshaller Instance = new PromptVariantMarshaller();

    }
}