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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Redshift.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Redshift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Snapshot Object
    /// </summary>  
    public class SnapshotUnmarshaller : IXmlUnmarshaller<Snapshot, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public Snapshot Unmarshall(XmlUnmarshallerContext context)
        {
            Snapshot unmarshalledObject = new Snapshot();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("AccountsWithRestoreAccess/AccountWithRestoreAccess", targetDepth))
                    {
                        var unmarshaller = AccountWithRestoreAccessUnmarshaller.Instance;
                        if (unmarshalledObject.AccountsWithRestoreAccess == null)
                        {
                            unmarshalledObject.AccountsWithRestoreAccess = new List<AccountWithRestoreAccess>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.AccountsWithRestoreAccess.Add(item);
                        continue;
                    }
                    if (context.TestExpression("ActualIncrementalBackupSizeInMegaBytes", targetDepth))
                    {
                        var unmarshaller = NullableDoubleUnmarshaller.Instance;
                        unmarshalledObject.ActualIncrementalBackupSizeInMegaBytes = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("AvailabilityZone", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.AvailabilityZone = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("BackupProgressInMegaBytes", targetDepth))
                    {
                        var unmarshaller = NullableDoubleUnmarshaller.Instance;
                        unmarshalledObject.BackupProgressInMegaBytes = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ClusterCreateTime", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.ClusterCreateTime = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ClusterIdentifier", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ClusterIdentifier = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ClusterVersion", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ClusterVersion = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("CurrentBackupRateInMegaBytesPerSecond", targetDepth))
                    {
                        var unmarshaller = NullableDoubleUnmarshaller.Instance;
                        unmarshalledObject.CurrentBackupRateInMegaBytesPerSecond = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DBName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DBName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ElapsedTimeInSeconds", targetDepth))
                    {
                        var unmarshaller = NullableLongUnmarshaller.Instance;
                        unmarshalledObject.ElapsedTimeInSeconds = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Encrypted", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.Encrypted = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("EncryptedWithHSM", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.EncryptedWithHSM = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("EngineFullVersion", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.EngineFullVersion = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("EnhancedVpcRouting", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.EnhancedVpcRouting = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("EstimatedSecondsToCompletion", targetDepth))
                    {
                        var unmarshaller = NullableLongUnmarshaller.Instance;
                        unmarshalledObject.EstimatedSecondsToCompletion = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("KmsKeyId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.KmsKeyId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("MaintenanceTrackName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.MaintenanceTrackName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ManualSnapshotRemainingDays", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.ManualSnapshotRemainingDays = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ManualSnapshotRetentionPeriod", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.ManualSnapshotRetentionPeriod = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("MasterPasswordSecretArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.MasterPasswordSecretArn = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("MasterPasswordSecretKmsKeyId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.MasterPasswordSecretKmsKeyId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("MasterUsername", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.MasterUsername = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("NodeType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.NodeType = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("NumberOfNodes", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.NumberOfNodes = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("OwnerAccount", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.OwnerAccount = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Port", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.Port = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("RestorableNodeTypes/NodeType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (unmarshalledObject.RestorableNodeTypes == null)
                        {
                            unmarshalledObject.RestorableNodeTypes = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.RestorableNodeTypes.Add(item);
                        continue;
                    }
                    if (context.TestExpression("SnapshotArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.SnapshotArn = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SnapshotCreateTime", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.SnapshotCreateTime = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SnapshotIdentifier", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.SnapshotIdentifier = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SnapshotRetentionStartTime", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.SnapshotRetentionStartTime = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SnapshotType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.SnapshotType = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SourceRegion", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.SourceRegion = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Status", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Tags/Tag", targetDepth))
                    {
                        var unmarshaller = TagUnmarshaller.Instance;
                        if (unmarshalledObject.Tags == null)
                        {
                            unmarshalledObject.Tags = new List<Tag>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Tags.Add(item);
                        continue;
                    }
                    if (context.TestExpression("TotalBackupSizeInMegaBytes", targetDepth))
                    {
                        var unmarshaller = NullableDoubleUnmarshaller.Instance;
                        unmarshalledObject.TotalBackupSizeInMegaBytes = unmarshaller.Unmarshall(context);
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

        private static SnapshotUnmarshaller _instance = new SnapshotUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SnapshotUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}