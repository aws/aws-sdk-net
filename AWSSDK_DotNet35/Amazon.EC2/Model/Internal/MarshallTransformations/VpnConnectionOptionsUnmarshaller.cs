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
     ///   VpnConnectionOptions Unmarshaller
     /// </summary>
    internal class VpnConnectionOptionsUnmarshaller : IUnmarshaller<VpnConnectionOptions, XmlUnmarshallerContext>, IUnmarshaller<VpnConnectionOptions, JsonUnmarshallerContext> 
    {
        public VpnConnectionOptions Unmarshall(XmlUnmarshallerContext context) 
        {
            VpnConnectionOptions vpnConnectionOptions = new VpnConnectionOptions();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 1;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("staticRoutesOnly", targetDepth))
                    {
                        vpnConnectionOptions.StaticRoutesOnly = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return vpnConnectionOptions;
                }
            }
                        


            return vpnConnectionOptions;
        }

        public VpnConnectionOptions Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static VpnConnectionOptionsUnmarshaller instance;

        public static VpnConnectionOptionsUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new VpnConnectionOptionsUnmarshaller();

            return instance;
        }
    }
}
    
