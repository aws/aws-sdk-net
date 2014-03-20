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
    using Amazon.OpsWorks.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.OpsWorks.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// StackSummaryUnmarshaller
      /// </summary>
      internal class StackSummaryUnmarshaller : IUnmarshaller<StackSummary, XmlUnmarshallerContext>, IUnmarshaller<StackSummary, JsonUnmarshallerContext>
      {
        StackSummary IUnmarshaller<StackSummary, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public StackSummary Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) return null;
            StackSummary stackSummary = new StackSummary();
        
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
              
              if (context.TestExpression("StackId", targetDepth))
              {
                stackSummary.StackId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Name", targetDepth))
              {
                stackSummary.Name = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("LayersCount", targetDepth))
              {
                stackSummary.LayersCount = IntUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("AppsCount", targetDepth))
              {
                stackSummary.AppsCount = IntUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("InstancesCount", targetDepth))
              {
                stackSummary.InstancesCount = InstancesCountUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
            }
          
            return stackSummary;
        }

        private static StackSummaryUnmarshaller instance;
        public static StackSummaryUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new StackSummaryUnmarshaller();
            return instance;
        }
    }
}
  
