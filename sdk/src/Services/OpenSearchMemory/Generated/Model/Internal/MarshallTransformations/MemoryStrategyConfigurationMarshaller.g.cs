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

using Amazon.OpenSearchMemory.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.OpenSearchMemory.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// MemoryStrategyConfiguration Marshaller
    /// </summary>
    public partial class MemoryStrategyConfigurationMarshaller : IRequestMarshaller<MemoryStrategyConfiguration, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(MemoryStrategyConfiguration requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetConsolidationEnabled())
            {
                context.Writer.WritePropertyName("consolidationEnabled");
                context.Writer.WriteBooleanValue(requestObject.ConsolidationEnabled.Value);
            }

            if (requestObject.IsSetExtractEveryNMessages())
            {
                context.Writer.WritePropertyName("extractEveryNMessages");
                context.Writer.WriteNumberValue(requestObject.ExtractEveryNMessages.Value);
            }

            if (requestObject.IsSetExtractEveryNTokens())
            {
                context.Writer.WritePropertyName("extractEveryNTokens");
                context.Writer.WriteNumberValue(requestObject.ExtractEveryNTokens.Value);
            }

            if (requestObject.IsSetExtractionPrompt())
            {
                context.Writer.WritePropertyName("extractionPrompt");
                context.Writer.WriteStringValue(requestObject.ExtractionPrompt);
            }

            if (requestObject.IsSetExtractionSeedRecentN())
            {
                context.Writer.WritePropertyName("extractionSeedRecentN");
                context.Writer.WriteNumberValue(requestObject.ExtractionSeedRecentN.Value);
            }

            if (requestObject.IsSetExtractionSeedTopK())
            {
                context.Writer.WritePropertyName("extractionSeedTopK");
                context.Writer.WriteNumberValue(requestObject.ExtractionSeedTopK.Value);
            }

            if (requestObject.IsSetIdleTimeoutSeconds())
            {
                context.Writer.WritePropertyName("idleTimeoutSeconds");
                context.Writer.WriteNumberValue(requestObject.IdleTimeoutSeconds.Value);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static MemoryStrategyConfigurationMarshaller Instance = new MemoryStrategyConfigurationMarshaller();
    }
}
