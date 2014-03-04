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

using Amazon.Redshift.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Redshift.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   ClusterSecurityGroup Unmarshaller
     /// </summary>
    internal class ClusterSecurityGroupUnmarshaller : IUnmarshaller<ClusterSecurityGroup, XmlUnmarshallerContext>, IUnmarshaller<ClusterSecurityGroup, JsonUnmarshallerContext> 
    {
        public ClusterSecurityGroup Unmarshall(XmlUnmarshallerContext context) 
        {
            ClusterSecurityGroup clusterSecurityGroup = new ClusterSecurityGroup();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            if (context.IsStartOfDocument) 
               targetDepth++;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("ClusterSecurityGroupName", targetDepth))
                    {
                        clusterSecurityGroup.ClusterSecurityGroupName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Description", targetDepth))
                    {
                        clusterSecurityGroup.Description = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("EC2SecurityGroups/EC2SecurityGroup", targetDepth))
                    {
                        clusterSecurityGroup.EC2SecurityGroups.Add(EC2SecurityGroupUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    } 
                    if (context.TestExpression("IPRanges/IPRange", targetDepth))
                    {
                        clusterSecurityGroup.IPRanges.Add(IPRangeUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return clusterSecurityGroup;
                }
            }
                        


            return clusterSecurityGroup;
        }

        public ClusterSecurityGroup Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static ClusterSecurityGroupUnmarshaller instance;

        public static ClusterSecurityGroupUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new ClusterSecurityGroupUnmarshaller();

            return instance;
        }
    }
}
    
