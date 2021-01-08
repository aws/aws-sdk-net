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
 * Do not modify this file. This file is generated from the lookoutvision-2020-11-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LookoutforVision.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.LookoutforVision.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ModelDescription Marshaller
    /// </summary>       
    public class ModelDescriptionMarshaller : IRequestMarshaller<ModelDescription, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ModelDescription requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetCreationTimestamp())
            {
                context.Writer.WritePropertyName("CreationTimestamp");
                context.Writer.Write(requestObject.CreationTimestamp);
            }

            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.Write(requestObject.Description);
            }

            if(requestObject.IsSetEvaluationEndTimestamp())
            {
                context.Writer.WritePropertyName("EvaluationEndTimestamp");
                context.Writer.Write(requestObject.EvaluationEndTimestamp);
            }

            if(requestObject.IsSetEvaluationManifest())
            {
                context.Writer.WritePropertyName("EvaluationManifest");
                context.Writer.WriteObjectStart();

                var marshaller = OutputS3ObjectMarshaller.Instance;
                marshaller.Marshall(requestObject.EvaluationManifest, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetEvaluationResult())
            {
                context.Writer.WritePropertyName("EvaluationResult");
                context.Writer.WriteObjectStart();

                var marshaller = OutputS3ObjectMarshaller.Instance;
                marshaller.Marshall(requestObject.EvaluationResult, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetKmsKeyId())
            {
                context.Writer.WritePropertyName("KmsKeyId");
                context.Writer.Write(requestObject.KmsKeyId);
            }

            if(requestObject.IsSetModelArn())
            {
                context.Writer.WritePropertyName("ModelArn");
                context.Writer.Write(requestObject.ModelArn);
            }

            if(requestObject.IsSetModelVersion())
            {
                context.Writer.WritePropertyName("ModelVersion");
                context.Writer.Write(requestObject.ModelVersion);
            }

            if(requestObject.IsSetOutputConfig())
            {
                context.Writer.WritePropertyName("OutputConfig");
                context.Writer.WriteObjectStart();

                var marshaller = OutputConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.OutputConfig, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetPerformance())
            {
                context.Writer.WritePropertyName("Performance");
                context.Writer.WriteObjectStart();

                var marshaller = ModelPerformanceMarshaller.Instance;
                marshaller.Marshall(requestObject.Performance, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetStatus())
            {
                context.Writer.WritePropertyName("Status");
                context.Writer.Write(requestObject.Status);
            }

            if(requestObject.IsSetStatusMessage())
            {
                context.Writer.WritePropertyName("StatusMessage");
                context.Writer.Write(requestObject.StatusMessage);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static ModelDescriptionMarshaller Instance = new ModelDescriptionMarshaller();

    }
}