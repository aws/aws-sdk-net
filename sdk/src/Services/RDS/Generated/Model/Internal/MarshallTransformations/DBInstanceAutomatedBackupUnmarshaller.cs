/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.RDS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.RDS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DBInstanceAutomatedBackup Object
    /// </summary>  
    public class DBInstanceAutomatedBackupUnmarshaller : IXmlUnmarshaller<DBInstanceAutomatedBackup, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public DBInstanceAutomatedBackup Unmarshall(XmlUnmarshallerContext context)
        {
            DBInstanceAutomatedBackup unmarshalledObject = new DBInstanceAutomatedBackup();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("AllocatedStorage", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.AllocatedStorage = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("AvailabilityZone", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.AvailabilityZone = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("AwsBackupRecoveryPointArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.AwsBackupRecoveryPointArn = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("BackupRetentionPeriod", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.BackupRetentionPeriod = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("BackupTarget", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.BackupTarget = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DBInstanceArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DBInstanceArn = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DBInstanceAutomatedBackupsArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DBInstanceAutomatedBackupsArn = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DBInstanceAutomatedBackupsReplications/DBInstanceAutomatedBackupsReplication", targetDepth))
                    {
                        var unmarshaller = DBInstanceAutomatedBackupsReplicationUnmarshaller.Instance;
                        if (unmarshalledObject.DBInstanceAutomatedBackupsReplications == null)
                        {
                            unmarshalledObject.DBInstanceAutomatedBackupsReplications = new List<DBInstanceAutomatedBackupsReplication>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.DBInstanceAutomatedBackupsReplications.Add(item);
                        continue;
                    }
                    if (context.TestExpression("DBInstanceIdentifier", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DBInstanceIdentifier = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DbiResourceId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DbiResourceId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DedicatedLogVolume", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.DedicatedLogVolume = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Encrypted", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.Encrypted = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Engine", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Engine = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("EngineVersion", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.EngineVersion = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("IAMDatabaseAuthenticationEnabled", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.IAMDatabaseAuthenticationEnabled = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("InstanceCreateTime", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.InstanceCreateTime = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Iops", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.Iops = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("KmsKeyId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.KmsKeyId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("LicenseModel", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.LicenseModel = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("MasterUsername", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.MasterUsername = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("MultiTenant", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.MultiTenant = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("OptionGroupName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.OptionGroupName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Port", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.Port = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Region", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Region = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("RestoreWindow", targetDepth))
                    {
                        var unmarshaller = RestoreWindowUnmarshaller.Instance;
                        unmarshalledObject.RestoreWindow = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Status", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("StorageThroughput", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.StorageThroughput = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("StorageType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.StorageType = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("TdeCredentialArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.TdeCredentialArn = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Timezone", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Timezone = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("VpcId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.VpcId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return unmarshalledObject;
                }
            }

            return unmarshalledObject;
        }

        private static DBInstanceAutomatedBackupUnmarshaller _instance = new DBInstanceAutomatedBackupUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DBInstanceAutomatedBackupUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}