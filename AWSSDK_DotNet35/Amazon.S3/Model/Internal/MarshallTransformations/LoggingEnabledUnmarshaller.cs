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

using Amazon.S3.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   LoggingEnabled Unmarshaller
     /// </summary>
    internal class LoggingEnabledUnmarshaller : IUnmarshaller<S3BucketLoggingConfig, XmlUnmarshallerContext>, IUnmarshaller<S3BucketLoggingConfig, JsonUnmarshallerContext> 
    {
        public S3BucketLoggingConfig Unmarshall(XmlUnmarshallerContext context) 
        {
            S3BucketLoggingConfig loggingEnabled = new S3BucketLoggingConfig();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("TargetBucket", targetDepth))
                    {
                        loggingEnabled.TargetBucketName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Grant", targetDepth + 1))
                    {
                        loggingEnabled.Grants.Add(GrantUnmarshaller.Instance.Unmarshall(context));
                            
                        continue;
                    }
                    if (context.TestExpression("TargetPrefix", targetDepth))
                    {
                        loggingEnabled.TargetPrefix = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return loggingEnabled;
                }
            }
                        


            return loggingEnabled;
        }

        public S3BucketLoggingConfig Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static LoggingEnabledUnmarshaller _instance;

        public static LoggingEnabledUnmarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new LoggingEnabledUnmarshaller();
                }
                return _instance;
            }
        }

    }
}
    
