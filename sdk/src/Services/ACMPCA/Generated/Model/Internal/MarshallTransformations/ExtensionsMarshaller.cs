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
    /// Extensions Marshaller
    /// </summary>
    public class ExtensionsMarshaller : IRequestMarshaller<Extensions, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Extensions requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCertificatePolicies())
            {
                context.Writer.WritePropertyName("CertificatePolicies");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCertificatePoliciesListValue in requestObject.CertificatePolicies)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = PolicyInformationMarshaller.Instance;
                    marshaller.Marshall(requestObjectCertificatePoliciesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetCustomExtensions())
            {
                context.Writer.WritePropertyName("CustomExtensions");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCustomExtensionsListValue in requestObject.CustomExtensions)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CustomExtensionMarshaller.Instance;
                    marshaller.Marshall(requestObjectCustomExtensionsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetExtendedKeyUsage())
            {
                context.Writer.WritePropertyName("ExtendedKeyUsage");
                context.Writer.WriteStartArray();
                foreach(var requestObjectExtendedKeyUsageListValue in requestObject.ExtendedKeyUsage)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ExtendedKeyUsageMarshaller.Instance;
                    marshaller.Marshall(requestObjectExtendedKeyUsageListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetKeyUsage())
            {
                context.Writer.WritePropertyName("KeyUsage");
                context.Writer.WriteStartObject();

                var marshaller = KeyUsageMarshaller.Instance;
                marshaller.Marshall(requestObject.KeyUsage, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSubjectAlternativeNames())
            {
                context.Writer.WritePropertyName("SubjectAlternativeNames");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSubjectAlternativeNamesListValue in requestObject.SubjectAlternativeNames)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = GeneralNameMarshaller.Instance;
                    marshaller.Marshall(requestObjectSubjectAlternativeNamesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ExtensionsMarshaller Instance = new ExtensionsMarshaller();

    }
}