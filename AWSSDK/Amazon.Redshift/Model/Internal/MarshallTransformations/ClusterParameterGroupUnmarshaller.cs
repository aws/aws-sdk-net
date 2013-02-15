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
     ///   ClusterParameterGroup Unmarshaller
     /// </summary>
    internal class ClusterParameterGroupUnmarshaller : IUnmarshaller<ClusterParameterGroup, XmlUnmarshallerContext>, IUnmarshaller<ClusterParameterGroup, JsonUnmarshallerContext> 
    {
        public ClusterParameterGroup Unmarshall(XmlUnmarshallerContext context) 
        {
            ClusterParameterGroup clusterParameterGroup = new ClusterParameterGroup();
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
                    if (context.TestExpression("ParameterGroupName", targetDepth))
                    {
                        clusterParameterGroup.ParameterGroupName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("ParameterGroupFamily", targetDepth))
                    {
                        clusterParameterGroup.ParameterGroupFamily = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Description", targetDepth))
                    {
                        clusterParameterGroup.Description = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return clusterParameterGroup;
                }
            }
                        


            return clusterParameterGroup;
        }

        public ClusterParameterGroup Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static ClusterParameterGroupUnmarshaller instance;

        public static ClusterParameterGroupUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new ClusterParameterGroupUnmarshaller();

            return instance;
        }
    }
}
    
