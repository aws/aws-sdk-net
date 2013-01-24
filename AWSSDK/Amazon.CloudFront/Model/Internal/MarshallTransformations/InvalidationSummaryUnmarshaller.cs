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

using Amazon.CloudFront.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CloudFront.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   InvalidationSummary Unmarshaller
     /// </summary>
    internal class InvalidationSummaryUnmarshaller : IUnmarshaller<InvalidationSummary, XmlUnmarshallerContext>, IUnmarshaller<InvalidationSummary, JsonUnmarshallerContext> 
    {
        public InvalidationSummary Unmarshall(XmlUnmarshallerContext context) 
        {
            InvalidationSummary invalidationSummary = new InvalidationSummary();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("Id", targetDepth))
                    {
                        invalidationSummary.Id = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("CreateTime", targetDepth))
                    {
                        invalidationSummary.CreateTime = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Status", targetDepth))
                    {
                        invalidationSummary.Status = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return invalidationSummary;
                }
            }
                        


            return invalidationSummary;
        }

        public InvalidationSummary Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static InvalidationSummaryUnmarshaller instance;

        public static InvalidationSummaryUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new InvalidationSummaryUnmarshaller();

            return instance;
        }
    }
}
    
