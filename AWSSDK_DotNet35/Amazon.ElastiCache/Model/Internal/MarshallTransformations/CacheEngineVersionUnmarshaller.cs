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
     ///   CacheEngineVersion Unmarshaller
     /// </summary>
    internal class CacheEngineVersionUnmarshaller : IUnmarshaller<CacheEngineVersion, XmlUnmarshallerContext>, IUnmarshaller<CacheEngineVersion, JsonUnmarshallerContext> 
    {
        public CacheEngineVersion Unmarshall(XmlUnmarshallerContext context) 
        {
            CacheEngineVersion cacheEngineVersion = new CacheEngineVersion();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("Engine", targetDepth))
                    {
                        cacheEngineVersion.Engine = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("EngineVersion", targetDepth))
                    {
                        cacheEngineVersion.EngineVersion = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("CacheParameterGroupFamily", targetDepth))
                    {
                        cacheEngineVersion.CacheParameterGroupFamily = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("CacheEngineDescription", targetDepth))
                    {
                        cacheEngineVersion.CacheEngineDescription = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("CacheEngineVersionDescription", targetDepth))
                    {
                        cacheEngineVersion.CacheEngineVersionDescription = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return cacheEngineVersion;
                }
            }
                        


            return cacheEngineVersion;
        }

        public CacheEngineVersion Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static CacheEngineVersionUnmarshaller instance;

        public static CacheEngineVersionUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new CacheEngineVersionUnmarshaller();

            return instance;
        }
    }
}
    
