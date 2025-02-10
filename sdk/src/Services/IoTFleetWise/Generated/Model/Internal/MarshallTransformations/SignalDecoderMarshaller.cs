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
    /// SignalDecoder Marshaller
    /// </summary>
    public class SignalDecoderMarshaller : IRequestMarshaller<SignalDecoder, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SignalDecoder requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCanSignal())
            {
                context.Writer.WritePropertyName("canSignal");
                context.Writer.WriteStartObject();

                var marshaller = CanSignalMarshaller.Instance;
                marshaller.Marshall(requestObject.CanSignal, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCustomDecodingSignal())
            {
                context.Writer.WritePropertyName("customDecodingSignal");
                context.Writer.WriteStartObject();

                var marshaller = CustomDecodingSignalMarshaller.Instance;
                marshaller.Marshall(requestObject.CustomDecodingSignal, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetFullyQualifiedName())
            {
                context.Writer.WritePropertyName("fullyQualifiedName");
                context.Writer.WriteStringValue(requestObject.FullyQualifiedName);
            }

            if(requestObject.IsSetInterfaceId())
            {
                context.Writer.WritePropertyName("interfaceId");
                context.Writer.WriteStringValue(requestObject.InterfaceId);
            }

            if(requestObject.IsSetMessageSignal())
            {
                context.Writer.WritePropertyName("messageSignal");
                context.Writer.WriteStartObject();

                var marshaller = MessageSignalMarshaller.Instance;
                marshaller.Marshall(requestObject.MessageSignal, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetObdSignal())
            {
                context.Writer.WritePropertyName("obdSignal");
                context.Writer.WriteStartObject();

                var marshaller = ObdSignalMarshaller.Instance;
                marshaller.Marshall(requestObject.ObdSignal, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetType())
            {
                context.Writer.WritePropertyName("type");
                context.Writer.WriteStringValue(requestObject.Type);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SignalDecoderMarshaller Instance = new SignalDecoderMarshaller();

    }
}