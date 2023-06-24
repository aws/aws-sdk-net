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
    /// ServerCertificateScope Marshaller
    /// </summary>
    public class ServerCertificateScopeMarshaller : IRequestMarshaller<ServerCertificateScope, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ServerCertificateScope requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetDestinationPorts())
            {
                context.Writer.WritePropertyName("DestinationPorts");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectDestinationPortsListValue in requestObject.DestinationPorts)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = PortRangeMarshaller.Instance;
                    marshaller.Marshall(requestObjectDestinationPortsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetDestinations())
            {
                context.Writer.WritePropertyName("Destinations");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectDestinationsListValue in requestObject.Destinations)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AddressMarshaller.Instance;
                    marshaller.Marshall(requestObjectDestinationsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetProtocols())
            {
                context.Writer.WritePropertyName("Protocols");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectProtocolsListValue in requestObject.Protocols)
                {
                        context.Writer.Write(requestObjectProtocolsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetSourcePorts())
            {
                context.Writer.WritePropertyName("SourcePorts");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectSourcePortsListValue in requestObject.SourcePorts)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = PortRangeMarshaller.Instance;
                    marshaller.Marshall(requestObjectSourcePortsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetSources())
            {
                context.Writer.WritePropertyName("Sources");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectSourcesListValue in requestObject.Sources)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AddressMarshaller.Instance;
                    marshaller.Marshall(requestObjectSourcesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ServerCertificateScopeMarshaller Instance = new ServerCertificateScopeMarshaller();

    }
}