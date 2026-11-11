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
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

using Amazon.CloudFront.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.CloudFront.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// EncryptionEntity Marshaller
    /// </summary>
    public partial class EncryptionEntityMarshaller : IRequestMarshaller<EncryptionEntity, XmlMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(EncryptionEntity requestObject, XmlMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetFieldPatterns())
            {
                context.Writer.WriteStartElement("FieldPatterns");
                FieldPatternsMarshaller.Instance.Marshall(requestObject.FieldPatterns, context);
                context.Writer.WriteEndElement();
            }
            if (requestObject.IsSetProviderId())
            {
                context.Writer.WriteElementString("ProviderId", StringUtils.FromString(requestObject.ProviderId));
            }
            if (requestObject.IsSetPublicKeyId())
            {
                context.Writer.WriteElementString("PublicKeyId", StringUtils.FromString(requestObject.PublicKeyId));
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static EncryptionEntityMarshaller Instance = new EncryptionEntityMarshaller();
    }
}
