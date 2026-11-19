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

using Amazon.ACMPCA.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.ACMPCA.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CrlConfiguration Marshaller
    /// </summary>
    public partial class CrlConfigurationMarshaller : IRequestMarshaller<CrlConfiguration, CborMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(CrlConfiguration requestObject, CborMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetCrlDistributionPointExtensionConfiguration())
            {
                context.Writer.WriteTextString("CrlDistributionPointExtensionConfiguration");
                context.Writer.WriteStartMap(null);

                var marshaller = CrlDistributionPointExtensionConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.CrlDistributionPointExtensionConfiguration, context);

                context.Writer.WriteEndMap();
            }

            if (requestObject.IsSetCrlType())
            {
                context.Writer.WriteTextString("CrlType");
                context.Writer.WriteTextString(requestObject.CrlType);
            }

            if (requestObject.IsSetCustomCname())
            {
                context.Writer.WriteTextString("CustomCname");
                context.Writer.WriteTextString(requestObject.CustomCname);
            }

            if (requestObject.IsSetCustomPath())
            {
                context.Writer.WriteTextString("CustomPath");
                context.Writer.WriteTextString(requestObject.CustomPath);
            }

            if (requestObject.IsSetEnabled())
            {
                context.Writer.WriteTextString("Enabled");
                context.Writer.WriteBoolean(requestObject.Enabled.Value);
            }

            if (requestObject.IsSetExpirationInDays())
            {
                context.Writer.WriteTextString("ExpirationInDays");
                context.Writer.WriteInt32(requestObject.ExpirationInDays.Value);
            }

            if (requestObject.IsSetS3BucketName())
            {
                context.Writer.WriteTextString("S3BucketName");
                context.Writer.WriteTextString(requestObject.S3BucketName);
            }

            if (requestObject.IsSetS3ObjectAcl())
            {
                context.Writer.WriteTextString("S3ObjectAcl");
                context.Writer.WriteTextString(requestObject.S3ObjectAcl);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static CrlConfigurationMarshaller Instance = new CrlConfigurationMarshaller();
    }
}
