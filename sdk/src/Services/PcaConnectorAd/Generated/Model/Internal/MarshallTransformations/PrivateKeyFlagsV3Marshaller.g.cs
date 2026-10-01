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

using Amazon.PcaConnectorAd.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.PcaConnectorAd.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PrivateKeyFlagsV3 Marshaller
    /// </summary>
    public partial class PrivateKeyFlagsV3Marshaller : IRequestMarshaller<PrivateKeyFlagsV3, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(PrivateKeyFlagsV3 requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetClientVersion())
            {
                context.Writer.WritePropertyName("ClientVersion");
                context.Writer.WriteStringValue(requestObject.ClientVersion);
            }

            if (requestObject.IsSetExportableKey())
            {
                context.Writer.WritePropertyName("ExportableKey");
                context.Writer.WriteBooleanValue(requestObject.ExportableKey.Value);
            }

            if (requestObject.IsSetRequireAlternateSignatureAlgorithm())
            {
                context.Writer.WritePropertyName("RequireAlternateSignatureAlgorithm");
                context.Writer.WriteBooleanValue(requestObject.RequireAlternateSignatureAlgorithm.Value);
            }

            if (requestObject.IsSetStrongKeyProtectionRequired())
            {
                context.Writer.WritePropertyName("StrongKeyProtectionRequired");
                context.Writer.WriteBooleanValue(requestObject.StrongKeyProtectionRequired.Value);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static PrivateKeyFlagsV3Marshaller Instance = new PrivateKeyFlagsV3Marshaller();
    }
}
