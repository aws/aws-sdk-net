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
     ///   UpdateConfigurationTemplateResult Unmarshaller
     /// </summary>
    internal class UpdateConfigurationTemplateResultUnmarshaller : IUnmarshaller<UpdateConfigurationTemplateResult, XmlUnmarshallerContext> 
    {
        public UpdateConfigurationTemplateResult Unmarshall(XmlUnmarshallerContext context) 
        {
            UpdateConfigurationTemplateResult updateConfigurationTemplateResult = new UpdateConfigurationTemplateResult();
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
                        updateConfigurationTemplateResult.SolutionStackName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("ApplicationName", targetDepth))
                    {
                        updateConfigurationTemplateResult.ApplicationName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("TemplateName", targetDepth))
                    {
                        updateConfigurationTemplateResult.TemplateName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Description", targetDepth))
                    {
                        updateConfigurationTemplateResult.Description = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("EnvironmentName", targetDepth))
                    {
                        updateConfigurationTemplateResult.EnvironmentName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("DeploymentStatus", targetDepth))
                    {
                        updateConfigurationTemplateResult.DeploymentStatus = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("DateCreated", targetDepth))
                    {
                        updateConfigurationTemplateResult.DateCreated = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("DateUpdated", targetDepth))
                    {
                        updateConfigurationTemplateResult.DateUpdated = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("OptionSettings/member", targetDepth))
                    {
                        updateConfigurationTemplateResult.OptionSettings.Add(ConfigurationOptionSettingUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return updateConfigurationTemplateResult;
                }
            }
                        


            return updateConfigurationTemplateResult;
        }

        private static UpdateConfigurationTemplateResultUnmarshaller instance;

        public static UpdateConfigurationTemplateResultUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new UpdateConfigurationTemplateResultUnmarshaller();

            return instance;
        }
    }
}
    
