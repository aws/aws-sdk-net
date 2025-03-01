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
 * Do not modify this file. This file is generated from the devicefarm-2015-06-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DeviceFarm.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.DeviceFarm.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateRemoteAccessSessionConfiguration Marshaller
    /// </summary>
    public class CreateRemoteAccessSessionConfigurationMarshaller : IRequestMarshaller<CreateRemoteAccessSessionConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CreateRemoteAccessSessionConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBillingMethod())
            {
                context.Writer.WritePropertyName("billingMethod");
                context.Writer.WriteStringValue(requestObject.BillingMethod);
            }

            if(requestObject.IsSetDeviceProxy())
            {
                context.Writer.WritePropertyName("deviceProxy");
                context.Writer.WriteStartObject();

                var marshaller = DeviceProxyMarshaller.Instance;
                marshaller.Marshall(requestObject.DeviceProxy, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetVpceConfigurationArns())
            {
                context.Writer.WritePropertyName("vpceConfigurationArns");
                context.Writer.WriteStartArray();
                foreach(var requestObjectVpceConfigurationArnsListValue in requestObject.VpceConfigurationArns)
                {
                        context.Writer.WriteStringValue(requestObjectVpceConfigurationArnsListValue);
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CreateRemoteAccessSessionConfigurationMarshaller Instance = new CreateRemoteAccessSessionConfigurationMarshaller();

    }
}