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

using Amazon.CloudSearch.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CloudSearch.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   LiteralOptions Unmarshaller
     /// </summary>
    internal class LiteralOptionsUnmarshaller : IUnmarshaller<LiteralOptions, XmlUnmarshallerContext> 
    {
        public LiteralOptions Unmarshall(XmlUnmarshallerContext context) 
        {
            LiteralOptions literalOptions = new LiteralOptions();
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
                        literalOptions.DefaultValue = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("SearchEnabled", targetDepth))
                    {
                        literalOptions.SearchEnabled = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("FacetEnabled", targetDepth))
                    {
                        literalOptions.FacetEnabled = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("ResultEnabled", targetDepth))
                    {
                        literalOptions.ResultEnabled = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return literalOptions;
                }
            }
                        


            return literalOptions;
        }

        private static LiteralOptionsUnmarshaller instance;

        public static LiteralOptionsUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new LiteralOptionsUnmarshaller();

            return instance;
        }
    }
}
    
