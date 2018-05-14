/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the iot1click-projects-2018-05-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoT1ClickProjects.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoT1ClickProjects.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeviceTemplate Marshaller
    /// </summary>       
    public class DeviceTemplateMarshaller : IRequestMarshaller<DeviceTemplate, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DeviceTemplate requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetCallbackOverrides())
            {
                context.Writer.WritePropertyName("callbackOverrides");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectCallbackOverridesKvp in requestObject.CallbackOverrides)
                {
                    context.Writer.WritePropertyName(requestObjectCallbackOverridesKvp.Key);
                    var requestObjectCallbackOverridesValue = requestObjectCallbackOverridesKvp.Value;

                        context.Writer.Write(requestObjectCallbackOverridesValue);
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDeviceType())
            {
                context.Writer.WritePropertyName("deviceType");
                context.Writer.Write(requestObject.DeviceType);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static DeviceTemplateMarshaller Instance = new DeviceTemplateMarshaller();

    }
}