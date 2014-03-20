/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
     ///   ConnectionDraining Unmarshaller
     /// </summary>
    internal class ConnectionDrainingUnmarshaller : IUnmarshaller<ConnectionDraining, XmlUnmarshallerContext>, IUnmarshaller<ConnectionDraining, JsonUnmarshallerContext> 
    {
        public ConnectionDraining Unmarshall(XmlUnmarshallerContext context) 
        {
            ConnectionDraining connectionDraining = new ConnectionDraining();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("Enabled", targetDepth))
                    {
                        connectionDraining.Enabled = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Timeout", targetDepth))
                    {
                        connectionDraining.Timeout = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return connectionDraining;
                }
            }
                        


            return connectionDraining;
        }

        public ConnectionDraining Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static ConnectionDrainingUnmarshaller instance;

        public static ConnectionDrainingUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new ConnectionDrainingUnmarshaller();

            return instance;
        }
    }
}
    
