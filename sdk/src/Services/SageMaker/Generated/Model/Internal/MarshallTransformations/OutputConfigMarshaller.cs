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
    /// OutputConfig Marshaller
    /// </summary>       
    public class OutputConfigMarshaller : IRequestMarshaller<OutputConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(OutputConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetCompilerOptions())
            {
                context.Writer.WritePropertyName("CompilerOptions");
                context.Writer.Write(requestObject.CompilerOptions);
            }

            if(requestObject.IsSetKmsKeyId())
            {
                context.Writer.WritePropertyName("KmsKeyId");
                context.Writer.Write(requestObject.KmsKeyId);
            }

            if(requestObject.IsSetS3OutputLocation())
            {
                context.Writer.WritePropertyName("S3OutputLocation");
                context.Writer.Write(requestObject.S3OutputLocation);
            }

            if(requestObject.IsSetTargetDevice())
            {
                context.Writer.WritePropertyName("TargetDevice");
                context.Writer.Write(requestObject.TargetDevice);
            }

            if(requestObject.IsSetTargetPlatform())
            {
                context.Writer.WritePropertyName("TargetPlatform");
                context.Writer.WriteObjectStart();

                var marshaller = TargetPlatformMarshaller.Instance;
                marshaller.Marshall(requestObject.TargetPlatform, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static OutputConfigMarshaller Instance = new OutputConfigMarshaller();

    }
}