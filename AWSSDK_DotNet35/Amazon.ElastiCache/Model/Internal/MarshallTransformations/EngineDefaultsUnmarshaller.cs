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
     ///   EngineDefaults Unmarshaller
     /// </summary>
    internal class EngineDefaultsUnmarshaller : IUnmarshaller<EngineDefaults, XmlUnmarshallerContext>, IUnmarshaller<EngineDefaults, JsonUnmarshallerContext> 
    {
        public EngineDefaults Unmarshall(XmlUnmarshallerContext context) 
        {
            EngineDefaults engineDefaults = new EngineDefaults();
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
                    if (context.TestExpression("CacheParameterGroupFamily", targetDepth))
                    {
                        engineDefaults.CacheParameterGroupFamily = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Marker", targetDepth))
                    {
                        engineDefaults.Marker = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Parameters/Parameter", targetDepth))
                    {
                        engineDefaults.Parameters.Add(ParameterUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                    if (context.TestExpression("CacheNodeTypeSpecificParameters/CacheNodeTypeSpecificParameter", targetDepth))
                    {
                        engineDefaults.CacheNodeTypeSpecificParameters.Add(CacheNodeTypeSpecificParameterUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return engineDefaults;
                }
            }
                        


            return engineDefaults;
        }

        public EngineDefaults Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static EngineDefaultsUnmarshaller instance;

        public static EngineDefaultsUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new EngineDefaultsUnmarshaller();

            return instance;
        }
    }
}
    
