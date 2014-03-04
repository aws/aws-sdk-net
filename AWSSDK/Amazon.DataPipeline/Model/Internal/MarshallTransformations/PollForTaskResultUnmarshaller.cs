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
      /// PollForTaskResultUnmarshaller
      /// </summary>
      internal class PollForTaskResultUnmarshaller : IUnmarshaller<PollForTaskResult, XmlUnmarshallerContext>, IUnmarshaller<PollForTaskResult, JsonUnmarshallerContext>
      {
        PollForTaskResult IUnmarshaller<PollForTaskResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public PollForTaskResult Unmarshall(JsonUnmarshallerContext context)
        {
            PollForTaskResult pollForTaskResult = new PollForTaskResult();
          
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                context.Read();
                context.Read();
              
              if (context.TestExpression("TaskObject", targetDepth))
              {
                pollForTaskResult.TaskObject = TaskObjectUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                }
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth)
                {
                    return pollForTaskResult;
                }
            }
          

            return pollForTaskResult;
        }

        private static PollForTaskResultUnmarshaller instance;
        public static PollForTaskResultUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new PollForTaskResultUnmarshaller();
            return instance;
        }
    }
}
  
