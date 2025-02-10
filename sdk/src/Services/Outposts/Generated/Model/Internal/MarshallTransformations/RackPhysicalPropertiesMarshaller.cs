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
 * Do not modify this file. This file is generated from the outposts-2019-12-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Outposts.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Outposts.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RackPhysicalProperties Marshaller
    /// </summary>
    public class RackPhysicalPropertiesMarshaller : IRequestMarshaller<RackPhysicalProperties, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RackPhysicalProperties requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetFiberOpticCableType())
            {
                context.Writer.WritePropertyName("FiberOpticCableType");
                context.Writer.WriteStringValue(requestObject.FiberOpticCableType);
            }

            if(requestObject.IsSetMaximumSupportedWeightLbs())
            {
                context.Writer.WritePropertyName("MaximumSupportedWeightLbs");
                context.Writer.WriteStringValue(requestObject.MaximumSupportedWeightLbs);
            }

            if(requestObject.IsSetOpticalStandard())
            {
                context.Writer.WritePropertyName("OpticalStandard");
                context.Writer.WriteStringValue(requestObject.OpticalStandard);
            }

            if(requestObject.IsSetPowerConnector())
            {
                context.Writer.WritePropertyName("PowerConnector");
                context.Writer.WriteStringValue(requestObject.PowerConnector);
            }

            if(requestObject.IsSetPowerDrawKva())
            {
                context.Writer.WritePropertyName("PowerDrawKva");
                context.Writer.WriteStringValue(requestObject.PowerDrawKva);
            }

            if(requestObject.IsSetPowerFeedDrop())
            {
                context.Writer.WritePropertyName("PowerFeedDrop");
                context.Writer.WriteStringValue(requestObject.PowerFeedDrop);
            }

            if(requestObject.IsSetPowerPhase())
            {
                context.Writer.WritePropertyName("PowerPhase");
                context.Writer.WriteStringValue(requestObject.PowerPhase);
            }

            if(requestObject.IsSetUplinkCount())
            {
                context.Writer.WritePropertyName("UplinkCount");
                context.Writer.WriteStringValue(requestObject.UplinkCount);
            }

            if(requestObject.IsSetUplinkGbps())
            {
                context.Writer.WritePropertyName("UplinkGbps");
                context.Writer.WriteStringValue(requestObject.UplinkGbps);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RackPhysicalPropertiesMarshaller Instance = new RackPhysicalPropertiesMarshaller();

    }
}