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
using ThirdParty.Json.LitJson;

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
            if(requestObject.IsSetFromPort())
            {
                context.Writer.WritePropertyName("FromPort");
                context.Writer.Write(requestObject.FromPort);
            }

            if(requestObject.IsSetIpProtocol())
            {
                context.Writer.WritePropertyName("IpProtocol");
                context.Writer.Write(requestObject.IpProtocol);
            }

            if(requestObject.IsSetIpRanges())
            {
                context.Writer.WritePropertyName("IpRanges");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectIpRangesListValue in requestObject.IpRanges)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AwsEc2SecurityGroupIpRangeMarshaller.Instance;
                    marshaller.Marshall(requestObjectIpRangesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetIpv6Ranges())
            {
                context.Writer.WritePropertyName("Ipv6Ranges");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectIpv6RangesListValue in requestObject.Ipv6Ranges)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AwsEc2SecurityGroupIpv6RangeMarshaller.Instance;
                    marshaller.Marshall(requestObjectIpv6RangesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetPrefixListIds())
            {
                context.Writer.WritePropertyName("PrefixListIds");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectPrefixListIdsListValue in requestObject.PrefixListIds)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AwsEc2SecurityGroupPrefixListIdMarshaller.Instance;
                    marshaller.Marshall(requestObjectPrefixListIdsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetToPort())
            {
                context.Writer.WritePropertyName("ToPort");
                context.Writer.Write(requestObject.ToPort);
            }

            if(requestObject.IsSetUserIdGroupPairs())
            {
                context.Writer.WritePropertyName("UserIdGroupPairs");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectUserIdGroupPairsListValue in requestObject.UserIdGroupPairs)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AwsEc2SecurityGroupUserIdGroupPairMarshaller.Instance;
                    marshaller.Marshall(requestObjectUserIdGroupPairsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static AwsEc2SecurityGroupIpPermissionMarshaller Instance = new AwsEc2SecurityGroupIpPermissionMarshaller();

    }
}