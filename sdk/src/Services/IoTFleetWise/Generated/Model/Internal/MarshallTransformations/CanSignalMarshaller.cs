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
#pragma warning disable CS0612,CS0618
namespace Amazon.IoTFleetWise.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CanSignal Marshaller
    /// </summary>
    public class CanSignalMarshaller : IRequestMarshaller<CanSignal, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CanSignal requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetFactor())
            {
                context.Writer.WritePropertyName("factor");
                if(StringUtils.IsSpecialDoubleValue(requestObject.Factor.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.Factor.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.Factor.Value);
                }
            }

            if(requestObject.IsSetIsBigEndian())
            {
                context.Writer.WritePropertyName("isBigEndian");
                context.Writer.WriteBooleanValue(requestObject.IsBigEndian.Value);
            }

            if(requestObject.IsSetIsSigned())
            {
                context.Writer.WritePropertyName("isSigned");
                context.Writer.WriteBooleanValue(requestObject.IsSigned.Value);
            }

            if(requestObject.IsSetLength())
            {
                context.Writer.WritePropertyName("length");
                context.Writer.WriteNumberValue(requestObject.Length.Value);
            }

            if(requestObject.IsSetMessageId())
            {
                context.Writer.WritePropertyName("messageId");
                context.Writer.WriteNumberValue(requestObject.MessageId.Value);
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(requestObject.Name);
            }

            if(requestObject.IsSetOffset())
            {
                context.Writer.WritePropertyName("offset");
                if(StringUtils.IsSpecialDoubleValue(requestObject.Offset.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.Offset.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.Offset.Value);
                }
            }

            if(requestObject.IsSetSignalValueType())
            {
                context.Writer.WritePropertyName("signalValueType");
                context.Writer.WriteStringValue(requestObject.SignalValueType);
            }

            if(requestObject.IsSetStartBit())
            {
                context.Writer.WritePropertyName("startBit");
                context.Writer.WriteNumberValue(requestObject.StartBit.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CanSignalMarshaller Instance = new CanSignalMarshaller();

    }
}