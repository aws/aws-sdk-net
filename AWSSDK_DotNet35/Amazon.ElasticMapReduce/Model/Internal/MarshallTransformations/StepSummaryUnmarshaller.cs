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
    using Amazon.ElasticMapReduce.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.ElasticMapReduce.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// StepSummaryUnmarshaller
      /// </summary>
      internal class StepSummaryUnmarshaller : IUnmarshaller<StepSummary, XmlUnmarshallerContext>, IUnmarshaller<StepSummary, JsonUnmarshallerContext>
      {
        StepSummary IUnmarshaller<StepSummary, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public StepSummary Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) return null;
            StepSummary stepSummary = new StepSummary();
        
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
              
              if (context.TestExpression("Id", targetDepth))
              {
                stepSummary.Id = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Name", targetDepth))
              {
                stepSummary.Name = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Status", targetDepth))
              {
                stepSummary.Status = StepStatusUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
            }
          
            return stepSummary;
        }

        private static StepSummaryUnmarshaller instance;
        public static StepSummaryUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new StepSummaryUnmarshaller();
            return instance;
        }
    }
}
  
