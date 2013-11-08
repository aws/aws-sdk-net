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
     ///   NetworkAclAssociation Unmarshaller
     /// </summary>
    internal class NetworkAclAssociationUnmarshaller : IUnmarshaller<NetworkAclAssociation, XmlUnmarshallerContext>, IUnmarshaller<NetworkAclAssociation, JsonUnmarshallerContext> 
    {
        public NetworkAclAssociation Unmarshall(XmlUnmarshallerContext context) 
        {
            NetworkAclAssociation networkAclAssociation = new NetworkAclAssociation();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 1;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("networkAclAssociationId", targetDepth))
                    {
                        networkAclAssociation.NetworkAclAssociationId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("networkAclId", targetDepth))
                    {
                        networkAclAssociation.NetworkAclId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("subnetId", targetDepth))
                    {
                        networkAclAssociation.SubnetId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return networkAclAssociation;
                }
            }
                        


            return networkAclAssociation;
        }

        public NetworkAclAssociation Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static NetworkAclAssociationUnmarshaller instance;

        public static NetworkAclAssociationUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new NetworkAclAssociationUnmarshaller();

            return instance;
        }
    }
}
    
