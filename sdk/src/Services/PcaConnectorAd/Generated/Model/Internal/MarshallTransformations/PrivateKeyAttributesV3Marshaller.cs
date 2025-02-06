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
#pragma warning disable CS0612,CS0618
namespace Amazon.PcaConnectorAd.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PrivateKeyAttributesV3 Marshaller
    /// </summary>
    public class PrivateKeyAttributesV3Marshaller : IRequestMarshaller<PrivateKeyAttributesV3, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(PrivateKeyAttributesV3 requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAlgorithm())
            {
                context.Writer.WritePropertyName("Algorithm");
                context.Writer.WriteStringValue(requestObject.Algorithm);
            }

            if(requestObject.IsSetCryptoProviders())
            {
                context.Writer.WritePropertyName("CryptoProviders");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCryptoProvidersListValue in requestObject.CryptoProviders)
                {
                        context.Writer.WriteStringValue(requestObjectCryptoProvidersListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetKeySpec())
            {
                context.Writer.WritePropertyName("KeySpec");
                context.Writer.WriteStringValue(requestObject.KeySpec);
            }

            if(requestObject.IsSetKeyUsageProperty())
            {
                context.Writer.WritePropertyName("KeyUsageProperty");
                context.Writer.WriteStartObject();

                var marshaller = KeyUsagePropertyMarshaller.Instance;
                marshaller.Marshall(requestObject.KeyUsageProperty, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMinimalKeyLength())
            {
                context.Writer.WritePropertyName("MinimalKeyLength");
                context.Writer.WriteNumberValue(requestObject.MinimalKeyLength.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static PrivateKeyAttributesV3Marshaller Instance = new PrivateKeyAttributesV3Marshaller();

    }
}