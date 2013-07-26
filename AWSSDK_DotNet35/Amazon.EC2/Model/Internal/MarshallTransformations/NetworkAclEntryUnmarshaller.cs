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
     ///   NetworkAclEntry Unmarshaller
     /// </summary>
    internal class NetworkAclEntryUnmarshaller : IUnmarshaller<NetworkAclEntry, XmlUnmarshallerContext>, IUnmarshaller<NetworkAclEntry, JsonUnmarshallerContext> 
    {
        public NetworkAclEntry Unmarshall(XmlUnmarshallerContext context) 
        {
            NetworkAclEntry networkAclEntry = new NetworkAclEntry();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 1;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("ruleNumber", targetDepth))
                    {
                        networkAclEntry.RuleNumber = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("protocol", targetDepth))
                    {
                        networkAclEntry.Protocol = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("ruleAction", targetDepth))
                    {
                        networkAclEntry.RuleAction = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("egress", targetDepth))
                    {
                        networkAclEntry.Egress = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("cidrBlock", targetDepth))
                    {
                        networkAclEntry.CidrBlock = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("icmpTypeCode", targetDepth))
                    {
                        networkAclEntry.IcmpTypeCode = IcmpTypeCodeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("portRange", targetDepth))
                    {
                        networkAclEntry.PortRange = PortRangeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return networkAclEntry;
                }
            }
                        


            return networkAclEntry;
        }

        public NetworkAclEntry Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static NetworkAclEntryUnmarshaller instance;

        public static NetworkAclEntryUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new NetworkAclEntryUnmarshaller();

            return instance;
        }
    }
}
    
