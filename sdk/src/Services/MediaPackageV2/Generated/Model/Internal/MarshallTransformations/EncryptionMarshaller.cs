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
 * Do not modify this file. This file is generated from the mediapackagev2-2022-12-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaPackageV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.MediaPackageV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Encryption Marshaller
    /// </summary>
    public class EncryptionMarshaller : IRequestMarshaller<Encryption, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Encryption requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCmafExcludeSegmentDrmMetadata())
            {
                context.Writer.WritePropertyName("CmafExcludeSegmentDrmMetadata");
                context.Writer.WriteBooleanValue(requestObject.CmafExcludeSegmentDrmMetadata.Value);
            }

            if(requestObject.IsSetConstantInitializationVector())
            {
                context.Writer.WritePropertyName("ConstantInitializationVector");
                context.Writer.WriteStringValue(requestObject.ConstantInitializationVector);
            }

            if(requestObject.IsSetEncryptionMethod())
            {
                context.Writer.WritePropertyName("EncryptionMethod");
                context.Writer.WriteStartObject();

                var marshaller = EncryptionMethodMarshaller.Instance;
                marshaller.Marshall(requestObject.EncryptionMethod, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetKeyRotationIntervalSeconds())
            {
                context.Writer.WritePropertyName("KeyRotationIntervalSeconds");
                context.Writer.WriteNumberValue(requestObject.KeyRotationIntervalSeconds.Value);
            }

            if(requestObject.IsSetSpekeKeyProvider())
            {
                context.Writer.WritePropertyName("SpekeKeyProvider");
                context.Writer.WriteStartObject();

                var marshaller = SpekeKeyProviderMarshaller.Instance;
                marshaller.Marshall(requestObject.SpekeKeyProvider, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static EncryptionMarshaller Instance = new EncryptionMarshaller();

    }
}