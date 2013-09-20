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
    using Amazon.DirectConnect.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.DirectConnect.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// ConnectionOrderStepUnmarshaller
      /// </summary>
      internal class ConnectionOrderStepUnmarshaller : IUnmarshaller<ConnectionOrderStep, XmlUnmarshallerContext>, IUnmarshaller<ConnectionOrderStep, JsonUnmarshallerContext>
      {
        ConnectionOrderStep IUnmarshaller<ConnectionOrderStep, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public ConnectionOrderStep Unmarshall(JsonUnmarshallerContext context)
        {
            ConnectionOrderStep connectionOrderStep = new ConnectionOrderStep();

        
        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
              
              if (context.TestExpression("number", targetDepth))
              {
                context.Read();
                connectionOrderStep.Number = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("name", targetDepth))
              {
                context.Read();
                connectionOrderStep.Name = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("description", targetDepth))
              {
                context.Read();
                connectionOrderStep.Description = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("owner", targetDepth))
              {
                context.Read();
                connectionOrderStep.Owner = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("sla", targetDepth))
              {
                context.Read();
                connectionOrderStep.Sla = IntUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("stepState", targetDepth))
              {
                context.Read();
                connectionOrderStep.StepState = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                if (context.CurrentDepth <= originalDepth)
                {
                    return connectionOrderStep;
                }
            }
          

            return connectionOrderStep;
        }

        private static ConnectionOrderStepUnmarshaller instance;
        public static ConnectionOrderStepUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new ConnectionOrderStepUnmarshaller();
            return instance;
        }
    }
}
  
