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
#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockAgent.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ParsingConfiguration Marshaller
    /// </summary>
    public class ParsingConfigurationMarshaller : IRequestMarshaller<ParsingConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ParsingConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBedrockDataAutomationConfiguration())
            {
                context.Writer.WritePropertyName("bedrockDataAutomationConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = BedrockDataAutomationConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.BedrockDataAutomationConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetBedrockFoundationModelConfiguration())
            {
                context.Writer.WritePropertyName("bedrockFoundationModelConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = BedrockFoundationModelConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.BedrockFoundationModelConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetParsingStrategy())
            {
                context.Writer.WritePropertyName("parsingStrategy");
                context.Writer.WriteStringValue(requestObject.ParsingStrategy);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ParsingConfigurationMarshaller Instance = new ParsingConfigurationMarshaller();

    }
}