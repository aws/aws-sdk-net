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
    /// AwsEc2SecurityGroupIpPermission Marshaller
    /// </summary>
    public class AwsEc2SecurityGroupIpPermissionMarshaller : IRequestMarshaller<AwsEc2SecurityGroupIpPermission, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsEc2SecurityGroupIpPermission requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetFromPort())
            {
                context.Writer.WritePropertyName("FromPort");
                context.Writer.WriteNumberValue(requestObject.FromPort.Value);
            }

            if(requestObject.IsSetIpProtocol())
            {
                context.Writer.WritePropertyName("IpProtocol");
                context.Writer.WriteStringValue(requestObject.IpProtocol);
            }

            if(requestObject.IsSetIpRanges())
            {
                context.Writer.WritePropertyName("IpRanges");
                context.Writer.WriteStartArray();
                foreach(var requestObjectIpRangesListValue in requestObject.IpRanges)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsEc2SecurityGroupIpRangeMarshaller.Instance;
                    marshaller.Marshall(requestObjectIpRangesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetIpv6Ranges())
            {
                context.Writer.WritePropertyName("Ipv6Ranges");
                context.Writer.WriteStartArray();
                foreach(var requestObjectIpv6RangesListValue in requestObject.Ipv6Ranges)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsEc2SecurityGroupIpv6RangeMarshaller.Instance;
                    marshaller.Marshall(requestObjectIpv6RangesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetPrefixListIds())
            {
                context.Writer.WritePropertyName("PrefixListIds");
                context.Writer.WriteStartArray();
                foreach(var requestObjectPrefixListIdsListValue in requestObject.PrefixListIds)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsEc2SecurityGroupPrefixListIdMarshaller.Instance;
                    marshaller.Marshall(requestObjectPrefixListIdsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetToPort())
            {
                context.Writer.WritePropertyName("ToPort");
                context.Writer.WriteNumberValue(requestObject.ToPort.Value);
            }

            if(requestObject.IsSetUserIdGroupPairs())
            {
                context.Writer.WritePropertyName("UserIdGroupPairs");
                context.Writer.WriteStartArray();
                foreach(var requestObjectUserIdGroupPairsListValue in requestObject.UserIdGroupPairs)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsEc2SecurityGroupUserIdGroupPairMarshaller.Instance;
                    marshaller.Marshall(requestObjectUserIdGroupPairsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsEc2SecurityGroupIpPermissionMarshaller Instance = new AwsEc2SecurityGroupIpPermissionMarshaller();

    }
}