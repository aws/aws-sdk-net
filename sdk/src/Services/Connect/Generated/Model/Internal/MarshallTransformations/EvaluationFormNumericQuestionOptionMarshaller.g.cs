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

using Amazon.Connect.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.Connect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// EvaluationFormNumericQuestionOption Marshaller
    /// </summary>
    public partial class EvaluationFormNumericQuestionOptionMarshaller : IRequestMarshaller<EvaluationFormNumericQuestionOption, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(EvaluationFormNumericQuestionOption requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetAutomaticFail())
            {
                context.Writer.WritePropertyName("AutomaticFail");
                context.Writer.WriteBooleanValue(requestObject.AutomaticFail.Value);
            }

            if (requestObject.IsSetAutomaticFailConfiguration())
            {
                context.Writer.WritePropertyName("AutomaticFailConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = AutomaticFailConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.AutomaticFailConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetMaxValue())
            {
                context.Writer.WritePropertyName("MaxValue");
                context.Writer.WriteNumberValue(requestObject.MaxValue.Value);
            }

            if (requestObject.IsSetMinValue())
            {
                context.Writer.WritePropertyName("MinValue");
                context.Writer.WriteNumberValue(requestObject.MinValue.Value);
            }

            if (requestObject.IsSetPointsConfiguration())
            {
                context.Writer.WritePropertyName("PointsConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = QuestionOptionPointsConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.PointsConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetScore())
            {
                context.Writer.WritePropertyName("Score");
                context.Writer.WriteNumberValue(requestObject.Score.Value);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static EvaluationFormNumericQuestionOptionMarshaller Instance = new EvaluationFormNumericQuestionOptionMarshaller();
    }
}
