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
 * Do not modify this file. This file is generated from the workspaces-2015-04-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.WorkSpaces.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.WorkSpaces.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// WorkspaceAccessProperties Marshaller
    /// </summary>
    public class WorkspaceAccessPropertiesMarshaller : IRequestMarshaller<WorkspaceAccessProperties, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(WorkspaceAccessProperties requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAccessEndpointConfig())
            {
                context.Writer.WritePropertyName("AccessEndpointConfig");
                context.Writer.WriteStartObject();

                var marshaller = AccessEndpointConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.AccessEndpointConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDeviceTypeAndroid())
            {
                context.Writer.WritePropertyName("DeviceTypeAndroid");
                context.Writer.WriteStringValue(requestObject.DeviceTypeAndroid);
            }

            if(requestObject.IsSetDeviceTypeChromeOs())
            {
                context.Writer.WritePropertyName("DeviceTypeChromeOs");
                context.Writer.WriteStringValue(requestObject.DeviceTypeChromeOs);
            }

            if(requestObject.IsSetDeviceTypeIos())
            {
                context.Writer.WritePropertyName("DeviceTypeIos");
                context.Writer.WriteStringValue(requestObject.DeviceTypeIos);
            }

            if(requestObject.IsSetDeviceTypeLinux())
            {
                context.Writer.WritePropertyName("DeviceTypeLinux");
                context.Writer.WriteStringValue(requestObject.DeviceTypeLinux);
            }

            if(requestObject.IsSetDeviceTypeOsx())
            {
                context.Writer.WritePropertyName("DeviceTypeOsx");
                context.Writer.WriteStringValue(requestObject.DeviceTypeOsx);
            }

            if(requestObject.IsSetDeviceTypeWeb())
            {
                context.Writer.WritePropertyName("DeviceTypeWeb");
                context.Writer.WriteStringValue(requestObject.DeviceTypeWeb);
            }

            if(requestObject.IsSetDeviceTypeWindows())
            {
                context.Writer.WritePropertyName("DeviceTypeWindows");
                context.Writer.WriteStringValue(requestObject.DeviceTypeWindows);
            }

            if(requestObject.IsSetDeviceTypeWorkSpacesThinClient())
            {
                context.Writer.WritePropertyName("DeviceTypeWorkSpacesThinClient");
                context.Writer.WriteStringValue(requestObject.DeviceTypeWorkSpacesThinClient);
            }

            if(requestObject.IsSetDeviceTypeZeroClient())
            {
                context.Writer.WritePropertyName("DeviceTypeZeroClient");
                context.Writer.WriteStringValue(requestObject.DeviceTypeZeroClient);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static WorkspaceAccessPropertiesMarshaller Instance = new WorkspaceAccessPropertiesMarshaller();

    }
}