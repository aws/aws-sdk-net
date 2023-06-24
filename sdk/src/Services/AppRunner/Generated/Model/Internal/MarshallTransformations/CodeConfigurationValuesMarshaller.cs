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
    /// CodeConfigurationValues Marshaller
    /// </summary>
    public class CodeConfigurationValuesMarshaller : IRequestMarshaller<CodeConfigurationValues, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CodeConfigurationValues requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetBuildCommand())
            {
                context.Writer.WritePropertyName("BuildCommand");
                context.Writer.Write(requestObject.BuildCommand);
            }

            if(requestObject.IsSetPort())
            {
                context.Writer.WritePropertyName("Port");
                context.Writer.Write(requestObject.Port);
            }

            if(requestObject.IsSetRuntime())
            {
                context.Writer.WritePropertyName("Runtime");
                context.Writer.Write(requestObject.Runtime);
            }

            if(requestObject.IsSetRuntimeEnvironmentSecrets())
            {
                context.Writer.WritePropertyName("RuntimeEnvironmentSecrets");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectRuntimeEnvironmentSecretsKvp in requestObject.RuntimeEnvironmentSecrets)
                {
                    context.Writer.WritePropertyName(requestObjectRuntimeEnvironmentSecretsKvp.Key);
                    var requestObjectRuntimeEnvironmentSecretsValue = requestObjectRuntimeEnvironmentSecretsKvp.Value;

                        context.Writer.Write(requestObjectRuntimeEnvironmentSecretsValue);
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetRuntimeEnvironmentVariables())
            {
                context.Writer.WritePropertyName("RuntimeEnvironmentVariables");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectRuntimeEnvironmentVariablesKvp in requestObject.RuntimeEnvironmentVariables)
                {
                    context.Writer.WritePropertyName(requestObjectRuntimeEnvironmentVariablesKvp.Key);
                    var requestObjectRuntimeEnvironmentVariablesValue = requestObjectRuntimeEnvironmentVariablesKvp.Value;

                        context.Writer.Write(requestObjectRuntimeEnvironmentVariablesValue);
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetStartCommand())
            {
                context.Writer.WritePropertyName("StartCommand");
                context.Writer.Write(requestObject.StartCommand);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CodeConfigurationValuesMarshaller Instance = new CodeConfigurationValuesMarshaller();

    }
}