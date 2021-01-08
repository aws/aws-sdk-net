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
using ThirdParty.Json.LitJson;

namespace Amazon.CloudDirectory.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// TypedLinkAttributeDefinition Marshaller
    /// </summary>       
    public class TypedLinkAttributeDefinitionMarshaller : IRequestMarshaller<TypedLinkAttributeDefinition, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(TypedLinkAttributeDefinition requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetDefaultValue())
            {
                context.Writer.WritePropertyName("DefaultValue");
                context.Writer.WriteObjectStart();

                var marshaller = TypedAttributeValueMarshaller.Instance;
                marshaller.Marshall(requestObject.DefaultValue, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetIsImmutable())
            {
                context.Writer.WritePropertyName("IsImmutable");
                context.Writer.Write(requestObject.IsImmutable);
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.Write(requestObject.Name);
            }

            if(requestObject.IsSetRequiredBehavior())
            {
                context.Writer.WritePropertyName("RequiredBehavior");
                context.Writer.Write(requestObject.RequiredBehavior);
            }

            if(requestObject.IsSetRules())
            {
                context.Writer.WritePropertyName("Rules");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectRulesKvp in requestObject.Rules)
                {
                    context.Writer.WritePropertyName(requestObjectRulesKvp.Key);
                    var requestObjectRulesValue = requestObjectRulesKvp.Value;

                    context.Writer.WriteObjectStart();

                    var marshaller = RuleMarshaller.Instance;
                    marshaller.Marshall(requestObjectRulesValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetType())
            {
                context.Writer.WritePropertyName("Type");
                context.Writer.Write(requestObject.Type);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static TypedLinkAttributeDefinitionMarshaller Instance = new TypedLinkAttributeDefinitionMarshaller();

    }
}