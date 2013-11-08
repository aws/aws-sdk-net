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
     ///   Origin Unmarshaller
     /// </summary>
    internal class OriginUnmarshaller : IUnmarshaller<Origin, XmlUnmarshallerContext>, IUnmarshaller<Origin, JsonUnmarshallerContext> 
    {
        public Origin Unmarshall(XmlUnmarshallerContext context) 
        {
            Origin origin = new Origin();
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
                        origin.Id = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("DomainName", targetDepth))
                    {
                        origin.DomainName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("S3OriginConfig", targetDepth))
                    {
                        origin.S3OriginConfig = S3OriginConfigUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("CustomOriginConfig", targetDepth))
                    {
                        origin.CustomOriginConfig = CustomOriginConfigUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return origin;
                }
            }
                        


            return origin;
        }

        public Origin Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static OriginUnmarshaller instance;

        public static OriginUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new OriginUnmarshaller();

            return instance;
        }
    }
}
    
