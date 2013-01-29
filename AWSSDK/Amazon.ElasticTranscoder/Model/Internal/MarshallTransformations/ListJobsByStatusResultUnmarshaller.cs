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
      /// ListJobsByStatusResultUnmarshaller
      /// </summary>
      internal class ListJobsByStatusResultUnmarshaller : IUnmarshaller<ListJobsByStatusResult, XmlUnmarshallerContext>, IUnmarshaller<ListJobsByStatusResult, JsonUnmarshallerContext>
      {
        ListJobsByStatusResult IUnmarshaller<ListJobsByStatusResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public ListJobsByStatusResult Unmarshall(JsonUnmarshallerContext context)
        {
            ListJobsByStatusResult listJobsByStatusResult = new ListJobsByStatusResult();
          listJobsByStatusResult.Jobs = null;
                        
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
                listJobsByStatusResult.Jobs = new List<Job>();
                        JobUnmarshaller unmarshaller = JobUnmarshaller.GetInstance();
                while (context.Read())
                {
                  if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                  {
                     listJobsByStatusResult.Jobs.Add(unmarshaller.Unmarshall(context));
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
                listJobsByStatusResult.NextPageToken = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                }
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth)
                {
                    return listJobsByStatusResult;
                }
            }
          

            return listJobsByStatusResult;
        }

        private static ListJobsByStatusResultUnmarshaller instance;
        public static ListJobsByStatusResultUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new ListJobsByStatusResultUnmarshaller();
            return instance;
        }
    }
}
  
