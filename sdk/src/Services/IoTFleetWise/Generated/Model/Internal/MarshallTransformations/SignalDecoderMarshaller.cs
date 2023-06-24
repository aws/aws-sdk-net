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
            if(requestObject.IsSetCanSignal())
            {
                context.Writer.WritePropertyName("canSignal");
                context.Writer.WriteObjectStart();

                var marshaller = CanSignalMarshaller.Instance;
                marshaller.Marshall(requestObject.CanSignal, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetFullyQualifiedName())
            {
                context.Writer.WritePropertyName("fullyQualifiedName");
                context.Writer.Write(requestObject.FullyQualifiedName);
            }

            if(requestObject.IsSetInterfaceId())
            {
                context.Writer.WritePropertyName("interfaceId");
                context.Writer.Write(requestObject.InterfaceId);
            }

            if(requestObject.IsSetObdSignal())
            {
                context.Writer.WritePropertyName("obdSignal");
                context.Writer.WriteObjectStart();

                var marshaller = ObdSignalMarshaller.Instance;
                marshaller.Marshall(requestObject.ObdSignal, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetType())
            {
                context.Writer.WritePropertyName("type");
                context.Writer.Write(requestObject.Type);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SignalDecoderMarshaller Instance = new SignalDecoderMarshaller();

    }
}