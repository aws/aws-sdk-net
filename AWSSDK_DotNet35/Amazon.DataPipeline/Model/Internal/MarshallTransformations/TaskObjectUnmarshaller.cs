/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) return null;
            TaskObject taskObject = new TaskObject();
        
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
              
              if (context.TestExpression("taskId", targetDepth))
              {
                taskObject.TaskId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("pipelineId", targetDepth))
              {
                taskObject.PipelineId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("attemptId", targetDepth))
              {
                taskObject.AttemptId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("objects", targetDepth))
              {
                
                var unmarshaller =  new DictionaryUnmarshaller<String,PipelineObject,StringUnmarshaller,PipelineObjectUnmarshaller>(
                    StringUnmarshaller.GetInstance(),PipelineObjectUnmarshaller.GetInstance());               
                taskObject.Objects = unmarshaller.Unmarshall(context);
                
                continue;
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
  
