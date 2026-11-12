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
    /// ASN1Subject Marshaller
    /// </summary>
    public partial class ASN1SubjectMarshaller : IRequestMarshaller<ASN1Subject, CborMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(ASN1Subject requestObject, CborMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetCommonName())
            {
                context.Writer.WriteTextString("CommonName");
                context.Writer.WriteTextString(requestObject.CommonName);
            }

            if (requestObject.IsSetCountry())
            {
                context.Writer.WriteTextString("Country");
                context.Writer.WriteTextString(requestObject.Country);
            }

            if (requestObject.IsSetCustomAttributes())
            {
                context.Writer.WriteTextString("CustomAttributes");
                context.Writer.WriteStartArray(requestObject.CustomAttributes.Count);
                foreach (var requestObjectCustomAttributesListValue in requestObject.CustomAttributes)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = CustomAttributeMarshaller.Instance;
                    marshaller.Marshall(requestObjectCustomAttributesListValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetDistinguishedNameQualifier())
            {
                context.Writer.WriteTextString("DistinguishedNameQualifier");
                context.Writer.WriteTextString(requestObject.DistinguishedNameQualifier);
            }

            if (requestObject.IsSetGenerationQualifier())
            {
                context.Writer.WriteTextString("GenerationQualifier");
                context.Writer.WriteTextString(requestObject.GenerationQualifier);
            }

            if (requestObject.IsSetGivenName())
            {
                context.Writer.WriteTextString("GivenName");
                context.Writer.WriteTextString(requestObject.GivenName);
            }

            if (requestObject.IsSetInitials())
            {
                context.Writer.WriteTextString("Initials");
                context.Writer.WriteTextString(requestObject.Initials);
            }

            if (requestObject.IsSetLocality())
            {
                context.Writer.WriteTextString("Locality");
                context.Writer.WriteTextString(requestObject.Locality);
            }

            if (requestObject.IsSetOrganization())
            {
                context.Writer.WriteTextString("Organization");
                context.Writer.WriteTextString(requestObject.Organization);
            }

            if (requestObject.IsSetOrganizationalUnit())
            {
                context.Writer.WriteTextString("OrganizationalUnit");
                context.Writer.WriteTextString(requestObject.OrganizationalUnit);
            }

            if (requestObject.IsSetPseudonym())
            {
                context.Writer.WriteTextString("Pseudonym");
                context.Writer.WriteTextString(requestObject.Pseudonym);
            }

            if (requestObject.IsSetSerialNumber())
            {
                context.Writer.WriteTextString("SerialNumber");
                context.Writer.WriteTextString(requestObject.SerialNumber);
            }

            if (requestObject.IsSetState())
            {
                context.Writer.WriteTextString("State");
                context.Writer.WriteTextString(requestObject.State);
            }

            if (requestObject.IsSetSurname())
            {
                context.Writer.WriteTextString("Surname");
                context.Writer.WriteTextString(requestObject.Surname);
            }

            if (requestObject.IsSetTitle())
            {
                context.Writer.WriteTextString("Title");
                context.Writer.WriteTextString(requestObject.Title);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static ASN1SubjectMarshaller Instance = new ASN1SubjectMarshaller();
    }
}
