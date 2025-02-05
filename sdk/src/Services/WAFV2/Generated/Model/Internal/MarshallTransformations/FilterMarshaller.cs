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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.WAFV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.WAFV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Filter Marshaller
    /// </summary>
    public class FilterMarshaller : IRequestMarshaller<Filter, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Filter requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBehavior())
            {
                context.Writer.WritePropertyName("Behavior");
                context.Writer.WriteStringValue(requestObject.Behavior);
            }

            if(requestObject.IsSetConditions())
            {
                context.Writer.WritePropertyName("Conditions");
                context.Writer.WriteStartArray();
                foreach(var requestObjectConditionsListValue in requestObject.Conditions)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ConditionMarshaller.Instance;
                    marshaller.Marshall(requestObjectConditionsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetRequirement())
            {
                context.Writer.WritePropertyName("Requirement");
                context.Writer.WriteStringValue(requestObject.Requirement);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static FilterMarshaller Instance = new FilterMarshaller();

    }
}