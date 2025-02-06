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
    /// As2ConnectorConfig Marshaller
    /// </summary>
    public class As2ConnectorConfigMarshaller : IRequestMarshaller<As2ConnectorConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(As2ConnectorConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBasicAuthSecretId())
            {
                context.Writer.WritePropertyName("BasicAuthSecretId");
                context.Writer.WriteStringValue(requestObject.BasicAuthSecretId);
            }

            if(requestObject.IsSetCompression())
            {
                context.Writer.WritePropertyName("Compression");
                context.Writer.WriteStringValue(requestObject.Compression);
            }

            if(requestObject.IsSetEncryptionAlgorithm())
            {
                context.Writer.WritePropertyName("EncryptionAlgorithm");
                context.Writer.WriteStringValue(requestObject.EncryptionAlgorithm);
            }

            if(requestObject.IsSetLocalProfileId())
            {
                context.Writer.WritePropertyName("LocalProfileId");
                context.Writer.WriteStringValue(requestObject.LocalProfileId);
            }

            if(requestObject.IsSetMdnResponse())
            {
                context.Writer.WritePropertyName("MdnResponse");
                context.Writer.WriteStringValue(requestObject.MdnResponse);
            }

            if(requestObject.IsSetMdnSigningAlgorithm())
            {
                context.Writer.WritePropertyName("MdnSigningAlgorithm");
                context.Writer.WriteStringValue(requestObject.MdnSigningAlgorithm);
            }

            if(requestObject.IsSetMessageSubject())
            {
                context.Writer.WritePropertyName("MessageSubject");
                context.Writer.WriteStringValue(requestObject.MessageSubject);
            }

            if(requestObject.IsSetPartnerProfileId())
            {
                context.Writer.WritePropertyName("PartnerProfileId");
                context.Writer.WriteStringValue(requestObject.PartnerProfileId);
            }

            if(requestObject.IsSetPreserveContentType())
            {
                context.Writer.WritePropertyName("PreserveContentType");
                context.Writer.WriteStringValue(requestObject.PreserveContentType);
            }

            if(requestObject.IsSetSigningAlgorithm())
            {
                context.Writer.WritePropertyName("SigningAlgorithm");
                context.Writer.WriteStringValue(requestObject.SigningAlgorithm);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static As2ConnectorConfigMarshaller Instance = new As2ConnectorConfigMarshaller();

    }
}