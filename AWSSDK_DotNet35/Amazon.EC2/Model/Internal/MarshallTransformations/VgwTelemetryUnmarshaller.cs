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
     ///   VgwTelemetry Unmarshaller
     /// </summary>
    internal class VgwTelemetryUnmarshaller : IUnmarshaller<VgwTelemetry, XmlUnmarshallerContext>, IUnmarshaller<VgwTelemetry, JsonUnmarshallerContext> 
    {
        public VgwTelemetry Unmarshall(XmlUnmarshallerContext context) 
        {
            VgwTelemetry vgwTelemetry = new VgwTelemetry();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 1;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("outsideIpAddress", targetDepth))
                    {
                        vgwTelemetry.OutsideIpAddress = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("status", targetDepth))
                    {
                        vgwTelemetry.Status = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("lastStatusChange", targetDepth))
                    {
                        vgwTelemetry.LastStatusChange = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("statusMessage", targetDepth))
                    {
                        vgwTelemetry.StatusMessage = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("acceptedRouteCount", targetDepth))
                    {
                        vgwTelemetry.AcceptedRouteCount = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return vgwTelemetry;
                }
            }
                        


            return vgwTelemetry;
        }

        public VgwTelemetry Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static VgwTelemetryUnmarshaller instance;

        public static VgwTelemetryUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new VgwTelemetryUnmarshaller();

            return instance;
        }
    }
}
    
