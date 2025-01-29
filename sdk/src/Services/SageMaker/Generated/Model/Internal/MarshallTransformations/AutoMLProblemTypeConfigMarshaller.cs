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
    /// AutoMLProblemTypeConfig Marshaller
    /// </summary>
    public class AutoMLProblemTypeConfigMarshaller : IRequestMarshaller<AutoMLProblemTypeConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AutoMLProblemTypeConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetImageClassificationJobConfig())
            {
                context.Writer.WritePropertyName("ImageClassificationJobConfig");
                context.Writer.WriteStartObject();

                var marshaller = ImageClassificationJobConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.ImageClassificationJobConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTabularJobConfig())
            {
                context.Writer.WritePropertyName("TabularJobConfig");
                context.Writer.WriteStartObject();

                var marshaller = TabularJobConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.TabularJobConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTextClassificationJobConfig())
            {
                context.Writer.WritePropertyName("TextClassificationJobConfig");
                context.Writer.WriteStartObject();

                var marshaller = TextClassificationJobConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.TextClassificationJobConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTextGenerationJobConfig())
            {
                context.Writer.WritePropertyName("TextGenerationJobConfig");
                context.Writer.WriteStartObject();

                var marshaller = TextGenerationJobConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.TextGenerationJobConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTimeSeriesForecastingJobConfig())
            {
                context.Writer.WritePropertyName("TimeSeriesForecastingJobConfig");
                context.Writer.WriteStartObject();

                var marshaller = TimeSeriesForecastingJobConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.TimeSeriesForecastingJobConfig, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AutoMLProblemTypeConfigMarshaller Instance = new AutoMLProblemTypeConfigMarshaller();

    }
}