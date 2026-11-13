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

using Amazon.NetworkFirewall.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.NetworkFirewall.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ServerCertificateConfiguration Marshaller
    /// </summary>
    public partial class ServerCertificateConfigurationMarshaller : IRequestMarshaller<ServerCertificateConfiguration, CborMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(ServerCertificateConfiguration requestObject, CborMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetCertificateAuthorityArn())
            {
                context.Writer.WriteTextString("CertificateAuthorityArn");
                context.Writer.WriteTextString(requestObject.CertificateAuthorityArn);
            }

            if (requestObject.IsSetCheckCertificateRevocationStatus())
            {
                context.Writer.WriteTextString("CheckCertificateRevocationStatus");
                context.Writer.WriteStartMap(null);

                var marshaller = CheckCertificateRevocationStatusActionsMarshaller.Instance;
                marshaller.Marshall(requestObject.CheckCertificateRevocationStatus, context);

                context.Writer.WriteEndMap();
            }

            if (requestObject.IsSetDefaultDecryptionBehavior())
            {
                context.Writer.WriteTextString("DefaultDecryptionBehavior");
                context.Writer.WriteTextString(requestObject.DefaultDecryptionBehavior);
            }

            if (requestObject.IsSetScopes())
            {
                context.Writer.WriteTextString("Scopes");
                context.Writer.WriteStartArray(requestObject.Scopes.Count);
                foreach (var requestObjectScopesListValue in requestObject.Scopes)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = ServerCertificateScopeMarshaller.Instance;
                    marshaller.Marshall(requestObjectScopesListValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetServerCertificates())
            {
                context.Writer.WriteTextString("ServerCertificates");
                context.Writer.WriteStartArray(requestObject.ServerCertificates.Count);
                foreach (var requestObjectServerCertificatesListValue in requestObject.ServerCertificates)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = ServerCertificateMarshaller.Instance;
                    marshaller.Marshall(requestObjectServerCertificatesListValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndArray();
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static ServerCertificateConfigurationMarshaller Instance = new ServerCertificateConfigurationMarshaller();
    }
}
