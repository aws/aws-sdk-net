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
 * Do not modify this file. This file is generated from the finspace-2021-03-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Finspace.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Finspace.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// NetworkACLEntry Marshaller
    /// </summary>
    public class NetworkACLEntryMarshaller : IRequestMarshaller<NetworkACLEntry, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(NetworkACLEntry requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCidrBlock())
            {
                context.Writer.WritePropertyName("cidrBlock");
                context.Writer.WriteStringValue(requestObject.CidrBlock);
            }

            if(requestObject.IsSetIcmpTypeCode())
            {
                context.Writer.WritePropertyName("icmpTypeCode");
                context.Writer.WriteStartObject();

                var marshaller = IcmpTypeCodeMarshaller.Instance;
                marshaller.Marshall(requestObject.IcmpTypeCode, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPortRange())
            {
                context.Writer.WritePropertyName("portRange");
                context.Writer.WriteStartObject();

                var marshaller = PortRangeMarshaller.Instance;
                marshaller.Marshall(requestObject.PortRange, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetProtocol())
            {
                context.Writer.WritePropertyName("protocol");
                context.Writer.WriteStringValue(requestObject.Protocol);
            }

            if(requestObject.IsSetRuleAction())
            {
                context.Writer.WritePropertyName("ruleAction");
                context.Writer.WriteStringValue(requestObject.RuleAction);
            }

            if(requestObject.IsSetRuleNumber())
            {
                context.Writer.WritePropertyName("ruleNumber");
                context.Writer.WriteNumberValue(requestObject.RuleNumber.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static NetworkACLEntryMarshaller Instance = new NetworkACLEntryMarshaller();

    }
}