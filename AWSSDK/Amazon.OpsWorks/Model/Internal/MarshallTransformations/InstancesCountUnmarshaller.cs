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
    using Amazon.OpsWorks.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.OpsWorks.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// InstancesCountUnmarshaller
      /// </summary>
      internal class InstancesCountUnmarshaller : IUnmarshaller<InstancesCount, XmlUnmarshallerContext>, IUnmarshaller<InstancesCount, JsonUnmarshallerContext>
      {
        InstancesCount IUnmarshaller<InstancesCount, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public InstancesCount Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonUnmarshallerContext.TokenType.Null)
                return null;
            InstancesCount instancesCount = new InstancesCount();
          
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                context.Read();
                context.Read();
              
              if (context.TestExpression("Booting", targetDepth))
              {
                instancesCount.Booting = IntUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("ConnectionLost", targetDepth))
              {
                instancesCount.ConnectionLost = IntUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Online", targetDepth))
              {
                instancesCount.Online = IntUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Pending", targetDepth))
              {
                instancesCount.Pending = IntUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Rebooting", targetDepth))
              {
                instancesCount.Rebooting = IntUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Requested", targetDepth))
              {
                instancesCount.Requested = IntUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("RunningSetup", targetDepth))
              {
                instancesCount.RunningSetup = IntUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("SetupFailed", targetDepth))
              {
                instancesCount.SetupFailed = IntUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("ShuttingDown", targetDepth))
              {
                instancesCount.ShuttingDown = IntUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("StartFailed", targetDepth))
              {
                instancesCount.StartFailed = IntUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Stopped", targetDepth))
              {
                instancesCount.Stopped = IntUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Stopping", targetDepth))
              {
                instancesCount.Stopping = IntUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Terminated", targetDepth))
              {
                instancesCount.Terminated = IntUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Terminating", targetDepth))
              {
                instancesCount.Terminating = IntUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                }
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth)
                {
                    return instancesCount;
                }
            }
          

            return instancesCount;
        }

        private static InstancesCountUnmarshaller instance;
        public static InstancesCountUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new InstancesCountUnmarshaller();
            return instance;
        }
    }
}
  
