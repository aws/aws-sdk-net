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
      /// DeploymentUnmarshaller
      /// </summary>
      internal class DeploymentUnmarshaller : IUnmarshaller<Deployment, XmlUnmarshallerContext>, IUnmarshaller<Deployment, JsonUnmarshallerContext>
      {
        Deployment IUnmarshaller<Deployment, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public Deployment Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) return null;
            Deployment deployment = new Deployment();
        
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
              
              if (context.TestExpression("DeploymentId", targetDepth))
              {
                deployment.DeploymentId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("StackId", targetDepth))
              {
                deployment.StackId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("AppId", targetDepth))
              {
                deployment.AppId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("CreatedAt", targetDepth))
              {
                deployment.CreatedAt = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("CompletedAt", targetDepth))
              {
                deployment.CompletedAt = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Duration", targetDepth))
              {
                deployment.Duration = IntUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("IamUserArn", targetDepth))
              {
                deployment.IamUserArn = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Comment", targetDepth))
              {
                deployment.Comment = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Command", targetDepth))
              {
                deployment.Command = DeploymentCommandUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Status", targetDepth))
              {
                deployment.Status = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("CustomJson", targetDepth))
              {
                deployment.CustomJson = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("InstanceIds", targetDepth))
              {
                
                var unmarshaller = new ListUnmarshaller<String,StringUnmarshaller>(
                    StringUnmarshaller.GetInstance());                  
                deployment.InstanceIds = unmarshaller.Unmarshall(context);
                
                continue;
              }
  
            }
          
            return deployment;
        }

        private static DeploymentUnmarshaller instance;
        public static DeploymentUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new DeploymentUnmarshaller();
            return instance;
        }
    }
}
  
