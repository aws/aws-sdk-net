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
     ///   S3OriginConfig Unmarshaller
     /// </summary>
    internal class S3OriginConfigUnmarshaller : IUnmarshaller<S3OriginConfig, XmlUnmarshallerContext>, IUnmarshaller<S3OriginConfig, JsonUnmarshallerContext> 
    {
        public S3OriginConfig Unmarshall(XmlUnmarshallerContext context) 
        {
            S3OriginConfig s3OriginConfig = new S3OriginConfig();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("OriginAccessIdentity", targetDepth))
                    {
                        s3OriginConfig.OriginAccessIdentity = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return s3OriginConfig;
                }
            }
                        


            return s3OriginConfig;
        }

        public S3OriginConfig Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static S3OriginConfigUnmarshaller instance;

        public static S3OriginConfigUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new S3OriginConfigUnmarshaller();

            return instance;
        }
    }
}
    
