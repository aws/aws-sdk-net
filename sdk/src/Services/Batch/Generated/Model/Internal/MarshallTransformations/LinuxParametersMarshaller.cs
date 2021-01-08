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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Batch.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Batch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// LinuxParameters Marshaller
    /// </summary>       
    public class LinuxParametersMarshaller : IRequestMarshaller<LinuxParameters, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(LinuxParameters requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetDevices())
            {
                context.Writer.WritePropertyName("devices");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectDevicesListValue in requestObject.Devices)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = DeviceMarshaller.Instance;
                    marshaller.Marshall(requestObjectDevicesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetInitProcessEnabled())
            {
                context.Writer.WritePropertyName("initProcessEnabled");
                context.Writer.Write(requestObject.InitProcessEnabled);
            }

            if(requestObject.IsSetMaxSwap())
            {
                context.Writer.WritePropertyName("maxSwap");
                context.Writer.Write(requestObject.MaxSwap);
            }

            if(requestObject.IsSetSharedMemorySize())
            {
                context.Writer.WritePropertyName("sharedMemorySize");
                context.Writer.Write(requestObject.SharedMemorySize);
            }

            if(requestObject.IsSetSwappiness())
            {
                context.Writer.WritePropertyName("swappiness");
                context.Writer.Write(requestObject.Swappiness);
            }

            if(requestObject.IsSetTmpfs())
            {
                context.Writer.WritePropertyName("tmpfs");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectTmpfsListValue in requestObject.Tmpfs)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = TmpfsMarshaller.Instance;
                    marshaller.Marshall(requestObjectTmpfsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static LinuxParametersMarshaller Instance = new LinuxParametersMarshaller();

    }
}