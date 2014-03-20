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
      /// CommandUnmarshaller
      /// </summary>
      internal class CommandUnmarshaller : IUnmarshaller<Command, XmlUnmarshallerContext>, IUnmarshaller<Command, JsonUnmarshallerContext>
      {
        Command IUnmarshaller<Command, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public Command Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) return null;
            Command command = new Command();
        
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
              
              if (context.TestExpression("Name", targetDepth))
              {
                command.Name = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("ScriptPath", targetDepth))
              {
                command.ScriptPath = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Args", targetDepth))
              {
                
                var unmarshaller = new ListUnmarshaller<String,StringUnmarshaller>(
                    StringUnmarshaller.GetInstance());                  
                command.Args = unmarshaller.Unmarshall(context);
                
                continue;
              }
  
            }
          
            return command;
        }

        private static CommandUnmarshaller instance;
        public static CommandUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new CommandUnmarshaller();
            return instance;
        }
    }
}
  
