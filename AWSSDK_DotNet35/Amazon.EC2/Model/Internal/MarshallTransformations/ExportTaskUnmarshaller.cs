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
     ///   ExportTask Unmarshaller
     /// </summary>
    internal class ExportTaskUnmarshaller : IUnmarshaller<ExportTask, XmlUnmarshallerContext>, IUnmarshaller<ExportTask, JsonUnmarshallerContext> 
    {
        public ExportTask Unmarshall(XmlUnmarshallerContext context) 
        {
            ExportTask exportTask = new ExportTask();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 1;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("exportTaskId", targetDepth))
                    {
                        exportTask.ExportTaskId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("description", targetDepth))
                    {
                        exportTask.Description = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("state", targetDepth))
                    {
                        exportTask.State = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("statusMessage", targetDepth))
                    {
                        exportTask.StatusMessage = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("instanceExport", targetDepth))
                    {
                        exportTask.InstanceExportDetails = InstanceExportDetailsUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("exportToS3", targetDepth))
                    {
                        exportTask.ExportToS3Task = ExportToS3TaskUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return exportTask;
                }
            }
                        


            return exportTask;
        }

        public ExportTask Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static ExportTaskUnmarshaller instance;

        public static ExportTaskUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new ExportTaskUnmarshaller();

            return instance;
        }
    }
}
    
