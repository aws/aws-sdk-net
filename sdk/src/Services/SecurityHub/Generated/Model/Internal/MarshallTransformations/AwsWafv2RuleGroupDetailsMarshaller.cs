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
    /// AwsWafv2RuleGroupDetails Marshaller
    /// </summary>
    public class AwsWafv2RuleGroupDetailsMarshaller : IRequestMarshaller<AwsWafv2RuleGroupDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsWafv2RuleGroupDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetArn())
            {
                context.Writer.WritePropertyName("Arn");
                context.Writer.WriteStringValue(requestObject.Arn);
            }

            if(requestObject.IsSetCapacity())
            {
                context.Writer.WritePropertyName("Capacity");
                context.Writer.WriteNumberValue(requestObject.Capacity.Value);
            }

            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(requestObject.Description);
            }

            if(requestObject.IsSetId())
            {
                context.Writer.WritePropertyName("Id");
                context.Writer.WriteStringValue(requestObject.Id);
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(requestObject.Name);
            }

            if(requestObject.IsSetRules())
            {
                context.Writer.WritePropertyName("Rules");
                context.Writer.WriteStartArray();
                foreach(var requestObjectRulesListValue in requestObject.Rules)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsWafv2RulesDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectRulesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetScope())
            {
                context.Writer.WritePropertyName("Scope");
                context.Writer.WriteStringValue(requestObject.Scope);
            }

            if(requestObject.IsSetVisibilityConfig())
            {
                context.Writer.WritePropertyName("VisibilityConfig");
                context.Writer.WriteStartObject();

                var marshaller = AwsWafv2VisibilityConfigDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.VisibilityConfig, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsWafv2RuleGroupDetailsMarshaller Instance = new AwsWafv2RuleGroupDetailsMarshaller();

    }
}