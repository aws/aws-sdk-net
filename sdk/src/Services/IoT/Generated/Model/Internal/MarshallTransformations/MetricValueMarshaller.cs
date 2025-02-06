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
    /// MetricValue Marshaller
    /// </summary>
    public class MetricValueMarshaller : IRequestMarshaller<MetricValue, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(MetricValue requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCidrs())
            {
                context.Writer.WritePropertyName("cidrs");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCidrsListValue in requestObject.Cidrs)
                {
                        context.Writer.WriteStringValue(requestObjectCidrsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetCount())
            {
                context.Writer.WritePropertyName("count");
                context.Writer.WriteNumberValue(requestObject.Count.Value);
            }

            if(requestObject.IsSetNumber())
            {
                context.Writer.WritePropertyName("number");
                if(StringUtils.IsSpecialDoubleValue(requestObject.Number.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.Number.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.Number.Value);
                }
            }

            if(requestObject.IsSetNumbers())
            {
                context.Writer.WritePropertyName("numbers");
                context.Writer.WriteStartArray();
                foreach(var requestObjectNumbersListValue in requestObject.Numbers)
                {
                        context.Writer.WriteNumberValue(requestObjectNumbersListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetPorts())
            {
                context.Writer.WritePropertyName("ports");
                context.Writer.WriteStartArray();
                foreach(var requestObjectPortsListValue in requestObject.Ports)
                {
                        context.Writer.WriteNumberValue(requestObjectPortsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetStrings())
            {
                context.Writer.WritePropertyName("strings");
                context.Writer.WriteStartArray();
                foreach(var requestObjectStringsListValue in requestObject.Strings)
                {
                        context.Writer.WriteStringValue(requestObjectStringsListValue);
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static MetricValueMarshaller Instance = new MetricValueMarshaller();

    }
}