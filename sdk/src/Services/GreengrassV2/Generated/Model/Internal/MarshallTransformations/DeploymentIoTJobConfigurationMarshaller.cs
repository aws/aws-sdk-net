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
 * Do not modify this file. This file is generated from the greengrassv2-2020-11-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.GreengrassV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.GreengrassV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeploymentIoTJobConfiguration Marshaller
    /// </summary>
    public class DeploymentIoTJobConfigurationMarshaller : IRequestMarshaller<DeploymentIoTJobConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DeploymentIoTJobConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAbortConfig())
            {
                context.Writer.WritePropertyName("abortConfig");
                context.Writer.WriteStartObject();

                var marshaller = IoTJobAbortConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.AbortConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetJobExecutionsRolloutConfig())
            {
                context.Writer.WritePropertyName("jobExecutionsRolloutConfig");
                context.Writer.WriteStartObject();

                var marshaller = IoTJobExecutionsRolloutConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.JobExecutionsRolloutConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTimeoutConfig())
            {
                context.Writer.WritePropertyName("timeoutConfig");
                context.Writer.WriteStartObject();

                var marshaller = IoTJobTimeoutConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.TimeoutConfig, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DeploymentIoTJobConfigurationMarshaller Instance = new DeploymentIoTJobConfigurationMarshaller();

    }
}