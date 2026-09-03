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
 * Do not modify this file. This file is generated from the agent-registry-control-2025-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AgentRegistryControl.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.AgentRegistryControl.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Provenance Marshaller
    /// </summary>
    public class ProvenanceMarshaller : IRequestMarshaller<Provenance, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Provenance requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetRelation())
            {
                context.Writer.WritePropertyName("relation");
                context.Writer.WriteStringValue(requestObject.Relation);
            }

            if(requestObject.IsSetSourceDetails())
            {
                context.Writer.WritePropertyName("sourceDetails");
                context.Writer.WriteStartObject();

                var marshaller = SourceDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.SourceDetails, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSourceId())
            {
                context.Writer.WritePropertyName("sourceId");
                context.Writer.WriteStringValue(requestObject.SourceId);
            }

            if(requestObject.IsSetSourceType())
            {
                context.Writer.WritePropertyName("sourceType");
                context.Writer.WriteStringValue(requestObject.SourceType);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ProvenanceMarshaller Instance = new ProvenanceMarshaller();

    }
}