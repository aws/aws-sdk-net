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
    /// AwsEc2SecurityGroupDetails Marshaller
    /// </summary>       
    public class AwsEc2SecurityGroupDetailsMarshaller : IRequestMarshaller<AwsEc2SecurityGroupDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsEc2SecurityGroupDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetGroupId())
            {
                context.Writer.WritePropertyName("GroupId");
                context.Writer.Write(requestObject.GroupId);
            }

            if(requestObject.IsSetGroupName())
            {
                context.Writer.WritePropertyName("GroupName");
                context.Writer.Write(requestObject.GroupName);
            }

            if(requestObject.IsSetIpPermissions())
            {
                context.Writer.WritePropertyName("IpPermissions");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectIpPermissionsListValue in requestObject.IpPermissions)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AwsEc2SecurityGroupIpPermissionMarshaller.Instance;
                    marshaller.Marshall(requestObjectIpPermissionsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetIpPermissionsEgress())
            {
                context.Writer.WritePropertyName("IpPermissionsEgress");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectIpPermissionsEgressListValue in requestObject.IpPermissionsEgress)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AwsEc2SecurityGroupIpPermissionMarshaller.Instance;
                    marshaller.Marshall(requestObjectIpPermissionsEgressListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetOwnerId())
            {
                context.Writer.WritePropertyName("OwnerId");
                context.Writer.Write(requestObject.OwnerId);
            }

            if(requestObject.IsSetVpcId())
            {
                context.Writer.WritePropertyName("VpcId");
                context.Writer.Write(requestObject.VpcId);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static AwsEc2SecurityGroupDetailsMarshaller Instance = new AwsEc2SecurityGroupDetailsMarshaller();

    }
}