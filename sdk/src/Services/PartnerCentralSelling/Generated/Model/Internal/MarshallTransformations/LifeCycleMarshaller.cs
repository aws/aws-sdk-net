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
 * Do not modify this file. This file is generated from the partnercentral-selling-2022-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.PartnerCentralSelling.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.PartnerCentralSelling.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// LifeCycle Marshaller
    /// </summary>
    public class LifeCycleMarshaller : IRequestMarshaller<LifeCycle, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(LifeCycle requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetClosedLostReason())
            {
                context.Writer.WritePropertyName("ClosedLostReason");
                context.Writer.WriteStringValue(requestObject.ClosedLostReason);
            }

            if(requestObject.IsSetNextSteps())
            {
                context.Writer.WritePropertyName("NextSteps");
                context.Writer.WriteStringValue(requestObject.NextSteps);
            }

            if(requestObject.IsSetNextStepsHistory())
            {
                context.Writer.WritePropertyName("NextStepsHistory");
                context.Writer.WriteStartArray();
                foreach(var requestObjectNextStepsHistoryListValue in requestObject.NextStepsHistory)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = NextStepsHistoryMarshaller.Instance;
                    marshaller.Marshall(requestObjectNextStepsHistoryListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetReviewComments())
            {
                context.Writer.WritePropertyName("ReviewComments");
                context.Writer.WriteStringValue(requestObject.ReviewComments);
            }

            if(requestObject.IsSetReviewStatus())
            {
                context.Writer.WritePropertyName("ReviewStatus");
                context.Writer.WriteStringValue(requestObject.ReviewStatus);
            }

            if(requestObject.IsSetReviewStatusReason())
            {
                context.Writer.WritePropertyName("ReviewStatusReason");
                context.Writer.WriteStringValue(requestObject.ReviewStatusReason);
            }

            if(requestObject.IsSetStage())
            {
                context.Writer.WritePropertyName("Stage");
                context.Writer.WriteStringValue(requestObject.Stage);
            }

            if(requestObject.IsSetTargetCloseDate())
            {
                context.Writer.WritePropertyName("TargetCloseDate");
                context.Writer.WriteStringValue(requestObject.TargetCloseDate);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static LifeCycleMarshaller Instance = new LifeCycleMarshaller();

    }
}