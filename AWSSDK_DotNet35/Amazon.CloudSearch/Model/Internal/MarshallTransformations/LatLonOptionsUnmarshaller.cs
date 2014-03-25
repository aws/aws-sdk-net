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
     ///   LatLonOptions Unmarshaller
     /// </summary>
    internal class LatLonOptionsUnmarshaller : IUnmarshaller<LatLonOptions, XmlUnmarshallerContext>, IUnmarshaller<LatLonOptions, JsonUnmarshallerContext> 
    {
        public LatLonOptions Unmarshall(XmlUnmarshallerContext context) 
        {
            LatLonOptions latLonOptions = new LatLonOptions();
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
                        latLonOptions.DefaultValue = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("SourceField", targetDepth))
                    {
                        latLonOptions.SourceField = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("FacetEnabled", targetDepth))
                    {
                        latLonOptions.FacetEnabled = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("SearchEnabled", targetDepth))
                    {
                        latLonOptions.SearchEnabled = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("ReturnEnabled", targetDepth))
                    {
                        latLonOptions.ReturnEnabled = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("SortEnabled", targetDepth))
                    {
                        latLonOptions.SortEnabled = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return latLonOptions;
                }
            }
                        


            return latLonOptions;
        }

        public LatLonOptions Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static LatLonOptionsUnmarshaller instance;

        public static LatLonOptionsUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new LatLonOptionsUnmarshaller();

            return instance;
        }
    }
}
    
