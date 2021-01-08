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
 * Do not modify this file. This file is generated from the synthetics-2017-10-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Synthetics.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Synthetics.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CanaryRunConfigInput Marshaller
    /// </summary>       
    public class CanaryRunConfigInputMarshaller : IRequestMarshaller<CanaryRunConfigInput, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CanaryRunConfigInput requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetActiveTracing())
            {
                context.Writer.WritePropertyName("ActiveTracing");
                context.Writer.Write(requestObject.ActiveTracing);
            }

            if(requestObject.IsSetEnvironmentVariables())
            {
                context.Writer.WritePropertyName("EnvironmentVariables");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectEnvironmentVariablesKvp in requestObject.EnvironmentVariables)
                {
                    context.Writer.WritePropertyName(requestObjectEnvironmentVariablesKvp.Key);
                    var requestObjectEnvironmentVariablesValue = requestObjectEnvironmentVariablesKvp.Value;

                        context.Writer.Write(requestObjectEnvironmentVariablesValue);
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetMemoryInMB())
            {
                context.Writer.WritePropertyName("MemoryInMB");
                context.Writer.Write(requestObject.MemoryInMB);
            }

            if(requestObject.IsSetTimeoutInSeconds())
            {
                context.Writer.WritePropertyName("TimeoutInSeconds");
                context.Writer.Write(requestObject.TimeoutInSeconds);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static CanaryRunConfigInputMarshaller Instance = new CanaryRunConfigInputMarshaller();

    }
}