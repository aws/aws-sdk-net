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
 * Do not modify this file. This file is generated from the clouddirectory-2017-01-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudDirectory.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.CloudDirectory.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// FacetAttributeDefinition Marshaller
    /// </summary>
    public class FacetAttributeDefinitionMarshaller : IRequestMarshaller<FacetAttributeDefinition, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(FacetAttributeDefinition requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDefaultValue())
            {
                context.Writer.WritePropertyName("DefaultValue");
                context.Writer.WriteStartObject();

                var marshaller = TypedAttributeValueMarshaller.Instance;
                marshaller.Marshall(requestObject.DefaultValue, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetIsImmutable())
            {
                context.Writer.WritePropertyName("IsImmutable");
                context.Writer.WriteBooleanValue(requestObject.IsImmutable.Value);
            }

            if(requestObject.IsSetRules())
            {
                context.Writer.WritePropertyName("Rules");
                context.Writer.WriteStartObject();
                foreach (var requestObjectRulesKvp in requestObject.Rules)
                {
                    context.Writer.WritePropertyName(requestObjectRulesKvp.Key);
                    var requestObjectRulesValue = requestObjectRulesKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = RuleMarshaller.Instance;
                    marshaller.Marshall(requestObjectRulesValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetType())
            {
                context.Writer.WritePropertyName("Type");
                context.Writer.WriteStringValue(requestObject.Type);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static FacetAttributeDefinitionMarshaller Instance = new FacetAttributeDefinitionMarshaller();

    }
}