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
using ThirdParty.Json.LitJson;

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
            if(requestObject.IsSetConfidence())
            {
                context.Writer.WritePropertyName("Confidence");
                context.Writer.Write(requestObject.Confidence);
            }

            if(requestObject.IsSetCriticality())
            {
                context.Writer.WritePropertyName("Criticality");
                context.Writer.Write(requestObject.Criticality);
            }

            if(requestObject.IsSetNote())
            {
                context.Writer.WritePropertyName("Note");
                context.Writer.WriteObjectStart();

                var marshaller = NoteUpdateMarshaller.Instance;
                marshaller.Marshall(requestObject.Note, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetRelatedFindings())
            {
                context.Writer.WritePropertyName("RelatedFindings");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectRelatedFindingsListValue in requestObject.RelatedFindings)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = RelatedFindingMarshaller.Instance;
                    marshaller.Marshall(requestObjectRelatedFindingsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetSeverity())
            {
                context.Writer.WritePropertyName("Severity");
                context.Writer.WriteObjectStart();

                var marshaller = SeverityUpdateMarshaller.Instance;
                marshaller.Marshall(requestObject.Severity, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTypes())
            {
                context.Writer.WritePropertyName("Types");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectTypesListValue in requestObject.Types)
                {
                        context.Writer.Write(requestObjectTypesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetUserDefinedFields())
            {
                context.Writer.WritePropertyName("UserDefinedFields");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectUserDefinedFieldsKvp in requestObject.UserDefinedFields)
                {
                    context.Writer.WritePropertyName(requestObjectUserDefinedFieldsKvp.Key);
                    var requestObjectUserDefinedFieldsValue = requestObjectUserDefinedFieldsKvp.Value;

                        context.Writer.Write(requestObjectUserDefinedFieldsValue);
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetVerificationState())
            {
                context.Writer.WritePropertyName("VerificationState");
                context.Writer.Write(requestObject.VerificationState);
            }

            if(requestObject.IsSetWorkflow())
            {
                context.Writer.WritePropertyName("Workflow");
                context.Writer.WriteObjectStart();

                var marshaller = WorkflowUpdateMarshaller.Instance;
                marshaller.Marshall(requestObject.Workflow, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AutomationRulesFindingFieldsUpdateMarshaller Instance = new AutomationRulesFindingFieldsUpdateMarshaller();

    }
}