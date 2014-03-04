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
     ///   DescribeCacheEngineVersionsResult Unmarshaller
     /// </summary>
    internal class DescribeCacheEngineVersionsResultUnmarshaller : IUnmarshaller<DescribeCacheEngineVersionsResult, XmlUnmarshallerContext>, IUnmarshaller<DescribeCacheEngineVersionsResult, JsonUnmarshallerContext> 
    {
        public DescribeCacheEngineVersionsResult Unmarshall(XmlUnmarshallerContext context) 
        {
            DescribeCacheEngineVersionsResult describeCacheEngineVersionsResult = new DescribeCacheEngineVersionsResult();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("Marker", targetDepth))
                    {
                        describeCacheEngineVersionsResult.Marker = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("CacheEngineVersions/CacheEngineVersion", targetDepth))
                    {
                        describeCacheEngineVersionsResult.CacheEngineVersions.Add(CacheEngineVersionUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return describeCacheEngineVersionsResult;
                }
            }
                        


            return describeCacheEngineVersionsResult;
        }

        public DescribeCacheEngineVersionsResult Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static DescribeCacheEngineVersionsResultUnmarshaller instance;

        public static DescribeCacheEngineVersionsResultUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new DescribeCacheEngineVersionsResultUnmarshaller();

            return instance;
        }
    }
}
    
