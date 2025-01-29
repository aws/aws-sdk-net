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
 * Do not modify this file. This file is generated from the groundstation-2019-05-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.GroundStation.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.GroundStation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// TLEData Marshaller
    /// </summary>
    public class TLEDataMarshaller : IRequestMarshaller<TLEData, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(TLEData requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetTleLine1())
            {
                context.Writer.WritePropertyName("tleLine1");
                context.Writer.WriteStringValue(requestObject.TleLine1);
            }

            if(requestObject.IsSetTleLine2())
            {
                context.Writer.WritePropertyName("tleLine2");
                context.Writer.WriteStringValue(requestObject.TleLine2);
            }

            if(requestObject.IsSetValidTimeRange())
            {
                context.Writer.WritePropertyName("validTimeRange");
                context.Writer.WriteStartObject();

                var marshaller = TimeRangeMarshaller.Instance;
                marshaller.Marshall(requestObject.ValidTimeRange, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static TLEDataMarshaller Instance = new TLEDataMarshaller();

    }
}