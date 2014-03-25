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
     ///   DateArrayOptions Unmarshaller
     /// </summary>
    internal class DateArrayOptionsUnmarshaller : IUnmarshaller<DateArrayOptions, XmlUnmarshallerContext>, IUnmarshaller<DateArrayOptions, JsonUnmarshallerContext> 
    {
        public DateArrayOptions Unmarshall(XmlUnmarshallerContext context) 
        {
            DateArrayOptions dateArrayOptions = new DateArrayOptions();
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
                        dateArrayOptions.DefaultValue = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("SourceFields", targetDepth))
                    {
                        dateArrayOptions.SourceFields = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("FacetEnabled", targetDepth))
                    {
                        dateArrayOptions.FacetEnabled = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("SearchEnabled", targetDepth))
                    {
                        dateArrayOptions.SearchEnabled = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("ReturnEnabled", targetDepth))
                    {
                        dateArrayOptions.ReturnEnabled = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return dateArrayOptions;
                }
            }
                        


            return dateArrayOptions;
        }

        public DateArrayOptions Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static DateArrayOptionsUnmarshaller instance;

        public static DateArrayOptionsUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new DateArrayOptionsUnmarshaller();

            return instance;
        }
    }
}
    
