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
#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockAgentRuntime.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// KnowledgeBaseVectorSearchConfiguration Marshaller
    /// </summary>
    public class KnowledgeBaseVectorSearchConfigurationMarshaller : IRequestMarshaller<KnowledgeBaseVectorSearchConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(KnowledgeBaseVectorSearchConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetFilter())
            {
                context.Writer.WritePropertyName("filter");
                context.Writer.WriteStartObject();

                var marshaller = RetrievalFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.Filter, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetImplicitFilterConfiguration())
            {
                context.Writer.WritePropertyName("implicitFilterConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = ImplicitFilterConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.ImplicitFilterConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetNumberOfResults())
            {
                context.Writer.WritePropertyName("numberOfResults");
                context.Writer.WriteNumberValue(requestObject.NumberOfResults.Value);
            }

            if(requestObject.IsSetOverrideSearchType())
            {
                context.Writer.WritePropertyName("overrideSearchType");
                context.Writer.WriteStringValue(requestObject.OverrideSearchType);
            }

            if(requestObject.IsSetRerankingConfiguration())
            {
                context.Writer.WritePropertyName("rerankingConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = VectorSearchRerankingConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.RerankingConfiguration, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static KnowledgeBaseVectorSearchConfigurationMarshaller Instance = new KnowledgeBaseVectorSearchConfigurationMarshaller();

    }
}