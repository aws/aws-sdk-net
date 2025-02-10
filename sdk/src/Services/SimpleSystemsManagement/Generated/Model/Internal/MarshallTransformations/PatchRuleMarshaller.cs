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
    /// PatchRule Marshaller
    /// </summary>
    public class PatchRuleMarshaller : IRequestMarshaller<PatchRule, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(PatchRule requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetApproveAfterDays())
            {
                context.Writer.WritePropertyName("ApproveAfterDays");
                context.Writer.WriteNumberValue(requestObject.ApproveAfterDays.Value);
            }

            if(requestObject.IsSetApproveUntilDate())
            {
                context.Writer.WritePropertyName("ApproveUntilDate");
                context.Writer.WriteStringValue(requestObject.ApproveUntilDate);
            }

            if(requestObject.IsSetComplianceLevel())
            {
                context.Writer.WritePropertyName("ComplianceLevel");
                context.Writer.WriteStringValue(requestObject.ComplianceLevel);
            }

            if(requestObject.IsSetEnableNonSecurity())
            {
                context.Writer.WritePropertyName("EnableNonSecurity");
                context.Writer.WriteBooleanValue(requestObject.EnableNonSecurity.Value);
            }

            if(requestObject.IsSetPatchFilterGroup())
            {
                context.Writer.WritePropertyName("PatchFilterGroup");
                context.Writer.WriteStartObject();

                var marshaller = PatchFilterGroupMarshaller.Instance;
                marshaller.Marshall(requestObject.PatchFilterGroup, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static PatchRuleMarshaller Instance = new PatchRuleMarshaller();

    }
}