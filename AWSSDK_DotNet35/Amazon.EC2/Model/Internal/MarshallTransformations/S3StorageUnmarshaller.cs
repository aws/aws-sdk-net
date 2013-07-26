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

using Amazon.EC2.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   S3Storage Unmarshaller
     /// </summary>
    internal class S3StorageUnmarshaller : IUnmarshaller<S3Storage, XmlUnmarshallerContext>, IUnmarshaller<S3Storage, JsonUnmarshallerContext> 
    {
        public S3Storage Unmarshall(XmlUnmarshallerContext context) 
        {
            S3Storage s3Storage = new S3Storage();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 1;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("bucket", targetDepth))
                    {
                        s3Storage.Bucket = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("prefix", targetDepth))
                    {
                        s3Storage.Prefix = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("awsAccessKeyId", targetDepth))
                    {
                        s3Storage.AWSAccessKeyId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("uploadPolicy", targetDepth))
                    {
                        s3Storage.UploadPolicy = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("uploadPolicySignature", targetDepth))
                    {
                        s3Storage.UploadPolicySignature = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return s3Storage;
                }
            }
                        


            return s3Storage;
        }

        public S3Storage Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static S3StorageUnmarshaller instance;

        public static S3StorageUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new S3StorageUnmarshaller();

            return instance;
        }
    }
}
    
