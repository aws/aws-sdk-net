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
     ///   TextArrayOptions Unmarshaller
     /// </summary>
    internal class TextArrayOptionsUnmarshaller : IUnmarshaller<TextArrayOptions, XmlUnmarshallerContext>, IUnmarshaller<TextArrayOptions, JsonUnmarshallerContext> 
    {
        public TextArrayOptions Unmarshall(XmlUnmarshallerContext context) 
        {
            TextArrayOptions textArrayOptions = new TextArrayOptions();
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
                        textArrayOptions.DefaultValue = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("SourceFields", targetDepth))
                    {
                        textArrayOptions.SourceFields = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("ReturnEnabled", targetDepth))
                    {
                        textArrayOptions.ReturnEnabled = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("HighlightEnabled", targetDepth))
                    {
                        textArrayOptions.HighlightEnabled = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("AnalysisScheme", targetDepth))
                    {
                        textArrayOptions.AnalysisScheme = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return textArrayOptions;
                }
            }
                        


            return textArrayOptions;
        }

        public TextArrayOptions Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static TextArrayOptionsUnmarshaller instance;

        public static TextArrayOptionsUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new TextArrayOptionsUnmarshaller();

            return instance;
        }
    }
}
    
