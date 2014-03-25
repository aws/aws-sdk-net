/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.CloudSearch.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CloudSearch.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   IntOptions Unmarshaller
     /// </summary>
    internal class IntOptionsUnmarshaller : IUnmarshaller<IntOptions, XmlUnmarshallerContext>, IUnmarshaller<IntOptions, JsonUnmarshallerContext> 
    {
        public IntOptions Unmarshall(XmlUnmarshallerContext context) 
        {
            IntOptions intOptions = new IntOptions();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("DefaultValue", targetDepth))
                    {
                        intOptions.DefaultValue = LongUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("SourceField", targetDepth))
                    {
                        intOptions.SourceField = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("FacetEnabled", targetDepth))
                    {
                        intOptions.FacetEnabled = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("SearchEnabled", targetDepth))
                    {
                        intOptions.SearchEnabled = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("ReturnEnabled", targetDepth))
                    {
                        intOptions.ReturnEnabled = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("SortEnabled", targetDepth))
                    {
                        intOptions.SortEnabled = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return intOptions;
                }
            }
                        


            return intOptions;
        }

        public IntOptions Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static IntOptionsUnmarshaller instance;

        public static IntOptionsUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new IntOptionsUnmarshaller();

            return instance;
        }
    }
}
    
