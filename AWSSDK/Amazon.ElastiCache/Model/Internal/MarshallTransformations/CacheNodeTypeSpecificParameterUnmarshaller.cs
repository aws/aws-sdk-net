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
     ///   CacheNodeTypeSpecificParameter Unmarshaller
     /// </summary>
    internal class CacheNodeTypeSpecificParameterUnmarshaller : IUnmarshaller<CacheNodeTypeSpecificParameter, XmlUnmarshallerContext>, IUnmarshaller<CacheNodeTypeSpecificParameter, JsonUnmarshallerContext> 
    {
        public CacheNodeTypeSpecificParameter Unmarshall(XmlUnmarshallerContext context) 
        {
            CacheNodeTypeSpecificParameter cacheNodeTypeSpecificParameter = new CacheNodeTypeSpecificParameter();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("ParameterName", targetDepth))
                    {
                        cacheNodeTypeSpecificParameter.ParameterName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Description", targetDepth))
                    {
                        cacheNodeTypeSpecificParameter.Description = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Source", targetDepth))
                    {
                        cacheNodeTypeSpecificParameter.Source = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("DataType", targetDepth))
                    {
                        cacheNodeTypeSpecificParameter.DataType = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("AllowedValues", targetDepth))
                    {
                        cacheNodeTypeSpecificParameter.AllowedValues = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("IsModifiable", targetDepth))
                    {
                        cacheNodeTypeSpecificParameter.IsModifiable = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("MinimumEngineVersion", targetDepth))
                    {
                        cacheNodeTypeSpecificParameter.MinimumEngineVersion = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("CacheNodeTypeSpecificValues/CacheNodeTypeSpecificValue", targetDepth))
                    {
                        cacheNodeTypeSpecificParameter.CacheNodeTypeSpecificValues.Add(CacheNodeTypeSpecificValueUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return cacheNodeTypeSpecificParameter;
                }
            }
                        


            return cacheNodeTypeSpecificParameter;
        }

        public CacheNodeTypeSpecificParameter Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static CacheNodeTypeSpecificParameterUnmarshaller instance;

        public static CacheNodeTypeSpecificParameterUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new CacheNodeTypeSpecificParameterUnmarshaller();

            return instance;
        }
    }
}
    
