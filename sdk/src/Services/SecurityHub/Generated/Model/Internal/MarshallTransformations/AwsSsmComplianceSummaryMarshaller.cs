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
    /// AwsSsmComplianceSummary Marshaller
    /// </summary>
    public class AwsSsmComplianceSummaryMarshaller : IRequestMarshaller<AwsSsmComplianceSummary, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsSsmComplianceSummary requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetComplianceType())
            {
                context.Writer.WritePropertyName("ComplianceType");
                context.Writer.Write(requestObject.ComplianceType);
            }

            if(requestObject.IsSetCompliantCriticalCount())
            {
                context.Writer.WritePropertyName("CompliantCriticalCount");
                context.Writer.Write(requestObject.CompliantCriticalCount);
            }

            if(requestObject.IsSetCompliantHighCount())
            {
                context.Writer.WritePropertyName("CompliantHighCount");
                context.Writer.Write(requestObject.CompliantHighCount);
            }

            if(requestObject.IsSetCompliantInformationalCount())
            {
                context.Writer.WritePropertyName("CompliantInformationalCount");
                context.Writer.Write(requestObject.CompliantInformationalCount);
            }

            if(requestObject.IsSetCompliantLowCount())
            {
                context.Writer.WritePropertyName("CompliantLowCount");
                context.Writer.Write(requestObject.CompliantLowCount);
            }

            if(requestObject.IsSetCompliantMediumCount())
            {
                context.Writer.WritePropertyName("CompliantMediumCount");
                context.Writer.Write(requestObject.CompliantMediumCount);
            }

            if(requestObject.IsSetCompliantUnspecifiedCount())
            {
                context.Writer.WritePropertyName("CompliantUnspecifiedCount");
                context.Writer.Write(requestObject.CompliantUnspecifiedCount);
            }

            if(requestObject.IsSetExecutionType())
            {
                context.Writer.WritePropertyName("ExecutionType");
                context.Writer.Write(requestObject.ExecutionType);
            }

            if(requestObject.IsSetNonCompliantCriticalCount())
            {
                context.Writer.WritePropertyName("NonCompliantCriticalCount");
                context.Writer.Write(requestObject.NonCompliantCriticalCount);
            }

            if(requestObject.IsSetNonCompliantHighCount())
            {
                context.Writer.WritePropertyName("NonCompliantHighCount");
                context.Writer.Write(requestObject.NonCompliantHighCount);
            }

            if(requestObject.IsSetNonCompliantInformationalCount())
            {
                context.Writer.WritePropertyName("NonCompliantInformationalCount");
                context.Writer.Write(requestObject.NonCompliantInformationalCount);
            }

            if(requestObject.IsSetNonCompliantLowCount())
            {
                context.Writer.WritePropertyName("NonCompliantLowCount");
                context.Writer.Write(requestObject.NonCompliantLowCount);
            }

            if(requestObject.IsSetNonCompliantMediumCount())
            {
                context.Writer.WritePropertyName("NonCompliantMediumCount");
                context.Writer.Write(requestObject.NonCompliantMediumCount);
            }

            if(requestObject.IsSetNonCompliantUnspecifiedCount())
            {
                context.Writer.WritePropertyName("NonCompliantUnspecifiedCount");
                context.Writer.Write(requestObject.NonCompliantUnspecifiedCount);
            }

            if(requestObject.IsSetOverallSeverity())
            {
                context.Writer.WritePropertyName("OverallSeverity");
                context.Writer.Write(requestObject.OverallSeverity);
            }

            if(requestObject.IsSetPatchBaselineId())
            {
                context.Writer.WritePropertyName("PatchBaselineId");
                context.Writer.Write(requestObject.PatchBaselineId);
            }

            if(requestObject.IsSetPatchGroup())
            {
                context.Writer.WritePropertyName("PatchGroup");
                context.Writer.Write(requestObject.PatchGroup);
            }

            if(requestObject.IsSetStatus())
            {
                context.Writer.WritePropertyName("Status");
                context.Writer.Write(requestObject.Status);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsSsmComplianceSummaryMarshaller Instance = new AwsSsmComplianceSummaryMarshaller();

    }
}