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
 * Do not modify this file. This file is generated from the mediapackage-2017-10-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaPackage.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.MediaPackage.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// HlsEncryption Marshaller
    /// </summary>
    public class HlsEncryptionMarshaller : IRequestMarshaller<HlsEncryption, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(HlsEncryption requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetConstantInitializationVector())
            {
                context.Writer.WritePropertyName("constantInitializationVector");
                context.Writer.WriteStringValue(requestObject.ConstantInitializationVector);
            }

            if(requestObject.IsSetEncryptionMethod())
            {
                context.Writer.WritePropertyName("encryptionMethod");
                context.Writer.WriteStringValue(requestObject.EncryptionMethod);
            }

            if(requestObject.IsSetKeyRotationIntervalSeconds())
            {
                context.Writer.WritePropertyName("keyRotationIntervalSeconds");
                context.Writer.WriteNumberValue(requestObject.KeyRotationIntervalSeconds.Value);
            }

            if(requestObject.IsSetRepeatExtXKey())
            {
                context.Writer.WritePropertyName("repeatExtXKey");
                context.Writer.WriteBooleanValue(requestObject.RepeatExtXKey.Value);
            }

            if(requestObject.IsSetSpekeKeyProvider())
            {
                context.Writer.WritePropertyName("spekeKeyProvider");
                context.Writer.WriteStartObject();

                var marshaller = SpekeKeyProviderMarshaller.Instance;
                marshaller.Marshall(requestObject.SpekeKeyProvider, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static HlsEncryptionMarshaller Instance = new HlsEncryptionMarshaller();

    }
}