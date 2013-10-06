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
     ///   UpdateEnvironmentResult Unmarshaller
     /// </summary>
    internal class UpdateEnvironmentResultUnmarshaller : IUnmarshaller<UpdateEnvironmentResult, XmlUnmarshallerContext> 
    {
        public UpdateEnvironmentResult Unmarshall(XmlUnmarshallerContext context) 
        {
            UpdateEnvironmentResult updateEnvironmentResult = new UpdateEnvironmentResult();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("EnvironmentName", targetDepth))
                    {
                        updateEnvironmentResult.EnvironmentName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("EnvironmentId", targetDepth))
                    {
                        updateEnvironmentResult.EnvironmentId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("ApplicationName", targetDepth))
                    {
                        updateEnvironmentResult.ApplicationName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("VersionLabel", targetDepth))
                    {
                        updateEnvironmentResult.VersionLabel = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("SolutionStackName", targetDepth))
                    {
                        updateEnvironmentResult.SolutionStackName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("TemplateName", targetDepth))
                    {
                        updateEnvironmentResult.TemplateName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Description", targetDepth))
                    {
                        updateEnvironmentResult.Description = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("EndpointURL", targetDepth))
                    {
                        updateEnvironmentResult.EndpointURL = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("CNAME", targetDepth))
                    {
                        updateEnvironmentResult.CNAME = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("DateCreated", targetDepth))
                    {
                        updateEnvironmentResult.DateCreated = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("DateUpdated", targetDepth))
                    {
                        updateEnvironmentResult.DateUpdated = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Status", targetDepth))
                    {
                        updateEnvironmentResult.Status = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Health", targetDepth))
                    {
                        updateEnvironmentResult.Health = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Resources", targetDepth))
                    {
                        updateEnvironmentResult.Resources = EnvironmentResourcesDescriptionUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return updateEnvironmentResult;
                }
            }
                        


            return updateEnvironmentResult;
        }

        private static UpdateEnvironmentResultUnmarshaller instance;

        public static UpdateEnvironmentResultUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new UpdateEnvironmentResultUnmarshaller();

            return instance;
        }
    }
}
    
