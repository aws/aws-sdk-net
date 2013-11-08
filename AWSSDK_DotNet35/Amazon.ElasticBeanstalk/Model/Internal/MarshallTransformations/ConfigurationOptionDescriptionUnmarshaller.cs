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
     ///   ConfigurationOptionDescription Unmarshaller
     /// </summary>
    internal class ConfigurationOptionDescriptionUnmarshaller : IUnmarshaller<ConfigurationOptionDescription, XmlUnmarshallerContext>, IUnmarshaller<ConfigurationOptionDescription, JsonUnmarshallerContext> 
    {
        public ConfigurationOptionDescription Unmarshall(XmlUnmarshallerContext context) 
        {
            ConfigurationOptionDescription configurationOptionDescription = new ConfigurationOptionDescription();
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
                        configurationOptionDescription.Namespace = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Name", targetDepth))
                    {
                        configurationOptionDescription.Name = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("DefaultValue", targetDepth))
                    {
                        configurationOptionDescription.DefaultValue = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("ChangeSeverity", targetDepth))
                    {
                        configurationOptionDescription.ChangeSeverity = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("UserDefined", targetDepth))
                    {
                        configurationOptionDescription.UserDefined = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("ValueType", targetDepth))
                    {
                        configurationOptionDescription.ValueType = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("ValueOptions/member", targetDepth))
                    {
                        configurationOptionDescription.ValueOptions.Add(StringUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                    if (context.TestExpression("MinValue", targetDepth))
                    {
                        configurationOptionDescription.MinValue = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("MaxValue", targetDepth))
                    {
                        configurationOptionDescription.MaxValue = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("MaxLength", targetDepth))
                    {
                        configurationOptionDescription.MaxLength = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Regex", targetDepth))
                    {
                        configurationOptionDescription.Regex = OptionRestrictionRegexUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return configurationOptionDescription;
                }
            }
                        


            return configurationOptionDescription;
        }

        public ConfigurationOptionDescription Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static ConfigurationOptionDescriptionUnmarshaller instance;

        public static ConfigurationOptionDescriptionUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new ConfigurationOptionDescriptionUnmarshaller();

            return instance;
        }
    }
}
    
