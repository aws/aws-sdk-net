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
 * Do not modify this file. This file is generated from the robomaker-2018-06-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.RoboMaker.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.RoboMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeploymentConfig Marshaller
    /// </summary>
    public class DeploymentConfigMarshaller : IRequestMarshaller<DeploymentConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DeploymentConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetConcurrentDeploymentPercentage())
            {
                context.Writer.WritePropertyName("concurrentDeploymentPercentage");
                context.Writer.WriteNumberValue(requestObject.ConcurrentDeploymentPercentage.Value);
            }

            if(requestObject.IsSetDownloadConditionFile())
            {
                context.Writer.WritePropertyName("downloadConditionFile");
                context.Writer.WriteStartObject();

                var marshaller = S3ObjectMarshaller.Instance;
                marshaller.Marshall(requestObject.DownloadConditionFile, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetFailureThresholdPercentage())
            {
                context.Writer.WritePropertyName("failureThresholdPercentage");
                context.Writer.WriteNumberValue(requestObject.FailureThresholdPercentage.Value);
            }

            if(requestObject.IsSetRobotDeploymentTimeoutInSeconds())
            {
                context.Writer.WritePropertyName("robotDeploymentTimeoutInSeconds");
                context.Writer.WriteNumberValue(requestObject.RobotDeploymentTimeoutInSeconds.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DeploymentConfigMarshaller Instance = new DeploymentConfigMarshaller();

    }
}