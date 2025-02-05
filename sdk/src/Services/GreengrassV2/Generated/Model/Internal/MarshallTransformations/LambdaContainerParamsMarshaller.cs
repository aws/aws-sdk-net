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
 * Do not modify this file. This file is generated from the greengrassv2-2020-11-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.GreengrassV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.GreengrassV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// LambdaContainerParams Marshaller
    /// </summary>
    public class LambdaContainerParamsMarshaller : IRequestMarshaller<LambdaContainerParams, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(LambdaContainerParams requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDevices())
            {
                context.Writer.WritePropertyName("devices");
                context.Writer.WriteStartArray();
                foreach(var requestObjectDevicesListValue in requestObject.Devices)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = LambdaDeviceMountMarshaller.Instance;
                    marshaller.Marshall(requestObjectDevicesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetMemorySizeInKB())
            {
                context.Writer.WritePropertyName("memorySizeInKB");
                context.Writer.WriteNumberValue(requestObject.MemorySizeInKB.Value);
            }

            if(requestObject.IsSetMountROSysfs())
            {
                context.Writer.WritePropertyName("mountROSysfs");
                context.Writer.WriteBooleanValue(requestObject.MountROSysfs.Value);
            }

            if(requestObject.IsSetVolumes())
            {
                context.Writer.WritePropertyName("volumes");
                context.Writer.WriteStartArray();
                foreach(var requestObjectVolumesListValue in requestObject.Volumes)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = LambdaVolumeMountMarshaller.Instance;
                    marshaller.Marshall(requestObjectVolumesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static LambdaContainerParamsMarshaller Instance = new LambdaContainerParamsMarshaller();

    }
}