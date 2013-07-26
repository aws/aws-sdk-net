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
     ///   ImportInstanceTaskDetails Unmarshaller
     /// </summary>
    internal class ImportInstanceTaskDetailsUnmarshaller : IUnmarshaller<ImportInstanceTaskDetails, XmlUnmarshallerContext>, IUnmarshaller<ImportInstanceTaskDetails, JsonUnmarshallerContext> 
    {
        public ImportInstanceTaskDetails Unmarshall(XmlUnmarshallerContext context) 
        {
            ImportInstanceTaskDetails importInstanceTaskDetails = new ImportInstanceTaskDetails();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 1;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("volumes/item", targetDepth))
                    {
                        importInstanceTaskDetails.Volumes.Add(ImportInstanceVolumeDetailItemUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                    if (context.TestExpression("instanceId", targetDepth))
                    {
                        importInstanceTaskDetails.InstanceId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("platform", targetDepth))
                    {
                        importInstanceTaskDetails.Platform = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("description", targetDepth))
                    {
                        importInstanceTaskDetails.Description = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return importInstanceTaskDetails;
                }
            }
                        


            return importInstanceTaskDetails;
        }

        public ImportInstanceTaskDetails Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static ImportInstanceTaskDetailsUnmarshaller instance;

        public static ImportInstanceTaskDetailsUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new ImportInstanceTaskDetailsUnmarshaller();

            return instance;
        }
    }
}
    
