/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.CloudFront.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CloudFront.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   Paths Unmarshaller
     /// </summary>
    internal class PathsUnmarshaller : IUnmarshaller<Paths, XmlUnmarshallerContext>, IUnmarshaller<Paths, JsonUnmarshallerContext> 
    {
        public Paths Unmarshall(XmlUnmarshallerContext context) 
        {
            Paths paths = new Paths();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("Quantity", targetDepth))
                    {
                        paths.Quantity = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Items/Path", targetDepth))
                    {
                        paths.Items.Add(StringUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return paths;
                }
            }
                        


            return paths;
        }

        public Paths Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static PathsUnmarshaller instance;

        public static PathsUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new PathsUnmarshaller();

            return instance;
        }
    }
}
    
