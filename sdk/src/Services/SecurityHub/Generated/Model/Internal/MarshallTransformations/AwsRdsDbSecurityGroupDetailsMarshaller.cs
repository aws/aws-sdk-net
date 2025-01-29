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
    /// AwsRdsDbSecurityGroupDetails Marshaller
    /// </summary>
    public class AwsRdsDbSecurityGroupDetailsMarshaller : IRequestMarshaller<AwsRdsDbSecurityGroupDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsRdsDbSecurityGroupDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDbSecurityGroupArn())
            {
                context.Writer.WritePropertyName("DbSecurityGroupArn");
                context.Writer.WriteStringValue(requestObject.DbSecurityGroupArn);
            }

            if(requestObject.IsSetDbSecurityGroupDescription())
            {
                context.Writer.WritePropertyName("DbSecurityGroupDescription");
                context.Writer.WriteStringValue(requestObject.DbSecurityGroupDescription);
            }

            if(requestObject.IsSetDbSecurityGroupName())
            {
                context.Writer.WritePropertyName("DbSecurityGroupName");
                context.Writer.WriteStringValue(requestObject.DbSecurityGroupName);
            }

            if(requestObject.IsSetEc2SecurityGroups())
            {
                context.Writer.WritePropertyName("Ec2SecurityGroups");
                context.Writer.WriteStartArray();
                foreach(var requestObjectEc2SecurityGroupsListValue in requestObject.Ec2SecurityGroups)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsRdsDbSecurityGroupEc2SecurityGroupMarshaller.Instance;
                    marshaller.Marshall(requestObjectEc2SecurityGroupsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetIpRanges())
            {
                context.Writer.WritePropertyName("IpRanges");
                context.Writer.WriteStartArray();
                foreach(var requestObjectIpRangesListValue in requestObject.IpRanges)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsRdsDbSecurityGroupIpRangeMarshaller.Instance;
                    marshaller.Marshall(requestObjectIpRangesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetOwnerId())
            {
                context.Writer.WritePropertyName("OwnerId");
                context.Writer.WriteStringValue(requestObject.OwnerId);
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
        public readonly static AwsRdsDbSecurityGroupDetailsMarshaller Instance = new AwsRdsDbSecurityGroupDetailsMarshaller();

    }
}