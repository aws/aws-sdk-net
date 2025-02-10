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
 * Do not modify this file. This file is generated from the docdb-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.DocDB.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.DocDB.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DBInstance Object
    /// </summary>  
    public class DBInstanceUnmarshaller : IXmlUnmarshaller<DBInstance, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public DBInstance Unmarshall(XmlUnmarshallerContext context)
        {
            DBInstance unmarshalledObject = new DBInstance();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("AutoMinorVersionUpgrade", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.AutoMinorVersionUpgrade = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("AvailabilityZone", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.AvailabilityZone = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("BackupRetentionPeriod", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.BackupRetentionPeriod = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("CACertificateIdentifier", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.CACertificateIdentifier = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("CertificateDetails", targetDepth))
                    {
                        var unmarshaller = CertificateDetailsUnmarshaller.Instance;
                        unmarshalledObject.CertificateDetails = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("CopyTagsToSnapshot", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.CopyTagsToSnapshot = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DBClusterIdentifier", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DBClusterIdentifier = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DBInstanceArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DBInstanceArn = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DBInstanceClass", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DBInstanceClass = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DBInstanceIdentifier", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DBInstanceIdentifier = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DBInstanceStatus", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DBInstanceStatus = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DbiResourceId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DbiResourceId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DBSubnetGroup", targetDepth))
                    {
                        var unmarshaller = DBSubnetGroupUnmarshaller.Instance;
                        unmarshalledObject.DBSubnetGroup = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("EnabledCloudwatchLogsExports/member", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (unmarshalledObject.EnabledCloudwatchLogsExports == null)
                        {
                            unmarshalledObject.EnabledCloudwatchLogsExports = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.EnabledCloudwatchLogsExports.Add(item);
                        continue;
                    }
                    if (context.TestExpression("Endpoint", targetDepth))
                    {
                        var unmarshaller = EndpointUnmarshaller.Instance;
                        unmarshalledObject.Endpoint = unmarshaller.Unmarshall(context);
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
                    if (context.TestExpression("InstanceCreateTime", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.InstanceCreateTime = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("KmsKeyId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.KmsKeyId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("LatestRestorableTime", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.LatestRestorableTime = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("PendingModifiedValues", targetDepth))
                    {
                        var unmarshaller = PendingModifiedValuesUnmarshaller.Instance;
                        unmarshalledObject.PendingModifiedValues = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("PerformanceInsightsEnabled", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.PerformanceInsightsEnabled = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("PerformanceInsightsKMSKeyId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.PerformanceInsightsKMSKeyId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("PreferredBackupWindow", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.PreferredBackupWindow = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("PreferredMaintenanceWindow", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.PreferredMaintenanceWindow = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("PromotionTier", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.PromotionTier = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("PubliclyAccessible", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.PubliclyAccessible = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("StatusInfos/DBInstanceStatusInfo", targetDepth))
                    {
                        var unmarshaller = DBInstanceStatusInfoUnmarshaller.Instance;
                        if (unmarshalledObject.StatusInfos == null)
                        {
                            unmarshalledObject.StatusInfos = new List<DBInstanceStatusInfo>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.StatusInfos.Add(item);
                        continue;
                    }
                    if (context.TestExpression("StorageEncrypted", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.StorageEncrypted = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("VpcSecurityGroups/VpcSecurityGroupMembership", targetDepth))
                    {
                        var unmarshaller = VpcSecurityGroupMembershipUnmarshaller.Instance;
                        if (unmarshalledObject.VpcSecurityGroups == null)
                        {
                            unmarshalledObject.VpcSecurityGroups = new List<VpcSecurityGroupMembership>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.VpcSecurityGroups.Add(item);
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

        private static DBInstanceUnmarshaller _instance = new DBInstanceUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DBInstanceUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}