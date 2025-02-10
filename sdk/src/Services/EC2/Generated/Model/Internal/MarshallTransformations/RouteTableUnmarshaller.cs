/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.EC2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for RouteTable Object
    /// </summary>  
    public class RouteTableUnmarshaller : IXmlUnmarshaller<RouteTable, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public RouteTable Unmarshall(XmlUnmarshallerContext context)
        {
            RouteTable unmarshalledObject = new RouteTable();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("associationSet/item", targetDepth))
                    {
                        var unmarshaller = RouteTableAssociationUnmarshaller.Instance;
                        if (unmarshalledObject.Associations == null)
                        {
                            unmarshalledObject.Associations = new List<RouteTableAssociation>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Associations.Add(item);
                        continue;
                    }
                    if (context.TestExpression("ownerId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.OwnerId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("propagatingVgwSet/item", targetDepth))
                    {
                        var unmarshaller = PropagatingVgwUnmarshaller.Instance;
                        if (unmarshalledObject.PropagatingVgws == null)
                        {
                            unmarshalledObject.PropagatingVgws = new List<PropagatingVgw>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.PropagatingVgws.Add(item);
                        continue;
                    }
                    if (context.TestExpression("routeSet/item", targetDepth))
                    {
                        var unmarshaller = RouteUnmarshaller.Instance;
                        if (unmarshalledObject.Routes == null)
                        {
                            unmarshalledObject.Routes = new List<Route>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Routes.Add(item);
                        continue;
                    }
                    if (context.TestExpression("routeTableId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.RouteTableId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("tagSet/item", targetDepth))
                    {
                        var unmarshaller = TagUnmarshaller.Instance;
                        if (unmarshalledObject.Tags == null)
                        {
                            unmarshalledObject.Tags = new List<Tag>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Tags.Add(item);
                        continue;
                    }
                    if (context.TestExpression("vpcId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.VpcId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return unmarshalledObject;
                }
            }

            return unmarshalledObject;
        }

        private static RouteTableUnmarshaller _instance = new RouteTableUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RouteTableUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}