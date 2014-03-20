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
      /// LayerUnmarshaller
      /// </summary>
      internal class LayerUnmarshaller : IUnmarshaller<Layer, XmlUnmarshallerContext>, IUnmarshaller<Layer, JsonUnmarshallerContext>
      {
        Layer IUnmarshaller<Layer, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public Layer Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) return null;
            Layer layer = new Layer();
        
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
              
              if (context.TestExpression("StackId", targetDepth))
              {
                layer.StackId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("LayerId", targetDepth))
              {
                layer.LayerId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Type", targetDepth))
              {
                layer.Type = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Name", targetDepth))
              {
                layer.Name = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Shortname", targetDepth))
              {
                layer.Shortname = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Attributes", targetDepth))
              {
                
                var unmarshaller =  new DictionaryUnmarshaller<String,String,StringUnmarshaller,StringUnmarshaller>(
                    StringUnmarshaller.GetInstance(),StringUnmarshaller.GetInstance());               
                layer.Attributes = unmarshaller.Unmarshall(context);
                
                continue;
              }
  
              if (context.TestExpression("CustomInstanceProfileArn", targetDepth))
              {
                layer.CustomInstanceProfileArn = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("CustomSecurityGroupIds", targetDepth))
              {
                
                var unmarshaller = new ListUnmarshaller<String,StringUnmarshaller>(
                    StringUnmarshaller.GetInstance());                  
                layer.CustomSecurityGroupIds = unmarshaller.Unmarshall(context);
                
                continue;
              }
  
              if (context.TestExpression("DefaultSecurityGroupNames", targetDepth))
              {
                
                var unmarshaller = new ListUnmarshaller<String,StringUnmarshaller>(
                    StringUnmarshaller.GetInstance());                  
                layer.DefaultSecurityGroupNames = unmarshaller.Unmarshall(context);
                
                continue;
              }
  
              if (context.TestExpression("Packages", targetDepth))
              {
                
                var unmarshaller = new ListUnmarshaller<String,StringUnmarshaller>(
                    StringUnmarshaller.GetInstance());                  
                layer.Packages = unmarshaller.Unmarshall(context);
                
                continue;
              }
  
              if (context.TestExpression("VolumeConfigurations", targetDepth))
              {
                
                var unmarshaller = new ListUnmarshaller<VolumeConfiguration,VolumeConfigurationUnmarshaller>(
                    VolumeConfigurationUnmarshaller.GetInstance());                  
                layer.VolumeConfigurations = unmarshaller.Unmarshall(context);
                
                continue;
              }
  
              if (context.TestExpression("EnableAutoHealing", targetDepth))
              {
                layer.EnableAutoHealing = BoolUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("AutoAssignElasticIps", targetDepth))
              {
                layer.AutoAssignElasticIps = BoolUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("AutoAssignPublicIps", targetDepth))
              {
                layer.AutoAssignPublicIps = BoolUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("DefaultRecipes", targetDepth))
              {
                layer.DefaultRecipes = RecipesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("CustomRecipes", targetDepth))
              {
                layer.CustomRecipes = RecipesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("CreatedAt", targetDepth))
              {
                layer.CreatedAt = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("InstallUpdatesOnBoot", targetDepth))
              {
                layer.InstallUpdatesOnBoot = BoolUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
            }
          
            return layer;
        }

        private static LayerUnmarshaller instance;
        public static LayerUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new LayerUnmarshaller();
            return instance;
        }
    }
}
  
