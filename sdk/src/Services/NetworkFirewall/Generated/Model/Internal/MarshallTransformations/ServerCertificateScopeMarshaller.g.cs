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
    /// ServerCertificateScope Marshaller
    /// </summary>
    public partial class ServerCertificateScopeMarshaller : IRequestMarshaller<ServerCertificateScope, CborMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(ServerCertificateScope requestObject, CborMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetDecryptionAction())
            {
                context.Writer.WriteTextString("DecryptionAction");
                context.Writer.WriteTextString(requestObject.DecryptionAction);
            }

            if (requestObject.IsSetDeploymentMode())
            {
                context.Writer.WriteTextString("DeploymentMode");
                context.Writer.WriteTextString(requestObject.DeploymentMode);
            }

            if (requestObject.IsSetDestinationPorts())
            {
                context.Writer.WriteTextString("DestinationPorts");
                context.Writer.WriteStartArray(requestObject.DestinationPorts.Count);
                foreach (var requestObjectDestinationPortsListValue in requestObject.DestinationPorts)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = PortRangeMarshaller.Instance;
                    marshaller.Marshall(requestObjectDestinationPortsListValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetDestinations())
            {
                context.Writer.WriteTextString("Destinations");
                context.Writer.WriteStartArray(requestObject.Destinations.Count);
                foreach (var requestObjectDestinationsListValue in requestObject.Destinations)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = AddressMarshaller.Instance;
                    marshaller.Marshall(requestObjectDestinationsListValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetDomainMatch())
            {
                context.Writer.WriteTextString("DomainMatch");
                context.Writer.WriteStartMap(null);

                var marshaller = DomainMatchMarshaller.Instance;
                marshaller.Marshall(requestObject.DomainMatch, context);

                context.Writer.WriteEndMap();
            }

            if (requestObject.IsSetProtocols())
            {
                context.Writer.WriteTextString("Protocols");
                context.Writer.WriteStartArray(requestObject.Protocols.Count);
                foreach (var requestObjectProtocolsListValue in requestObject.Protocols)
                {
                    context.Writer.WriteInt32(requestObjectProtocolsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetSourcePorts())
            {
                context.Writer.WriteTextString("SourcePorts");
                context.Writer.WriteStartArray(requestObject.SourcePorts.Count);
                foreach (var requestObjectSourcePortsListValue in requestObject.SourcePorts)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = PortRangeMarshaller.Instance;
                    marshaller.Marshall(requestObjectSourcePortsListValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetSources())
            {
                context.Writer.WriteTextString("Sources");
                context.Writer.WriteStartArray(requestObject.Sources.Count);
                foreach (var requestObjectSourcesListValue in requestObject.Sources)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = AddressMarshaller.Instance;
                    marshaller.Marshall(requestObjectSourcesListValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndArray();
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static ServerCertificateScopeMarshaller Instance = new ServerCertificateScopeMarshaller();
    }
}
