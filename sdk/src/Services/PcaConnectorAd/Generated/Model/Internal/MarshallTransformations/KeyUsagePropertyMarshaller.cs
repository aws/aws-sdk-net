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
    /// KeyUsageProperty Marshaller
    /// </summary>
    public class KeyUsagePropertyMarshaller : IRequestMarshaller<KeyUsageProperty, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(KeyUsageProperty requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetPropertyFlags())
            {
                context.Writer.WritePropertyName("PropertyFlags");
                context.Writer.WriteStartObject();

                var marshaller = KeyUsagePropertyFlagsMarshaller.Instance;
                marshaller.Marshall(requestObject.PropertyFlags, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPropertyType())
            {
                context.Writer.WritePropertyName("PropertyType");
                context.Writer.WriteStringValue(requestObject.PropertyType);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static KeyUsagePropertyMarshaller Instance = new KeyUsagePropertyMarshaller();

    }
}