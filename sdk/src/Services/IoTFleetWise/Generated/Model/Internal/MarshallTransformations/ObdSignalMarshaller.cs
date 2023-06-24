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
 * Do not modify this file. This file is generated from the iotfleetwise-2021-06-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTFleetWise.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoTFleetWise.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ObdSignal Marshaller
    /// </summary>
    public class ObdSignalMarshaller : IRequestMarshaller<ObdSignal, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ObdSignal requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetBitMaskLength())
            {
                context.Writer.WritePropertyName("bitMaskLength");
                context.Writer.Write(requestObject.BitMaskLength);
            }

            if(requestObject.IsSetBitRightShift())
            {
                context.Writer.WritePropertyName("bitRightShift");
                context.Writer.Write(requestObject.BitRightShift);
            }

            if(requestObject.IsSetByteLength())
            {
                context.Writer.WritePropertyName("byteLength");
                context.Writer.Write(requestObject.ByteLength);
            }

            if(requestObject.IsSetOffset())
            {
                context.Writer.WritePropertyName("offset");
                context.Writer.Write(requestObject.Offset);
            }

            if(requestObject.IsSetPid())
            {
                context.Writer.WritePropertyName("pid");
                context.Writer.Write(requestObject.Pid);
            }

            if(requestObject.IsSetPidResponseLength())
            {
                context.Writer.WritePropertyName("pidResponseLength");
                context.Writer.Write(requestObject.PidResponseLength);
            }

            if(requestObject.IsSetScaling())
            {
                context.Writer.WritePropertyName("scaling");
                context.Writer.Write(requestObject.Scaling);
            }

            if(requestObject.IsSetServiceMode())
            {
                context.Writer.WritePropertyName("serviceMode");
                context.Writer.Write(requestObject.ServiceMode);
            }

            if(requestObject.IsSetStartByte())
            {
                context.Writer.WritePropertyName("startByte");
                context.Writer.Write(requestObject.StartByte);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ObdSignalMarshaller Instance = new ObdSignalMarshaller();

    }
}