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
using ThirdParty.Json.LitJson;

namespace Amazon.IoTWireless.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// LoRaWANDeviceProfile Marshaller
    /// </summary>       
    public class LoRaWANDeviceProfileMarshaller : IRequestMarshaller<LoRaWANDeviceProfile, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(LoRaWANDeviceProfile requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetClassBTimeout())
            {
                context.Writer.WritePropertyName("ClassBTimeout");
                context.Writer.Write(requestObject.ClassBTimeout);
            }

            if(requestObject.IsSetClassCTimeout())
            {
                context.Writer.WritePropertyName("ClassCTimeout");
                context.Writer.Write(requestObject.ClassCTimeout);
            }

            if(requestObject.IsSetFactoryPresetFreqsList())
            {
                context.Writer.WritePropertyName("FactoryPresetFreqsList");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectFactoryPresetFreqsListListValue in requestObject.FactoryPresetFreqsList)
                {
                        context.Writer.Write(requestObjectFactoryPresetFreqsListListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetMacVersion())
            {
                context.Writer.WritePropertyName("MacVersion");
                context.Writer.Write(requestObject.MacVersion);
            }

            if(requestObject.IsSetMaxDutyCycle())
            {
                context.Writer.WritePropertyName("MaxDutyCycle");
                context.Writer.Write(requestObject.MaxDutyCycle);
            }

            if(requestObject.IsSetMaxEirp())
            {
                context.Writer.WritePropertyName("MaxEirp");
                context.Writer.Write(requestObject.MaxEirp);
            }

            if(requestObject.IsSetPingSlotDr())
            {
                context.Writer.WritePropertyName("PingSlotDr");
                context.Writer.Write(requestObject.PingSlotDr);
            }

            if(requestObject.IsSetPingSlotFreq())
            {
                context.Writer.WritePropertyName("PingSlotFreq");
                context.Writer.Write(requestObject.PingSlotFreq);
            }

            if(requestObject.IsSetPingSlotPeriod())
            {
                context.Writer.WritePropertyName("PingSlotPeriod");
                context.Writer.Write(requestObject.PingSlotPeriod);
            }

            if(requestObject.IsSetRegParamsRevision())
            {
                context.Writer.WritePropertyName("RegParamsRevision");
                context.Writer.Write(requestObject.RegParamsRevision);
            }

            if(requestObject.IsSetRfRegion())
            {
                context.Writer.WritePropertyName("RfRegion");
                context.Writer.Write(requestObject.RfRegion);
            }

            if(requestObject.IsSetRxDataRate2())
            {
                context.Writer.WritePropertyName("RxDataRate2");
                context.Writer.Write(requestObject.RxDataRate2);
            }

            if(requestObject.IsSetRxDelay1())
            {
                context.Writer.WritePropertyName("RxDelay1");
                context.Writer.Write(requestObject.RxDelay1);
            }

            if(requestObject.IsSetRxDrOffset1())
            {
                context.Writer.WritePropertyName("RxDrOffset1");
                context.Writer.Write(requestObject.RxDrOffset1);
            }

            if(requestObject.IsSetRxFreq2())
            {
                context.Writer.WritePropertyName("RxFreq2");
                context.Writer.Write(requestObject.RxFreq2);
            }

            if(requestObject.IsSetSupports32BitFCnt())
            {
                context.Writer.WritePropertyName("Supports32BitFCnt");
                context.Writer.Write(requestObject.Supports32BitFCnt);
            }

            if(requestObject.IsSetSupportsClassB())
            {
                context.Writer.WritePropertyName("SupportsClassB");
                context.Writer.Write(requestObject.SupportsClassB);
            }

            if(requestObject.IsSetSupportsClassC())
            {
                context.Writer.WritePropertyName("SupportsClassC");
                context.Writer.Write(requestObject.SupportsClassC);
            }

            if(requestObject.IsSetSupportsJoin())
            {
                context.Writer.WritePropertyName("SupportsJoin");
                context.Writer.Write(requestObject.SupportsJoin);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static LoRaWANDeviceProfileMarshaller Instance = new LoRaWANDeviceProfileMarshaller();

    }
}