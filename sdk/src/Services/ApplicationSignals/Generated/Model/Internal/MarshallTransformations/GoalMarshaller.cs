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
 * Do not modify this file. This file is generated from the application-signals-2024-04-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ApplicationSignals.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.ApplicationSignals.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Goal Marshaller
    /// </summary>
    public class GoalMarshaller : IRequestMarshaller<Goal, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Goal requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAttainmentGoal())
            {
                context.Writer.WritePropertyName("AttainmentGoal");
                if(StringUtils.IsSpecialDoubleValue(requestObject.AttainmentGoal))
                {
                    context.Writer.Write(StringUtils.FromSpecialDoubleValue(requestObject.AttainmentGoal));
                }
                else
                {
                    context.Writer.Write(requestObject.AttainmentGoal);
                }
            }

            if(requestObject.IsSetInterval())
            {
                context.Writer.WritePropertyName("Interval");
                context.Writer.WriteObjectStart();

                var marshaller = IntervalMarshaller.Instance;
                marshaller.Marshall(requestObject.Interval, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetWarningThreshold())
            {
                context.Writer.WritePropertyName("WarningThreshold");
                if(StringUtils.IsSpecialDoubleValue(requestObject.WarningThreshold))
                {
                    context.Writer.Write(StringUtils.FromSpecialDoubleValue(requestObject.WarningThreshold));
                }
                else
                {
                    context.Writer.Write(requestObject.WarningThreshold);
                }
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static GoalMarshaller Instance = new GoalMarshaller();

    }
}