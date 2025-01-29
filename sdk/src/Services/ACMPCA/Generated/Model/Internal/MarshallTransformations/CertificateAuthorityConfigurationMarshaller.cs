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
 * Do not modify this file. This file is generated from the acm-pca-2017-08-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ACMPCA.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ACMPCA.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CertificateAuthorityConfiguration Marshaller
    /// </summary>
    public class CertificateAuthorityConfigurationMarshaller : IRequestMarshaller<CertificateAuthorityConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CertificateAuthorityConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCsrExtensions())
            {
                context.Writer.WritePropertyName("CsrExtensions");
                context.Writer.WriteStartObject();

                var marshaller = CsrExtensionsMarshaller.Instance;
                marshaller.Marshall(requestObject.CsrExtensions, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetKeyAlgorithm())
            {
                context.Writer.WritePropertyName("KeyAlgorithm");
                context.Writer.WriteStringValue(requestObject.KeyAlgorithm);
            }

            if(requestObject.IsSetSigningAlgorithm())
            {
                context.Writer.WritePropertyName("SigningAlgorithm");
                context.Writer.WriteStringValue(requestObject.SigningAlgorithm);
            }

            if(requestObject.IsSetSubject())
            {
                context.Writer.WritePropertyName("Subject");
                context.Writer.WriteStartObject();

                var marshaller = ASN1SubjectMarshaller.Instance;
                marshaller.Marshall(requestObject.Subject, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CertificateAuthorityConfigurationMarshaller Instance = new CertificateAuthorityConfigurationMarshaller();

    }
}