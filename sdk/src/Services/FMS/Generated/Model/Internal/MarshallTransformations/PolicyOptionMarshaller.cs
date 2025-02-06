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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.FMS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.FMS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PolicyOption Marshaller
    /// </summary>
    public class PolicyOptionMarshaller : IRequestMarshaller<PolicyOption, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(PolicyOption requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetNetworkAclCommonPolicy())
            {
                context.Writer.WritePropertyName("NetworkAclCommonPolicy");
                context.Writer.WriteStartObject();

                var marshaller = NetworkAclCommonPolicyMarshaller.Instance;
                marshaller.Marshall(requestObject.NetworkAclCommonPolicy, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetNetworkFirewallPolicy())
            {
                context.Writer.WritePropertyName("NetworkFirewallPolicy");
                context.Writer.WriteStartObject();

                var marshaller = NetworkFirewallPolicyMarshaller.Instance;
                marshaller.Marshall(requestObject.NetworkFirewallPolicy, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetThirdPartyFirewallPolicy())
            {
                context.Writer.WritePropertyName("ThirdPartyFirewallPolicy");
                context.Writer.WriteStartObject();

                var marshaller = ThirdPartyFirewallPolicyMarshaller.Instance;
                marshaller.Marshall(requestObject.ThirdPartyFirewallPolicy, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static PolicyOptionMarshaller Instance = new PolicyOptionMarshaller();

    }
}