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
     ///   NetworkAcl Unmarshaller
     /// </summary>
    internal class NetworkAclUnmarshaller : IUnmarshaller<NetworkAcl, XmlUnmarshallerContext>, IUnmarshaller<NetworkAcl, JsonUnmarshallerContext> 
    {
        public NetworkAcl Unmarshall(XmlUnmarshallerContext context) 
        {
            NetworkAcl networkAcl = new NetworkAcl();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 1;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("networkAclId", targetDepth))
                    {
                        networkAcl.NetworkAclId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("vpcId", targetDepth))
                    {
                        networkAcl.VpcId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("default", targetDepth))
                    {
                        networkAcl.IsDefault = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("entrySet/item", targetDepth))
                    {
                        networkAcl.Entries.Add(NetworkAclEntryUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                    if (context.TestExpression("associationSet/item", targetDepth))
                    {
                        networkAcl.Associations.Add(NetworkAclAssociationUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                    if (context.TestExpression("tagSet/item", targetDepth))
                    {
                        networkAcl.Tags.Add(TagUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return networkAcl;
                }
            }
                        


            return networkAcl;
        }

        public NetworkAcl Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static NetworkAclUnmarshaller instance;

        public static NetworkAclUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new NetworkAclUnmarshaller();

            return instance;
        }
    }
}
    
