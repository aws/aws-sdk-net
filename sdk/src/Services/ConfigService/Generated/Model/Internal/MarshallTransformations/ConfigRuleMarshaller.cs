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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ConfigService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ConfigService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ConfigRule Marshaller
    /// </summary>
    public class ConfigRuleMarshaller : IRequestMarshaller<ConfigRule, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ConfigRule requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetConfigRuleArn())
            {
                context.Writer.WritePropertyName("ConfigRuleArn");
                context.Writer.WriteStringValue(requestObject.ConfigRuleArn);
            }

            if(requestObject.IsSetConfigRuleId())
            {
                context.Writer.WritePropertyName("ConfigRuleId");
                context.Writer.WriteStringValue(requestObject.ConfigRuleId);
            }

            if(requestObject.IsSetConfigRuleName())
            {
                context.Writer.WritePropertyName("ConfigRuleName");
                context.Writer.WriteStringValue(requestObject.ConfigRuleName);
            }

            if(requestObject.IsSetConfigRuleState())
            {
                context.Writer.WritePropertyName("ConfigRuleState");
                context.Writer.WriteStringValue(requestObject.ConfigRuleState);
            }

            if(requestObject.IsSetCreatedBy())
            {
                context.Writer.WritePropertyName("CreatedBy");
                context.Writer.WriteStringValue(requestObject.CreatedBy);
            }

            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(requestObject.Description);
            }

            if(requestObject.IsSetEvaluationModes())
            {
                context.Writer.WritePropertyName("EvaluationModes");
                context.Writer.WriteStartArray();
                foreach(var requestObjectEvaluationModesListValue in requestObject.EvaluationModes)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = EvaluationModeConfigurationMarshaller.Instance;
                    marshaller.Marshall(requestObjectEvaluationModesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetInputParameters())
            {
                context.Writer.WritePropertyName("InputParameters");
                context.Writer.WriteStringValue(requestObject.InputParameters);
            }

            if(requestObject.IsSetMaximumExecutionFrequency())
            {
                context.Writer.WritePropertyName("MaximumExecutionFrequency");
                context.Writer.WriteStringValue(requestObject.MaximumExecutionFrequency);
            }

            if(requestObject.IsSetScope())
            {
                context.Writer.WritePropertyName("Scope");
                context.Writer.WriteStartObject();

                var marshaller = ScopeMarshaller.Instance;
                marshaller.Marshall(requestObject.Scope, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSource())
            {
                context.Writer.WritePropertyName("Source");
                context.Writer.WriteStartObject();

                var marshaller = SourceMarshaller.Instance;
                marshaller.Marshall(requestObject.Source, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ConfigRuleMarshaller Instance = new ConfigRuleMarshaller();

    }
}