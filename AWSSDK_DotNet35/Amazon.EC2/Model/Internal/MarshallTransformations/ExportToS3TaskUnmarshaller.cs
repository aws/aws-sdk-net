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

using Amazon.EC2.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   ExportToS3Task Unmarshaller
     /// </summary>
    internal class ExportToS3TaskUnmarshaller : IUnmarshaller<ExportToS3Task, XmlUnmarshallerContext>, IUnmarshaller<ExportToS3Task, JsonUnmarshallerContext> 
    {
        public ExportToS3Task Unmarshall(XmlUnmarshallerContext context) 
        {
            ExportToS3Task exportToS3Task = new ExportToS3Task();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 1;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("diskImageFormat", targetDepth))
                    {
                        exportToS3Task.DiskImageFormat = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("containerFormat", targetDepth))
                    {
                        exportToS3Task.ContainerFormat = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("s3Bucket", targetDepth))
                    {
                        exportToS3Task.S3Bucket = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("s3Key", targetDepth))
                    {
                        exportToS3Task.S3Key = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return exportToS3Task;
                }
            }
                        


            return exportToS3Task;
        }

        public ExportToS3Task Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static ExportToS3TaskUnmarshaller instance;

        public static ExportToS3TaskUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new ExportToS3TaskUnmarshaller();

            return instance;
        }
    }
}
    
