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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ConfigService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ConfigService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CustomPolicyDetails Marshaller
    /// </summary>
    public class CustomPolicyDetailsMarshaller : IRequestMarshaller<CustomPolicyDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CustomPolicyDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetEnableDebugLogDelivery())
            {
                context.Writer.WritePropertyName("EnableDebugLogDelivery");
                context.Writer.Write(requestObject.EnableDebugLogDelivery);
            }

            if(requestObject.IsSetPolicyRuntime())
            {
                context.Writer.WritePropertyName("PolicyRuntime");
                context.Writer.Write(requestObject.PolicyRuntime);
            }

            if(requestObject.IsSetPolicyText())
            {
                context.Writer.WritePropertyName("PolicyText");
                context.Writer.Write(requestObject.PolicyText);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CustomPolicyDetailsMarshaller Instance = new CustomPolicyDetailsMarshaller();

    }
}