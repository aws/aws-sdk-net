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
    /// ProfilerConfigForUpdate Marshaller
    /// </summary>       
    public class ProfilerConfigForUpdateMarshaller : IRequestMarshaller<ProfilerConfigForUpdate, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ProfilerConfigForUpdate requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetDisableProfiler())
            {
                context.Writer.WritePropertyName("DisableProfiler");
                context.Writer.Write(requestObject.DisableProfiler);
            }

            if(requestObject.IsSetProfilingIntervalInMilliseconds())
            {
                context.Writer.WritePropertyName("ProfilingIntervalInMilliseconds");
                context.Writer.Write(requestObject.ProfilingIntervalInMilliseconds);
            }

            if(requestObject.IsSetProfilingParameters())
            {
                context.Writer.WritePropertyName("ProfilingParameters");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectProfilingParametersKvp in requestObject.ProfilingParameters)
                {
                    context.Writer.WritePropertyName(requestObjectProfilingParametersKvp.Key);
                    var requestObjectProfilingParametersValue = requestObjectProfilingParametersKvp.Value;

                        context.Writer.Write(requestObjectProfilingParametersValue);
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetS3OutputPath())
            {
                context.Writer.WritePropertyName("S3OutputPath");
                context.Writer.Write(requestObject.S3OutputPath);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static ProfilerConfigForUpdateMarshaller Instance = new ProfilerConfigForUpdateMarshaller();

    }
}