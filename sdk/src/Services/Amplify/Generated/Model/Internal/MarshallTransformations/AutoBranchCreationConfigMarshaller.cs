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
 * Do not modify this file. This file is generated from the amplify-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Amplify.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Amplify.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AutoBranchCreationConfig Marshaller
    /// </summary>
    public class AutoBranchCreationConfigMarshaller : IRequestMarshaller<AutoBranchCreationConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AutoBranchCreationConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBasicAuthCredentials())
            {
                context.Writer.WritePropertyName("basicAuthCredentials");
                context.Writer.WriteStringValue(requestObject.BasicAuthCredentials);
            }

            if(requestObject.IsSetBuildSpec())
            {
                context.Writer.WritePropertyName("buildSpec");
                context.Writer.WriteStringValue(requestObject.BuildSpec);
            }

            if(requestObject.IsSetEnableAutoBuild())
            {
                context.Writer.WritePropertyName("enableAutoBuild");
                context.Writer.WriteBooleanValue(requestObject.EnableAutoBuild.Value);
            }

            if(requestObject.IsSetEnableBasicAuth())
            {
                context.Writer.WritePropertyName("enableBasicAuth");
                context.Writer.WriteBooleanValue(requestObject.EnableBasicAuth.Value);
            }

            if(requestObject.IsSetEnablePerformanceMode())
            {
                context.Writer.WritePropertyName("enablePerformanceMode");
                context.Writer.WriteBooleanValue(requestObject.EnablePerformanceMode.Value);
            }

            if(requestObject.IsSetEnablePullRequestPreview())
            {
                context.Writer.WritePropertyName("enablePullRequestPreview");
                context.Writer.WriteBooleanValue(requestObject.EnablePullRequestPreview.Value);
            }

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

            if(requestObject.IsSetFramework())
            {
                context.Writer.WritePropertyName("framework");
                context.Writer.WriteStringValue(requestObject.Framework);
            }

            if(requestObject.IsSetPullRequestEnvironmentName())
            {
                context.Writer.WritePropertyName("pullRequestEnvironmentName");
                context.Writer.WriteStringValue(requestObject.PullRequestEnvironmentName);
            }

            if(requestObject.IsSetStage())
            {
                context.Writer.WritePropertyName("stage");
                context.Writer.WriteStringValue(requestObject.Stage);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AutoBranchCreationConfigMarshaller Instance = new AutoBranchCreationConfigMarshaller();

    }
}