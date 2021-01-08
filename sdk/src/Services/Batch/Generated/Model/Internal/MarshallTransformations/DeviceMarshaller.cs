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
    /// Device Marshaller
    /// </summary>       
    public class DeviceMarshaller : IRequestMarshaller<Device, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Device requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetContainerPath())
            {
                context.Writer.WritePropertyName("containerPath");
                context.Writer.Write(requestObject.ContainerPath);
            }

            if(requestObject.IsSetHostPath())
            {
                context.Writer.WritePropertyName("hostPath");
                context.Writer.Write(requestObject.HostPath);
            }

            if(requestObject.IsSetPermissions())
            {
                context.Writer.WritePropertyName("permissions");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectPermissionsListValue in requestObject.Permissions)
                {
                        context.Writer.Write(requestObjectPermissionsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static DeviceMarshaller Instance = new DeviceMarshaller();

    }
}