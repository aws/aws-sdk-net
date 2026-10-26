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

using Amazon.BedrockAgentCoreControl.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.BedrockAgentCoreControl.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SummaryMemoryStrategyInput Marshaller
    /// </summary>
    public partial class SummaryMemoryStrategyInputMarshaller : IRequestMarshaller<SummaryMemoryStrategyInput, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(SummaryMemoryStrategyInput requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(requestObject.Description);
            }

            if (requestObject.IsSetMemoryRecordSchema())
            {
                context.Writer.WritePropertyName("memoryRecordSchema");
                context.Writer.WriteStartObject();

                var marshaller = MemoryRecordSchemaMarshaller.Instance;
                marshaller.Marshall(requestObject.MemoryRecordSchema, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(requestObject.Name);
            }

            if (requestObject.IsSetNamespaceTemplates())
            {
                context.Writer.WritePropertyName("namespaceTemplates");
                context.Writer.WriteStartArray();
                foreach (var requestObjectNamespaceTemplatesListValue in requestObject.NamespaceTemplates)
                {
                    context.Writer.WriteStringValue(requestObjectNamespaceTemplatesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetNamespaces())
            {
                context.Writer.WritePropertyName("namespaces");
                context.Writer.WriteStartArray();
                foreach (var requestObjectNamespacesListValue in requestObject.Namespaces)
                {
                    context.Writer.WriteStringValue(requestObjectNamespacesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetRecordExpirySpecification())
            {
                context.Writer.WritePropertyName("recordExpirySpecification");
                context.Writer.WriteStartObject();

                var marshaller = RecordExpirySpecificationMarshaller.Instance;
                marshaller.Marshall(requestObject.RecordExpirySpecification, context);

                context.Writer.WriteEndObject();
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static SummaryMemoryStrategyInputMarshaller Instance = new SummaryMemoryStrategyInputMarshaller();
    }
}
