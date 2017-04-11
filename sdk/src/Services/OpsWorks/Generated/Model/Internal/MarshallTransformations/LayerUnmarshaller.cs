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

/*
 * Do not modify this file. This file is generated from the opsworks-2013-02-18.normal.json service model.
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
using ThirdParty.Json.LitJson;

namespace Amazon.OpsWorks.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Layer Object
    /// </summary>  
    public class LayerUnmarshaller : IUnmarshaller<Layer, XmlUnmarshallerContext>, IUnmarshaller<Layer, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Layer IUnmarshaller<Layer, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public Layer Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            Layer unmarshalledObject = new Layer();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Attributes", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.Attributes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AutoAssignElasticIps", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.AutoAssignElasticIps = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AutoAssignPublicIps", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.AutoAssignPublicIps = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CloudWatchLogsConfiguration", targetDepth))
                {
                    var unmarshaller = CloudWatchLogsConfigurationUnmarshaller.Instance;
                    unmarshalledObject.CloudWatchLogsConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreatedAt", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CreatedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CustomInstanceProfileArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CustomInstanceProfileArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CustomJson", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CustomJson = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CustomRecipes", targetDepth))
                {
                    var unmarshaller = RecipesUnmarshaller.Instance;
                    unmarshalledObject.CustomRecipes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CustomSecurityGroupIds", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.CustomSecurityGroupIds = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DefaultRecipes", targetDepth))
                {
                    var unmarshaller = RecipesUnmarshaller.Instance;
                    unmarshalledObject.DefaultRecipes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DefaultSecurityGroupNames", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.DefaultSecurityGroupNames = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EnableAutoHealing", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.EnableAutoHealing = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InstallUpdatesOnBoot", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.InstallUpdatesOnBoot = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LayerId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LayerId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LifecycleEventConfiguration", targetDepth))
                {
                    var unmarshaller = LifecycleEventConfigurationUnmarshaller.Instance;
                    unmarshalledObject.LifecycleEventConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Packages", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.Packages = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Shortname", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Shortname = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StackId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StackId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Type", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Type = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UseEbsOptimizedInstances", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.UseEbsOptimizedInstances = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VolumeConfigurations", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<VolumeConfiguration, VolumeConfigurationUnmarshaller>(VolumeConfigurationUnmarshaller.Instance);
                    unmarshalledObject.VolumeConfigurations = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static LayerUnmarshaller _instance = new LayerUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static LayerUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}