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
     ///   IntArrayOptions Unmarshaller
     /// </summary>
    internal class IntArrayOptionsUnmarshaller : IUnmarshaller<IntArrayOptions, XmlUnmarshallerContext>, IUnmarshaller<IntArrayOptions, JsonUnmarshallerContext> 
    {
        public IntArrayOptions Unmarshall(XmlUnmarshallerContext context) 
        {
            IntArrayOptions intArrayOptions = new IntArrayOptions();
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
                        intArrayOptions.DefaultValue = LongUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("SourceFields", targetDepth))
                    {
                        intArrayOptions.SourceFields = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("FacetEnabled", targetDepth))
                    {
                        intArrayOptions.FacetEnabled = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("SearchEnabled", targetDepth))
                    {
                        intArrayOptions.SearchEnabled = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("ReturnEnabled", targetDepth))
                    {
                        intArrayOptions.ReturnEnabled = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return intArrayOptions;
                }
            }
                        


            return intArrayOptions;
        }

        public IntArrayOptions Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static IntArrayOptionsUnmarshaller instance;

        public static IntArrayOptionsUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new IntArrayOptionsUnmarshaller();

            return instance;
        }
    }
}
    
