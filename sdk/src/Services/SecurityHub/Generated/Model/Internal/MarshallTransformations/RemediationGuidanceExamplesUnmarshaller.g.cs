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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.SecurityHub.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618

namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for RemediationGuidanceExamples Object
    /// </summary>
    public partial class RemediationGuidanceExamplesUnmarshaller : IJsonUnmarshaller<RemediationGuidanceExamples, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public RemediationGuidanceExamples Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            var unmarshalledObject = new RemediationGuidanceExamples();
            if (context.IsEmptyResponse) return null;

            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("AwsCli", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AwsCli = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("Cdk", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Cdk = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("Cli", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Cli = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("CloudFormation", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CloudFormation = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("IaC", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.IaC = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("Python", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Python = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("Template", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Template = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("Terraform", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Terraform = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }

        private static RemediationGuidanceExamplesUnmarshaller _instance = new RemediationGuidanceExamplesUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static RemediationGuidanceExamplesUnmarshaller Instance => _instance;
    }
}
