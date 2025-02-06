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
    /// OtaaV1_0_x Marshaller
    /// </summary>
    public class OtaaV1_0_xMarshaller : IRequestMarshaller<OtaaV1_0_x, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(OtaaV1_0_x requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAppEui())
            {
                context.Writer.WritePropertyName("AppEui");
                context.Writer.WriteStringValue(requestObject.AppEui);
            }

            if(requestObject.IsSetAppKey())
            {
                context.Writer.WritePropertyName("AppKey");
                context.Writer.WriteStringValue(requestObject.AppKey);
            }

            if(requestObject.IsSetGenAppKey())
            {
                context.Writer.WritePropertyName("GenAppKey");
                context.Writer.WriteStringValue(requestObject.GenAppKey);
            }

            if(requestObject.IsSetJoinEui())
            {
                context.Writer.WritePropertyName("JoinEui");
                context.Writer.WriteStringValue(requestObject.JoinEui);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static OtaaV1_0_xMarshaller Instance = new OtaaV1_0_xMarshaller();

    }
}