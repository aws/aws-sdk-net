/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    using System;
    using System.Collections.Generic;
    using System.IO;
    using Amazon.DataPipeline.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.DataPipeline.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// TaskObjectUnmarshaller
      /// </summary>
      internal class TaskObjectUnmarshaller : IUnmarshaller<TaskObject, XmlUnmarshallerContext>, IUnmarshaller<TaskObject, JsonUnmarshallerContext>
      {
        TaskObject IUnmarshaller<TaskObject, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public TaskObject Unmarshall(JsonUnmarshallerContext context)
        {
            TaskObject taskObject = new TaskObject();
          taskObject.Objects = null;
                        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                context.Read();
                context.Read();
              
              if (context.TestExpression("TaskId", targetDepth))
              {
                taskObject.TaskId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("PipelineId", targetDepth))
              {
                taskObject.PipelineId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("AttemptId", targetDepth))
              {
                taskObject.AttemptId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Objects", targetDepth))
              {
                taskObject.Objects = new Dictionary<String,PipelineObject>();
                KeyValueUnmarshaller<string, PipelineObject, StringUnmarshaller, PipelineObjectUnmarshaller> unmarshaller = new KeyValueUnmarshaller<string, PipelineObject, StringUnmarshaller, PipelineObjectUnmarshaller>(StringUnmarshaller.GetInstance(), PipelineObjectUnmarshaller.GetInstance());
                while (context.Read())
                {
                  if (((context.IsStartArray || context.IsStartElement || context.IsLeafValue) && (context.CurrentDepth == targetDepth)) ||
                      ((context.IsKey) && (context.CurrentDepth == targetDepth+1)))
                  {
                    KeyValuePair<string, PipelineObject> kvp = unmarshaller.Unmarshall(context);
                    taskObject.Objects.Add(kvp.Key, kvp.Value);
                  }
                  else if (context.IsEndElement)
                  {
                    break;
                  }
                }
                continue;
              }
  
                }
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth)
                {
                    return taskObject;
                }
            }
          

            return taskObject;
        }

        private static TaskObjectUnmarshaller instance;
        public static TaskObjectUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new TaskObjectUnmarshaller();
            return instance;
        }
    }
}
  
