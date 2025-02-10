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
    /// LambdaFunctionRecipeSource Marshaller
    /// </summary>
    public class LambdaFunctionRecipeSourceMarshaller : IRequestMarshaller<LambdaFunctionRecipeSource, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(LambdaFunctionRecipeSource requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetComponentDependencies())
            {
                context.Writer.WritePropertyName("componentDependencies");
                context.Writer.WriteStartObject();
                foreach (var requestObjectComponentDependenciesKvp in requestObject.ComponentDependencies)
                {
                    context.Writer.WritePropertyName(requestObjectComponentDependenciesKvp.Key);
                    var requestObjectComponentDependenciesValue = requestObjectComponentDependenciesKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = ComponentDependencyRequirementMarshaller.Instance;
                    marshaller.Marshall(requestObjectComponentDependenciesValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetComponentLambdaParameters())
            {
                context.Writer.WritePropertyName("componentLambdaParameters");
                context.Writer.WriteStartObject();

                var marshaller = LambdaExecutionParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.ComponentLambdaParameters, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetComponentName())
            {
                context.Writer.WritePropertyName("componentName");
                context.Writer.WriteStringValue(requestObject.ComponentName);
            }

            if(requestObject.IsSetComponentPlatforms())
            {
                context.Writer.WritePropertyName("componentPlatforms");
                context.Writer.WriteStartArray();
                foreach(var requestObjectComponentPlatformsListValue in requestObject.ComponentPlatforms)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ComponentPlatformMarshaller.Instance;
                    marshaller.Marshall(requestObjectComponentPlatformsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetComponentVersion())
            {
                context.Writer.WritePropertyName("componentVersion");
                context.Writer.WriteStringValue(requestObject.ComponentVersion);
            }

            if(requestObject.IsSetLambdaArn())
            {
                context.Writer.WritePropertyName("lambdaArn");
                context.Writer.WriteStringValue(requestObject.LambdaArn);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static LambdaFunctionRecipeSourceMarshaller Instance = new LambdaFunctionRecipeSourceMarshaller();

    }
}