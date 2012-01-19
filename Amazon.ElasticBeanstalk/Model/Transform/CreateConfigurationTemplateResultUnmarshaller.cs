/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.ElasticBeanstalk.Model.Transform
{
     /// <summary>
     ///   CreateConfigurationTemplateResult Unmarshaller
     /// </summary>
    internal class CreateConfigurationTemplateResultUnmarshaller : IUnmarshaller<CreateConfigurationTemplateResult, UnmarshallerContext> 
    {
        public CreateConfigurationTemplateResult Unmarshall(UnmarshallerContext context) 
        {
            CreateConfigurationTemplateResult createConfigurationTemplateResult = new CreateConfigurationTemplateResult();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("SolutionStackName", targetDepth))
                    {
                        createConfigurationTemplateResult.SolutionStackName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("ApplicationName", targetDepth))
                    {
                        createConfigurationTemplateResult.ApplicationName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("TemplateName", targetDepth))
                    {
                        createConfigurationTemplateResult.TemplateName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Description", targetDepth))
                    {
                        createConfigurationTemplateResult.Description = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("EnvironmentName", targetDepth))
                    {
                        createConfigurationTemplateResult.EnvironmentName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("DeploymentStatus", targetDepth))
                    {
                        createConfigurationTemplateResult.DeploymentStatus = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("DateCreated", targetDepth))
                    {
                        createConfigurationTemplateResult.DateCreated = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("DateUpdated", targetDepth))
                    {
                        createConfigurationTemplateResult.DateUpdated = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("OptionSettings/member", targetDepth))
                    {
                        createConfigurationTemplateResult.OptionSettings.Add(ConfigurationOptionSettingUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return createConfigurationTemplateResult;
                }
            }

            return createConfigurationTemplateResult;
        }

        private static CreateConfigurationTemplateResultUnmarshaller instance;

        public static CreateConfigurationTemplateResultUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new CreateConfigurationTemplateResultUnmarshaller();

            return instance;
        }
    }
}
    
