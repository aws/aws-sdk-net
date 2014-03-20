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
      /// DeploymentCommandUnmarshaller
      /// </summary>
      internal class DeploymentCommandUnmarshaller : IUnmarshaller<DeploymentCommand, XmlUnmarshallerContext>, IUnmarshaller<DeploymentCommand, JsonUnmarshallerContext>
      {
        DeploymentCommand IUnmarshaller<DeploymentCommand, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public DeploymentCommand Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) return null;
            DeploymentCommand deploymentCommand = new DeploymentCommand();
        
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
              
              if (context.TestExpression("Name", targetDepth))
              {
                deploymentCommand.Name = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Args", targetDepth))
              {
                
                var unmarshaller =  new DictionaryUnmarshaller<String,List<string>,StringUnmarshaller,ListUnmarshaller<string, StringUnmarshaller>>(
                    StringUnmarshaller.GetInstance(),new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.GetInstance()));               
                deploymentCommand.Args = unmarshaller.Unmarshall(context);
                
                continue;
              }
  
            }
          
            return deploymentCommand;
        }

        private static DeploymentCommandUnmarshaller instance;
        public static DeploymentCommandUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new DeploymentCommandUnmarshaller();
            return instance;
        }
    }
}
  
