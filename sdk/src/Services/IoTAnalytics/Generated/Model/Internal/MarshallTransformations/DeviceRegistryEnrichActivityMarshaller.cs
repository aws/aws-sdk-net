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
 * Do not modify this file. This file is generated from the iotanalytics-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTAnalytics.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoTAnalytics.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeviceRegistryEnrichActivity Marshaller
    /// </summary>       
    public class DeviceRegistryEnrichActivityMarshaller : IRequestMarshaller<DeviceRegistryEnrichActivity, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DeviceRegistryEnrichActivity requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAttribute())
            {
                context.Writer.WritePropertyName("attribute");
                context.Writer.Write(requestObject.Attribute);
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.Write(requestObject.Name);
            }

            if(requestObject.IsSetNext())
            {
                context.Writer.WritePropertyName("next");
                context.Writer.Write(requestObject.Next);
            }

            if(requestObject.IsSetRoleArn())
            {
                context.Writer.WritePropertyName("roleArn");
                context.Writer.Write(requestObject.RoleArn);
            }

            if(requestObject.IsSetThingName())
            {
                context.Writer.WritePropertyName("thingName");
                context.Writer.Write(requestObject.ThingName);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static DeviceRegistryEnrichActivityMarshaller Instance = new DeviceRegistryEnrichActivityMarshaller();

    }
}