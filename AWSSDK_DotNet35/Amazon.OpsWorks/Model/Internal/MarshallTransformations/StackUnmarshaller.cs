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
      /// StackUnmarshaller
      /// </summary>
      internal class StackUnmarshaller : IUnmarshaller<Stack, XmlUnmarshallerContext>, IUnmarshaller<Stack, JsonUnmarshallerContext>
      {
        Stack IUnmarshaller<Stack, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public Stack Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) return null;
            Stack stack = new Stack();
        
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
              
              if (context.TestExpression("StackId", targetDepth))
              {
                stack.StackId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Name", targetDepth))
              {
                stack.Name = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Region", targetDepth))
              {
                stack.Region = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("VpcId", targetDepth))
              {
                stack.VpcId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Attributes", targetDepth))
              {
                
                var unmarshaller =  new DictionaryUnmarshaller<String,String,StringUnmarshaller,StringUnmarshaller>(
                    StringUnmarshaller.GetInstance(),StringUnmarshaller.GetInstance());               
                stack.Attributes = unmarshaller.Unmarshall(context);
                
                continue;
              }
  
              if (context.TestExpression("ServiceRoleArn", targetDepth))
              {
                stack.ServiceRoleArn = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("DefaultInstanceProfileArn", targetDepth))
              {
                stack.DefaultInstanceProfileArn = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("DefaultOs", targetDepth))
              {
                stack.DefaultOs = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("HostnameTheme", targetDepth))
              {
                stack.HostnameTheme = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("DefaultAvailabilityZone", targetDepth))
              {
                stack.DefaultAvailabilityZone = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("DefaultSubnetId", targetDepth))
              {
                stack.DefaultSubnetId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("CustomJson", targetDepth))
              {
                stack.CustomJson = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("ConfigurationManager", targetDepth))
              {
                stack.ConfigurationManager = StackConfigurationManagerUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("UseCustomCookbooks", targetDepth))
              {
                stack.UseCustomCookbooks = BoolUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("CustomCookbooksSource", targetDepth))
              {
                stack.CustomCookbooksSource = SourceUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("DefaultSshKeyName", targetDepth))
              {
                stack.DefaultSshKeyName = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("CreatedAt", targetDepth))
              {
                stack.CreatedAt = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("DefaultRootDeviceType", targetDepth))
              {
                stack.DefaultRootDeviceType = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
            }
          
            return stack;
        }

        private static StackUnmarshaller instance;
        public static StackUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new StackUnmarshaller();
            return instance;
        }
    }
}
  
