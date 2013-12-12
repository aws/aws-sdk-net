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

using Amazon.RDS.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.RDS.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   DBSnapshot Unmarshaller
     /// </summary>
    internal class DBSnapshotUnmarshaller : IUnmarshaller<DBSnapshot, XmlUnmarshallerContext>, IUnmarshaller<DBSnapshot, JsonUnmarshallerContext> 
    {
        public DBSnapshot Unmarshall(XmlUnmarshallerContext context) 
        {
            DBSnapshot dBSnapshot = new DBSnapshot();
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
                    if (context.TestExpression("DBSnapshotIdentifier", targetDepth))
                    {
                        dBSnapshot.DBSnapshotIdentifier = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("DBInstanceIdentifier", targetDepth))
                    {
                        dBSnapshot.DBInstanceIdentifier = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("SnapshotCreateTime", targetDepth))
                    {
                        dBSnapshot.SnapshotCreateTime = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Engine", targetDepth))
                    {
                        dBSnapshot.Engine = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("AllocatedStorage", targetDepth))
                    {
                        dBSnapshot.AllocatedStorage = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Status", targetDepth))
                    {
                        dBSnapshot.Status = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Port", targetDepth))
                    {
                        dBSnapshot.Port = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("AvailabilityZone", targetDepth))
                    {
                        dBSnapshot.AvailabilityZone = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("VpcId", targetDepth))
                    {
                        dBSnapshot.VpcId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("InstanceCreateTime", targetDepth))
                    {
                        dBSnapshot.InstanceCreateTime = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("MasterUsername", targetDepth))
                    {
                        dBSnapshot.MasterUsername = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("EngineVersion", targetDepth))
                    {
                        dBSnapshot.EngineVersion = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("LicenseModel", targetDepth))
                    {
                        dBSnapshot.LicenseModel = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("SnapshotType", targetDepth))
                    {
                        dBSnapshot.SnapshotType = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Iops", targetDepth))
                    {
                        dBSnapshot.Iops = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("OptionGroupName", targetDepth))
                    {
                        dBSnapshot.OptionGroupName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("PercentProgress", targetDepth))
                    {
                        dBSnapshot.PercentProgress = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("SourceRegion", targetDepth))
                    {
                        dBSnapshot.SourceRegion = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return dBSnapshot;
                }
            }
                        


            return dBSnapshot;
        }

        public DBSnapshot Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static DBSnapshotUnmarshaller instance;

        public static DBSnapshotUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new DBSnapshotUnmarshaller();

            return instance;
        }
    }
}
    
