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
      /// AppUnmarshaller
      /// </summary>
      internal class AppUnmarshaller : IUnmarshaller<App, XmlUnmarshallerContext>, IUnmarshaller<App, JsonUnmarshallerContext>
      {
        App IUnmarshaller<App, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public App Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) return null;
            App app = new App();
        
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
              
              if (context.TestExpression("AppId", targetDepth))
              {
                app.AppId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("StackId", targetDepth))
              {
                app.StackId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Shortname", targetDepth))
              {
                app.Shortname = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Name", targetDepth))
              {
                app.Name = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Description", targetDepth))
              {
                app.Description = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Type", targetDepth))
              {
                app.Type = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("AppSource", targetDepth))
              {
                app.AppSource = SourceUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Domains", targetDepth))
              {
                
                var unmarshaller = new ListUnmarshaller<String,StringUnmarshaller>(
                    StringUnmarshaller.GetInstance());                  
                app.Domains = unmarshaller.Unmarshall(context);
                
                continue;
              }
  
              if (context.TestExpression("EnableSsl", targetDepth))
              {
                app.EnableSsl = BoolUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("SslConfiguration", targetDepth))
              {
                app.SslConfiguration = SslConfigurationUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Attributes", targetDepth))
              {
                
                var unmarshaller =  new DictionaryUnmarshaller<String,String,StringUnmarshaller,StringUnmarshaller>(
                    StringUnmarshaller.GetInstance(),StringUnmarshaller.GetInstance());               
                app.Attributes = unmarshaller.Unmarshall(context);
                
                continue;
              }
  
              if (context.TestExpression("CreatedAt", targetDepth))
              {
                app.CreatedAt = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
            }
          
            return app;
        }

        private static AppUnmarshaller instance;
        public static AppUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new AppUnmarshaller();
            return instance;
        }
    }
}
  
