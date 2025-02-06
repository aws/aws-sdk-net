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
    /// ASN1Subject Marshaller
    /// </summary>
    public class ASN1SubjectMarshaller : IRequestMarshaller<ASN1Subject, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ASN1Subject requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCommonName())
            {
                context.Writer.WritePropertyName("CommonName");
                context.Writer.WriteStringValue(requestObject.CommonName);
            }

            if(requestObject.IsSetCountry())
            {
                context.Writer.WritePropertyName("Country");
                context.Writer.WriteStringValue(requestObject.Country);
            }

            if(requestObject.IsSetCustomAttributes())
            {
                context.Writer.WritePropertyName("CustomAttributes");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCustomAttributesListValue in requestObject.CustomAttributes)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CustomAttributeMarshaller.Instance;
                    marshaller.Marshall(requestObjectCustomAttributesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetDistinguishedNameQualifier())
            {
                context.Writer.WritePropertyName("DistinguishedNameQualifier");
                context.Writer.WriteStringValue(requestObject.DistinguishedNameQualifier);
            }

            if(requestObject.IsSetGenerationQualifier())
            {
                context.Writer.WritePropertyName("GenerationQualifier");
                context.Writer.WriteStringValue(requestObject.GenerationQualifier);
            }

            if(requestObject.IsSetGivenName())
            {
                context.Writer.WritePropertyName("GivenName");
                context.Writer.WriteStringValue(requestObject.GivenName);
            }

            if(requestObject.IsSetInitials())
            {
                context.Writer.WritePropertyName("Initials");
                context.Writer.WriteStringValue(requestObject.Initials);
            }

            if(requestObject.IsSetLocality())
            {
                context.Writer.WritePropertyName("Locality");
                context.Writer.WriteStringValue(requestObject.Locality);
            }

            if(requestObject.IsSetOrganization())
            {
                context.Writer.WritePropertyName("Organization");
                context.Writer.WriteStringValue(requestObject.Organization);
            }

            if(requestObject.IsSetOrganizationalUnit())
            {
                context.Writer.WritePropertyName("OrganizationalUnit");
                context.Writer.WriteStringValue(requestObject.OrganizationalUnit);
            }

            if(requestObject.IsSetPseudonym())
            {
                context.Writer.WritePropertyName("Pseudonym");
                context.Writer.WriteStringValue(requestObject.Pseudonym);
            }

            if(requestObject.IsSetSerialNumber())
            {
                context.Writer.WritePropertyName("SerialNumber");
                context.Writer.WriteStringValue(requestObject.SerialNumber);
            }

            if(requestObject.IsSetState())
            {
                context.Writer.WritePropertyName("State");
                context.Writer.WriteStringValue(requestObject.State);
            }

            if(requestObject.IsSetSurname())
            {
                context.Writer.WritePropertyName("Surname");
                context.Writer.WriteStringValue(requestObject.Surname);
            }

            if(requestObject.IsSetTitle())
            {
                context.Writer.WritePropertyName("Title");
                context.Writer.WriteStringValue(requestObject.Title);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ASN1SubjectMarshaller Instance = new ASN1SubjectMarshaller();

    }
}