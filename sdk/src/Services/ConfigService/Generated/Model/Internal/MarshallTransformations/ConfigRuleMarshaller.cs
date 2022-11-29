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
using ThirdParty.Json.LitJson;

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
            if(requestObject.IsSetConfigRuleArn())
            {
                context.Writer.WritePropertyName("ConfigRuleArn");
                context.Writer.Write(requestObject.ConfigRuleArn);
            }

            if(requestObject.IsSetConfigRuleId())
            {
                context.Writer.WritePropertyName("ConfigRuleId");
                context.Writer.Write(requestObject.ConfigRuleId);
            }

            if(requestObject.IsSetConfigRuleName())
            {
                context.Writer.WritePropertyName("ConfigRuleName");
                context.Writer.Write(requestObject.ConfigRuleName);
            }

            if(requestObject.IsSetConfigRuleState())
            {
                context.Writer.WritePropertyName("ConfigRuleState");
                context.Writer.Write(requestObject.ConfigRuleState);
            }

            if(requestObject.IsSetCreatedBy())
            {
                context.Writer.WritePropertyName("CreatedBy");
                context.Writer.Write(requestObject.CreatedBy);
            }

            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.Write(requestObject.Description);
            }

            if(requestObject.IsSetEvaluationModes())
            {
                context.Writer.WritePropertyName("EvaluationModes");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectEvaluationModesListValue in requestObject.EvaluationModes)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = EvaluationModeConfigurationMarshaller.Instance;
                    marshaller.Marshall(requestObjectEvaluationModesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetInputParameters())
            {
                context.Writer.WritePropertyName("InputParameters");
                context.Writer.Write(requestObject.InputParameters);
            }

            if(requestObject.IsSetMaximumExecutionFrequency())
            {
                context.Writer.WritePropertyName("MaximumExecutionFrequency");
                context.Writer.Write(requestObject.MaximumExecutionFrequency);
            }

            if(requestObject.IsSetScope())
            {
                context.Writer.WritePropertyName("Scope");
                context.Writer.WriteObjectStart();

                var marshaller = ScopeMarshaller.Instance;
                marshaller.Marshall(requestObject.Scope, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSource())
            {
                context.Writer.WritePropertyName("Source");
                context.Writer.WriteObjectStart();

                var marshaller = SourceMarshaller.Instance;
                marshaller.Marshall(requestObject.Source, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ConfigRuleMarshaller Instance = new ConfigRuleMarshaller();

    }
}