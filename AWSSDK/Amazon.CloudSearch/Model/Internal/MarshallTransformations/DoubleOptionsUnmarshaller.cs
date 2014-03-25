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
     ///   DoubleOptions Unmarshaller
     /// </summary>
    internal class DoubleOptionsUnmarshaller : IUnmarshaller<DoubleOptions, XmlUnmarshallerContext>, IUnmarshaller<DoubleOptions, JsonUnmarshallerContext> 
    {
        public DoubleOptions Unmarshall(XmlUnmarshallerContext context) 
        {
            DoubleOptions doubleOptions = new DoubleOptions();
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
                        doubleOptions.DefaultValue = DoubleUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("SourceField", targetDepth))
                    {
                        doubleOptions.SourceField = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("FacetEnabled", targetDepth))
                    {
                        doubleOptions.FacetEnabled = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("SearchEnabled", targetDepth))
                    {
                        doubleOptions.SearchEnabled = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("ReturnEnabled", targetDepth))
                    {
                        doubleOptions.ReturnEnabled = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("SortEnabled", targetDepth))
                    {
                        doubleOptions.SortEnabled = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return doubleOptions;
                }
            }
                        


            return doubleOptions;
        }

        public DoubleOptions Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static DoubleOptionsUnmarshaller instance;

        public static DoubleOptionsUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new DoubleOptionsUnmarshaller();

            return instance;
        }
    }
}
    
