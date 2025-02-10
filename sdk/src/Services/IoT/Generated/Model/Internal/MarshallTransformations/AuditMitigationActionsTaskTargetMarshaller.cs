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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoT.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.IoT.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AuditMitigationActionsTaskTarget Marshaller
    /// </summary>
    public class AuditMitigationActionsTaskTargetMarshaller : IRequestMarshaller<AuditMitigationActionsTaskTarget, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AuditMitigationActionsTaskTarget requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAuditCheckToReasonCodeFilter())
            {
                context.Writer.WritePropertyName("auditCheckToReasonCodeFilter");
                context.Writer.WriteStartObject();
                foreach (var requestObjectAuditCheckToReasonCodeFilterKvp in requestObject.AuditCheckToReasonCodeFilter)
                {
                    context.Writer.WritePropertyName(requestObjectAuditCheckToReasonCodeFilterKvp.Key);
                    var requestObjectAuditCheckToReasonCodeFilterValue = requestObjectAuditCheckToReasonCodeFilterKvp.Value;

                    context.Writer.WriteStartArray();
                    foreach(var requestObjectAuditCheckToReasonCodeFilterValueListValue in requestObjectAuditCheckToReasonCodeFilterValue)
                    {
                            context.Writer.WriteStringValue(requestObjectAuditCheckToReasonCodeFilterValueListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAuditTaskId())
            {
                context.Writer.WritePropertyName("auditTaskId");
                context.Writer.WriteStringValue(requestObject.AuditTaskId);
            }

            if(requestObject.IsSetFindingIds())
            {
                context.Writer.WritePropertyName("findingIds");
                context.Writer.WriteStartArray();
                foreach(var requestObjectFindingIdsListValue in requestObject.FindingIds)
                {
                        context.Writer.WriteStringValue(requestObjectFindingIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AuditMitigationActionsTaskTargetMarshaller Instance = new AuditMitigationActionsTaskTargetMarshaller();

    }
}