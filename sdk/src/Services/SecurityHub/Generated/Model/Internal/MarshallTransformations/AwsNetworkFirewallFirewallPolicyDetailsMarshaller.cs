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
    /// AwsNetworkFirewallFirewallPolicyDetails Marshaller
    /// </summary>
    public class AwsNetworkFirewallFirewallPolicyDetailsMarshaller : IRequestMarshaller<AwsNetworkFirewallFirewallPolicyDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsNetworkFirewallFirewallPolicyDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.Write(requestObject.Description);
            }

            if(requestObject.IsSetFirewallPolicy())
            {
                context.Writer.WritePropertyName("FirewallPolicy");
                context.Writer.WriteObjectStart();

                var marshaller = FirewallPolicyDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.FirewallPolicy, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetFirewallPolicyArn())
            {
                context.Writer.WritePropertyName("FirewallPolicyArn");
                context.Writer.Write(requestObject.FirewallPolicyArn);
            }

            if(requestObject.IsSetFirewallPolicyId())
            {
                context.Writer.WritePropertyName("FirewallPolicyId");
                context.Writer.Write(requestObject.FirewallPolicyId);
            }

            if(requestObject.IsSetFirewallPolicyName())
            {
                context.Writer.WritePropertyName("FirewallPolicyName");
                context.Writer.Write(requestObject.FirewallPolicyName);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsNetworkFirewallFirewallPolicyDetailsMarshaller Instance = new AwsNetworkFirewallFirewallPolicyDetailsMarshaller();

    }
}