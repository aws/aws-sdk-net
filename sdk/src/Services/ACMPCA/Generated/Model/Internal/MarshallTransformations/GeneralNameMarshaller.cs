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
    /// GeneralName Marshaller
    /// </summary>       
    public class GeneralNameMarshaller : IRequestMarshaller<GeneralName, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(GeneralName requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetDirectoryName())
            {
                context.Writer.WritePropertyName("DirectoryName");
                context.Writer.WriteObjectStart();

                var marshaller = ASN1SubjectMarshaller.Instance;
                marshaller.Marshall(requestObject.DirectoryName, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDnsName())
            {
                context.Writer.WritePropertyName("DnsName");
                context.Writer.Write(requestObject.DnsName);
            }

            if(requestObject.IsSetEdiPartyName())
            {
                context.Writer.WritePropertyName("EdiPartyName");
                context.Writer.WriteObjectStart();

                var marshaller = EdiPartyNameMarshaller.Instance;
                marshaller.Marshall(requestObject.EdiPartyName, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetIpAddress())
            {
                context.Writer.WritePropertyName("IpAddress");
                context.Writer.Write(requestObject.IpAddress);
            }

            if(requestObject.IsSetOtherName())
            {
                context.Writer.WritePropertyName("OtherName");
                context.Writer.WriteObjectStart();

                var marshaller = OtherNameMarshaller.Instance;
                marshaller.Marshall(requestObject.OtherName, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetRegisteredId())
            {
                context.Writer.WritePropertyName("RegisteredId");
                context.Writer.Write(requestObject.RegisteredId);
            }

            if(requestObject.IsSetRfc822Name())
            {
                context.Writer.WritePropertyName("Rfc822Name");
                context.Writer.Write(requestObject.Rfc822Name);
            }

            if(requestObject.IsSetUniformResourceIdentifier())
            {
                context.Writer.WritePropertyName("UniformResourceIdentifier");
                context.Writer.Write(requestObject.UniformResourceIdentifier);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static GeneralNameMarshaller Instance = new GeneralNameMarshaller();

    }
}