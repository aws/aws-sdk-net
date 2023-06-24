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
 * Do not modify this file. This file is generated from the iot-roborunner-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTRoboRunner.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoTRoboRunner.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// VendorProperties Marshaller
    /// </summary>
    public class VendorPropertiesMarshaller : IRequestMarshaller<VendorProperties, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(VendorProperties requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetVendorAdditionalFixedProperties())
            {
                context.Writer.WritePropertyName("vendorAdditionalFixedProperties");
                context.Writer.Write(requestObject.VendorAdditionalFixedProperties);
            }

            if(requestObject.IsSetVendorAdditionalTransientProperties())
            {
                context.Writer.WritePropertyName("vendorAdditionalTransientProperties");
                context.Writer.Write(requestObject.VendorAdditionalTransientProperties);
            }

            if(requestObject.IsSetVendorWorkerId())
            {
                context.Writer.WritePropertyName("vendorWorkerId");
                context.Writer.Write(requestObject.VendorWorkerId);
            }

            if(requestObject.IsSetVendorWorkerIpAddress())
            {
                context.Writer.WritePropertyName("vendorWorkerIpAddress");
                context.Writer.Write(requestObject.VendorWorkerIpAddress);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static VendorPropertiesMarshaller Instance = new VendorPropertiesMarshaller();

    }
}