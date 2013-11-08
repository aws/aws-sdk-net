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
     ///   RouteTableAssociation Unmarshaller
     /// </summary>
    internal class RouteTableAssociationUnmarshaller : IUnmarshaller<RouteTableAssociation, XmlUnmarshallerContext>, IUnmarshaller<RouteTableAssociation, JsonUnmarshallerContext> 
    {
        public RouteTableAssociation Unmarshall(XmlUnmarshallerContext context) 
        {
            RouteTableAssociation routeTableAssociation = new RouteTableAssociation();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 1;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("routeTableAssociationId", targetDepth))
                    {
                        routeTableAssociation.RouteTableAssociationId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("routeTableId", targetDepth))
                    {
                        routeTableAssociation.RouteTableId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("subnetId", targetDepth))
                    {
                        routeTableAssociation.SubnetId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("main", targetDepth))
                    {
                        routeTableAssociation.Main = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return routeTableAssociation;
                }
            }
                        


            return routeTableAssociation;
        }

        public RouteTableAssociation Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static RouteTableAssociationUnmarshaller instance;

        public static RouteTableAssociationUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new RouteTableAssociationUnmarshaller();

            return instance;
        }
    }
}
    
