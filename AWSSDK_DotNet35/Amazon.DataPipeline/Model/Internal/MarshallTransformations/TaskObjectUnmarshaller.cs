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
    using ThirdParty.Json.LitJson;
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
            if (context.CurrentTokenType == JsonToken.Null)
                return null;

            TaskObject taskObject = new TaskObject();

        
        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
              
              if (context.TestExpression("taskId", targetDepth))
              {
                context.Read();
                taskObject.TaskId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("pipelineId", targetDepth))
              {
                context.Read();
                taskObject.PipelineId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("attemptId", targetDepth))
              {
                context.Read();
                taskObject.AttemptId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("objects", targetDepth))
              {
                context.Read();
                taskObject.Objects = new Dictionary<String,PipelineObject>();
                KeyValueUnmarshaller<string, PipelineObject, StringUnmarshaller, PipelineObjectUnmarshaller> unmarshaller = new KeyValueUnmarshaller<string, PipelineObject, StringUnmarshaller, PipelineObjectUnmarshaller>(StringUnmarshaller.GetInstance(), PipelineObjectUnmarshaller.GetInstance());
                while (context.Read())
                {
                  JsonToken token = context.CurrentTokenType;
                  if (token == JsonToken.ArrayStart || token == JsonToken.ObjectStart)
                  {
                      continue;
                  }
                  if (token == JsonToken.ArrayEnd || token == JsonToken.ObjectEnd)
                  {
                      break;
                  }
                  KeyValuePair<string, PipelineObject> kvp = unmarshaller.Unmarshall(context);
                    taskObject.Objects.Add(kvp.Key, kvp.Value);
                }
                continue;
              }
  
                if (context.CurrentDepth <= originalDepth)
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
  
