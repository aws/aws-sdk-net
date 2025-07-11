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
 * Do not modify this file. This file is generated from the cleanroomsml-2023-09-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CleanRoomsML.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.CleanRoomsML.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// TrainedModelsConfigurationPolicy Marshaller
    /// </summary>
    public class TrainedModelsConfigurationPolicyMarshaller : IRequestMarshaller<TrainedModelsConfigurationPolicy, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(TrainedModelsConfigurationPolicy requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetContainerLogs())
            {
                context.Writer.WritePropertyName("containerLogs");
                context.Writer.WriteStartArray();
                foreach(var requestObjectContainerLogsListValue in requestObject.ContainerLogs)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = LogsConfigurationPolicyMarshaller.Instance;
                    marshaller.Marshall(requestObjectContainerLogsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetContainerMetrics())
            {
                context.Writer.WritePropertyName("containerMetrics");
                context.Writer.WriteStartObject();

                var marshaller = MetricsConfigurationPolicyMarshaller.Instance;
                marshaller.Marshall(requestObject.ContainerMetrics, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMaxArtifactSize())
            {
                context.Writer.WritePropertyName("maxArtifactSize");
                context.Writer.WriteStartObject();

                var marshaller = TrainedModelArtifactMaxSizeMarshaller.Instance;
                marshaller.Marshall(requestObject.MaxArtifactSize, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static TrainedModelsConfigurationPolicyMarshaller Instance = new TrainedModelsConfigurationPolicyMarshaller();

    }
}