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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SageMaker.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// QueryFilters Marshaller
    /// </summary>
    public class QueryFiltersMarshaller : IRequestMarshaller<QueryFilters, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(QueryFilters requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCreatedAfter())
            {
                context.Writer.WritePropertyName("CreatedAfter");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(requestObject.CreatedAfter.Value)));
            }

            if(requestObject.IsSetCreatedBefore())
            {
                context.Writer.WritePropertyName("CreatedBefore");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(requestObject.CreatedBefore.Value)));
            }

            if(requestObject.IsSetLineageTypes())
            {
                context.Writer.WritePropertyName("LineageTypes");
                context.Writer.WriteStartArray();
                foreach(var requestObjectLineageTypesListValue in requestObject.LineageTypes)
                {
                        context.Writer.WriteStringValue(requestObjectLineageTypesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetModifiedAfter())
            {
                context.Writer.WritePropertyName("ModifiedAfter");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(requestObject.ModifiedAfter.Value)));
            }

            if(requestObject.IsSetModifiedBefore())
            {
                context.Writer.WritePropertyName("ModifiedBefore");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(requestObject.ModifiedBefore.Value)));
            }

            if(requestObject.IsSetProperties())
            {
                context.Writer.WritePropertyName("Properties");
                context.Writer.WriteStartObject();
                foreach (var requestObjectPropertiesKvp in requestObject.Properties)
                {
                    context.Writer.WritePropertyName(requestObjectPropertiesKvp.Key);
                    var requestObjectPropertiesValue = requestObjectPropertiesKvp.Value;

                        context.Writer.WriteStringValue(requestObjectPropertiesValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTypes())
            {
                context.Writer.WritePropertyName("Types");
                context.Writer.WriteStartArray();
                foreach(var requestObjectTypesListValue in requestObject.Types)
                {
                        context.Writer.WriteStringValue(requestObjectTypesListValue);
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static QueryFiltersMarshaller Instance = new QueryFiltersMarshaller();

    }
}