/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.ElasticLoadBalancing.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ElasticLoadBalancing.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   AccessLog Unmarshaller
     /// </summary>
    internal class AccessLogUnmarshaller : IUnmarshaller<AccessLog, XmlUnmarshallerContext>, IUnmarshaller<AccessLog, JsonUnmarshallerContext> 
    {
        public AccessLog Unmarshall(XmlUnmarshallerContext context) 
        {
            AccessLog accessLog = new AccessLog();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("Enabled", targetDepth))
                    {
                        accessLog.Enabled = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("S3BucketName", targetDepth))
                    {
                        accessLog.S3BucketName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("EmitInterval", targetDepth))
                    {
                        accessLog.EmitInterval = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("S3BucketPrefix", targetDepth))
                    {
                        accessLog.S3BucketPrefix = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return accessLog;
                }
            }
                        


            return accessLog;
        }

        public AccessLog Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static AccessLogUnmarshaller instance;

        public static AccessLogUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new AccessLogUnmarshaller();

            return instance;
        }
    }
}
    
