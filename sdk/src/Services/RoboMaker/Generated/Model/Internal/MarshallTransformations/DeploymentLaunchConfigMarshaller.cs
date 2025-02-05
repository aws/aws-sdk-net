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
    /// DeploymentLaunchConfig Marshaller
    /// </summary>
    public class DeploymentLaunchConfigMarshaller : IRequestMarshaller<DeploymentLaunchConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DeploymentLaunchConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetEnvironmentVariables())
            {
                context.Writer.WritePropertyName("environmentVariables");
                context.Writer.WriteStartObject();
                foreach (var requestObjectEnvironmentVariablesKvp in requestObject.EnvironmentVariables)
                {
                    context.Writer.WritePropertyName(requestObjectEnvironmentVariablesKvp.Key);
                    var requestObjectEnvironmentVariablesValue = requestObjectEnvironmentVariablesKvp.Value;

                        context.Writer.WriteStringValue(requestObjectEnvironmentVariablesValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetLaunchFile())
            {
                context.Writer.WritePropertyName("launchFile");
                context.Writer.WriteStringValue(requestObject.LaunchFile);
            }

            if(requestObject.IsSetPackageName())
            {
                context.Writer.WritePropertyName("packageName");
                context.Writer.WriteStringValue(requestObject.PackageName);
            }

            if(requestObject.IsSetPostLaunchFile())
            {
                context.Writer.WritePropertyName("postLaunchFile");
                context.Writer.WriteStringValue(requestObject.PostLaunchFile);
            }

            if(requestObject.IsSetPreLaunchFile())
            {
                context.Writer.WritePropertyName("preLaunchFile");
                context.Writer.WriteStringValue(requestObject.PreLaunchFile);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DeploymentLaunchConfigMarshaller Instance = new DeploymentLaunchConfigMarshaller();

    }
}