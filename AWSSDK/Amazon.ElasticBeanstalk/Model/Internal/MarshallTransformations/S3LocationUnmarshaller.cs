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

using Amazon.ElasticBeanstalk.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ElasticBeanstalk.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   S3Location Unmarshaller
     /// </summary>
    internal class S3LocationUnmarshaller : IUnmarshaller<S3Location, XmlUnmarshallerContext> 
    {
        public S3Location Unmarshall(XmlUnmarshallerContext context) 
        {
            S3Location s3Location = new S3Location();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("S3Bucket", targetDepth))
                    {
                        s3Location.S3Bucket = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("S3Key", targetDepth))
                    {
                        s3Location.S3Key = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return s3Location;
                }
            }
                        


            return s3Location;
        }

        private static S3LocationUnmarshaller instance;

        public static S3LocationUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new S3LocationUnmarshaller();

            return instance;
        }
    }
}
    
