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
 * Do not modify this file. This file is generated from the iotdeviceadvisor-2020-09-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTDeviceAdvisor.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.IoTDeviceAdvisor.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SuiteDefinitionConfiguration Marshaller
    /// </summary>
    public class SuiteDefinitionConfigurationMarshaller : IRequestMarshaller<SuiteDefinitionConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SuiteDefinitionConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDevicePermissionRoleArn())
            {
                context.Writer.WritePropertyName("devicePermissionRoleArn");
                context.Writer.WriteStringValue(requestObject.DevicePermissionRoleArn);
            }

            if(requestObject.IsSetDevices())
            {
                context.Writer.WritePropertyName("devices");
                context.Writer.WriteStartArray();
                foreach(var requestObjectDevicesListValue in requestObject.Devices)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = DeviceUnderTestMarshaller.Instance;
                    marshaller.Marshall(requestObjectDevicesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetIntendedForQualification())
            {
                context.Writer.WritePropertyName("intendedForQualification");
                context.Writer.WriteBooleanValue(requestObject.IntendedForQualification.Value);
            }

            if(requestObject.IsSetIsLongDurationTest())
            {
                context.Writer.WritePropertyName("isLongDurationTest");
                context.Writer.WriteBooleanValue(requestObject.IsLongDurationTest.Value);
            }

            if(requestObject.IsSetProtocol())
            {
                context.Writer.WritePropertyName("protocol");
                context.Writer.WriteStringValue(requestObject.Protocol);
            }

            if(requestObject.IsSetRootGroup())
            {
                context.Writer.WritePropertyName("rootGroup");
                context.Writer.WriteStringValue(requestObject.RootGroup);
            }

            if(requestObject.IsSetSuiteDefinitionName())
            {
                context.Writer.WritePropertyName("suiteDefinitionName");
                context.Writer.WriteStringValue(requestObject.SuiteDefinitionName);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SuiteDefinitionConfigurationMarshaller Instance = new SuiteDefinitionConfigurationMarshaller();

    }
}