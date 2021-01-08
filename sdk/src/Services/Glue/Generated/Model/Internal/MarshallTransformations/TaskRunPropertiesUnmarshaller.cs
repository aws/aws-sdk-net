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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glue.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for TaskRunProperties Object
    /// </summary>  
    public class TaskRunPropertiesUnmarshaller : IUnmarshaller<TaskRunProperties, XmlUnmarshallerContext>, IUnmarshaller<TaskRunProperties, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        TaskRunProperties IUnmarshaller<TaskRunProperties, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public TaskRunProperties Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            TaskRunProperties unmarshalledObject = new TaskRunProperties();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ExportLabelsTaskRunProperties", targetDepth))
                {
                    var unmarshaller = ExportLabelsTaskRunPropertiesUnmarshaller.Instance;
                    unmarshalledObject.ExportLabelsTaskRunProperties = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FindMatchesTaskRunProperties", targetDepth))
                {
                    var unmarshaller = FindMatchesTaskRunPropertiesUnmarshaller.Instance;
                    unmarshalledObject.FindMatchesTaskRunProperties = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ImportLabelsTaskRunProperties", targetDepth))
                {
                    var unmarshaller = ImportLabelsTaskRunPropertiesUnmarshaller.Instance;
                    unmarshalledObject.ImportLabelsTaskRunProperties = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LabelingSetGenerationTaskRunProperties", targetDepth))
                {
                    var unmarshaller = LabelingSetGenerationTaskRunPropertiesUnmarshaller.Instance;
                    unmarshalledObject.LabelingSetGenerationTaskRunProperties = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TaskType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TaskType = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static TaskRunPropertiesUnmarshaller _instance = new TaskRunPropertiesUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TaskRunPropertiesUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}