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
    /// ProcessingOutput Marshaller
    /// </summary>       
    public class ProcessingOutputMarshaller : IRequestMarshaller<ProcessingOutput, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ProcessingOutput requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAppManaged())
            {
                context.Writer.WritePropertyName("AppManaged");
                context.Writer.Write(requestObject.AppManaged);
            }

            if(requestObject.IsSetFeatureStoreOutput())
            {
                context.Writer.WritePropertyName("FeatureStoreOutput");
                context.Writer.WriteObjectStart();

                var marshaller = ProcessingFeatureStoreOutputMarshaller.Instance;
                marshaller.Marshall(requestObject.FeatureStoreOutput, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetOutputName())
            {
                context.Writer.WritePropertyName("OutputName");
                context.Writer.Write(requestObject.OutputName);
            }

            if(requestObject.IsSetS3Output())
            {
                context.Writer.WritePropertyName("S3Output");
                context.Writer.WriteObjectStart();

                var marshaller = ProcessingS3OutputMarshaller.Instance;
                marshaller.Marshall(requestObject.S3Output, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static ProcessingOutputMarshaller Instance = new ProcessingOutputMarshaller();

    }
}