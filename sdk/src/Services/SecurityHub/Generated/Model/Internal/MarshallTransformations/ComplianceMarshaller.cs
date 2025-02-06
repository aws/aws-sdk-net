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
    /// Compliance Marshaller
    /// </summary>
    public class ComplianceMarshaller : IRequestMarshaller<Compliance, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Compliance requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAssociatedStandards())
            {
                context.Writer.WritePropertyName("AssociatedStandards");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAssociatedStandardsListValue in requestObject.AssociatedStandards)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AssociatedStandardMarshaller.Instance;
                    marshaller.Marshall(requestObjectAssociatedStandardsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetRelatedRequirements())
            {
                context.Writer.WritePropertyName("RelatedRequirements");
                context.Writer.WriteStartArray();
                foreach(var requestObjectRelatedRequirementsListValue in requestObject.RelatedRequirements)
                {
                        context.Writer.WriteStringValue(requestObjectRelatedRequirementsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetSecurityControlId())
            {
                context.Writer.WritePropertyName("SecurityControlId");
                context.Writer.WriteStringValue(requestObject.SecurityControlId);
            }

            if(requestObject.IsSetSecurityControlParameters())
            {
                context.Writer.WritePropertyName("SecurityControlParameters");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSecurityControlParametersListValue in requestObject.SecurityControlParameters)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = SecurityControlParameterMarshaller.Instance;
                    marshaller.Marshall(requestObjectSecurityControlParametersListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetStatus())
            {
                context.Writer.WritePropertyName("Status");
                context.Writer.WriteStringValue(requestObject.Status);
            }

            if(requestObject.IsSetStatusReasons())
            {
                context.Writer.WritePropertyName("StatusReasons");
                context.Writer.WriteStartArray();
                foreach(var requestObjectStatusReasonsListValue in requestObject.StatusReasons)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StatusReasonMarshaller.Instance;
                    marshaller.Marshall(requestObjectStatusReasonsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ComplianceMarshaller Instance = new ComplianceMarshaller();

    }
}