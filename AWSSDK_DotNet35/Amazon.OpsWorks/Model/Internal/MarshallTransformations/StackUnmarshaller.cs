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
            if (context.CurrentTokenType == JsonToken.Null)
                return null;

            Stack stack = new Stack();

        
        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
              
              if (context.TestExpression("StackId", targetDepth))
              {
                context.Read();
                stack.StackId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Name", targetDepth))
              {
                context.Read();
                stack.Name = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Region", targetDepth))
              {
                context.Read();
                stack.Region = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("VpcId", targetDepth))
              {
                context.Read();
                stack.VpcId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Attributes", targetDepth))
              {
                context.Read();
                stack.Attributes = new Dictionary<String,String>();
                KeyValueUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller> unmarshaller = new KeyValueUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.GetInstance(), StringUnmarshaller.GetInstance());
                while (context.Read())
                {
                  JsonToken token = context.CurrentTokenType;
                  if (token == JsonToken.ArrayStart || token == JsonToken.ObjectStart)
                  {
                      continue;
                  }
                  if (token == JsonToken.ArrayEnd || token == JsonToken.ObjectEnd)
                  {
                      break;
                  }
                  KeyValuePair<string, string> kvp = unmarshaller.Unmarshall(context);
                    stack.Attributes.Add(kvp.Key, kvp.Value);
                }
                continue;
              }
  
              if (context.TestExpression("ServiceRoleArn", targetDepth))
              {
                context.Read();
                stack.ServiceRoleArn = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("DefaultInstanceProfileArn", targetDepth))
              {
                context.Read();
                stack.DefaultInstanceProfileArn = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("DefaultOs", targetDepth))
              {
                context.Read();
                stack.DefaultOs = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("HostnameTheme", targetDepth))
              {
                context.Read();
                stack.HostnameTheme = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("DefaultAvailabilityZone", targetDepth))
              {
                context.Read();
                stack.DefaultAvailabilityZone = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("DefaultSubnetId", targetDepth))
              {
                context.Read();
                stack.DefaultSubnetId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("CustomJson", targetDepth))
              {
                context.Read();
                stack.CustomJson = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("ConfigurationManager", targetDepth))
              {
                context.Read();
                stack.ConfigurationManager = StackConfigurationManagerUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("UseCustomCookbooks", targetDepth))
              {
                context.Read();
                stack.UseCustomCookbooks = BoolUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("CustomCookbooksSource", targetDepth))
              {
                context.Read();
                stack.CustomCookbooksSource = SourceUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("DefaultSshKeyName", targetDepth))
              {
                context.Read();
                stack.DefaultSshKeyName = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("CreatedAt", targetDepth))
              {
                context.Read();
                stack.CreatedAt = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("DefaultRootDeviceType", targetDepth))
              {
                context.Read();
                stack.DefaultRootDeviceType = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                if (context.CurrentDepth <= originalDepth)
                {
                    return stack;
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
  
