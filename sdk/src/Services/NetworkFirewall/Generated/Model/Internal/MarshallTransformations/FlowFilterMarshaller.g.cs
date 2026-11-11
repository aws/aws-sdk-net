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
    /// FlowFilter Marshaller
    /// </summary>
    public partial class FlowFilterMarshaller : IRequestMarshaller<FlowFilter, CborMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(FlowFilter requestObject, CborMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetDestinationAddress())
            {
                context.Writer.WriteTextString("DestinationAddress");
                context.Writer.WriteStartMap(null);

                var marshaller = AddressMarshaller.Instance;
                marshaller.Marshall(requestObject.DestinationAddress, context);

                context.Writer.WriteEndMap();
            }

            if (requestObject.IsSetDestinationPort())
            {
                context.Writer.WriteTextString("DestinationPort");
                context.Writer.WriteTextString(requestObject.DestinationPort);
            }

            if (requestObject.IsSetProtocols())
            {
                context.Writer.WriteTextString("Protocols");
                context.Writer.WriteStartArray(requestObject.Protocols.Count);
                foreach (var requestObjectProtocolsListValue in requestObject.Protocols)
                {
                    context.Writer.WriteTextString(requestObjectProtocolsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetSourceAddress())
            {
                context.Writer.WriteTextString("SourceAddress");
                context.Writer.WriteStartMap(null);

                var marshaller = AddressMarshaller.Instance;
                marshaller.Marshall(requestObject.SourceAddress, context);

                context.Writer.WriteEndMap();
            }

            if (requestObject.IsSetSourcePort())
            {
                context.Writer.WriteTextString("SourcePort");
                context.Writer.WriteTextString(requestObject.SourcePort);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static FlowFilterMarshaller Instance = new FlowFilterMarshaller();
    }
}
