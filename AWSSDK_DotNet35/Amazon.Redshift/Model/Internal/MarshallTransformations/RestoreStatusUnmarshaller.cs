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
     ///   RestoreStatus Unmarshaller
     /// </summary>
    internal class RestoreStatusUnmarshaller : IUnmarshaller<RestoreStatus, XmlUnmarshallerContext>, IUnmarshaller<RestoreStatus, JsonUnmarshallerContext> 
    {
        public RestoreStatus Unmarshall(XmlUnmarshallerContext context) 
        {
            RestoreStatus restoreStatus = new RestoreStatus();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("Status", targetDepth))
                    {
                        restoreStatus.Status = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("CurrentRestoreRateInMegaBytesPerSecond", targetDepth))
                    {
                        restoreStatus.CurrentRestoreRateInMegaBytesPerSecond = DoubleUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("SnapshotSizeInMegaBytes", targetDepth))
                    {
                        restoreStatus.SnapshotSizeInMegaBytes = LongUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("ProgressInMegaBytes", targetDepth))
                    {
                        restoreStatus.ProgressInMegaBytes = LongUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("ElapsedTimeInSeconds", targetDepth))
                    {
                        restoreStatus.ElapsedTimeInSeconds = LongUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("EstimatedTimeToCompletionInSeconds", targetDepth))
                    {
                        restoreStatus.EstimatedTimeToCompletionInSeconds = LongUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return restoreStatus;
                }
            }
                        


            return restoreStatus;
        }

        public RestoreStatus Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static RestoreStatusUnmarshaller instance;

        public static RestoreStatusUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new RestoreStatusUnmarshaller();

            return instance;
        }
    }
}
    
