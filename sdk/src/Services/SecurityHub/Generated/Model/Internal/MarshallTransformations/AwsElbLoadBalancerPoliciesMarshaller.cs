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
    /// AwsElbLoadBalancerPolicies Marshaller
    /// </summary>
    public class AwsElbLoadBalancerPoliciesMarshaller : IRequestMarshaller<AwsElbLoadBalancerPolicies, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsElbLoadBalancerPolicies requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAppCookieStickinessPolicies())
            {
                context.Writer.WritePropertyName("AppCookieStickinessPolicies");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAppCookieStickinessPoliciesListValue in requestObject.AppCookieStickinessPolicies)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsElbAppCookieStickinessPolicyMarshaller.Instance;
                    marshaller.Marshall(requestObjectAppCookieStickinessPoliciesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetLbCookieStickinessPolicies())
            {
                context.Writer.WritePropertyName("LbCookieStickinessPolicies");
                context.Writer.WriteStartArray();
                foreach(var requestObjectLbCookieStickinessPoliciesListValue in requestObject.LbCookieStickinessPolicies)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsElbLbCookieStickinessPolicyMarshaller.Instance;
                    marshaller.Marshall(requestObjectLbCookieStickinessPoliciesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetOtherPolicies())
            {
                context.Writer.WritePropertyName("OtherPolicies");
                context.Writer.WriteStartArray();
                foreach(var requestObjectOtherPoliciesListValue in requestObject.OtherPolicies)
                {
                        context.Writer.WriteStringValue(requestObjectOtherPoliciesListValue);
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsElbLoadBalancerPoliciesMarshaller Instance = new AwsElbLoadBalancerPoliciesMarshaller();

    }
}