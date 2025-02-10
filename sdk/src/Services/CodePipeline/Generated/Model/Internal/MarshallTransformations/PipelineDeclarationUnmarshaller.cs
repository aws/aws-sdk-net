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
    /// Response Unmarshaller for PipelineDeclaration Object
    /// </summary>  
    public class PipelineDeclarationUnmarshaller : IJsonUnmarshaller<PipelineDeclaration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public PipelineDeclaration Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            PipelineDeclaration unmarshalledObject = new PipelineDeclaration();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("artifactStore", targetDepth))
                {
                    var unmarshaller = ArtifactStoreUnmarshaller.Instance;
                    unmarshalledObject.ArtifactStore = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("artifactStores", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, ArtifactStore, StringUnmarshaller, ArtifactStoreUnmarshaller>(StringUnmarshaller.Instance, ArtifactStoreUnmarshaller.Instance);
                    unmarshalledObject.ArtifactStores = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("executionMode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ExecutionMode = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("pipelineType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PipelineType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("roleArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RoleArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("stages", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<StageDeclaration, StageDeclarationUnmarshaller>(StageDeclarationUnmarshaller.Instance);
                    unmarshalledObject.Stages = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("triggers", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<PipelineTriggerDeclaration, PipelineTriggerDeclarationUnmarshaller>(PipelineTriggerDeclarationUnmarshaller.Instance);
                    unmarshalledObject.Triggers = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("variables", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<PipelineVariableDeclaration, PipelineVariableDeclarationUnmarshaller>(PipelineVariableDeclarationUnmarshaller.Instance);
                    unmarshalledObject.Variables = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("version", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.Version = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static PipelineDeclarationUnmarshaller _instance = new PipelineDeclarationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PipelineDeclarationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}