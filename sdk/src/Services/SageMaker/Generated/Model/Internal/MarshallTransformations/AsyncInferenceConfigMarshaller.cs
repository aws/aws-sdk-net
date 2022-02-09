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
    /// AsyncInferenceConfig Marshaller
    /// </summary>
    public class AsyncInferenceConfigMarshaller : IRequestMarshaller<AsyncInferenceConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AsyncInferenceConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetClientConfig())
            {
                context.Writer.WritePropertyName("ClientConfig");
                context.Writer.WriteObjectStart();

                var marshaller = AsyncInferenceClientConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.ClientConfig, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetOutputConfig())
            {
                context.Writer.WritePropertyName("OutputConfig");
                context.Writer.WriteObjectStart();

                var marshaller = AsyncInferenceOutputConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.OutputConfig, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AsyncInferenceConfigMarshaller Instance = new AsyncInferenceConfigMarshaller();

    }
}