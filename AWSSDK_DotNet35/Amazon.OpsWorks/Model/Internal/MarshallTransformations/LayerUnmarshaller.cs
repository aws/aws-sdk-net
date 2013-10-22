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
            if (context.CurrentTokenType == JsonToken.Null)
                return null;

            Layer layer = new Layer();

        
        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
              
              if (context.TestExpression("StackId", targetDepth))
              {
                context.Read();
                layer.StackId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("LayerId", targetDepth))
              {
                context.Read();
                layer.LayerId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Type", targetDepth))
              {
                context.Read();
                layer.Type = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Name", targetDepth))
              {
                context.Read();
                layer.Name = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Shortname", targetDepth))
              {
                context.Read();
                layer.Shortname = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Attributes", targetDepth))
              {
                context.Read();
                layer.Attributes = new Dictionary<String,String>();
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
                    layer.Attributes.Add(kvp.Key, kvp.Value);
                }
                continue;
              }
  
              if (context.TestExpression("CustomInstanceProfileArn", targetDepth))
              {
                context.Read();
                layer.CustomInstanceProfileArn = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("CustomSecurityGroupIds", targetDepth))
              {
                context.Read();
                layer.CustomSecurityGroupIds = new List<String>();
                        StringUnmarshaller unmarshaller = StringUnmarshaller.GetInstance();
                while (context.Read())
                {
                  JsonToken token = context.CurrentTokenType;                
                  if (token == JsonToken.ArrayStart)
                  {
                    continue;
                  }
                  if (token == JsonToken.ArrayEnd)
                  {
                    break;
                  }
                   layer.CustomSecurityGroupIds.Add(unmarshaller.Unmarshall(context));
                }
                continue;
              }
  
              if (context.TestExpression("DefaultSecurityGroupNames", targetDepth))
              {
                context.Read();
                layer.DefaultSecurityGroupNames = new List<String>();
                        StringUnmarshaller unmarshaller = StringUnmarshaller.GetInstance();
                while (context.Read())
                {
                  JsonToken token = context.CurrentTokenType;                
                  if (token == JsonToken.ArrayStart)
                  {
                    continue;
                  }
                  if (token == JsonToken.ArrayEnd)
                  {
                    break;
                  }
                   layer.DefaultSecurityGroupNames.Add(unmarshaller.Unmarshall(context));
                }
                continue;
              }
  
              if (context.TestExpression("Packages", targetDepth))
              {
                context.Read();
                layer.Packages = new List<String>();
                        StringUnmarshaller unmarshaller = StringUnmarshaller.GetInstance();
                while (context.Read())
                {
                  JsonToken token = context.CurrentTokenType;                
                  if (token == JsonToken.ArrayStart)
                  {
                    continue;
                  }
                  if (token == JsonToken.ArrayEnd)
                  {
                    break;
                  }
                   layer.Packages.Add(unmarshaller.Unmarshall(context));
                }
                continue;
              }
  
              if (context.TestExpression("VolumeConfigurations", targetDepth))
              {
                context.Read();
                layer.VolumeConfigurations = new List<VolumeConfiguration>();
                        VolumeConfigurationUnmarshaller unmarshaller = VolumeConfigurationUnmarshaller.GetInstance();
                while (context.Read())
                {
                  JsonToken token = context.CurrentTokenType;                
                  if (token == JsonToken.ArrayStart)
                  {
                    continue;
                  }
                  if (token == JsonToken.ArrayEnd)
                  {
                    break;
                  }
                   layer.VolumeConfigurations.Add(unmarshaller.Unmarshall(context));
                }
                continue;
              }
  
              if (context.TestExpression("EnableAutoHealing", targetDepth))
              {
                context.Read();
                layer.EnableAutoHealing = BoolUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("AutoAssignElasticIps", targetDepth))
              {
                context.Read();
                layer.AutoAssignElasticIps = BoolUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("AutoAssignPublicIps", targetDepth))
              {
                context.Read();
                layer.AutoAssignPublicIps = BoolUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("DefaultRecipes", targetDepth))
              {
                context.Read();
                layer.DefaultRecipes = RecipesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("CustomRecipes", targetDepth))
              {
                context.Read();
                layer.CustomRecipes = RecipesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("CreatedAt", targetDepth))
              {
                context.Read();
                layer.CreatedAt = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("InstallUpdatesOnBoot", targetDepth))
              {
                context.Read();
                layer.InstallUpdatesOnBoot = BoolUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                if (context.CurrentDepth <= originalDepth)
                {
                    return layer;
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
  
