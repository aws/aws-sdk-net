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

using Amazon.ELBProxy.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.ELBProxy.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateProxyVpcConfiguration Marshaller
    /// </summary>
    public partial class UpdateProxyVpcConfigurationMarshaller : IRequestMarshaller<UpdateProxyVpcConfiguration, CborMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(UpdateProxyVpcConfiguration requestObject, CborMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetSecurityGroups())
            {
                context.Writer.WriteTextString("securityGroups");
                context.Writer.WriteStartArray(requestObject.SecurityGroups.Count);
                foreach (var requestObjectSecurityGroupsListValue in requestObject.SecurityGroups)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = SecurityGroupDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectSecurityGroupsListValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetSubnets())
            {
                context.Writer.WriteTextString("subnets");
                context.Writer.WriteStartArray(requestObject.Subnets.Count);
                foreach (var requestObjectSubnetsListValue in requestObject.Subnets)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = SubnetDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectSubnetsListValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndArray();
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static UpdateProxyVpcConfigurationMarshaller Instance = new UpdateProxyVpcConfigurationMarshaller();
    }
}
