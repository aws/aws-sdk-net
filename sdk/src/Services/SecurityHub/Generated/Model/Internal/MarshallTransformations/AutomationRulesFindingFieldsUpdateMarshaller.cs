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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AutomationRulesFindingFieldsUpdate Marshaller
    /// </summary>
    public class AutomationRulesFindingFieldsUpdateMarshaller : IRequestMarshaller<AutomationRulesFindingFieldsUpdate, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AutomationRulesFindingFieldsUpdate requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetConfidence())
            {
                context.Writer.WritePropertyName("Confidence");
                context.Writer.WriteNumberValue(requestObject.Confidence.Value);
            }

            if(requestObject.IsSetCriticality())
            {
                context.Writer.WritePropertyName("Criticality");
                context.Writer.WriteNumberValue(requestObject.Criticality.Value);
            }

            if(requestObject.IsSetNote())
            {
                context.Writer.WritePropertyName("Note");
                context.Writer.WriteStartObject();

                var marshaller = NoteUpdateMarshaller.Instance;
                marshaller.Marshall(requestObject.Note, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRelatedFindings())
            {
                context.Writer.WritePropertyName("RelatedFindings");
                context.Writer.WriteStartArray();
                foreach(var requestObjectRelatedFindingsListValue in requestObject.RelatedFindings)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = RelatedFindingMarshaller.Instance;
                    marshaller.Marshall(requestObjectRelatedFindingsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetSeverity())
            {
                context.Writer.WritePropertyName("Severity");
                context.Writer.WriteStartObject();

                var marshaller = SeverityUpdateMarshaller.Instance;
                marshaller.Marshall(requestObject.Severity, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTypes())
            {
                context.Writer.WritePropertyName("Types");
                context.Writer.WriteStartArray();
                foreach(var requestObjectTypesListValue in requestObject.Types)
                {
                        context.Writer.WriteStringValue(requestObjectTypesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetUserDefinedFields())
            {
                context.Writer.WritePropertyName("UserDefinedFields");
                context.Writer.WriteStartObject();
                foreach (var requestObjectUserDefinedFieldsKvp in requestObject.UserDefinedFields)
                {
                    context.Writer.WritePropertyName(requestObjectUserDefinedFieldsKvp.Key);
                    var requestObjectUserDefinedFieldsValue = requestObjectUserDefinedFieldsKvp.Value;

                        context.Writer.WriteStringValue(requestObjectUserDefinedFieldsValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetVerificationState())
            {
                context.Writer.WritePropertyName("VerificationState");
                context.Writer.WriteStringValue(requestObject.VerificationState);
            }

            if(requestObject.IsSetWorkflow())
            {
                context.Writer.WritePropertyName("Workflow");
                context.Writer.WriteStartObject();

                var marshaller = WorkflowUpdateMarshaller.Instance;
                marshaller.Marshall(requestObject.Workflow, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AutomationRulesFindingFieldsUpdateMarshaller Instance = new AutomationRulesFindingFieldsUpdateMarshaller();

    }
}