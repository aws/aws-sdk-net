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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CustomerProfiles.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.CustomerProfiles.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RuleBasedMatchingRequest Marshaller
    /// </summary>
    public class RuleBasedMatchingRequestMarshaller : IRequestMarshaller<RuleBasedMatchingRequest, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RuleBasedMatchingRequest requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAttributeTypesSelector())
            {
                context.Writer.WritePropertyName("AttributeTypesSelector");
                context.Writer.WriteStartObject();

                var marshaller = AttributeTypesSelectorMarshaller.Instance;
                marshaller.Marshall(requestObject.AttributeTypesSelector, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetConflictResolution())
            {
                context.Writer.WritePropertyName("ConflictResolution");
                context.Writer.WriteStartObject();

                var marshaller = ConflictResolutionMarshaller.Instance;
                marshaller.Marshall(requestObject.ConflictResolution, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetEnabled())
            {
                context.Writer.WritePropertyName("Enabled");
                context.Writer.WriteBooleanValue(requestObject.Enabled.Value);
            }

            if(requestObject.IsSetExportingConfig())
            {
                context.Writer.WritePropertyName("ExportingConfig");
                context.Writer.WriteStartObject();

                var marshaller = ExportingConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.ExportingConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMatchingRules())
            {
                context.Writer.WritePropertyName("MatchingRules");
                context.Writer.WriteStartArray();
                foreach(var requestObjectMatchingRulesListValue in requestObject.MatchingRules)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = MatchingRuleMarshaller.Instance;
                    marshaller.Marshall(requestObjectMatchingRulesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetMaxAllowedRuleLevelForMatching())
            {
                context.Writer.WritePropertyName("MaxAllowedRuleLevelForMatching");
                context.Writer.WriteNumberValue(requestObject.MaxAllowedRuleLevelForMatching.Value);
            }

            if(requestObject.IsSetMaxAllowedRuleLevelForMerging())
            {
                context.Writer.WritePropertyName("MaxAllowedRuleLevelForMerging");
                context.Writer.WriteNumberValue(requestObject.MaxAllowedRuleLevelForMerging.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RuleBasedMatchingRequestMarshaller Instance = new RuleBasedMatchingRequestMarshaller();

    }
}