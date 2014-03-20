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
      /// SourceUnmarshaller
      /// </summary>
      internal class SourceUnmarshaller : IUnmarshaller<Source, XmlUnmarshallerContext>, IUnmarshaller<Source, JsonUnmarshallerContext>
      {
        Source IUnmarshaller<Source, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public Source Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) return null;
            Source source = new Source();
        
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
              
              if (context.TestExpression("Type", targetDepth))
              {
                source.Type = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Url", targetDepth))
              {
                source.Url = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Username", targetDepth))
              {
                source.Username = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Password", targetDepth))
              {
                source.Password = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("SshKey", targetDepth))
              {
                source.SshKey = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Revision", targetDepth))
              {
                source.Revision = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
            }
          
            return source;
        }

        private static SourceUnmarshaller instance;
        public static SourceUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new SourceUnmarshaller();
            return instance;
        }
    }
}
  
