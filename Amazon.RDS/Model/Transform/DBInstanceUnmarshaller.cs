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
     ///   DBInstance Unmarshaller
     /// </summary>
    internal class DBInstanceUnmarshaller : IUnmarshaller<DBInstance, UnmarshallerContext> 
    {
        public DBInstance Unmarshall(UnmarshallerContext context) 
        {
            DBInstance dBInstance = new DBInstance();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            if (context.IsStartOfDocument) 
               targetDepth++;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("DBInstanceIdentifier", targetDepth))
                    {
                        dBInstance.DBInstanceIdentifier = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("DBInstanceClass", targetDepth))
                    {
                        dBInstance.DBInstanceClass = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Engine", targetDepth))
                    {
                        dBInstance.Engine = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("DBInstanceStatus", targetDepth))
                    {
                        dBInstance.DBInstanceStatus = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("MasterUsername", targetDepth))
                    {
                        dBInstance.MasterUsername = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("DBName", targetDepth))
                    {
                        dBInstance.DBName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Endpoint", targetDepth))
                    {
                        dBInstance.Endpoint = EndpointUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("AllocatedStorage", targetDepth))
                    {
                        dBInstance.AllocatedStorage = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("InstanceCreateTime", targetDepth))
                    {
                        dBInstance.InstanceCreateTime = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("PreferredBackupWindow", targetDepth))
                    {
                        dBInstance.PreferredBackupWindow = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("BackupRetentionPeriod", targetDepth))
                    {
                        dBInstance.BackupRetentionPeriod = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("DBSecurityGroups/DBSecurityGroup", targetDepth))
                    {
                        dBInstance.DBSecurityGroups.Add(DBSecurityGroupMembershipUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                    if (context.TestExpression("DBParameterGroups/DBParameterGroup", targetDepth))
                    {
                        dBInstance.DBParameterGroups.Add(DBParameterGroupStatusUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                    if (context.TestExpression("AvailabilityZone", targetDepth))
                    {
                        dBInstance.AvailabilityZone = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("PreferredMaintenanceWindow", targetDepth))
                    {
                        dBInstance.PreferredMaintenanceWindow = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("PendingModifiedValues", targetDepth))
                    {
                        dBInstance.PendingModifiedValues = PendingModifiedValuesUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("LatestRestorableTime", targetDepth))
                    {
                        dBInstance.LatestRestorableTime = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("MultiAZ", targetDepth))
                    {
                        dBInstance.MultiAZ = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("EngineVersion", targetDepth))
                    {
                        dBInstance.EngineVersion = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("AutoMinorVersionUpgrade", targetDepth))
                    {
                        dBInstance.AutoMinorVersionUpgrade = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("ReadReplicaSourceDBInstanceIdentifier", targetDepth))
                    {
                        dBInstance.ReadReplicaSourceDBInstanceIdentifier = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("ReadReplicaDBInstanceIdentifiers/ReadReplicaDBInstanceIdentifier", targetDepth))
                    {
                        dBInstance.ReadReplicaDBInstanceIdentifiers.Add(StringUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return dBInstance;
                }
            }

            return dBInstance;
        }

        private static DBInstanceUnmarshaller instance;

        public static DBInstanceUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new DBInstanceUnmarshaller();

            return instance;
        }
    }
}
    
