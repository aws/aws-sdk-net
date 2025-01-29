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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ConfigService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ConfigService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ConformancePackEvaluationFilters Marshaller
    /// </summary>
    public class ConformancePackEvaluationFiltersMarshaller : IRequestMarshaller<ConformancePackEvaluationFilters, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ConformancePackEvaluationFilters requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetComplianceType())
            {
                context.Writer.WritePropertyName("ComplianceType");
                context.Writer.WriteStringValue(requestObject.ComplianceType);
            }

            if(requestObject.IsSetConfigRuleNames())
            {
                context.Writer.WritePropertyName("ConfigRuleNames");
                context.Writer.WriteStartArray();
                foreach(var requestObjectConfigRuleNamesListValue in requestObject.ConfigRuleNames)
                {
                        context.Writer.WriteStringValue(requestObjectConfigRuleNamesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetResourceIds())
            {
                context.Writer.WritePropertyName("ResourceIds");
                context.Writer.WriteStartArray();
                foreach(var requestObjectResourceIdsListValue in requestObject.ResourceIds)
                {
                        context.Writer.WriteStringValue(requestObjectResourceIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetResourceType())
            {
                context.Writer.WritePropertyName("ResourceType");
                context.Writer.WriteStringValue(requestObject.ResourceType);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ConformancePackEvaluationFiltersMarshaller Instance = new ConformancePackEvaluationFiltersMarshaller();

    }
}