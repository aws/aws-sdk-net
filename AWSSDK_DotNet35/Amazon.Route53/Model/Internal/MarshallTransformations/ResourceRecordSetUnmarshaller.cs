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

using Amazon.Route53.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Route53.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   ResourceRecordSet Unmarshaller
     /// </summary>
    internal class ResourceRecordSetUnmarshaller : IUnmarshaller<ResourceRecordSet, XmlUnmarshallerContext>, IUnmarshaller<ResourceRecordSet, JsonUnmarshallerContext> 
    {
        public ResourceRecordSet Unmarshall(XmlUnmarshallerContext context) 
        {
            ResourceRecordSet resourceRecordSet = new ResourceRecordSet();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("Name", targetDepth))
                    {
                        resourceRecordSet.Name = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Type", targetDepth))
                    {
                        resourceRecordSet.Type = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("SetIdentifier", targetDepth))
                    {
                        resourceRecordSet.SetIdentifier = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Weight", targetDepth))
                    {
                        resourceRecordSet.Weight = LongUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Region", targetDepth))
                    {
                        resourceRecordSet.Region = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Failover", targetDepth))
                    {
                        resourceRecordSet.Failover = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("TTL", targetDepth))
                    {
                        resourceRecordSet.TTL = LongUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("ResourceRecords/ResourceRecord", targetDepth))
                    {
                        resourceRecordSet.ResourceRecords.Add(ResourceRecordUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                    if (context.TestExpression("AliasTarget", targetDepth))
                    {
                        resourceRecordSet.AliasTarget = AliasTargetUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("HealthCheckId", targetDepth))
                    {
                        resourceRecordSet.HealthCheckId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return resourceRecordSet;
                }
            }
                        


            return resourceRecordSet;
        }

        public ResourceRecordSet Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static ResourceRecordSetUnmarshaller instance;

        public static ResourceRecordSetUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new ResourceRecordSetUnmarshaller();

            return instance;
        }
    }
}
    
