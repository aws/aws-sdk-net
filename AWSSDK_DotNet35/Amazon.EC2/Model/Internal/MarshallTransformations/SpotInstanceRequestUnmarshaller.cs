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
     ///   SpotInstanceRequest Unmarshaller
     /// </summary>
    internal class SpotInstanceRequestUnmarshaller : IUnmarshaller<SpotInstanceRequest, XmlUnmarshallerContext>, IUnmarshaller<SpotInstanceRequest, JsonUnmarshallerContext> 
    {
        public SpotInstanceRequest Unmarshall(XmlUnmarshallerContext context) 
        {
            SpotInstanceRequest spotInstanceRequest = new SpotInstanceRequest();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 1;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("spotInstanceRequestId", targetDepth))
                    {
                        spotInstanceRequest.SpotInstanceRequestId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("spotPrice", targetDepth))
                    {
                        spotInstanceRequest.SpotPrice = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("type", targetDepth))
                    {
                        spotInstanceRequest.Type = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("state", targetDepth))
                    {
                        spotInstanceRequest.State = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("fault", targetDepth))
                    {
                        spotInstanceRequest.Fault = SpotInstanceStateFaultUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("status", targetDepth))
                    {
                        spotInstanceRequest.Status = SpotInstanceStatusUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("validFrom", targetDepth))
                    {
                        spotInstanceRequest.ValidFrom = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("validUntil", targetDepth))
                    {
                        spotInstanceRequest.ValidUntil = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("launchGroup", targetDepth))
                    {
                        spotInstanceRequest.LaunchGroup = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("availabilityZoneGroup", targetDepth))
                    {
                        spotInstanceRequest.AvailabilityZoneGroup = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("launchSpecification", targetDepth))
                    {
                        spotInstanceRequest.LaunchSpecification = LaunchSpecificationUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("instanceId", targetDepth))
                    {
                        spotInstanceRequest.InstanceId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("createTime", targetDepth))
                    {
                        spotInstanceRequest.CreateTime = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("productDescription", targetDepth))
                    {
                        spotInstanceRequest.ProductDescription = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("tagSet/item", targetDepth))
                    {
                        spotInstanceRequest.Tags.Add(TagUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                    if (context.TestExpression("launchedAvailabilityZone", targetDepth))
                    {
                        spotInstanceRequest.LaunchedAvailabilityZone = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return spotInstanceRequest;
                }
            }
                        


            return spotInstanceRequest;
        }

        public SpotInstanceRequest Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static SpotInstanceRequestUnmarshaller instance;

        public static SpotInstanceRequestUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new SpotInstanceRequestUnmarshaller();

            return instance;
        }
    }
}
    
