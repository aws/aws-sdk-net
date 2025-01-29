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
 * Do not modify this file. This file is generated from the inspector-2016-02-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Inspector.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Inspector.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AssessmentTemplateFilter Marshaller
    /// </summary>
    public class AssessmentTemplateFilterMarshaller : IRequestMarshaller<AssessmentTemplateFilter, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AssessmentTemplateFilter requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDurationRange())
            {
                context.Writer.WritePropertyName("durationRange");
                context.Writer.WriteStartObject();

                var marshaller = DurationRangeMarshaller.Instance;
                marshaller.Marshall(requestObject.DurationRange, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetNamePattern())
            {
                context.Writer.WritePropertyName("namePattern");
                context.Writer.WriteStringValue(requestObject.NamePattern);
            }

            if(requestObject.IsSetRulesPackageArns())
            {
                context.Writer.WritePropertyName("rulesPackageArns");
                context.Writer.WriteStartArray();
                foreach(var requestObjectRulesPackageArnsListValue in requestObject.RulesPackageArns)
                {
                        context.Writer.WriteStringValue(requestObjectRulesPackageArnsListValue);
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AssessmentTemplateFilterMarshaller Instance = new AssessmentTemplateFilterMarshaller();

    }
}