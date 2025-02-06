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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Lightsail.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Lightsail.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ContainerServiceHealthCheckConfig Marshaller
    /// </summary>
    public class ContainerServiceHealthCheckConfigMarshaller : IRequestMarshaller<ContainerServiceHealthCheckConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ContainerServiceHealthCheckConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetHealthyThreshold())
            {
                context.Writer.WritePropertyName("healthyThreshold");
                context.Writer.WriteNumberValue(requestObject.HealthyThreshold.Value);
            }

            if(requestObject.IsSetIntervalSeconds())
            {
                context.Writer.WritePropertyName("intervalSeconds");
                context.Writer.WriteNumberValue(requestObject.IntervalSeconds.Value);
            }

            if(requestObject.IsSetPath())
            {
                context.Writer.WritePropertyName("path");
                context.Writer.WriteStringValue(requestObject.Path);
            }

            if(requestObject.IsSetSuccessCodes())
            {
                context.Writer.WritePropertyName("successCodes");
                context.Writer.WriteStringValue(requestObject.SuccessCodes);
            }

            if(requestObject.IsSetTimeoutSeconds())
            {
                context.Writer.WritePropertyName("timeoutSeconds");
                context.Writer.WriteNumberValue(requestObject.TimeoutSeconds.Value);
            }

            if(requestObject.IsSetUnhealthyThreshold())
            {
                context.Writer.WritePropertyName("unhealthyThreshold");
                context.Writer.WriteNumberValue(requestObject.UnhealthyThreshold.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ContainerServiceHealthCheckConfigMarshaller Instance = new ContainerServiceHealthCheckConfigMarshaller();

    }
}