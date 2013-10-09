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
    using Amazon.ElasticTranscoder.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.ElasticTranscoder.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// ListJobsByPipelineResultUnmarshaller
      /// </summary>
      internal class ListJobsByPipelineResultUnmarshaller : IUnmarshaller<ListJobsByPipelineResult, XmlUnmarshallerContext>, IUnmarshaller<ListJobsByPipelineResult, JsonUnmarshallerContext>
      {
        ListJobsByPipelineResult IUnmarshaller<ListJobsByPipelineResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public ListJobsByPipelineResult Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonUnmarshallerContext.TokenType.Null)
                return null;
            ListJobsByPipelineResult listJobsByPipelineResult = new ListJobsByPipelineResult();
          listJobsByPipelineResult.Jobs = null;
                        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                context.Read();
                context.Read();
              
              if (context.TestExpression("Jobs", targetDepth))
              {
                listJobsByPipelineResult.Jobs = new List<Job>();
                        JobUnmarshaller unmarshaller = JobUnmarshaller.GetInstance();
                while (context.Read())
                {
                  if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                  {
                     listJobsByPipelineResult.Jobs.Add(unmarshaller.Unmarshall(context));
                  }
                  else if (context.IsEndArray)
                  {
                    break;
                  }
                }
                continue;
              }
  
              if (context.TestExpression("NextPageToken", targetDepth))
              {
                listJobsByPipelineResult.NextPageToken = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                }
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth)
                {
                    return listJobsByPipelineResult;
                }
            }
          

            return listJobsByPipelineResult;
        }

        private static ListJobsByPipelineResultUnmarshaller instance;
        public static ListJobsByPipelineResultUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new ListJobsByPipelineResultUnmarshaller();
            return instance;
        }
    }
}
  
