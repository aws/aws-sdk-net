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
 * Do not modify this file. This file is generated from the apprunner-2020-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AppRunner.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.AppRunner.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// HealthCheckConfiguration Marshaller
    /// </summary>
    public class HealthCheckConfigurationMarshaller : IRequestMarshaller<HealthCheckConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(HealthCheckConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetHealthyThreshold())
            {
                context.Writer.WritePropertyName("HealthyThreshold");
                context.Writer.Write(requestObject.HealthyThreshold);
            }

            if(requestObject.IsSetInterval())
            {
                context.Writer.WritePropertyName("Interval");
                context.Writer.Write(requestObject.Interval);
            }

            if(requestObject.IsSetPath())
            {
                context.Writer.WritePropertyName("Path");
                context.Writer.Write(requestObject.Path);
            }

            if(requestObject.IsSetProtocol())
            {
                context.Writer.WritePropertyName("Protocol");
                context.Writer.Write(requestObject.Protocol);
            }

            if(requestObject.IsSetTimeout())
            {
                context.Writer.WritePropertyName("Timeout");
                context.Writer.Write(requestObject.Timeout);
            }

            if(requestObject.IsSetUnhealthyThreshold())
            {
                context.Writer.WritePropertyName("UnhealthyThreshold");
                context.Writer.Write(requestObject.UnhealthyThreshold);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static HealthCheckConfigurationMarshaller Instance = new HealthCheckConfigurationMarshaller();

    }
}