/*
 * Copyright 2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.RDS.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.RDS.Model.Transform
{
     /// <summary>
     ///   PendingModifiedValues Unmarshaller
     /// </summary>
    internal class PendingModifiedValuesUnmarshaller : IUnmarshaller<PendingModifiedValues, UnmarshallerContext> 
    {
        public PendingModifiedValues Unmarshall(UnmarshallerContext context) 
        {
            PendingModifiedValues pendingModifiedValues = new PendingModifiedValues();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("DBInstanceClass", targetDepth))
                    {
                        pendingModifiedValues.DBInstanceClass = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("AllocatedStorage", targetDepth))
                    {
                        pendingModifiedValues.AllocatedStorage = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("MasterUserPassword", targetDepth))
                    {
                        pendingModifiedValues.MasterUserPassword = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Port", targetDepth))
                    {
                        pendingModifiedValues.Port = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("BackupRetentionPeriod", targetDepth))
                    {
                        pendingModifiedValues.BackupRetentionPeriod = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("MultiAZ", targetDepth))
                    {
                        pendingModifiedValues.MultiAZ = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("EngineVersion", targetDepth))
                    {
                        pendingModifiedValues.EngineVersion = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return pendingModifiedValues;
                }
            }

            return pendingModifiedValues;
        }

        private static PendingModifiedValuesUnmarshaller instance;

        public static PendingModifiedValuesUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new PendingModifiedValuesUnmarshaller();

            return instance;
        }
    }
}
    
