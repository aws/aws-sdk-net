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
    using Amazon.ElasticMapReduce.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.ElasticMapReduce.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// JobFlowExecutionStatusDetailUnmarshaller
      /// </summary>
      internal class JobFlowExecutionStatusDetailUnmarshaller : IUnmarshaller<JobFlowExecutionStatusDetail, XmlUnmarshallerContext>, IUnmarshaller<JobFlowExecutionStatusDetail, JsonUnmarshallerContext>
      {
        JobFlowExecutionStatusDetail IUnmarshaller<JobFlowExecutionStatusDetail, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public JobFlowExecutionStatusDetail Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonToken.Null)
                return null;

            JobFlowExecutionStatusDetail jobFlowExecutionStatusDetail = new JobFlowExecutionStatusDetail();

        
        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
              
              if (context.TestExpression("State", targetDepth))
              {
                context.Read();
                jobFlowExecutionStatusDetail.State = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("CreationDateTime", targetDepth))
              {
                context.Read();
                jobFlowExecutionStatusDetail.CreationDateTime = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("StartDateTime", targetDepth))
              {
                context.Read();
                jobFlowExecutionStatusDetail.StartDateTime = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("ReadyDateTime", targetDepth))
              {
                context.Read();
                jobFlowExecutionStatusDetail.ReadyDateTime = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("EndDateTime", targetDepth))
              {
                context.Read();
                jobFlowExecutionStatusDetail.EndDateTime = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("LastStateChangeReason", targetDepth))
              {
                context.Read();
                jobFlowExecutionStatusDetail.LastStateChangeReason = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                if (context.CurrentDepth <= originalDepth)
                {
                    return jobFlowExecutionStatusDetail;
                }
            }
          

            return jobFlowExecutionStatusDetail;
        }

        private static JobFlowExecutionStatusDetailUnmarshaller instance;
        public static JobFlowExecutionStatusDetailUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new JobFlowExecutionStatusDetailUnmarshaller();
            return instance;
        }
    }
}
  
