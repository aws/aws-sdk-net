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
     ///   ConversionTask Unmarshaller
     /// </summary>
    internal class ConversionTaskUnmarshaller : IUnmarshaller<ConversionTask, XmlUnmarshallerContext>, IUnmarshaller<ConversionTask, JsonUnmarshallerContext> 
    {
        public ConversionTask Unmarshall(XmlUnmarshallerContext context) 
        {
            ConversionTask conversionTask = new ConversionTask();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 1;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("conversionTaskId", targetDepth))
                    {
                        conversionTask.ConversionTaskId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("expirationTime", targetDepth))
                    {
                        conversionTask.ExpirationTime = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("importInstance", targetDepth))
                    {
                        conversionTask.ImportInstance = ImportInstanceTaskDetailsUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("importVolume", targetDepth))
                    {
                        conversionTask.ImportVolume = ImportVolumeTaskDetailsUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("state", targetDepth))
                    {
                        conversionTask.State = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("statusMessage", targetDepth))
                    {
                        conversionTask.StatusMessage = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("tagSet/item", targetDepth))
                    {
                        conversionTask.Tags.Add(TagUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return conversionTask;
                }
            }
                        


            return conversionTask;
        }

        public ConversionTask Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static ConversionTaskUnmarshaller instance;

        public static ConversionTaskUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new ConversionTaskUnmarshaller();

            return instance;
        }
    }
}
    
