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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.QuickSight.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// TopicNamedEntity Marshaller
    /// </summary>
    public class TopicNamedEntityMarshaller : IRequestMarshaller<TopicNamedEntity, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(TopicNamedEntity requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDefinition())
            {
                context.Writer.WritePropertyName("Definition");
                context.Writer.WriteStartArray();
                foreach(var requestObjectDefinitionListValue in requestObject.Definition)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = NamedEntityDefinitionMarshaller.Instance;
                    marshaller.Marshall(requestObjectDefinitionListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetEntityDescription())
            {
                context.Writer.WritePropertyName("EntityDescription");
                context.Writer.WriteStringValue(requestObject.EntityDescription);
            }

            if(requestObject.IsSetEntityName())
            {
                context.Writer.WritePropertyName("EntityName");
                context.Writer.WriteStringValue(requestObject.EntityName);
            }

            if(requestObject.IsSetEntitySynonyms())
            {
                context.Writer.WritePropertyName("EntitySynonyms");
                context.Writer.WriteStartArray();
                foreach(var requestObjectEntitySynonymsListValue in requestObject.EntitySynonyms)
                {
                        context.Writer.WriteStringValue(requestObjectEntitySynonymsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetSemanticEntityType())
            {
                context.Writer.WritePropertyName("SemanticEntityType");
                context.Writer.WriteStartObject();

                var marshaller = SemanticEntityTypeMarshaller.Instance;
                marshaller.Marshall(requestObject.SemanticEntityType, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static TopicNamedEntityMarshaller Instance = new TopicNamedEntityMarshaller();

    }
}