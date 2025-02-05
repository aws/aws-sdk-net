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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.QuickSight.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RowLevelPermissionTagConfiguration Marshaller
    /// </summary>
    public class RowLevelPermissionTagConfigurationMarshaller : IRequestMarshaller<RowLevelPermissionTagConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RowLevelPermissionTagConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetStatus())
            {
                context.Writer.WritePropertyName("Status");
                context.Writer.WriteStringValue(requestObject.Status);
            }

            if(requestObject.IsSetTagRuleConfigurations())
            {
                context.Writer.WritePropertyName("TagRuleConfigurations");
                context.Writer.WriteStartArray();
                foreach(var requestObjectTagRuleConfigurationsListValue in requestObject.TagRuleConfigurations)
                {
                    context.Writer.WriteStartArray();
                    foreach(var requestObjectTagRuleConfigurationsListValueListValue in requestObjectTagRuleConfigurationsListValue)
                    {
                            context.Writer.WriteStringValue(requestObjectTagRuleConfigurationsListValueListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetTagRules())
            {
                context.Writer.WritePropertyName("TagRules");
                context.Writer.WriteStartArray();
                foreach(var requestObjectTagRulesListValue in requestObject.TagRules)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = RowLevelPermissionTagRuleMarshaller.Instance;
                    marshaller.Marshall(requestObjectTagRulesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RowLevelPermissionTagConfigurationMarshaller Instance = new RowLevelPermissionTagConfigurationMarshaller();

    }
}