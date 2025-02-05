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
    /// Response Unmarshaller for PipelineExecution Object
    /// </summary>  
    public class PipelineExecutionUnmarshaller : IJsonUnmarshaller<PipelineExecution, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public PipelineExecution Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            PipelineExecution unmarshalledObject = new PipelineExecution();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("artifactRevisions", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<ArtifactRevision, ArtifactRevisionUnmarshaller>(ArtifactRevisionUnmarshaller.Instance);
                    unmarshalledObject.ArtifactRevisions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("executionMode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ExecutionMode = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("executionType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ExecutionType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("pipelineExecutionId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PipelineExecutionId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("pipelineName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PipelineName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("pipelineVersion", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.PipelineVersion = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("rollbackMetadata", targetDepth))
                {
                    var unmarshaller = PipelineRollbackMetadataUnmarshaller.Instance;
                    unmarshalledObject.RollbackMetadata = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("statusSummary", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StatusSummary = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("trigger", targetDepth))
                {
                    var unmarshaller = ExecutionTriggerUnmarshaller.Instance;
                    unmarshalledObject.Trigger = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("variables", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<ResolvedPipelineVariable, ResolvedPipelineVariableUnmarshaller>(ResolvedPipelineVariableUnmarshaller.Instance);
                    unmarshalledObject.Variables = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static PipelineExecutionUnmarshaller _instance = new PipelineExecutionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PipelineExecutionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}