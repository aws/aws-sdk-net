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
 * Do not modify this file. This file is generated from the bedrock-data-automation-2023-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BedrockDataAutomation.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockDataAutomation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DocumentStandardOutputConfiguration Marshaller
    /// </summary>
    public class DocumentStandardOutputConfigurationMarshaller : IRequestMarshaller<DocumentStandardOutputConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DocumentStandardOutputConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetExtraction())
            {
                context.Writer.WritePropertyName("extraction");
                context.Writer.WriteStartObject();

                var marshaller = DocumentStandardExtractionMarshaller.Instance;
                marshaller.Marshall(requestObject.Extraction, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetGenerativeField())
            {
                context.Writer.WritePropertyName("generativeField");
                context.Writer.WriteStartObject();

                var marshaller = DocumentStandardGenerativeFieldMarshaller.Instance;
                marshaller.Marshall(requestObject.GenerativeField, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetOutputFormat())
            {
                context.Writer.WritePropertyName("outputFormat");
                context.Writer.WriteStartObject();

                var marshaller = DocumentOutputFormatMarshaller.Instance;
                marshaller.Marshall(requestObject.OutputFormat, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DocumentStandardOutputConfigurationMarshaller Instance = new DocumentStandardOutputConfigurationMarshaller();

    }
}