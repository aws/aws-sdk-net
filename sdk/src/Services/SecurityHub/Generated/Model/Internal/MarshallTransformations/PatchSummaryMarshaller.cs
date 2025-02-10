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
    /// PatchSummary Marshaller
    /// </summary>
    public class PatchSummaryMarshaller : IRequestMarshaller<PatchSummary, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(PatchSummary requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetFailedCount())
            {
                context.Writer.WritePropertyName("FailedCount");
                context.Writer.WriteNumberValue(requestObject.FailedCount.Value);
            }

            if(requestObject.IsSetId())
            {
                context.Writer.WritePropertyName("Id");
                context.Writer.WriteStringValue(requestObject.Id);
            }

            if(requestObject.IsSetInstalledCount())
            {
                context.Writer.WritePropertyName("InstalledCount");
                context.Writer.WriteNumberValue(requestObject.InstalledCount.Value);
            }

            if(requestObject.IsSetInstalledOtherCount())
            {
                context.Writer.WritePropertyName("InstalledOtherCount");
                context.Writer.WriteNumberValue(requestObject.InstalledOtherCount.Value);
            }

            if(requestObject.IsSetInstalledPendingReboot())
            {
                context.Writer.WritePropertyName("InstalledPendingReboot");
                context.Writer.WriteNumberValue(requestObject.InstalledPendingReboot.Value);
            }

            if(requestObject.IsSetInstalledRejectedCount())
            {
                context.Writer.WritePropertyName("InstalledRejectedCount");
                context.Writer.WriteNumberValue(requestObject.InstalledRejectedCount.Value);
            }

            if(requestObject.IsSetMissingCount())
            {
                context.Writer.WritePropertyName("MissingCount");
                context.Writer.WriteNumberValue(requestObject.MissingCount.Value);
            }

            if(requestObject.IsSetOperation())
            {
                context.Writer.WritePropertyName("Operation");
                context.Writer.WriteStringValue(requestObject.Operation);
            }

            if(requestObject.IsSetOperationEndTime())
            {
                context.Writer.WritePropertyName("OperationEndTime");
                context.Writer.WriteStringValue(requestObject.OperationEndTime);
            }

            if(requestObject.IsSetOperationStartTime())
            {
                context.Writer.WritePropertyName("OperationStartTime");
                context.Writer.WriteStringValue(requestObject.OperationStartTime);
            }

            if(requestObject.IsSetRebootOption())
            {
                context.Writer.WritePropertyName("RebootOption");
                context.Writer.WriteStringValue(requestObject.RebootOption);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static PatchSummaryMarshaller Instance = new PatchSummaryMarshaller();

    }
}