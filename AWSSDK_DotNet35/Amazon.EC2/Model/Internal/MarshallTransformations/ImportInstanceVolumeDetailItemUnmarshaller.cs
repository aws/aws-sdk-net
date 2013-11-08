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
     ///   ImportInstanceVolumeDetailItem Unmarshaller
     /// </summary>
    internal class ImportInstanceVolumeDetailItemUnmarshaller : IUnmarshaller<ImportInstanceVolumeDetailItem, XmlUnmarshallerContext>, IUnmarshaller<ImportInstanceVolumeDetailItem, JsonUnmarshallerContext> 
    {
        public ImportInstanceVolumeDetailItem Unmarshall(XmlUnmarshallerContext context) 
        {
            ImportInstanceVolumeDetailItem importInstanceVolumeDetailItem = new ImportInstanceVolumeDetailItem();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 1;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("bytesConverted", targetDepth))
                    {
                        importInstanceVolumeDetailItem.BytesConverted = LongUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("availabilityZone", targetDepth))
                    {
                        importInstanceVolumeDetailItem.AvailabilityZone = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("image", targetDepth))
                    {
                        importInstanceVolumeDetailItem.Image = DiskImageDescriptionUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("volume", targetDepth))
                    {
                        importInstanceVolumeDetailItem.Volume = DiskImageVolumeDescriptionUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("status", targetDepth))
                    {
                        importInstanceVolumeDetailItem.Status = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("statusMessage", targetDepth))
                    {
                        importInstanceVolumeDetailItem.StatusMessage = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("description", targetDepth))
                    {
                        importInstanceVolumeDetailItem.Description = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return importInstanceVolumeDetailItem;
                }
            }
                        


            return importInstanceVolumeDetailItem;
        }

        public ImportInstanceVolumeDetailItem Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static ImportInstanceVolumeDetailItemUnmarshaller instance;

        public static ImportInstanceVolumeDetailItemUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new ImportInstanceVolumeDetailItemUnmarshaller();

            return instance;
        }
    }
}
    
