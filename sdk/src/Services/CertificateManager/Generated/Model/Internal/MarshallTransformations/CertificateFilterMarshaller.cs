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
 * Do not modify this file. This file is generated from the acm-2015-12-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CertificateManager.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.CertificateManager.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CertificateFilter Marshaller
    /// </summary>
    public class CertificateFilterMarshaller : IRequestMarshaller<CertificateFilter, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CertificateFilter requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAcmCertificateMetadataFilter())
            {
                context.Writer.WritePropertyName("AcmCertificateMetadataFilter");
                context.Writer.WriteStartObject();

                var marshaller = AcmCertificateMetadataFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.AcmCertificateMetadataFilter, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCertificateArn())
            {
                context.Writer.WritePropertyName("CertificateArn");
                context.Writer.WriteStringValue(requestObject.CertificateArn);
            }

            if(requestObject.IsSetX509AttributeFilter())
            {
                context.Writer.WritePropertyName("X509AttributeFilter");
                context.Writer.WriteStartObject();

                var marshaller = X509AttributeFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.X509AttributeFilter, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CertificateFilterMarshaller Instance = new CertificateFilterMarshaller();

    }
}