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
     ///   EnvironmentDescription Unmarshaller
     /// </summary>
    internal class EnvironmentDescriptionUnmarshaller : IUnmarshaller<EnvironmentDescription, XmlUnmarshallerContext> 
    {
        public EnvironmentDescription Unmarshall(XmlUnmarshallerContext context) 
        {
            EnvironmentDescription environmentDescription = new EnvironmentDescription();
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
                        environmentDescription.EnvironmentName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("EnvironmentId", targetDepth))
                    {
                        environmentDescription.EnvironmentId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("ApplicationName", targetDepth))
                    {
                        environmentDescription.ApplicationName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("VersionLabel", targetDepth))
                    {
                        environmentDescription.VersionLabel = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("SolutionStackName", targetDepth))
                    {
                        environmentDescription.SolutionStackName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("TemplateName", targetDepth))
                    {
                        environmentDescription.TemplateName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Description", targetDepth))
                    {
                        environmentDescription.Description = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("EndpointURL", targetDepth))
                    {
                        environmentDescription.EndpointURL = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("CNAME", targetDepth))
                    {
                        environmentDescription.CNAME = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("DateCreated", targetDepth))
                    {
                        environmentDescription.DateCreated = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("DateUpdated", targetDepth))
                    {
                        environmentDescription.DateUpdated = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Status", targetDepth))
                    {
                        environmentDescription.Status = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Health", targetDepth))
                    {
                        environmentDescription.Health = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Resources", targetDepth))
                    {
                        environmentDescription.Resources = EnvironmentResourcesDescriptionUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return environmentDescription;
                }
            }
                        


            return environmentDescription;
        }

        private static EnvironmentDescriptionUnmarshaller instance;

        public static EnvironmentDescriptionUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new EnvironmentDescriptionUnmarshaller();

            return instance;
        }
    }
}
    
