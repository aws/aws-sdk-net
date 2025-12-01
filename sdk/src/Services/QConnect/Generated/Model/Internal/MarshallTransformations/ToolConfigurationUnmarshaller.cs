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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.QConnect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.QConnect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ToolConfiguration Object
    /// </summary>  
    public class ToolConfigurationUnmarshaller : IUnmarshaller<ToolConfiguration, XmlUnmarshallerContext>, IUnmarshaller<ToolConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ToolConfiguration IUnmarshaller<ToolConfiguration, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ToolConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            ToolConfiguration unmarshalledObject = new ToolConfiguration();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("annotations", targetDepth))
                {
                    var unmarshaller = AnnotationUnmarshaller.Instance;
                    unmarshalledObject.Annotations = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("inputSchema", targetDepth))
                {
                    var unmarshaller = Amazon.Runtime.Documents.Internal.Transform.DocumentUnmarshaller.Instance;
                    unmarshalledObject.InputSchema = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("instruction", targetDepth))
                {
                    var unmarshaller = ToolInstructionUnmarshaller.Instance;
                    unmarshalledObject.Instruction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("outputFilters", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ToolOutputFilter, ToolOutputFilterUnmarshaller>(ToolOutputFilterUnmarshaller.Instance);
                    unmarshalledObject.OutputFilters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("outputSchema", targetDepth))
                {
                    var unmarshaller = Amazon.Runtime.Documents.Internal.Transform.DocumentUnmarshaller.Instance;
                    unmarshalledObject.OutputSchema = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("overrideInputValues", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ToolOverrideInputValue, ToolOverrideInputValueUnmarshaller>(ToolOverrideInputValueUnmarshaller.Instance);
                    unmarshalledObject.OverrideInputValues = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("title", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Title = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("toolId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ToolId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("toolName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ToolName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("toolType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ToolType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("userInteractionConfiguration", targetDepth))
                {
                    var unmarshaller = UserInteractionConfigurationUnmarshaller.Instance;
                    unmarshalledObject.UserInteractionConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ToolConfigurationUnmarshaller _instance = new ToolConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ToolConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}