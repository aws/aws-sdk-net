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
 * Do not modify this file. This file is generated from the robomaker-2018-06-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.RoboMaker.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.RoboMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SimulationApplicationConfig Marshaller
    /// </summary>
    public class SimulationApplicationConfigMarshaller : IRequestMarshaller<SimulationApplicationConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SimulationApplicationConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetApplication())
            {
                context.Writer.WritePropertyName("application");
                context.Writer.WriteStringValue(requestObject.Application);
            }

            if(requestObject.IsSetApplicationVersion())
            {
                context.Writer.WritePropertyName("applicationVersion");
                context.Writer.WriteStringValue(requestObject.ApplicationVersion);
            }

            if(requestObject.IsSetLaunchConfig())
            {
                context.Writer.WritePropertyName("launchConfig");
                context.Writer.WriteStartObject();

                var marshaller = LaunchConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.LaunchConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTools())
            {
                context.Writer.WritePropertyName("tools");
                context.Writer.WriteStartArray();
                foreach(var requestObjectToolsListValue in requestObject.Tools)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ToolMarshaller.Instance;
                    marshaller.Marshall(requestObjectToolsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetUploadConfigurations())
            {
                context.Writer.WritePropertyName("uploadConfigurations");
                context.Writer.WriteStartArray();
                foreach(var requestObjectUploadConfigurationsListValue in requestObject.UploadConfigurations)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = UploadConfigurationMarshaller.Instance;
                    marshaller.Marshall(requestObjectUploadConfigurationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetUseDefaultTools())
            {
                context.Writer.WritePropertyName("useDefaultTools");
                context.Writer.WriteBooleanValue(requestObject.UseDefaultTools.Value);
            }

            if(requestObject.IsSetUseDefaultUploadConfigurations())
            {
                context.Writer.WritePropertyName("useDefaultUploadConfigurations");
                context.Writer.WriteBooleanValue(requestObject.UseDefaultUploadConfigurations.Value);
            }

            if(requestObject.IsSetWorldConfigs())
            {
                context.Writer.WritePropertyName("worldConfigs");
                context.Writer.WriteStartArray();
                foreach(var requestObjectWorldConfigsListValue in requestObject.WorldConfigs)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = WorldConfigMarshaller.Instance;
                    marshaller.Marshall(requestObjectWorldConfigsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SimulationApplicationConfigMarshaller Instance = new SimulationApplicationConfigMarshaller();

    }
}