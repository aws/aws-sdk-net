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

using Amazon.ElastiCache.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ElastiCache.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   CacheParameterGroup Unmarshaller
     /// </summary>
    internal class CacheParameterGroupUnmarshaller : IUnmarshaller<CacheParameterGroup, XmlUnmarshallerContext>, IUnmarshaller<CacheParameterGroup, JsonUnmarshallerContext> 
    {
        public CacheParameterGroup Unmarshall(XmlUnmarshallerContext context) 
        {
            CacheParameterGroup cacheParameterGroup = new CacheParameterGroup();
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
                    if (context.TestExpression("CacheParameterGroupName", targetDepth))
                    {
                        cacheParameterGroup.CacheParameterGroupName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("CacheParameterGroupFamily", targetDepth))
                    {
                        cacheParameterGroup.CacheParameterGroupFamily = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Description", targetDepth))
                    {
                        cacheParameterGroup.Description = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return cacheParameterGroup;
                }
            }
                        


            return cacheParameterGroup;
        }

        public CacheParameterGroup Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static CacheParameterGroupUnmarshaller instance;

        public static CacheParameterGroupUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new CacheParameterGroupUnmarshaller();

            return instance;
        }
    }
}
    
