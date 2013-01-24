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
     ///   ApplicationDescription Unmarshaller
     /// </summary>
    internal class ApplicationDescriptionUnmarshaller : IUnmarshaller<ApplicationDescription, XmlUnmarshallerContext> 
    {
        public ApplicationDescription Unmarshall(XmlUnmarshallerContext context) 
        {
            ApplicationDescription applicationDescription = new ApplicationDescription();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("ApplicationName", targetDepth))
                    {
                        applicationDescription.ApplicationName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Description", targetDepth))
                    {
                        applicationDescription.Description = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("DateCreated", targetDepth))
                    {
                        applicationDescription.DateCreated = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("DateUpdated", targetDepth))
                    {
                        applicationDescription.DateUpdated = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Versions/member", targetDepth))
                    {
                        applicationDescription.Versions.Add(StringUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    } 
                    if (context.TestExpression("ConfigurationTemplates/member", targetDepth))
                    {
                        applicationDescription.ConfigurationTemplates.Add(StringUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return applicationDescription;
                }
            }
                        


            return applicationDescription;
        }

        private static ApplicationDescriptionUnmarshaller instance;

        public static ApplicationDescriptionUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new ApplicationDescriptionUnmarshaller();

            return instance;
        }
    }
}
    
