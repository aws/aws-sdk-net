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
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CodePipeline.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.CodePipeline.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ThirdPartyJobData Object
    /// </summary>  
    public class ThirdPartyJobDataUnmarshaller : IJsonUnmarshaller<ThirdPartyJobData, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public ThirdPartyJobData Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            ThirdPartyJobData unmarshalledObject = new ThirdPartyJobData();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("actionConfiguration", targetDepth))
                {
                    var unmarshaller = ActionConfigurationUnmarshaller.Instance;
                    unmarshalledObject.ActionConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("actionTypeId", targetDepth))
                {
                    var unmarshaller = ActionTypeIdUnmarshaller.Instance;
                    unmarshalledObject.ActionTypeId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("artifactCredentials", targetDepth))
                {
                    var unmarshaller = AWSSessionCredentialsUnmarshaller.Instance;
                    unmarshalledObject.ArtifactCredentials = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("continuationToken", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ContinuationToken = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("encryptionKey", targetDepth))
                {
                    var unmarshaller = EncryptionKeyUnmarshaller.Instance;
                    unmarshalledObject.EncryptionKey = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("inputArtifacts", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<Artifact, ArtifactUnmarshaller>(ArtifactUnmarshaller.Instance);
                    unmarshalledObject.InputArtifacts = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("outputArtifacts", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<Artifact, ArtifactUnmarshaller>(ArtifactUnmarshaller.Instance);
                    unmarshalledObject.OutputArtifacts = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("pipelineContext", targetDepth))
                {
                    var unmarshaller = PipelineContextUnmarshaller.Instance;
                    unmarshalledObject.PipelineContext = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ThirdPartyJobDataUnmarshaller _instance = new ThirdPartyJobDataUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ThirdPartyJobDataUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}