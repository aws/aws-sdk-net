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
     ///   HealthCheckConfig Unmarshaller
     /// </summary>
    internal class HealthCheckConfigUnmarshaller : IUnmarshaller<HealthCheckConfig, XmlUnmarshallerContext>, IUnmarshaller<HealthCheckConfig, JsonUnmarshallerContext> 
    {
        public HealthCheckConfig Unmarshall(XmlUnmarshallerContext context) 
        {
            HealthCheckConfig healthCheckConfig = new HealthCheckConfig();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("IPAddress", targetDepth))
                    {
                        healthCheckConfig.IPAddress = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Port", targetDepth))
                    {
                        healthCheckConfig.Port = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Type", targetDepth))
                    {
                        healthCheckConfig.Type = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("ResourcePath", targetDepth))
                    {
                        healthCheckConfig.ResourcePath = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("FullyQualifiedDomainName", targetDepth))
                    {
                        healthCheckConfig.FullyQualifiedDomainName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return healthCheckConfig;
                }
            }
                        


            return healthCheckConfig;
        }

        public HealthCheckConfig Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static HealthCheckConfigUnmarshaller instance;

        public static HealthCheckConfigUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new HealthCheckConfigUnmarshaller();

            return instance;
        }
    }
}
    
