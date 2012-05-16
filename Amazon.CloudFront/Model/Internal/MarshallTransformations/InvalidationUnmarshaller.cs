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
     ///   Invalidation Unmarshaller
     /// </summary>
    internal class InvalidationUnmarshaller : IUnmarshaller<Invalidation, XmlUnmarshallerContext>, IUnmarshaller<Invalidation, JsonUnmarshallerContext> 
    {
        public Invalidation Unmarshall(XmlUnmarshallerContext context) 
        {
            Invalidation invalidation = new Invalidation();
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
                        invalidation.Id = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Status", targetDepth))
                    {
                        invalidation.Status = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("CreateTime", targetDepth))
                    {
                        invalidation.CreateTime = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("InvalidationBatch", targetDepth))
                    {
                        invalidation.InvalidationBatch = InvalidationBatchUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return invalidation;
                }
            }
                        


            return invalidation;
        }

        public Invalidation Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static InvalidationUnmarshaller instance;

        public static InvalidationUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new InvalidationUnmarshaller();

            return instance;
        }
    }
}
    
