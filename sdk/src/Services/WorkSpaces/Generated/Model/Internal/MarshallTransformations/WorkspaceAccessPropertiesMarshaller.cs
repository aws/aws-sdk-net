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
using ThirdParty.Json.LitJson;

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
            if(requestObject.IsSetDeviceTypeAndroid())
            {
                context.Writer.WritePropertyName("DeviceTypeAndroid");
                context.Writer.Write(requestObject.DeviceTypeAndroid);
            }

            if(requestObject.IsSetDeviceTypeChromeOs())
            {
                context.Writer.WritePropertyName("DeviceTypeChromeOs");
                context.Writer.Write(requestObject.DeviceTypeChromeOs);
            }

            if(requestObject.IsSetDeviceTypeIos())
            {
                context.Writer.WritePropertyName("DeviceTypeIos");
                context.Writer.Write(requestObject.DeviceTypeIos);
            }

            if(requestObject.IsSetDeviceTypeOsx())
            {
                context.Writer.WritePropertyName("DeviceTypeOsx");
                context.Writer.Write(requestObject.DeviceTypeOsx);
            }

            if(requestObject.IsSetDeviceTypeWeb())
            {
                context.Writer.WritePropertyName("DeviceTypeWeb");
                context.Writer.Write(requestObject.DeviceTypeWeb);
            }

            if(requestObject.IsSetDeviceTypeWindows())
            {
                context.Writer.WritePropertyName("DeviceTypeWindows");
                context.Writer.Write(requestObject.DeviceTypeWindows);
            }

            if(requestObject.IsSetDeviceTypeZeroClient())
            {
                context.Writer.WritePropertyName("DeviceTypeZeroClient");
                context.Writer.Write(requestObject.DeviceTypeZeroClient);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static WorkspaceAccessPropertiesMarshaller Instance = new WorkspaceAccessPropertiesMarshaller();

    }
}