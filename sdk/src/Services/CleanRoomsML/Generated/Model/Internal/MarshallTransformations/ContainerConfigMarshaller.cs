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
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.CleanRoomsML.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ContainerConfig Marshaller
    /// </summary>
    public class ContainerConfigMarshaller : IRequestMarshaller<ContainerConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ContainerConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetArguments())
            {
                context.Writer.WritePropertyName("arguments");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectArgumentsListValue in requestObject.Arguments)
                {
                        context.Writer.Write(requestObjectArgumentsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetEntrypoint())
            {
                context.Writer.WritePropertyName("entrypoint");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectEntrypointListValue in requestObject.Entrypoint)
                {
                        context.Writer.Write(requestObjectEntrypointListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetImageUri())
            {
                context.Writer.WritePropertyName("imageUri");
                context.Writer.Write(requestObject.ImageUri);
            }

            if(requestObject.IsSetMetricDefinitions())
            {
                context.Writer.WritePropertyName("metricDefinitions");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectMetricDefinitionsListValue in requestObject.MetricDefinitions)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = MetricDefinitionMarshaller.Instance;
                    marshaller.Marshall(requestObjectMetricDefinitionsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ContainerConfigMarshaller Instance = new ContainerConfigMarshaller();

    }
}