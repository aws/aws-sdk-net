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
    /// NamedEntityDefinition Marshaller
    /// </summary>
    public class NamedEntityDefinitionMarshaller : IRequestMarshaller<NamedEntityDefinition, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(NamedEntityDefinition requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetFieldName())
            {
                context.Writer.WritePropertyName("FieldName");
                context.Writer.WriteStringValue(requestObject.FieldName);
            }

            if(requestObject.IsSetMetric())
            {
                context.Writer.WritePropertyName("Metric");
                context.Writer.WriteStartObject();

                var marshaller = NamedEntityDefinitionMetricMarshaller.Instance;
                marshaller.Marshall(requestObject.Metric, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPropertyName())
            {
                context.Writer.WritePropertyName("PropertyName");
                context.Writer.WriteStringValue(requestObject.PropertyName);
            }

            if(requestObject.IsSetPropertyRole())
            {
                context.Writer.WritePropertyName("PropertyRole");
                context.Writer.WriteStringValue(requestObject.PropertyRole);
            }

            if(requestObject.IsSetPropertyUsage())
            {
                context.Writer.WritePropertyName("PropertyUsage");
                context.Writer.WriteStringValue(requestObject.PropertyUsage);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static NamedEntityDefinitionMarshaller Instance = new NamedEntityDefinitionMarshaller();

    }
}