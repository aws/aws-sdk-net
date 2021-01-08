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
using ThirdParty.Json.LitJson;

namespace Amazon.DLM.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// FastRestoreRule Marshaller
    /// </summary>       
    public class FastRestoreRuleMarshaller : IRequestMarshaller<FastRestoreRule, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(FastRestoreRule requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAvailabilityZones())
            {
                context.Writer.WritePropertyName("AvailabilityZones");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAvailabilityZonesListValue in requestObject.AvailabilityZones)
                {
                        context.Writer.Write(requestObjectAvailabilityZonesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetCount())
            {
                context.Writer.WritePropertyName("Count");
                context.Writer.Write(requestObject.Count);
            }

            if(requestObject.IsSetInterval())
            {
                context.Writer.WritePropertyName("Interval");
                context.Writer.Write(requestObject.Interval);
            }

            if(requestObject.IsSetIntervalUnit())
            {
                context.Writer.WritePropertyName("IntervalUnit");
                context.Writer.Write(requestObject.IntervalUnit);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static FastRestoreRuleMarshaller Instance = new FastRestoreRuleMarshaller();

    }
}