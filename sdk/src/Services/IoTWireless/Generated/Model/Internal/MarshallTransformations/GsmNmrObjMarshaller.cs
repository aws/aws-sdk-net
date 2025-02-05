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
    /// GsmNmrObj Marshaller
    /// </summary>
    public class GsmNmrObjMarshaller : IRequestMarshaller<GsmNmrObj, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(GsmNmrObj requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBcch())
            {
                context.Writer.WritePropertyName("Bcch");
                context.Writer.WriteNumberValue(requestObject.Bcch.Value);
            }

            if(requestObject.IsSetBsic())
            {
                context.Writer.WritePropertyName("Bsic");
                context.Writer.WriteNumberValue(requestObject.Bsic.Value);
            }

            if(requestObject.IsSetGlobalIdentity())
            {
                context.Writer.WritePropertyName("GlobalIdentity");
                context.Writer.WriteStartObject();

                var marshaller = GlobalIdentityMarshaller.Instance;
                marshaller.Marshall(requestObject.GlobalIdentity, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRxLevel())
            {
                context.Writer.WritePropertyName("RxLevel");
                context.Writer.WriteNumberValue(requestObject.RxLevel.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static GsmNmrObjMarshaller Instance = new GsmNmrObjMarshaller();

    }
}