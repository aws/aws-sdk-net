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
 * Do not modify this file. This file is generated from the payment-cryptography-data-2022-02-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.PaymentCryptographyData.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.PaymentCryptographyData.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SessionKeyEmv2000 Marshaller
    /// </summary>
    public class SessionKeyEmv2000Marshaller : IRequestMarshaller<SessionKeyEmv2000, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SessionKeyEmv2000 requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetApplicationTransactionCounter())
            {
                context.Writer.WritePropertyName("ApplicationTransactionCounter");
                context.Writer.WriteStringValue(requestObject.ApplicationTransactionCounter);
            }

            if(requestObject.IsSetPanSequenceNumber())
            {
                context.Writer.WritePropertyName("PanSequenceNumber");
                context.Writer.WriteStringValue(requestObject.PanSequenceNumber);
            }

            if(requestObject.IsSetPrimaryAccountNumber())
            {
                context.Writer.WritePropertyName("PrimaryAccountNumber");
                context.Writer.WriteStringValue(requestObject.PrimaryAccountNumber);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SessionKeyEmv2000Marshaller Instance = new SessionKeyEmv2000Marshaller();

    }
}