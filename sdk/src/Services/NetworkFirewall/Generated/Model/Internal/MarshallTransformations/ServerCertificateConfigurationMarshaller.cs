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
 * Do not modify this file. This file is generated from the network-firewall-2020-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.NetworkFirewall.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.NetworkFirewall.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ServerCertificateConfiguration Marshaller
    /// </summary>
    public class ServerCertificateConfigurationMarshaller : IRequestMarshaller<ServerCertificateConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ServerCertificateConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetScopes())
            {
                context.Writer.WritePropertyName("Scopes");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectScopesListValue in requestObject.Scopes)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = ServerCertificateScopeMarshaller.Instance;
                    marshaller.Marshall(requestObjectScopesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetServerCertificates())
            {
                context.Writer.WritePropertyName("ServerCertificates");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectServerCertificatesListValue in requestObject.ServerCertificates)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = ServerCertificateMarshaller.Instance;
                    marshaller.Marshall(requestObjectServerCertificatesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ServerCertificateConfigurationMarshaller Instance = new ServerCertificateConfigurationMarshaller();

    }
}