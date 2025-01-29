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
    /// ModelQualityJobInput Marshaller
    /// </summary>
    public class ModelQualityJobInputMarshaller : IRequestMarshaller<ModelQualityJobInput, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ModelQualityJobInput requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBatchTransformInput())
            {
                context.Writer.WritePropertyName("BatchTransformInput");
                context.Writer.WriteStartObject();

                var marshaller = BatchTransformInputMarshaller.Instance;
                marshaller.Marshall(requestObject.BatchTransformInput, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetEndpointInput())
            {
                context.Writer.WritePropertyName("EndpointInput");
                context.Writer.WriteStartObject();

                var marshaller = EndpointInputMarshaller.Instance;
                marshaller.Marshall(requestObject.EndpointInput, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetGroundTruthS3Input())
            {
                context.Writer.WritePropertyName("GroundTruthS3Input");
                context.Writer.WriteStartObject();

                var marshaller = MonitoringGroundTruthS3InputMarshaller.Instance;
                marshaller.Marshall(requestObject.GroundTruthS3Input, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ModelQualityJobInputMarshaller Instance = new ModelQualityJobInputMarshaller();

    }
}