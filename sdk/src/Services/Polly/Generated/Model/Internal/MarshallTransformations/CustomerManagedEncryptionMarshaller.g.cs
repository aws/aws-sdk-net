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

using Amazon.Polly.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.Polly.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CustomerManagedEncryption Marshaller
    /// </summary>
    public partial class CustomerManagedEncryptionMarshaller : IRequestMarshaller<CustomerManagedEncryption, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(CustomerManagedEncryption requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetEncryptionContext())
            {
                context.Writer.WritePropertyName("EncryptionContext");
                context.Writer.WriteStartObject();
                foreach (var requestObjectEncryptionContextKvp in requestObject.EncryptionContext)
                {
                    context.Writer.WritePropertyName(requestObjectEncryptionContextKvp.Key);
                    var requestObjectEncryptionContextValue = requestObjectEncryptionContextKvp.Value;
                    context.Writer.WriteStringValue(requestObjectEncryptionContextValue);
                }
                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetKmsKeyArn())
            {
                context.Writer.WritePropertyName("KmsKeyArn");
                context.Writer.WriteStringValue(requestObject.KmsKeyArn);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static CustomerManagedEncryptionMarshaller Instance = new CustomerManagedEncryptionMarshaller();
    }
}
