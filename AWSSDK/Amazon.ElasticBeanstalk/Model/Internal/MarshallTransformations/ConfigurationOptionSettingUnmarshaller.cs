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
using System.Collections.Generic;

using Amazon.ElasticBeanstalk.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ElasticBeanstalk.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   ConfigurationOptionSetting Unmarshaller
     /// </summary>
    internal class ConfigurationOptionSettingUnmarshaller : IUnmarshaller<ConfigurationOptionSetting, XmlUnmarshallerContext> 
    {
        public ConfigurationOptionSetting Unmarshall(XmlUnmarshallerContext context) 
        {
            ConfigurationOptionSetting configurationOptionSetting = new ConfigurationOptionSetting();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("Namespace", targetDepth))
                    {
                        configurationOptionSetting.Namespace = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("OptionName", targetDepth))
                    {
                        configurationOptionSetting.OptionName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Value", targetDepth))
                    {
                        configurationOptionSetting.Value = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return configurationOptionSetting;
                }
            }
                        


            return configurationOptionSetting;
        }

        private static ConfigurationOptionSettingUnmarshaller instance;

        public static ConfigurationOptionSettingUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new ConfigurationOptionSettingUnmarshaller();

            return instance;
        }
    }
}
    
