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

using Amazon.ElasticLoadBalancing.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ElasticLoadBalancing.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   HealthCheck Unmarshaller
     /// </summary>
    internal class HealthCheckUnmarshaller : IUnmarshaller<HealthCheck, XmlUnmarshallerContext>, IUnmarshaller<HealthCheck, JsonUnmarshallerContext> 
    {
        public HealthCheck Unmarshall(XmlUnmarshallerContext context) 
        {
            HealthCheck healthCheck = new HealthCheck();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("Target", targetDepth))
                    {
                        healthCheck.Target = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Interval", targetDepth))
                    {
                        healthCheck.Interval = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Timeout", targetDepth))
                    {
                        healthCheck.Timeout = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("UnhealthyThreshold", targetDepth))
                    {
                        healthCheck.UnhealthyThreshold = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("HealthyThreshold", targetDepth))
                    {
                        healthCheck.HealthyThreshold = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return healthCheck;
                }
            }
                        


            return healthCheck;
        }

        public HealthCheck Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static HealthCheckUnmarshaller instance;

        public static HealthCheckUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new HealthCheckUnmarshaller();

            return instance;
        }
    }
}
    
