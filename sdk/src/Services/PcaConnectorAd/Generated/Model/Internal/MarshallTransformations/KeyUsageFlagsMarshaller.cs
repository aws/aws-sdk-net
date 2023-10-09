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
 * Do not modify this file. This file is generated from the pca-connector-ad-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.PcaConnectorAd.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.PcaConnectorAd.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// KeyUsageFlags Marshaller
    /// </summary>
    public class KeyUsageFlagsMarshaller : IRequestMarshaller<KeyUsageFlags, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(KeyUsageFlags requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetDataEncipherment())
            {
                context.Writer.WritePropertyName("DataEncipherment");
                context.Writer.Write(requestObject.DataEncipherment);
            }

            if(requestObject.IsSetDigitalSignature())
            {
                context.Writer.WritePropertyName("DigitalSignature");
                context.Writer.Write(requestObject.DigitalSignature);
            }

            if(requestObject.IsSetKeyAgreement())
            {
                context.Writer.WritePropertyName("KeyAgreement");
                context.Writer.Write(requestObject.KeyAgreement);
            }

            if(requestObject.IsSetKeyEncipherment())
            {
                context.Writer.WritePropertyName("KeyEncipherment");
                context.Writer.Write(requestObject.KeyEncipherment);
            }

            if(requestObject.IsSetNonRepudiation())
            {
                context.Writer.WritePropertyName("NonRepudiation");
                context.Writer.Write(requestObject.NonRepudiation);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static KeyUsageFlagsMarshaller Instance = new KeyUsageFlagsMarshaller();

    }
}