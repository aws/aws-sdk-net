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

using Amazon.Redshift.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Redshift.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   EnableLoggingResult Unmarshaller
     /// </summary>
    internal class EnableLoggingResultUnmarshaller : IUnmarshaller<EnableLoggingResult, XmlUnmarshallerContext>, IUnmarshaller<EnableLoggingResult, JsonUnmarshallerContext> 
    {
        public EnableLoggingResult Unmarshall(XmlUnmarshallerContext context) 
        {
            EnableLoggingResult enableLoggingResult = new EnableLoggingResult();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("LoggingEnabled", targetDepth))
                    {
                        enableLoggingResult.LoggingEnabled = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("BucketName", targetDepth))
                    {
                        enableLoggingResult.BucketName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("S3KeyPrefix", targetDepth))
                    {
                        enableLoggingResult.S3KeyPrefix = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("LastSuccessfulDeliveryTime", targetDepth))
                    {
                        enableLoggingResult.LastSuccessfulDeliveryTime = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("LastFailureTime", targetDepth))
                    {
                        enableLoggingResult.LastFailureTime = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("LastFailureMessage", targetDepth))
                    {
                        enableLoggingResult.LastFailureMessage = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return enableLoggingResult;
                }
            }
                        


            return enableLoggingResult;
        }

        public EnableLoggingResult Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static EnableLoggingResultUnmarshaller instance;

        public static EnableLoggingResultUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new EnableLoggingResultUnmarshaller();

            return instance;
        }
    }
}
    
