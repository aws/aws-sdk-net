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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ECS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ECS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DockerVolumeConfiguration Marshaller
    /// </summary>       
    public class DockerVolumeConfigurationMarshaller : IRequestMarshaller<DockerVolumeConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DockerVolumeConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAutoprovision())
            {
                context.Writer.WritePropertyName("autoprovision");
                context.Writer.Write(requestObject.Autoprovision);
            }

            if(requestObject.IsSetDriver())
            {
                context.Writer.WritePropertyName("driver");
                context.Writer.Write(requestObject.Driver);
            }

            if(requestObject.IsSetDriverOpts())
            {
                context.Writer.WritePropertyName("driverOpts");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectDriverOptsKvp in requestObject.DriverOpts)
                {
                    context.Writer.WritePropertyName(requestObjectDriverOptsKvp.Key);
                    var requestObjectDriverOptsValue = requestObjectDriverOptsKvp.Value;

                        context.Writer.Write(requestObjectDriverOptsValue);
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetLabels())
            {
                context.Writer.WritePropertyName("labels");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectLabelsKvp in requestObject.Labels)
                {
                    context.Writer.WritePropertyName(requestObjectLabelsKvp.Key);
                    var requestObjectLabelsValue = requestObjectLabelsKvp.Value;

                        context.Writer.Write(requestObjectLabelsValue);
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetScope())
            {
                context.Writer.WritePropertyName("scope");
                context.Writer.Write(requestObject.Scope);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static DockerVolumeConfigurationMarshaller Instance = new DockerVolumeConfigurationMarshaller();

    }
}