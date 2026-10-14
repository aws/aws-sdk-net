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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.Glue.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DataQualityResultsV2FilterCriteria Marshaller
    /// </summary>
    public partial class DataQualityResultsV2FilterCriteriaMarshaller : IRequestMarshaller<DataQualityResultsV2FilterCriteria, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(DataQualityResultsV2FilterCriteria requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetDataSource())
            {
                context.Writer.WritePropertyName("DataSource");
                context.Writer.WriteStartObject();

                var marshaller = DataSourceMarshaller.Instance;
                marshaller.Marshall(requestObject.DataSource, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetDimensions())
            {
                context.Writer.WritePropertyName("Dimensions");
                context.Writer.WriteStartObject();
                foreach (var requestObjectDimensionsKvp in requestObject.Dimensions)
                {
                    context.Writer.WritePropertyName(requestObjectDimensionsKvp.Key);
                    var requestObjectDimensionsValue = requestObjectDimensionsKvp.Value;
                    context.Writer.WriteStringValue(requestObjectDimensionsValue);
                }
                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetEvaluationContext())
            {
                context.Writer.WritePropertyName("EvaluationContext");
                context.Writer.WriteStringValue(requestObject.EvaluationContext);
            }

            if (requestObject.IsSetPublishedAfter())
            {
                context.Writer.WritePropertyName("PublishedAfter");
                context.Writer.WriteNumberValue(Amazon.Util.AWSSDKUtils.ConvertToUnixEpochSecondsDecimal(requestObject.PublishedAfter.Value));
            }

            if (requestObject.IsSetPublishedBefore())
            {
                context.Writer.WritePropertyName("PublishedBefore");
                context.Writer.WriteNumberValue(Amazon.Util.AWSSDKUtils.ConvertToUnixEpochSecondsDecimal(requestObject.PublishedBefore.Value));
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static DataQualityResultsV2FilterCriteriaMarshaller Instance = new DataQualityResultsV2FilterCriteriaMarshaller();
    }
}
