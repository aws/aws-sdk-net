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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BedrockAgentCoreControl.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockAgentCoreControl.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CustomConsolidationConfigurationInput Marshaller
    /// </summary>
    public class CustomConsolidationConfigurationInputMarshaller : IRequestMarshaller<CustomConsolidationConfigurationInput, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CustomConsolidationConfigurationInput requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetSemanticConsolidationOverride())
            {
                context.Writer.WritePropertyName("semanticConsolidationOverride");
                context.Writer.WriteObjectStart();

                var marshaller = SemanticOverrideConsolidationConfigurationInputMarshaller.Instance;
                marshaller.Marshall(requestObject.SemanticConsolidationOverride, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSummaryConsolidationOverride())
            {
                context.Writer.WritePropertyName("summaryConsolidationOverride");
                context.Writer.WriteObjectStart();

                var marshaller = SummaryOverrideConsolidationConfigurationInputMarshaller.Instance;
                marshaller.Marshall(requestObject.SummaryConsolidationOverride, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetUserPreferenceConsolidationOverride())
            {
                context.Writer.WritePropertyName("userPreferenceConsolidationOverride");
                context.Writer.WriteObjectStart();

                var marshaller = UserPreferenceOverrideConsolidationConfigurationInputMarshaller.Instance;
                marshaller.Marshall(requestObject.UserPreferenceConsolidationOverride, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CustomConsolidationConfigurationInputMarshaller Instance = new CustomConsolidationConfigurationInputMarshaller();

    }
}