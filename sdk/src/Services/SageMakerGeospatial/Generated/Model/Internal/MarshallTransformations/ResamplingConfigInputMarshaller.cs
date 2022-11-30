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
 * Do not modify this file. This file is generated from the sagemaker-geospatial-2020-05-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SageMakerGeospatial.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SageMakerGeospatial.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ResamplingConfigInput Marshaller
    /// </summary>
    public class ResamplingConfigInputMarshaller : IRequestMarshaller<ResamplingConfigInput, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ResamplingConfigInput requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAlgorithmName())
            {
                context.Writer.WritePropertyName("AlgorithmName");
                context.Writer.Write(requestObject.AlgorithmName);
            }

            if(requestObject.IsSetOutputResolution())
            {
                context.Writer.WritePropertyName("OutputResolution");
                context.Writer.WriteObjectStart();

                var marshaller = OutputResolutionResamplingInputMarshaller.Instance;
                marshaller.Marshall(requestObject.OutputResolution, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTargetBands())
            {
                context.Writer.WritePropertyName("TargetBands");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectTargetBandsListValue in requestObject.TargetBands)
                {
                        context.Writer.Write(requestObjectTargetBandsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ResamplingConfigInputMarshaller Instance = new ResamplingConfigInputMarshaller();

    }
}