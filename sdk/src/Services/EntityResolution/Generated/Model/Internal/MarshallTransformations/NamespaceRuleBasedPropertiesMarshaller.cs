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
 * Do not modify this file. This file is generated from the entityresolution-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EntityResolution.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.EntityResolution.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// NamespaceRuleBasedProperties Marshaller
    /// </summary>
    public class NamespaceRuleBasedPropertiesMarshaller : IRequestMarshaller<NamespaceRuleBasedProperties, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(NamespaceRuleBasedProperties requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAttributeMatchingModel())
            {
                context.Writer.WritePropertyName("attributeMatchingModel");
                context.Writer.Write(requestObject.AttributeMatchingModel);
            }

            if(requestObject.IsSetRecordMatchingModels())
            {
                context.Writer.WritePropertyName("recordMatchingModels");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectRecordMatchingModelsListValue in requestObject.RecordMatchingModels)
                {
                        context.Writer.Write(requestObjectRecordMatchingModelsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetRuleDefinitionTypes())
            {
                context.Writer.WritePropertyName("ruleDefinitionTypes");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectRuleDefinitionTypesListValue in requestObject.RuleDefinitionTypes)
                {
                        context.Writer.Write(requestObjectRuleDefinitionTypesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetRules())
            {
                context.Writer.WritePropertyName("rules");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectRulesListValue in requestObject.Rules)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = RuleMarshaller.Instance;
                    marshaller.Marshall(requestObjectRulesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static NamespaceRuleBasedPropertiesMarshaller Instance = new NamespaceRuleBasedPropertiesMarshaller();

    }
}