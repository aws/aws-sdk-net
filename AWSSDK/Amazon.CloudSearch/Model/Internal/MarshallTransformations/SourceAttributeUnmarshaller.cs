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
     ///   SourceAttribute Unmarshaller
     /// </summary>
    internal class SourceAttributeUnmarshaller : IUnmarshaller<SourceAttribute, XmlUnmarshallerContext> 
    {
        public SourceAttribute Unmarshall(XmlUnmarshallerContext context) 
        {
            SourceAttribute sourceAttribute = new SourceAttribute();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("SourceDataFunction", targetDepth))
                    {
                        sourceAttribute.SourceDataFunction = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("SourceDataCopy", targetDepth))
                    {
                        sourceAttribute.SourceDataCopy = SourceDataUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("SourceDataTrimTitle", targetDepth))
                    {
                        sourceAttribute.SourceDataTrimTitle = SourceDataTrimTitleUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("SourceDataMap", targetDepth))
                    {
                        sourceAttribute.SourceDataMap = SourceDataMapUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return sourceAttribute;
                }
            }
                        


            return sourceAttribute;
        }

        private static SourceAttributeUnmarshaller instance;

        public static SourceAttributeUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new SourceAttributeUnmarshaller();

            return instance;
        }
    }
}
    
