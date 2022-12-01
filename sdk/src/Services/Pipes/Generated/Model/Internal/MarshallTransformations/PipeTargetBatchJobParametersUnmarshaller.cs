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
 * Do not modify this file. This file is generated from the pipes-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Pipes.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Pipes.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for PipeTargetBatchJobParameters Object
    /// </summary>  
    public class PipeTargetBatchJobParametersUnmarshaller : IUnmarshaller<PipeTargetBatchJobParameters, XmlUnmarshallerContext>, IUnmarshaller<PipeTargetBatchJobParameters, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        PipeTargetBatchJobParameters IUnmarshaller<PipeTargetBatchJobParameters, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public PipeTargetBatchJobParameters Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            PipeTargetBatchJobParameters unmarshalledObject = new PipeTargetBatchJobParameters();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ArrayProperties", targetDepth))
                {
                    var unmarshaller = BatchArrayPropertiesUnmarshaller.Instance;
                    unmarshalledObject.ArrayProperties = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ContainerOverrides", targetDepth))
                {
                    var unmarshaller = BatchContainerOverridesUnmarshaller.Instance;
                    unmarshalledObject.ContainerOverrides = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DependsOn", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<BatchJobDependency, BatchJobDependencyUnmarshaller>(BatchJobDependencyUnmarshaller.Instance);
                    unmarshalledObject.DependsOn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("JobDefinition", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.JobDefinition = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("JobName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.JobName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Parameters", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.Parameters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RetryStrategy", targetDepth))
                {
                    var unmarshaller = BatchRetryStrategyUnmarshaller.Instance;
                    unmarshalledObject.RetryStrategy = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static PipeTargetBatchJobParametersUnmarshaller _instance = new PipeTargetBatchJobParametersUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PipeTargetBatchJobParametersUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}