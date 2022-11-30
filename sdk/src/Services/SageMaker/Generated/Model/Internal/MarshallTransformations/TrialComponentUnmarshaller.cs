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
using ThirdParty.Json.LitJson;

namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for TrialComponent Object
    /// </summary>  
    public class TrialComponentUnmarshaller : IUnmarshaller<TrialComponent, XmlUnmarshallerContext>, IUnmarshaller<TrialComponent, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        TrialComponent IUnmarshaller<TrialComponent, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public TrialComponent Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            TrialComponent unmarshalledObject = new TrialComponent();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CreatedBy", targetDepth))
                {
                    var unmarshaller = UserContextUnmarshaller.Instance;
                    unmarshalledObject.CreatedBy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreationTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreationTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DisplayName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DisplayName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EndTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.EndTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InputArtifacts", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, TrialComponentArtifact, StringUnmarshaller, TrialComponentArtifactUnmarshaller>(StringUnmarshaller.Instance, TrialComponentArtifactUnmarshaller.Instance);
                    unmarshalledObject.InputArtifacts = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastModifiedBy", targetDepth))
                {
                    var unmarshaller = UserContextUnmarshaller.Instance;
                    unmarshalledObject.LastModifiedBy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastModifiedTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastModifiedTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LineageGroupArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LineageGroupArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MetadataProperties", targetDepth))
                {
                    var unmarshaller = MetadataPropertiesUnmarshaller.Instance;
                    unmarshalledObject.MetadataProperties = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Metrics", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<TrialComponentMetricSummary, TrialComponentMetricSummaryUnmarshaller>(TrialComponentMetricSummaryUnmarshaller.Instance);
                    unmarshalledObject.Metrics = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OutputArtifacts", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, TrialComponentArtifact, StringUnmarshaller, TrialComponentArtifactUnmarshaller>(StringUnmarshaller.Instance, TrialComponentArtifactUnmarshaller.Instance);
                    unmarshalledObject.OutputArtifacts = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Parameters", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, TrialComponentParameterValue, StringUnmarshaller, TrialComponentParameterValueUnmarshaller>(StringUnmarshaller.Instance, TrialComponentParameterValueUnmarshaller.Instance);
                    unmarshalledObject.Parameters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Parents", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Parent, ParentUnmarshaller>(ParentUnmarshaller.Instance);
                    unmarshalledObject.Parents = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RunName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RunName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Source", targetDepth))
                {
                    var unmarshaller = TrialComponentSourceUnmarshaller.Instance;
                    unmarshalledObject.Source = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SourceDetail", targetDepth))
                {
                    var unmarshaller = TrialComponentSourceDetailUnmarshaller.Instance;
                    unmarshalledObject.SourceDetail = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StartTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.StartTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Status", targetDepth))
                {
                    var unmarshaller = TrialComponentStatusUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Tags", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Tag, TagUnmarshaller>(TagUnmarshaller.Instance);
                    unmarshalledObject.Tags = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TrialComponentArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TrialComponentArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TrialComponentName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TrialComponentName = unmarshaller.Unmarshall(context);
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