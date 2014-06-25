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
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.OpsWorks.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.OpsWorks.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Layer Object
    /// </summary>  
    public class LayerUnmarshaller : IUnmarshaller<Layer, XmlUnmarshallerContext>, IUnmarshaller<Layer, JsonUnmarshallerContext>
    {
        Layer IUnmarshaller<Layer, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        public Layer Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonUnmarshallerContext.TokenType.Null)
                return null;
            
            var unmarshalledObject = new Layer();
            unmarshalledObject.Attributes = null;
            unmarshalledObject.CustomSecurityGroupIds = null;
            unmarshalledObject.DefaultSecurityGroupNames = null;
            unmarshalledObject.Packages = null;
            unmarshalledObject.VolumeConfigurations = null;
                    
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;

            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                    context.Read();
                    context.Read();
                    if (context.TestExpression("Attributes", targetDepth))
                    {
                        if (context.CurrentTokenType == JsonUnmarshallerContext.TokenType.Null)
                        {
                            unmarshalledObject.Attributes =  null;
                            continue;
                        }
                        unmarshalledObject.Attributes = new Dictionary<string, string>();
                        var unmarshaller = new KeyValueUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.GetInstance(), StringUnmarshaller.GetInstance());
                        while (context.Read())
                        {
                          if (((context.IsStartArray || context.IsStartElement || context.IsLeafValue) && (context.CurrentDepth == targetDepth)) ||
                              ((context.IsKey) && (context.CurrentDepth == targetDepth+1)))
                          {
                            var kvp = unmarshaller.Unmarshall(context);
                            unmarshalledObject.Attributes.Add(kvp.Key, kvp.Value);
                          }
                          else if (context.IsEndElement)
                          {
                            break;
                          }
                        }
                        continue;
                    }
                    if (context.TestExpression("AutoAssignElasticIps", targetDepth))
                    {
                        unmarshalledObject.AutoAssignElasticIps = BoolUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("AutoAssignPublicIps", targetDepth))
                    {
                        unmarshalledObject.AutoAssignPublicIps = BoolUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("CreatedAt", targetDepth))
                    {
                        unmarshalledObject.CreatedAt = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("CustomInstanceProfileArn", targetDepth))
                    {
                        unmarshalledObject.CustomInstanceProfileArn = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("CustomRecipes", targetDepth))
                    {
                        unmarshalledObject.CustomRecipes = RecipesUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("CustomSecurityGroupIds", targetDepth))
                    {
                        if (context.CurrentTokenType == JsonUnmarshallerContext.TokenType.Null)
                        {
                            unmarshalledObject.CustomSecurityGroupIds =  null;
                            continue;
                        }
                        unmarshalledObject.CustomSecurityGroupIds = new List<string>();
                        var unmarshaller = StringUnmarshaller.GetInstance();
                        while (context.Read())
                        {
                          if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                          {
                             unmarshalledObject.CustomSecurityGroupIds.Add(unmarshaller.Unmarshall(context));
                          }
                          else if (context.IsEndArray)
                          {
                            break;
                          }
                        }
                        continue;
                    }
                    if (context.TestExpression("DefaultRecipes", targetDepth))
                    {
                        unmarshalledObject.DefaultRecipes = RecipesUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DefaultSecurityGroupNames", targetDepth))
                    {
                        if (context.CurrentTokenType == JsonUnmarshallerContext.TokenType.Null)
                        {
                            unmarshalledObject.DefaultSecurityGroupNames =  null;
                            continue;
                        }
                        unmarshalledObject.DefaultSecurityGroupNames = new List<string>();
                        var unmarshaller = StringUnmarshaller.GetInstance();
                        while (context.Read())
                        {
                          if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                          {
                             unmarshalledObject.DefaultSecurityGroupNames.Add(unmarshaller.Unmarshall(context));
                          }
                          else if (context.IsEndArray)
                          {
                            break;
                          }
                        }
                        continue;
                    }
                    if (context.TestExpression("EnableAutoHealing", targetDepth))
                    {
                        unmarshalledObject.EnableAutoHealing = BoolUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("InstallUpdatesOnBoot", targetDepth))
                    {
                        unmarshalledObject.InstallUpdatesOnBoot = BoolUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("LayerId", targetDepth))
                    {
                        unmarshalledObject.LayerId = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Name", targetDepth))
                    {
                        unmarshalledObject.Name = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Packages", targetDepth))
                    {
                        if (context.CurrentTokenType == JsonUnmarshallerContext.TokenType.Null)
                        {
                            unmarshalledObject.Packages =  null;
                            continue;
                        }
                        unmarshalledObject.Packages = new List<string>();
                        var unmarshaller = StringUnmarshaller.GetInstance();
                        while (context.Read())
                        {
                          if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                          {
                             unmarshalledObject.Packages.Add(unmarshaller.Unmarshall(context));
                          }
                          else if (context.IsEndArray)
                          {
                            break;
                          }
                        }
                        continue;
                    }
                    if (context.TestExpression("Shortname", targetDepth))
                    {
                        unmarshalledObject.Shortname = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("StackId", targetDepth))
                    {
                        unmarshalledObject.StackId = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Type", targetDepth))
                    {
                        unmarshalledObject.Type = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("UseEbsOptimizedInstances", targetDepth))
                    {
                        unmarshalledObject.UseEbsOptimizedInstances = BoolUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("VolumeConfigurations", targetDepth))
                    {
                        if (context.CurrentTokenType == JsonUnmarshallerContext.TokenType.Null)
                        {
                            unmarshalledObject.VolumeConfigurations =  null;
                            continue;
                        }
                        unmarshalledObject.VolumeConfigurations = new List<VolumeConfiguration>();
                        var unmarshaller = VolumeConfigurationUnmarshaller.GetInstance();
                        while (context.Read())
                        {
                          if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                          {
                             unmarshalledObject.VolumeConfigurations.Add(unmarshaller.Unmarshall(context));
                          }
                          else if (context.IsEndArray)
                          {
                            break;
                          }
                        }
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth)
                {
                    return unmarshalledObject;
                }
            }          
            return unmarshalledObject;
        }


        private static LayerUnmarshaller instance;
        public static LayerUnmarshaller GetInstance()
        {
            if (instance == null)
            {
                instance = new LayerUnmarshaller();
            }
            return instance;
        }

    }
}