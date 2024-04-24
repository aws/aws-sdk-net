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
using ThirdParty.Json.LitJson;

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
                context.Writer.WriteObjectStart();

                var marshaller = AttributeTypesSelectorMarshaller.Instance;
                marshaller.Marshall(requestObject.AttributeTypesSelector, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetConflictResolution())
            {
                context.Writer.WritePropertyName("ConflictResolution");
                context.Writer.WriteObjectStart();

                var marshaller = ConflictResolutionMarshaller.Instance;
                marshaller.Marshall(requestObject.ConflictResolution, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetEnabled())
            {
                context.Writer.WritePropertyName("Enabled");
                context.Writer.Write(requestObject.Enabled);
            }

            if(requestObject.IsSetExportingConfig())
            {
                context.Writer.WritePropertyName("ExportingConfig");
                context.Writer.WriteObjectStart();

                var marshaller = ExportingConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.ExportingConfig, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetMatchingRules())
            {
                context.Writer.WritePropertyName("MatchingRules");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectMatchingRulesListValue in requestObject.MatchingRules)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = MatchingRuleMarshaller.Instance;
                    marshaller.Marshall(requestObjectMatchingRulesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetMaxAllowedRuleLevelForMatching())
            {
                context.Writer.WritePropertyName("MaxAllowedRuleLevelForMatching");
                context.Writer.Write(requestObject.MaxAllowedRuleLevelForMatching);
            }

            if(requestObject.IsSetMaxAllowedRuleLevelForMerging())
            {
                context.Writer.WritePropertyName("MaxAllowedRuleLevelForMerging");
                context.Writer.Write(requestObject.MaxAllowedRuleLevelForMerging);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RuleBasedMatchingRequestMarshaller Instance = new RuleBasedMatchingRequestMarshaller();

    }
}