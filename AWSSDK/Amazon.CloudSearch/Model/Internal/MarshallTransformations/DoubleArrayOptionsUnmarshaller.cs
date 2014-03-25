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
     ///   DoubleArrayOptions Unmarshaller
     /// </summary>
    internal class DoubleArrayOptionsUnmarshaller : IUnmarshaller<DoubleArrayOptions, XmlUnmarshallerContext>, IUnmarshaller<DoubleArrayOptions, JsonUnmarshallerContext> 
    {
        public DoubleArrayOptions Unmarshall(XmlUnmarshallerContext context) 
        {
            DoubleArrayOptions doubleArrayOptions = new DoubleArrayOptions();
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
                        doubleArrayOptions.DefaultValue = DoubleUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("SourceFields", targetDepth))
                    {
                        doubleArrayOptions.SourceFields = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("FacetEnabled", targetDepth))
                    {
                        doubleArrayOptions.FacetEnabled = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("SearchEnabled", targetDepth))
                    {
                        doubleArrayOptions.SearchEnabled = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("ReturnEnabled", targetDepth))
                    {
                        doubleArrayOptions.ReturnEnabled = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return doubleArrayOptions;
                }
            }
                        


            return doubleArrayOptions;
        }

        public DoubleArrayOptions Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static DoubleArrayOptionsUnmarshaller instance;

        public static DoubleArrayOptionsUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new DoubleArrayOptionsUnmarshaller();

            return instance;
        }
    }
}
    
