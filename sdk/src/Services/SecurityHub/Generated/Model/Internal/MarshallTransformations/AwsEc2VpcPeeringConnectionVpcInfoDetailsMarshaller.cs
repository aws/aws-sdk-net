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
    /// AwsEc2VpcPeeringConnectionVpcInfoDetails Marshaller
    /// </summary>
    public class AwsEc2VpcPeeringConnectionVpcInfoDetailsMarshaller : IRequestMarshaller<AwsEc2VpcPeeringConnectionVpcInfoDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsEc2VpcPeeringConnectionVpcInfoDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCidrBlock())
            {
                context.Writer.WritePropertyName("CidrBlock");
                context.Writer.WriteStringValue(requestObject.CidrBlock);
            }

            if(requestObject.IsSetCidrBlockSet())
            {
                context.Writer.WritePropertyName("CidrBlockSet");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCidrBlockSetListValue in requestObject.CidrBlockSet)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = VpcInfoCidrBlockSetDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectCidrBlockSetListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetIpv6CidrBlockSet())
            {
                context.Writer.WritePropertyName("Ipv6CidrBlockSet");
                context.Writer.WriteStartArray();
                foreach(var requestObjectIpv6CidrBlockSetListValue in requestObject.Ipv6CidrBlockSet)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = VpcInfoIpv6CidrBlockSetDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectIpv6CidrBlockSetListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetOwnerId())
            {
                context.Writer.WritePropertyName("OwnerId");
                context.Writer.WriteStringValue(requestObject.OwnerId);
            }

            if(requestObject.IsSetPeeringOptions())
            {
                context.Writer.WritePropertyName("PeeringOptions");
                context.Writer.WriteStartObject();

                var marshaller = VpcInfoPeeringOptionsDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.PeeringOptions, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRegion())
            {
                context.Writer.WritePropertyName("Region");
                context.Writer.WriteStringValue(requestObject.Region);
            }

            if(requestObject.IsSetVpcId())
            {
                context.Writer.WritePropertyName("VpcId");
                context.Writer.WriteStringValue(requestObject.VpcId);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsEc2VpcPeeringConnectionVpcInfoDetailsMarshaller Instance = new AwsEc2VpcPeeringConnectionVpcInfoDetailsMarshaller();

    }
}