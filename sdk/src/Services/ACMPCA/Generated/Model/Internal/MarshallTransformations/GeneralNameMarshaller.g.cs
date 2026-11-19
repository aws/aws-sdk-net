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
    /// GeneralName Marshaller
    /// </summary>
    public partial class GeneralNameMarshaller : IRequestMarshaller<GeneralName, CborMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(GeneralName requestObject, CborMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetDirectoryName())
            {
                context.Writer.WriteTextString("DirectoryName");
                context.Writer.WriteStartMap(null);

                var marshaller = ASN1SubjectMarshaller.Instance;
                marshaller.Marshall(requestObject.DirectoryName, context);

                context.Writer.WriteEndMap();
            }

            if (requestObject.IsSetDnsName())
            {
                context.Writer.WriteTextString("DnsName");
                context.Writer.WriteTextString(requestObject.DnsName);
            }

            if (requestObject.IsSetEdiPartyName())
            {
                context.Writer.WriteTextString("EdiPartyName");
                context.Writer.WriteStartMap(null);

                var marshaller = EdiPartyNameMarshaller.Instance;
                marshaller.Marshall(requestObject.EdiPartyName, context);

                context.Writer.WriteEndMap();
            }

            if (requestObject.IsSetIpAddress())
            {
                context.Writer.WriteTextString("IpAddress");
                context.Writer.WriteTextString(requestObject.IpAddress);
            }

            if (requestObject.IsSetOtherName())
            {
                context.Writer.WriteTextString("OtherName");
                context.Writer.WriteStartMap(null);

                var marshaller = OtherNameMarshaller.Instance;
                marshaller.Marshall(requestObject.OtherName, context);

                context.Writer.WriteEndMap();
            }

            if (requestObject.IsSetRegisteredId())
            {
                context.Writer.WriteTextString("RegisteredId");
                context.Writer.WriteTextString(requestObject.RegisteredId);
            }

            if (requestObject.IsSetRfc822Name())
            {
                context.Writer.WriteTextString("Rfc822Name");
                context.Writer.WriteTextString(requestObject.Rfc822Name);
            }

            if (requestObject.IsSetUniformResourceIdentifier())
            {
                context.Writer.WriteTextString("UniformResourceIdentifier");
                context.Writer.WriteTextString(requestObject.UniformResourceIdentifier);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static GeneralNameMarshaller Instance = new GeneralNameMarshaller();
    }
}
