/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.ElastiCache.Model.Transform
{
     /// <summary>
     ///   DescribeCacheParametersResult Unmarshaller
     /// </summary>
    internal class DescribeCacheParametersResultUnmarshaller : IUnmarshaller<DescribeCacheParametersResult, UnmarshallerContext> 
    {
        public DescribeCacheParametersResult Unmarshall(UnmarshallerContext context) 
        {
            DescribeCacheParametersResult describeCacheParametersResult = new DescribeCacheParametersResult();
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
                        describeCacheParametersResult.Marker = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Parameters/Parameter", targetDepth))
                    {
                        describeCacheParametersResult.Parameters.Add(ParameterUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                    if (context.TestExpression("CacheNodeTypeSpecificParameters/CacheNodeTypeSpecificParameter", targetDepth))
                    {
                        describeCacheParametersResult.CacheNodeTypeSpecificParameters.Add(CacheNodeTypeSpecificParameterUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return describeCacheParametersResult;
                }
            }

            return describeCacheParametersResult;
        }

        private static DescribeCacheParametersResultUnmarshaller instance;

        public static DescribeCacheParametersResultUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new DescribeCacheParametersResultUnmarshaller();

            return instance;
        }
    }
}
    
