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
    /// DataQualityMetricValues Marshaller
    /// </summary>
    public partial class DataQualityMetricValuesMarshaller : IRequestMarshaller<DataQualityMetricValues, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(DataQualityMetricValues requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetActualValue())
            {
                context.Writer.WritePropertyName("ActualValue");
                if (StringUtils.IsSpecialDoubleValue(requestObject.ActualValue.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.ActualValue.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.ActualValue.Value);
                }
            }

            if (requestObject.IsSetExpectedValue())
            {
                context.Writer.WritePropertyName("ExpectedValue");
                if (StringUtils.IsSpecialDoubleValue(requestObject.ExpectedValue.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.ExpectedValue.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.ExpectedValue.Value);
                }
            }

            if (requestObject.IsSetLowerLimit())
            {
                context.Writer.WritePropertyName("LowerLimit");
                if (StringUtils.IsSpecialDoubleValue(requestObject.LowerLimit.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.LowerLimit.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.LowerLimit.Value);
                }
            }

            if (requestObject.IsSetUpperLimit())
            {
                context.Writer.WritePropertyName("UpperLimit");
                if (StringUtils.IsSpecialDoubleValue(requestObject.UpperLimit.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.UpperLimit.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.UpperLimit.Value);
                }
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static DataQualityMetricValuesMarshaller Instance = new DataQualityMetricValuesMarshaller();
    }
}
