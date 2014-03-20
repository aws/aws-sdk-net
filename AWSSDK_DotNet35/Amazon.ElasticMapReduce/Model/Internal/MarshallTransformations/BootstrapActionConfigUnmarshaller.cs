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
      /// BootstrapActionConfigUnmarshaller
      /// </summary>
      internal class BootstrapActionConfigUnmarshaller : IUnmarshaller<BootstrapActionConfig, XmlUnmarshallerContext>, IUnmarshaller<BootstrapActionConfig, JsonUnmarshallerContext>
      {
        BootstrapActionConfig IUnmarshaller<BootstrapActionConfig, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public BootstrapActionConfig Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) return null;
            BootstrapActionConfig bootstrapActionConfig = new BootstrapActionConfig();
        
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
              
              if (context.TestExpression("Name", targetDepth))
              {
                bootstrapActionConfig.Name = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("ScriptBootstrapAction", targetDepth))
              {
                bootstrapActionConfig.ScriptBootstrapAction = ScriptBootstrapActionConfigUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
            }
          
            return bootstrapActionConfig;
        }

        private static BootstrapActionConfigUnmarshaller instance;
        public static BootstrapActionConfigUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new BootstrapActionConfigUnmarshaller();
            return instance;
        }
    }
}
  
