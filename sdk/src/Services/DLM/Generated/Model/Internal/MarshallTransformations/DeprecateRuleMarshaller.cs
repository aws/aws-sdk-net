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
    /// DeprecateRule Marshaller
    /// </summary>
    public class DeprecateRuleMarshaller : IRequestMarshaller<DeprecateRule, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DeprecateRule requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCount())
            {
                context.Writer.WritePropertyName("Count");
                context.Writer.WriteNumberValue(requestObject.Count.Value);
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

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DeprecateRuleMarshaller Instance = new DeprecateRuleMarshaller();

    }
}