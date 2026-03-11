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
 * Do not modify this file. This file is generated from the iotwireless-2020-11-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTWireless.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.IoTWireless.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// LoRaWANServiceProfile Marshaller
    /// </summary>
    public class LoRaWANServiceProfileMarshaller : IRequestMarshaller<LoRaWANServiceProfile, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(LoRaWANServiceProfile requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAddGwMetadata())
            {
                context.Writer.WritePropertyName("AddGwMetadata");
                context.Writer.WriteBooleanValue(requestObject.AddGwMetadata.Value);
            }

            if(requestObject.IsSetDrMax())
            {
                context.Writer.WritePropertyName("DrMax");
                context.Writer.WriteNumberValue(requestObject.DrMax.Value);
            }

            if(requestObject.IsSetDrMin())
            {
                context.Writer.WritePropertyName("DrMin");
                context.Writer.WriteNumberValue(requestObject.DrMin.Value);
            }

            if(requestObject.IsSetNbTransMax())
            {
                context.Writer.WritePropertyName("NbTransMax");
                context.Writer.WriteNumberValue(requestObject.NbTransMax.Value);
            }

            if(requestObject.IsSetNbTransMin())
            {
                context.Writer.WritePropertyName("NbTransMin");
                context.Writer.WriteNumberValue(requestObject.NbTransMin.Value);
            }

            if(requestObject.IsSetPrAllowed())
            {
                context.Writer.WritePropertyName("PrAllowed");
                context.Writer.WriteBooleanValue(requestObject.PrAllowed.Value);
            }

            if(requestObject.IsSetRaAllowed())
            {
                context.Writer.WritePropertyName("RaAllowed");
                context.Writer.WriteBooleanValue(requestObject.RaAllowed.Value);
            }

            if(requestObject.IsSetTxPowerIndexMax())
            {
                context.Writer.WritePropertyName("TxPowerIndexMax");
                context.Writer.WriteNumberValue(requestObject.TxPowerIndexMax.Value);
            }

            if(requestObject.IsSetTxPowerIndexMin())
            {
                context.Writer.WritePropertyName("TxPowerIndexMin");
                context.Writer.WriteNumberValue(requestObject.TxPowerIndexMin.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static LoRaWANServiceProfileMarshaller Instance = new LoRaWANServiceProfileMarshaller();

    }
}