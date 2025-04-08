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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SimpleSystemsManagement.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SimpleSystemsManagement.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// BaselineOverride Marshaller
    /// </summary>
    public class BaselineOverrideMarshaller : IRequestMarshaller<BaselineOverride, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(BaselineOverride requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetApprovalRules())
            {
                context.Writer.WritePropertyName("ApprovalRules");
                context.Writer.WriteStartObject();

                var marshaller = PatchRuleGroupMarshaller.Instance;
                marshaller.Marshall(requestObject.ApprovalRules, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetApprovedPatches())
            {
                context.Writer.WritePropertyName("ApprovedPatches");
                context.Writer.WriteStartArray();
                foreach(var requestObjectApprovedPatchesListValue in requestObject.ApprovedPatches)
                {
                        context.Writer.WriteStringValue(requestObjectApprovedPatchesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetApprovedPatchesComplianceLevel())
            {
                context.Writer.WritePropertyName("ApprovedPatchesComplianceLevel");
                context.Writer.WriteStringValue(requestObject.ApprovedPatchesComplianceLevel);
            }

            if(requestObject.IsSetApprovedPatchesEnableNonSecurity())
            {
                context.Writer.WritePropertyName("ApprovedPatchesEnableNonSecurity");
                context.Writer.WriteBooleanValue(requestObject.ApprovedPatchesEnableNonSecurity.Value);
            }

            if(requestObject.IsSetAvailableSecurityUpdatesComplianceStatus())
            {
                context.Writer.WritePropertyName("AvailableSecurityUpdatesComplianceStatus");
                context.Writer.WriteStringValue(requestObject.AvailableSecurityUpdatesComplianceStatus);
            }

            if(requestObject.IsSetGlobalFilters())
            {
                context.Writer.WritePropertyName("GlobalFilters");
                context.Writer.WriteStartObject();

                var marshaller = PatchFilterGroupMarshaller.Instance;
                marshaller.Marshall(requestObject.GlobalFilters, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetOperatingSystem())
            {
                context.Writer.WritePropertyName("OperatingSystem");
                context.Writer.WriteStringValue(requestObject.OperatingSystem);
            }

            if(requestObject.IsSetRejectedPatches())
            {
                context.Writer.WritePropertyName("RejectedPatches");
                context.Writer.WriteStartArray();
                foreach(var requestObjectRejectedPatchesListValue in requestObject.RejectedPatches)
                {
                        context.Writer.WriteStringValue(requestObjectRejectedPatchesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetRejectedPatchesAction())
            {
                context.Writer.WritePropertyName("RejectedPatchesAction");
                context.Writer.WriteStringValue(requestObject.RejectedPatchesAction);
            }

            if(requestObject.IsSetSources())
            {
                context.Writer.WritePropertyName("Sources");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSourcesListValue in requestObject.Sources)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = PatchSourceMarshaller.Instance;
                    marshaller.Marshall(requestObjectSourcesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static BaselineOverrideMarshaller Instance = new BaselineOverrideMarshaller();

    }
}