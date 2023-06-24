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
            if(requestObject.IsSetFactor())
            {
                context.Writer.WritePropertyName("factor");
                context.Writer.Write(requestObject.Factor);
            }

            if(requestObject.IsSetIsBigEndian())
            {
                context.Writer.WritePropertyName("isBigEndian");
                context.Writer.Write(requestObject.IsBigEndian);
            }

            if(requestObject.IsSetIsSigned())
            {
                context.Writer.WritePropertyName("isSigned");
                context.Writer.Write(requestObject.IsSigned);
            }

            if(requestObject.IsSetLength())
            {
                context.Writer.WritePropertyName("length");
                context.Writer.Write(requestObject.Length);
            }

            if(requestObject.IsSetMessageId())
            {
                context.Writer.WritePropertyName("messageId");
                context.Writer.Write(requestObject.MessageId);
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.Write(requestObject.Name);
            }

            if(requestObject.IsSetOffset())
            {
                context.Writer.WritePropertyName("offset");
                context.Writer.Write(requestObject.Offset);
            }

            if(requestObject.IsSetStartBit())
            {
                context.Writer.WritePropertyName("startBit");
                context.Writer.Write(requestObject.StartBit);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CanSignalMarshaller Instance = new CanSignalMarshaller();

    }
}