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
 * Do not modify this file. This file is generated from the athena-2017-05-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Athena.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Athena.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// EngineConfiguration Marshaller
    /// </summary>
    public class EngineConfigurationMarshaller : IRequestMarshaller<EngineConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(EngineConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAdditionalConfigs())
            {
                context.Writer.WritePropertyName("AdditionalConfigs");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectAdditionalConfigsKvp in requestObject.AdditionalConfigs)
                {
                    context.Writer.WritePropertyName(requestObjectAdditionalConfigsKvp.Key);
                    var requestObjectAdditionalConfigsValue = requestObjectAdditionalConfigsKvp.Value;

                        context.Writer.Write(requestObjectAdditionalConfigsValue);
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetCoordinatorDpuSize())
            {
                context.Writer.WritePropertyName("CoordinatorDpuSize");
                context.Writer.Write(requestObject.CoordinatorDpuSize);
            }

            if(requestObject.IsSetDefaultExecutorDpuSize())
            {
                context.Writer.WritePropertyName("DefaultExecutorDpuSize");
                context.Writer.Write(requestObject.DefaultExecutorDpuSize);
            }

            if(requestObject.IsSetMaxConcurrentDpus())
            {
                context.Writer.WritePropertyName("MaxConcurrentDpus");
                context.Writer.Write(requestObject.MaxConcurrentDpus);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static EngineConfigurationMarshaller Instance = new EngineConfigurationMarshaller();

    }
}