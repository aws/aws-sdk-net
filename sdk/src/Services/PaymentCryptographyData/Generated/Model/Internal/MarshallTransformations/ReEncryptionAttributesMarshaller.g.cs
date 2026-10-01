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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.PaymentCryptographyData.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.PaymentCryptographyData.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ReEncryptionAttributes Marshaller
    /// </summary>
    public partial class ReEncryptionAttributesMarshaller : IRequestMarshaller<ReEncryptionAttributes, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(ReEncryptionAttributes requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetAsymmetric())
            {
                context.Writer.WritePropertyName("Asymmetric");
                context.Writer.WriteStartObject();

                var marshaller = AsymmetricEncryptionAttributesMarshaller.Instance;
                marshaller.Marshall(requestObject.Asymmetric, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetDukpt())
            {
                context.Writer.WritePropertyName("Dukpt");
                context.Writer.WriteStartObject();

                var marshaller = DukptEncryptionAttributesMarshaller.Instance;
                marshaller.Marshall(requestObject.Dukpt, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetSymmetric())
            {
                context.Writer.WritePropertyName("Symmetric");
                context.Writer.WriteStartObject();

                var marshaller = SymmetricEncryptionAttributesMarshaller.Instance;
                marshaller.Marshall(requestObject.Symmetric, context);

                context.Writer.WriteEndObject();
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static ReEncryptionAttributesMarshaller Instance = new ReEncryptionAttributesMarshaller();
    }
}
