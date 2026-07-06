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
 * Do not modify this file. This file is generated from the mailmanager-2023-10-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MailManager.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.MailManager.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PolicyCondition Marshaller
    /// </summary>
    public class PolicyConditionMarshaller : IRequestMarshaller<PolicyCondition, CborMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(PolicyCondition requestObject, CborMarshallerContext context)
        {
            if (requestObject == null)
                return;

            if (requestObject.IsSetBooleanExpression())
            {
                context.Writer.WriteTextString("BooleanExpression");
                context.Writer.WriteStartMap(null);

                var marshaller = IngressBooleanExpressionMarshaller.Instance;
                marshaller.Marshall(requestObject.BooleanExpression, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetIpExpression())
            {
                context.Writer.WriteTextString("IpExpression");
                context.Writer.WriteStartMap(null);

                var marshaller = IngressIpv4ExpressionMarshaller.Instance;
                marshaller.Marshall(requestObject.IpExpression, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetIpv6Expression())
            {
                context.Writer.WriteTextString("Ipv6Expression");
                context.Writer.WriteStartMap(null);

                var marshaller = IngressIpv6ExpressionMarshaller.Instance;
                marshaller.Marshall(requestObject.Ipv6Expression, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetStringExpression())
            {
                context.Writer.WriteTextString("StringExpression");
                context.Writer.WriteStartMap(null);

                var marshaller = IngressStringExpressionMarshaller.Instance;
                marshaller.Marshall(requestObject.StringExpression, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetTlsExpression())
            {
                context.Writer.WriteTextString("TlsExpression");
                context.Writer.WriteStartMap(null);

                var marshaller = IngressTlsProtocolExpressionMarshaller.Instance;
                marshaller.Marshall(requestObject.TlsExpression, context);

                context.Writer.WriteEndMap();
            }
        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static PolicyConditionMarshaller Instance = new PolicyConditionMarshaller();

    }
}