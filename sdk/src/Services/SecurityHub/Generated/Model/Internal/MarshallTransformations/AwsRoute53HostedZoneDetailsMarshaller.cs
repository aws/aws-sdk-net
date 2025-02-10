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
    /// AwsRoute53HostedZoneDetails Marshaller
    /// </summary>
    public class AwsRoute53HostedZoneDetailsMarshaller : IRequestMarshaller<AwsRoute53HostedZoneDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsRoute53HostedZoneDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetHostedZone())
            {
                context.Writer.WritePropertyName("HostedZone");
                context.Writer.WriteStartObject();

                var marshaller = AwsRoute53HostedZoneObjectDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.HostedZone, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetNameServers())
            {
                context.Writer.WritePropertyName("NameServers");
                context.Writer.WriteStartArray();
                foreach(var requestObjectNameServersListValue in requestObject.NameServers)
                {
                        context.Writer.WriteStringValue(requestObjectNameServersListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetQueryLoggingConfig())
            {
                context.Writer.WritePropertyName("QueryLoggingConfig");
                context.Writer.WriteStartObject();

                var marshaller = AwsRoute53QueryLoggingConfigDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.QueryLoggingConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetVpcs())
            {
                context.Writer.WritePropertyName("Vpcs");
                context.Writer.WriteStartArray();
                foreach(var requestObjectVpcsListValue in requestObject.Vpcs)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsRoute53HostedZoneVpcDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectVpcsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsRoute53HostedZoneDetailsMarshaller Instance = new AwsRoute53HostedZoneDetailsMarshaller();

    }
}