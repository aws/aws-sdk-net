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
using ThirdParty.Json.LitJson;

namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DataCaptureConfig Marshaller
    /// </summary>       
    public class DataCaptureConfigMarshaller : IRequestMarshaller<DataCaptureConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DataCaptureConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetCaptureContentTypeHeader())
            {
                context.Writer.WritePropertyName("CaptureContentTypeHeader");
                context.Writer.WriteObjectStart();

                var marshaller = CaptureContentTypeHeaderMarshaller.Instance;
                marshaller.Marshall(requestObject.CaptureContentTypeHeader, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetCaptureOptions())
            {
                context.Writer.WritePropertyName("CaptureOptions");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectCaptureOptionsListValue in requestObject.CaptureOptions)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = CaptureOptionMarshaller.Instance;
                    marshaller.Marshall(requestObjectCaptureOptionsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetDestinationS3Uri())
            {
                context.Writer.WritePropertyName("DestinationS3Uri");
                context.Writer.Write(requestObject.DestinationS3Uri);
            }

            if(requestObject.IsSetEnableCapture())
            {
                context.Writer.WritePropertyName("EnableCapture");
                context.Writer.Write(requestObject.EnableCapture);
            }

            if(requestObject.IsSetInitialSamplingPercentage())
            {
                context.Writer.WritePropertyName("InitialSamplingPercentage");
                context.Writer.Write(requestObject.InitialSamplingPercentage);
            }

            if(requestObject.IsSetKmsKeyId())
            {
                context.Writer.WritePropertyName("KmsKeyId");
                context.Writer.Write(requestObject.KmsKeyId);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static DataCaptureConfigMarshaller Instance = new DataCaptureConfigMarshaller();

    }
}