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
    /// AwsWafRegionalWebAclDetails Marshaller
    /// </summary>
    public class AwsWafRegionalWebAclDetailsMarshaller : IRequestMarshaller<AwsWafRegionalWebAclDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsWafRegionalWebAclDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDefaultAction())
            {
                context.Writer.WritePropertyName("DefaultAction");
                context.Writer.WriteStringValue(requestObject.DefaultAction);
            }

            if(requestObject.IsSetMetricName())
            {
                context.Writer.WritePropertyName("MetricName");
                context.Writer.WriteStringValue(requestObject.MetricName);
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(requestObject.Name);
            }

            if(requestObject.IsSetRulesList())
            {
                context.Writer.WritePropertyName("RulesList");
                context.Writer.WriteStartArray();
                foreach(var requestObjectRulesListListValue in requestObject.RulesList)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsWafRegionalWebAclRulesListDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectRulesListListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetWebAclId())
            {
                context.Writer.WritePropertyName("WebAclId");
                context.Writer.WriteStringValue(requestObject.WebAclId);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsWafRegionalWebAclDetailsMarshaller Instance = new AwsWafRegionalWebAclDetailsMarshaller();

    }
}