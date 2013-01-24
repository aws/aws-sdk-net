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
     ///   ApplicationVersionDescription Unmarshaller
     /// </summary>
    internal class ApplicationVersionDescriptionUnmarshaller : IUnmarshaller<ApplicationVersionDescription, XmlUnmarshallerContext> 
    {
        public ApplicationVersionDescription Unmarshall(XmlUnmarshallerContext context) 
        {
            ApplicationVersionDescription applicationVersionDescription = new ApplicationVersionDescription();
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
                        applicationVersionDescription.ApplicationName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Description", targetDepth))
                    {
                        applicationVersionDescription.Description = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("VersionLabel", targetDepth))
                    {
                        applicationVersionDescription.VersionLabel = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("SourceBundle", targetDepth))
                    {
                        applicationVersionDescription.SourceBundle = S3LocationUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("DateCreated", targetDepth))
                    {
                        applicationVersionDescription.DateCreated = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("DateUpdated", targetDepth))
                    {
                        applicationVersionDescription.DateUpdated = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return applicationVersionDescription;
                }
            }
                        


            return applicationVersionDescription;
        }

        private static ApplicationVersionDescriptionUnmarshaller instance;

        public static ApplicationVersionDescriptionUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new ApplicationVersionDescriptionUnmarshaller();

            return instance;
        }
    }
}
    
