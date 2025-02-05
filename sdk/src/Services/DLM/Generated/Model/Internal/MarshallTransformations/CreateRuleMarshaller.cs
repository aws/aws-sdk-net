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
 * Do not modify this file. This file is generated from the dlm-2018-01-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DLM.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.DLM.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateRule Marshaller
    /// </summary>
    public class CreateRuleMarshaller : IRequestMarshaller<CreateRule, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CreateRule requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCronExpression())
            {
                context.Writer.WritePropertyName("CronExpression");
                context.Writer.WriteStringValue(requestObject.CronExpression);
            }

            if(requestObject.IsSetInterval())
            {
                context.Writer.WritePropertyName("Interval");
                context.Writer.WriteNumberValue(requestObject.Interval.Value);
            }

            if(requestObject.IsSetIntervalUnit())
            {
                context.Writer.WritePropertyName("IntervalUnit");
                context.Writer.WriteStringValue(requestObject.IntervalUnit);
            }

            if(requestObject.IsSetLocation())
            {
                context.Writer.WritePropertyName("Location");
                context.Writer.WriteStringValue(requestObject.Location);
            }

            if(requestObject.IsSetScripts())
            {
                context.Writer.WritePropertyName("Scripts");
                context.Writer.WriteStartArray();
                foreach(var requestObjectScriptsListValue in requestObject.Scripts)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ScriptMarshaller.Instance;
                    marshaller.Marshall(requestObjectScriptsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetTimes())
            {
                context.Writer.WritePropertyName("Times");
                context.Writer.WriteStartArray();
                foreach(var requestObjectTimesListValue in requestObject.Times)
                {
                        context.Writer.WriteStringValue(requestObjectTimesListValue);
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CreateRuleMarshaller Instance = new CreateRuleMarshaller();

    }
}