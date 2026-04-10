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
 * Do not modify this file. This file is generated from the rtbfabric-2023-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.RTBFabric.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.RTBFabric.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// HealthCheckConfig Marshaller
    /// </summary>
    public class HealthCheckConfigMarshaller : IRequestMarshaller<HealthCheckConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(HealthCheckConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetHealthyThresholdCount())
            {
                context.Writer.WritePropertyName("healthyThresholdCount");
                context.Writer.WriteNumberValue(requestObject.HealthyThresholdCount.Value);
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

            if(requestObject.IsSetPort())
            {
                context.Writer.WritePropertyName("port");
                context.Writer.WriteNumberValue(requestObject.Port.Value);
            }

            if(requestObject.IsSetProtocol())
            {
                context.Writer.WritePropertyName("protocol");
                context.Writer.WriteStringValue(requestObject.Protocol);
            }

            if(requestObject.IsSetStatusCodeMatcher())
            {
                context.Writer.WritePropertyName("statusCodeMatcher");
                context.Writer.WriteStringValue(requestObject.StatusCodeMatcher);
            }

            if(requestObject.IsSetTimeoutMs())
            {
                context.Writer.WritePropertyName("timeoutMs");
                context.Writer.WriteNumberValue(requestObject.TimeoutMs.Value);
            }

            if(requestObject.IsSetUnhealthyThresholdCount())
            {
                context.Writer.WritePropertyName("unhealthyThresholdCount");
                context.Writer.WriteNumberValue(requestObject.UnhealthyThresholdCount.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static HealthCheckConfigMarshaller Instance = new HealthCheckConfigMarshaller();

    }
}