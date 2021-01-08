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
 * Do not modify this file. This file is generated from the sagemaker-edge-2020-09-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SagemakerEdgeManager.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SagemakerEdgeManager.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Model Marshaller
    /// </summary>       
    public class ModelMarshaller : IRequestMarshaller<Model, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Model requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetLatestInference())
            {
                context.Writer.WritePropertyName("LatestInference");
                context.Writer.Write(requestObject.LatestInference);
            }

            if(requestObject.IsSetLatestSampleTime())
            {
                context.Writer.WritePropertyName("LatestSampleTime");
                context.Writer.Write(requestObject.LatestSampleTime);
            }

            if(requestObject.IsSetModelMetrics())
            {
                context.Writer.WritePropertyName("ModelMetrics");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectModelMetricsListValue in requestObject.ModelMetrics)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = EdgeMetricMarshaller.Instance;
                    marshaller.Marshall(requestObjectModelMetricsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetModelName())
            {
                context.Writer.WritePropertyName("ModelName");
                context.Writer.Write(requestObject.ModelName);
            }

            if(requestObject.IsSetModelVersion())
            {
                context.Writer.WritePropertyName("ModelVersion");
                context.Writer.Write(requestObject.ModelVersion);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static ModelMarshaller Instance = new ModelMarshaller();

    }
}