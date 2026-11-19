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

using Amazon.BedrockAgentCore.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.BedrockAgentCore.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GroundTruthConfig Marshaller
    /// </summary>
    public partial class GroundTruthConfigMarshaller : IRequestMarshaller<GroundTruthConfig, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(GroundTruthConfig requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetFields())
            {
                context.Writer.WritePropertyName("fields");
                context.Writer.WriteStartArray();
                foreach (var requestObjectFieldsListValue in requestObject.Fields)
                {
                    context.Writer.WriteStringValue(requestObjectFieldsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetQualityFilters())
            {
                context.Writer.WritePropertyName("qualityFilters");
                context.Writer.WriteStartArray();
                foreach (var requestObjectQualityFiltersListValue in requestObject.QualityFilters)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = EvaluatorFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectQualityFiltersListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static GroundTruthConfigMarshaller Instance = new GroundTruthConfigMarshaller();
    }
}
