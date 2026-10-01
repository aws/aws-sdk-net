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
 * Do not modify this file. This file is generated from the cloudwatchomni-2025-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudWatchOmni.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.CloudWatchOmni.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// TelemetryRule Marshaller
    /// </summary>
    public class TelemetryRuleMarshaller : IRequestMarshaller<TelemetryRule, CborMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(TelemetryRule requestObject, CborMarshallerContext context)
        {
            if (requestObject == null)
                return;

            if (requestObject.IsSetCondition())
            {
                context.Writer.WriteTextString("condition");
                context.Writer.WriteStartMap(null);

                var marshaller = AlertConditionMarshaller.Instance;
                marshaller.Marshall(requestObject.Condition, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetEvaluation())
            {
                context.Writer.WriteTextString("evaluation");
                context.Writer.WriteStartMap(null);

                var marshaller = AlertEvaluationMarshaller.Instance;
                marshaller.Marshall(requestObject.Evaluation, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetNoData())
            {
                context.Writer.WriteTextString("noData");
                context.Writer.WriteStartMap(null);

                var marshaller = NoDataMarshaller.Instance;
                marshaller.Marshall(requestObject.NoData, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetQuery())
            {
                context.Writer.WriteTextString("query");
                context.Writer.WriteStartMap(null);

                var marshaller = AlertRuleQueryMarshaller.Instance;
                marshaller.Marshall(requestObject.Query, context);

                context.Writer.WriteEndMap();
            }
        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static TelemetryRuleMarshaller Instance = new TelemetryRuleMarshaller();

    }
}