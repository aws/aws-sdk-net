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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SageMaker.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for TrialComponent Object
    /// </summary>  
    public class TrialComponentUnmarshaller : IJsonUnmarshaller<TrialComponent, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public TrialComponent Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            TrialComponent unmarshalledObject = new TrialComponent();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("CreatedBy", targetDepth, ref reader))
                {
                    var unmarshaller = UserContextUnmarshaller.Instance;
                    unmarshalledObject.CreatedBy = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CreationTime", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreationTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DisplayName", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DisplayName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("EndTime", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.EndTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("InputArtifacts", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, TrialComponentArtifact, StringUnmarshaller, TrialComponentArtifactUnmarshaller>(StringUnmarshaller.Instance, TrialComponentArtifactUnmarshaller.Instance);
                    unmarshalledObject.InputArtifacts = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("LastModifiedBy", targetDepth, ref reader))
                {
                    var unmarshaller = UserContextUnmarshaller.Instance;
                    unmarshalledObject.LastModifiedBy = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("LastModifiedTime", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastModifiedTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("LineageGroupArn", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LineageGroupArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("MetadataProperties", targetDepth, ref reader))
                {
                    var unmarshaller = MetadataPropertiesUnmarshaller.Instance;
                    unmarshalledObject.MetadataProperties = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Metrics", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<TrialComponentMetricSummary, TrialComponentMetricSummaryUnmarshaller>(TrialComponentMetricSummaryUnmarshaller.Instance);
                    unmarshalledObject.Metrics = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("OutputArtifacts", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, TrialComponentArtifact, StringUnmarshaller, TrialComponentArtifactUnmarshaller>(StringUnmarshaller.Instance, TrialComponentArtifactUnmarshaller.Instance);
                    unmarshalledObject.OutputArtifacts = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Parameters", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, TrialComponentParameterValue, StringUnmarshaller, TrialComponentParameterValueUnmarshaller>(StringUnmarshaller.Instance, TrialComponentParameterValueUnmarshaller.Instance);
                    unmarshalledObject.Parameters = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Parents", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<Parent, ParentUnmarshaller>(ParentUnmarshaller.Instance);
                    unmarshalledObject.Parents = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RunName", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RunName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Source", targetDepth, ref reader))
                {
                    var unmarshaller = TrialComponentSourceUnmarshaller.Instance;
                    unmarshalledObject.Source = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SourceDetail", targetDepth, ref reader))
                {
                    var unmarshaller = TrialComponentSourceDetailUnmarshaller.Instance;
                    unmarshalledObject.SourceDetail = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("StartTime", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.StartTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Status", targetDepth, ref reader))
                {
                    var unmarshaller = TrialComponentStatusUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Tags", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<Tag, TagUnmarshaller>(TagUnmarshaller.Instance);
                    unmarshalledObject.Tags = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("TrialComponentArn", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TrialComponentArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("TrialComponentName", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TrialComponentName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static TrialComponentUnmarshaller _instance = new TrialComponentUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TrialComponentUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}