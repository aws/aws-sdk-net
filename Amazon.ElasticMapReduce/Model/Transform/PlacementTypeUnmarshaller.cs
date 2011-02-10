/*
 * Copyright 2010-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.ElasticMapReduce.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ElasticMapReduce.Model.Transform
{
     /// <summary>
     ///   PlacementType Unmarshaller
     /// </summary>
    internal class PlacementTypeUnmarshaller : IUnmarshaller<PlacementType, UnmarshallerContext> 
    {
        public PlacementType Unmarshall(UnmarshallerContext context) 
        {
            PlacementType placementType = new PlacementType();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("AvailabilityZone", targetDepth))
                    {
                        placementType.AvailabilityZone = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return placementType;
                }
            }

            return placementType;
        }

        private static PlacementTypeUnmarshaller instance;

        public static PlacementTypeUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new PlacementTypeUnmarshaller();

            return instance;
        }
    }
}
    
