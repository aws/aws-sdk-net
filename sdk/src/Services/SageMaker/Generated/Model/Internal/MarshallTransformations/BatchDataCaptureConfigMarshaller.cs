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
    /// BatchDataCaptureConfig Marshaller
    /// </summary>
    public class BatchDataCaptureConfigMarshaller : IRequestMarshaller<BatchDataCaptureConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(BatchDataCaptureConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDestinationS3Uri())
            {
                context.Writer.WritePropertyName("DestinationS3Uri");
                context.Writer.WriteStringValue(requestObject.DestinationS3Uri);
            }

            if(requestObject.IsSetGenerateInferenceId())
            {
                context.Writer.WritePropertyName("GenerateInferenceId");
                context.Writer.WriteBooleanValue(requestObject.GenerateInferenceId.Value);
            }

            if(requestObject.IsSetKmsKeyId())
            {
                context.Writer.WritePropertyName("KmsKeyId");
                context.Writer.WriteStringValue(requestObject.KmsKeyId);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static BatchDataCaptureConfigMarshaller Instance = new BatchDataCaptureConfigMarshaller();

    }
}