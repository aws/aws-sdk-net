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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AwsEcsTaskDefinitionContainerDefinitionsLinuxParametersDetails Marshaller
    /// </summary>
    public class AwsEcsTaskDefinitionContainerDefinitionsLinuxParametersDetailsMarshaller : IRequestMarshaller<AwsEcsTaskDefinitionContainerDefinitionsLinuxParametersDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsEcsTaskDefinitionContainerDefinitionsLinuxParametersDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetCapabilities())
            {
                context.Writer.WritePropertyName("Capabilities");
                context.Writer.WriteObjectStart();

                var marshaller = AwsEcsTaskDefinitionContainerDefinitionsLinuxParametersCapabilitiesDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.Capabilities, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDevices())
            {
                context.Writer.WritePropertyName("Devices");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectDevicesListValue in requestObject.Devices)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AwsEcsTaskDefinitionContainerDefinitionsLinuxParametersDevicesDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectDevicesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetInitProcessEnabled())
            {
                context.Writer.WritePropertyName("InitProcessEnabled");
                context.Writer.Write(requestObject.InitProcessEnabled);
            }

            if(requestObject.IsSetMaxSwap())
            {
                context.Writer.WritePropertyName("MaxSwap");
                context.Writer.Write(requestObject.MaxSwap);
            }

            if(requestObject.IsSetSharedMemorySize())
            {
                context.Writer.WritePropertyName("SharedMemorySize");
                context.Writer.Write(requestObject.SharedMemorySize);
            }

            if(requestObject.IsSetSwappiness())
            {
                context.Writer.WritePropertyName("Swappiness");
                context.Writer.Write(requestObject.Swappiness);
            }

            if(requestObject.IsSetTmpfs())
            {
                context.Writer.WritePropertyName("Tmpfs");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectTmpfsListValue in requestObject.Tmpfs)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AwsEcsTaskDefinitionContainerDefinitionsLinuxParametersTmpfsDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectTmpfsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsEcsTaskDefinitionContainerDefinitionsLinuxParametersDetailsMarshaller Instance = new AwsEcsTaskDefinitionContainerDefinitionsLinuxParametersDetailsMarshaller();

    }
}