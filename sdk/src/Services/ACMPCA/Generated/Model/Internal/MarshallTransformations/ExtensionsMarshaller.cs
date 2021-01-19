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
using ThirdParty.Json.LitJson;

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
            if(requestObject.IsSetCertificatePolicies())
            {
                context.Writer.WritePropertyName("CertificatePolicies");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectCertificatePoliciesListValue in requestObject.CertificatePolicies)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = PolicyInformationMarshaller.Instance;
                    marshaller.Marshall(requestObjectCertificatePoliciesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetExtendedKeyUsage())
            {
                context.Writer.WritePropertyName("ExtendedKeyUsage");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectExtendedKeyUsageListValue in requestObject.ExtendedKeyUsage)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = ExtendedKeyUsageMarshaller.Instance;
                    marshaller.Marshall(requestObjectExtendedKeyUsageListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetKeyUsage())
            {
                context.Writer.WritePropertyName("KeyUsage");
                context.Writer.WriteObjectStart();

                var marshaller = KeyUsageMarshaller.Instance;
                marshaller.Marshall(requestObject.KeyUsage, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSubjectAlternativeNames())
            {
                context.Writer.WritePropertyName("SubjectAlternativeNames");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectSubjectAlternativeNamesListValue in requestObject.SubjectAlternativeNames)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = GeneralNameMarshaller.Instance;
                    marshaller.Marshall(requestObjectSubjectAlternativeNamesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static ExtensionsMarshaller Instance = new ExtensionsMarshaller();

    }
}