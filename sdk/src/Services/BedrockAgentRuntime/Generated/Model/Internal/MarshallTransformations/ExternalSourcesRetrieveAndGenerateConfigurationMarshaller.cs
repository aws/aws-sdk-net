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
 * Do not modify this file. This file is generated from the bedrock-agent-runtime-2023-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BedrockAgentRuntime.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockAgentRuntime.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ExternalSourcesRetrieveAndGenerateConfiguration Marshaller
    /// </summary>
    public class ExternalSourcesRetrieveAndGenerateConfigurationMarshaller : IRequestMarshaller<ExternalSourcesRetrieveAndGenerateConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ExternalSourcesRetrieveAndGenerateConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetGenerationConfiguration())
            {
                context.Writer.WritePropertyName("generationConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = ExternalSourcesGenerationConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.GenerationConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetModelArn())
            {
                context.Writer.WritePropertyName("modelArn");
                context.Writer.Write(requestObject.ModelArn);
            }

            if(requestObject.IsSetSources())
            {
                context.Writer.WritePropertyName("sources");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectSourcesListValue in requestObject.Sources)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = ExternalSourceMarshaller.Instance;
                    marshaller.Marshall(requestObjectSourcesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ExternalSourcesRetrieveAndGenerateConfigurationMarshaller Instance = new ExternalSourcesRetrieveAndGenerateConfigurationMarshaller();

    }
}