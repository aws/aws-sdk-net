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
 * Do not modify this file. This file is generated from the transfer-2018-11-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Transfer.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Transfer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ProtocolDetails Marshaller
    /// </summary>
    public class ProtocolDetailsMarshaller : IRequestMarshaller<ProtocolDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ProtocolDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAs2Transports())
            {
                context.Writer.WritePropertyName("As2Transports");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAs2TransportsListValue in requestObject.As2Transports)
                {
                        context.Writer.WriteStringValue(requestObjectAs2TransportsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetPassiveIp())
            {
                context.Writer.WritePropertyName("PassiveIp");
                context.Writer.WriteStringValue(requestObject.PassiveIp);
            }

            if(requestObject.IsSetSetStatOption())
            {
                context.Writer.WritePropertyName("SetStatOption");
                context.Writer.WriteStringValue(requestObject.SetStatOption);
            }

            if(requestObject.IsSetTlsSessionResumptionMode())
            {
                context.Writer.WritePropertyName("TlsSessionResumptionMode");
                context.Writer.WriteStringValue(requestObject.TlsSessionResumptionMode);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ProtocolDetailsMarshaller Instance = new ProtocolDetailsMarshaller();

    }
}