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
    /// AssessmentConfiguration Marshaller
    /// </summary>
    public partial class AssessmentConfigurationMarshaller : IRequestMarshaller<AssessmentConfiguration, CborMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(AssessmentConfiguration requestObject, CborMarshallerContext context)
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

            if (requestObject.IsSetDnsName())
            {
                context.Writer.WriteTextString("DnsName");
                context.Writer.WriteTextString(requestObject.DnsName);
            }

            if (requestObject.IsSetInstanceIds())
            {
                context.Writer.WriteTextString("InstanceIds");
                context.Writer.WriteStartArray(requestObject.InstanceIds.Count);
                foreach (var requestObjectInstanceIdsListValue in requestObject.InstanceIds)
                {
                    context.Writer.WriteTextString(requestObjectInstanceIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetSecurityGroupIds())
            {
                context.Writer.WriteTextString("SecurityGroupIds");
                context.Writer.WriteStartArray(requestObject.SecurityGroupIds.Count);
                foreach (var requestObjectSecurityGroupIdsListValue in requestObject.SecurityGroupIds)
                {
                    context.Writer.WriteTextString(requestObjectSecurityGroupIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetVpcSettings())
            {
                context.Writer.WriteTextString("VpcSettings");
                context.Writer.WriteStartMap(null);

                var marshaller = DirectoryVpcSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.VpcSettings, context);

                context.Writer.WriteEndMap();
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static AssessmentConfigurationMarshaller Instance = new AssessmentConfigurationMarshaller();
    }
}
