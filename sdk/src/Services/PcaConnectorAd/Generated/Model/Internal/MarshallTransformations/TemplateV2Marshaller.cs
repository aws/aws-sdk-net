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
 * Do not modify this file. This file is generated from the pca-connector-ad-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.PcaConnectorAd.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.PcaConnectorAd.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// TemplateV2 Marshaller
    /// </summary>
    public class TemplateV2Marshaller : IRequestMarshaller<TemplateV2, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(TemplateV2 requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCertificateValidity())
            {
                context.Writer.WritePropertyName("CertificateValidity");
                context.Writer.WriteStartObject();

                var marshaller = CertificateValidityMarshaller.Instance;
                marshaller.Marshall(requestObject.CertificateValidity, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetEnrollmentFlags())
            {
                context.Writer.WritePropertyName("EnrollmentFlags");
                context.Writer.WriteStartObject();

                var marshaller = EnrollmentFlagsV2Marshaller.Instance;
                marshaller.Marshall(requestObject.EnrollmentFlags, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetExtensions())
            {
                context.Writer.WritePropertyName("Extensions");
                context.Writer.WriteStartObject();

                var marshaller = ExtensionsV2Marshaller.Instance;
                marshaller.Marshall(requestObject.Extensions, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetGeneralFlags())
            {
                context.Writer.WritePropertyName("GeneralFlags");
                context.Writer.WriteStartObject();

                var marshaller = GeneralFlagsV2Marshaller.Instance;
                marshaller.Marshall(requestObject.GeneralFlags, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPrivateKeyAttributes())
            {
                context.Writer.WritePropertyName("PrivateKeyAttributes");
                context.Writer.WriteStartObject();

                var marshaller = PrivateKeyAttributesV2Marshaller.Instance;
                marshaller.Marshall(requestObject.PrivateKeyAttributes, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPrivateKeyFlags())
            {
                context.Writer.WritePropertyName("PrivateKeyFlags");
                context.Writer.WriteStartObject();

                var marshaller = PrivateKeyFlagsV2Marshaller.Instance;
                marshaller.Marshall(requestObject.PrivateKeyFlags, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSubjectNameFlags())
            {
                context.Writer.WritePropertyName("SubjectNameFlags");
                context.Writer.WriteStartObject();

                var marshaller = SubjectNameFlagsV2Marshaller.Instance;
                marshaller.Marshall(requestObject.SubjectNameFlags, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSupersededTemplates())
            {
                context.Writer.WritePropertyName("SupersededTemplates");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSupersededTemplatesListValue in requestObject.SupersededTemplates)
                {
                        context.Writer.WriteStringValue(requestObjectSupersededTemplatesListValue);
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static TemplateV2Marshaller Instance = new TemplateV2Marshaller();

    }
}