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
     ///   IndexField Unmarshaller
     /// </summary>
    internal class IndexFieldUnmarshaller : IUnmarshaller<IndexField, XmlUnmarshallerContext>, IUnmarshaller<IndexField, JsonUnmarshallerContext> 
    {
        public IndexField Unmarshall(XmlUnmarshallerContext context) 
        {
            IndexField indexField = new IndexField();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("IndexFieldName", targetDepth))
                    {
                        indexField.IndexFieldName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("IndexFieldType", targetDepth))
                    {
                        indexField.IndexFieldType = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("UIntOptions", targetDepth))
                    {
                        indexField.UIntOptions = UIntOptionsUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("LiteralOptions", targetDepth))
                    {
                        indexField.LiteralOptions = LiteralOptionsUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("TextOptions", targetDepth))
                    {
                        indexField.TextOptions = TextOptionsUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("SourceAttributes/member", targetDepth))
                    {
                        indexField.SourceAttributes.Add(SourceAttributeUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return indexField;
                }
            }
                        


            return indexField;
        }

        public IndexField Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static IndexFieldUnmarshaller instance;

        public static IndexFieldUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new IndexFieldUnmarshaller();

            return instance;
        }
    }
}
    
