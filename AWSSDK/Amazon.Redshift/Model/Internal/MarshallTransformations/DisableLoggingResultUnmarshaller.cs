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
     ///   DisableLoggingResult Unmarshaller
     /// </summary>
    internal class DisableLoggingResultUnmarshaller : IUnmarshaller<DisableLoggingResult, XmlUnmarshallerContext>, IUnmarshaller<DisableLoggingResult, JsonUnmarshallerContext> 
    {
        public DisableLoggingResult Unmarshall(XmlUnmarshallerContext context) 
        {
            DisableLoggingResult disableLoggingResult = new DisableLoggingResult();
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
                        disableLoggingResult.LoggingEnabled = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("BucketName", targetDepth))
                    {
                        disableLoggingResult.BucketName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("S3KeyPrefix", targetDepth))
                    {
                        disableLoggingResult.S3KeyPrefix = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("LastSuccessfulDeliveryTime", targetDepth))
                    {
                        disableLoggingResult.LastSuccessfulDeliveryTime = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("LastFailureTime", targetDepth))
                    {
                        disableLoggingResult.LastFailureTime = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("LastFailureMessage", targetDepth))
                    {
                        disableLoggingResult.LastFailureMessage = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return disableLoggingResult;
                }
            }
                        


            return disableLoggingResult;
        }

        public DisableLoggingResult Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static DisableLoggingResultUnmarshaller instance;

        public static DisableLoggingResultUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new DisableLoggingResultUnmarshaller();

            return instance;
        }
    }
}
    
