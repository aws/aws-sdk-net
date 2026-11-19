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

using Amazon.DirectoryService.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.DirectoryService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DirectoryConnectSettings Marshaller
    /// </summary>
    public partial class DirectoryConnectSettingsMarshaller : IRequestMarshaller<DirectoryConnectSettings, CborMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(DirectoryConnectSettings requestObject, CborMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetCustomerDnsIps())
            {
                context.Writer.WriteTextString("CustomerDnsIps");
                context.Writer.WriteStartArray(requestObject.CustomerDnsIps.Count);
                foreach (var requestObjectCustomerDnsIpsListValue in requestObject.CustomerDnsIps)
                {
                    context.Writer.WriteTextString(requestObjectCustomerDnsIpsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetCustomerDnsIpsV6())
            {
                context.Writer.WriteTextString("CustomerDnsIpsV6");
                context.Writer.WriteStartArray(requestObject.CustomerDnsIpsV6.Count);
                foreach (var requestObjectCustomerDnsIpsV6ListValue in requestObject.CustomerDnsIpsV6)
                {
                    context.Writer.WriteTextString(requestObjectCustomerDnsIpsV6ListValue);
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetCustomerUserName())
            {
                context.Writer.WriteTextString("CustomerUserName");
                context.Writer.WriteTextString(requestObject.CustomerUserName);
            }

            if (requestObject.IsSetSubnetIds())
            {
                context.Writer.WriteTextString("SubnetIds");
                context.Writer.WriteStartArray(requestObject.SubnetIds.Count);
                foreach (var requestObjectSubnetIdsListValue in requestObject.SubnetIds)
                {
                    context.Writer.WriteTextString(requestObjectSubnetIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetVpcId())
            {
                context.Writer.WriteTextString("VpcId");
                context.Writer.WriteTextString(requestObject.VpcId);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static DirectoryConnectSettingsMarshaller Instance = new DirectoryConnectSettingsMarshaller();
    }
}
