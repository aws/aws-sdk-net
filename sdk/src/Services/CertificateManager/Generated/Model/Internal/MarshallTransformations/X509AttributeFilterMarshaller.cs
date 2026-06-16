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
    /// X509AttributeFilter Marshaller
    /// </summary>
    public class X509AttributeFilterMarshaller : IRequestMarshaller<X509AttributeFilter, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(X509AttributeFilter requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetExtendedKeyUsage())
            {
                context.Writer.WritePropertyName("ExtendedKeyUsage");
                context.Writer.WriteStringValue(requestObject.ExtendedKeyUsage);
            }

            if(requestObject.IsSetKeyAlgorithm())
            {
                context.Writer.WritePropertyName("KeyAlgorithm");
                context.Writer.WriteStringValue(requestObject.KeyAlgorithm);
            }

            if(requestObject.IsSetKeyUsage())
            {
                context.Writer.WritePropertyName("KeyUsage");
                context.Writer.WriteStringValue(requestObject.KeyUsage);
            }

            if(requestObject.IsSetNotAfter())
            {
                context.Writer.WritePropertyName("NotAfter");
                context.Writer.WriteStartObject();

                var marshaller = TimestampRangeMarshaller.Instance;
                marshaller.Marshall(requestObject.NotAfter, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetNotBefore())
            {
                context.Writer.WritePropertyName("NotBefore");
                context.Writer.WriteStartObject();

                var marshaller = TimestampRangeMarshaller.Instance;
                marshaller.Marshall(requestObject.NotBefore, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSerialNumber())
            {
                context.Writer.WritePropertyName("SerialNumber");
                context.Writer.WriteStringValue(requestObject.SerialNumber);
            }

            if(requestObject.IsSetSubject())
            {
                context.Writer.WritePropertyName("Subject");
                context.Writer.WriteStartObject();

                var marshaller = SubjectFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.Subject, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSubjectAlternativeName())
            {
                context.Writer.WritePropertyName("SubjectAlternativeName");
                context.Writer.WriteStartObject();

                var marshaller = SubjectAlternativeNameFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.SubjectAlternativeName, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static X509AttributeFilterMarshaller Instance = new X509AttributeFilterMarshaller();

    }
}