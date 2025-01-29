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
 * Do not modify this file. This file is generated from the appmesh-2019-01-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AppMesh.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.AppMesh.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListenerTls Marshaller
    /// </summary>
    public class ListenerTlsMarshaller : IRequestMarshaller<ListenerTls, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ListenerTls requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCertificate())
            {
                context.Writer.WritePropertyName("certificate");
                context.Writer.WriteStartObject();

                var marshaller = ListenerTlsCertificateMarshaller.Instance;
                marshaller.Marshall(requestObject.Certificate, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMode())
            {
                context.Writer.WritePropertyName("mode");
                context.Writer.WriteStringValue(requestObject.Mode);
            }

            if(requestObject.IsSetValidation())
            {
                context.Writer.WritePropertyName("validation");
                context.Writer.WriteStartObject();

                var marshaller = ListenerTlsValidationContextMarshaller.Instance;
                marshaller.Marshall(requestObject.Validation, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ListenerTlsMarshaller Instance = new ListenerTlsMarshaller();

    }
}