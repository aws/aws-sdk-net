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
    using Amazon.Glacier.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.Glacier.Model.Internal.MarshallTransformations 
    { 
      /// <summary> 
      /// ListJobsResultUnmarshaller 
      /// </summary> 
      internal class ListJobsResultUnmarshaller : IUnmarshaller<ListJobsResult, XmlUnmarshallerContext>, IUnmarshaller<ListJobsResult, JsonUnmarshallerContext> 
      { 
        ListJobsResult IUnmarshaller<ListJobsResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }
        
        public ListJobsResult Unmarshall(JsonUnmarshallerContext context) 
        {
            ListJobsResult listJobsResult = new ListJobsResult();
          listJobsResult.JobList = null; 
                                  
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                context.Read();
                context.Read();
               
              if (context.TestExpression("JobList", targetDepth)) 
              {
                listJobsResult.JobList = new List<GlacierJobDescription>();
                        GlacierJobDescriptionUnmarshaller unmarshaller = GlacierJobDescriptionUnmarshaller.GetInstance();
                while (context.Read())
                {
                  if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                  {
                     listJobsResult.JobList.Add(unmarshaller.Unmarshall(context));
                  }
                  else if (context.IsEndArray)
                  {
                    break;
                  }
                }
                continue; 
              }
   
              if (context.TestExpression("Marker", targetDepth)) 
              {
                listJobsResult.Marker = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
                } 
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth) 
                { 
                    return listJobsResult; 
                } 
            } 
          
          
            return listJobsResult; 
        } 
        
        private static ListJobsResultUnmarshaller instance; 
        public static ListJobsResultUnmarshaller GetInstance() 
        { 
            if (instance == null) 
                instance = new ListJobsResultUnmarshaller(); 
            return instance;
        } 
    } 
} 
  
