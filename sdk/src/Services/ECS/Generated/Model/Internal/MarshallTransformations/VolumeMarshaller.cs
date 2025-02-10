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
#pragma warning disable CS0612,CS0618
namespace Amazon.ECS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Volume Marshaller
    /// </summary>
    public class VolumeMarshaller : IRequestMarshaller<Volume, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Volume requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetConfiguredAtLaunch())
            {
                context.Writer.WritePropertyName("configuredAtLaunch");
                context.Writer.WriteBooleanValue(requestObject.ConfiguredAtLaunch.Value);
            }

            if(requestObject.IsSetDockerVolumeConfiguration())
            {
                context.Writer.WritePropertyName("dockerVolumeConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = DockerVolumeConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.DockerVolumeConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetEfsVolumeConfiguration())
            {
                context.Writer.WritePropertyName("efsVolumeConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = EFSVolumeConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.EfsVolumeConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetFsxWindowsFileServerVolumeConfiguration())
            {
                context.Writer.WritePropertyName("fsxWindowsFileServerVolumeConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = FSxWindowsFileServerVolumeConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.FsxWindowsFileServerVolumeConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetHost())
            {
                context.Writer.WritePropertyName("host");
                context.Writer.WriteStartObject();

                var marshaller = HostVolumePropertiesMarshaller.Instance;
                marshaller.Marshall(requestObject.Host, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(requestObject.Name);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static VolumeMarshaller Instance = new VolumeMarshaller();

    }
}