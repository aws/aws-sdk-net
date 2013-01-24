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
     ///   TerminateEnvironmentResult Unmarshaller
     /// </summary>
    internal class TerminateEnvironmentResultUnmarshaller : IUnmarshaller<TerminateEnvironmentResult, XmlUnmarshallerContext> 
    {
        public TerminateEnvironmentResult Unmarshall(XmlUnmarshallerContext context) 
        {
            TerminateEnvironmentResult terminateEnvironmentResult = new TerminateEnvironmentResult();
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
                        terminateEnvironmentResult.EnvironmentName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("EnvironmentId", targetDepth))
                    {
                        terminateEnvironmentResult.EnvironmentId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("ApplicationName", targetDepth))
                    {
                        terminateEnvironmentResult.ApplicationName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("VersionLabel", targetDepth))
                    {
                        terminateEnvironmentResult.VersionLabel = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("SolutionStackName", targetDepth))
                    {
                        terminateEnvironmentResult.SolutionStackName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("TemplateName", targetDepth))
                    {
                        terminateEnvironmentResult.TemplateName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Description", targetDepth))
                    {
                        terminateEnvironmentResult.Description = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("EndpointURL", targetDepth))
                    {
                        terminateEnvironmentResult.EndpointURL = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("CNAME", targetDepth))
                    {
                        terminateEnvironmentResult.CNAME = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("DateCreated", targetDepth))
                    {
                        terminateEnvironmentResult.DateCreated = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("DateUpdated", targetDepth))
                    {
                        terminateEnvironmentResult.DateUpdated = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Status", targetDepth))
                    {
                        terminateEnvironmentResult.Status = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Health", targetDepth))
                    {
                        terminateEnvironmentResult.Health = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Resources", targetDepth))
                    {
                        terminateEnvironmentResult.Resources = EnvironmentResourcesDescriptionUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return terminateEnvironmentResult;
                }
            }
                        


            return terminateEnvironmentResult;
        }

        private static TerminateEnvironmentResultUnmarshaller instance;

        public static TerminateEnvironmentResultUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new TerminateEnvironmentResultUnmarshaller();

            return instance;
        }
    }
}
    
