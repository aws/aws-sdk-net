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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Network Marshaller
    /// </summary>
    public class NetworkMarshaller : IRequestMarshaller<Network, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Network requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDestinationDomain())
            {
                context.Writer.WritePropertyName("DestinationDomain");
                context.Writer.WriteStringValue(requestObject.DestinationDomain);
            }

            if(requestObject.IsSetDestinationIpV4())
            {
                context.Writer.WritePropertyName("DestinationIpV4");
                context.Writer.WriteStringValue(requestObject.DestinationIpV4);
            }

            if(requestObject.IsSetDestinationIpV6())
            {
                context.Writer.WritePropertyName("DestinationIpV6");
                context.Writer.WriteStringValue(requestObject.DestinationIpV6);
            }

            if(requestObject.IsSetDestinationPort())
            {
                context.Writer.WritePropertyName("DestinationPort");
                context.Writer.WriteNumberValue(requestObject.DestinationPort.Value);
            }

            if(requestObject.IsSetDirection())
            {
                context.Writer.WritePropertyName("Direction");
                context.Writer.WriteStringValue(requestObject.Direction);
            }

            if(requestObject.IsSetOpenPortRange())
            {
                context.Writer.WritePropertyName("OpenPortRange");
                context.Writer.WriteStartObject();

                var marshaller = PortRangeMarshaller.Instance;
                marshaller.Marshall(requestObject.OpenPortRange, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetProtocol())
            {
                context.Writer.WritePropertyName("Protocol");
                context.Writer.WriteStringValue(requestObject.Protocol);
            }

            if(requestObject.IsSetSourceDomain())
            {
                context.Writer.WritePropertyName("SourceDomain");
                context.Writer.WriteStringValue(requestObject.SourceDomain);
            }

            if(requestObject.IsSetSourceIpV4())
            {
                context.Writer.WritePropertyName("SourceIpV4");
                context.Writer.WriteStringValue(requestObject.SourceIpV4);
            }

            if(requestObject.IsSetSourceIpV6())
            {
                context.Writer.WritePropertyName("SourceIpV6");
                context.Writer.WriteStringValue(requestObject.SourceIpV6);
            }

            if(requestObject.IsSetSourceMac())
            {
                context.Writer.WritePropertyName("SourceMac");
                context.Writer.WriteStringValue(requestObject.SourceMac);
            }

            if(requestObject.IsSetSourcePort())
            {
                context.Writer.WritePropertyName("SourcePort");
                context.Writer.WriteNumberValue(requestObject.SourcePort.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static NetworkMarshaller Instance = new NetworkMarshaller();

    }
}