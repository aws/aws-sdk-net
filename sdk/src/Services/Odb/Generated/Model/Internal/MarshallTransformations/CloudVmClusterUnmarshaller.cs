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
 * Do not modify this file. This file is generated from the odb-2024-08-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Odb.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Odb.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CloudVmCluster Object
    /// </summary>  
    public class CloudVmClusterUnmarshaller : IUnmarshaller<CloudVmCluster, XmlUnmarshallerContext>, IUnmarshaller<CloudVmCluster, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        CloudVmCluster IUnmarshaller<CloudVmCluster, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public CloudVmCluster Unmarshall(JsonUnmarshallerContext context)
        {
            CloudVmCluster unmarshalledObject = new CloudVmCluster();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("cloudExadataInfrastructureArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CloudExadataInfrastructureArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("cloudExadataInfrastructureId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CloudExadataInfrastructureId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("cloudVmClusterArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CloudVmClusterArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("cloudVmClusterId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CloudVmClusterId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("clusterName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ClusterName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("computeModel", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ComputeModel = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("cpuCoreCount", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.CpuCoreCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("createdAt", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreatedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dataCollectionOptions", targetDepth))
                {
                    var unmarshaller = DataCollectionOptionsUnmarshaller.Instance;
                    unmarshalledObject.DataCollectionOptions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dataStorageSizeInTBs", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.DataStorageSizeInTBs = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dbNodeStorageSizeInGBs", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.DbNodeStorageSizeInGBs = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dbServers", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.DbServers = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("diskRedundancy", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DiskRedundancy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("displayName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DisplayName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("domain", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Domain = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("giVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.GiVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("hostname", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Hostname = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("iamRoles", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<IamRole, IamRoleUnmarshaller>(IamRoleUnmarshaller.Instance);
                    unmarshalledObject.IamRoles = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("iormConfigCache", targetDepth))
                {
                    var unmarshaller = ExadataIormConfigUnmarshaller.Instance;
                    unmarshalledObject.IormConfigCache = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("isLocalBackupEnabled", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.IsLocalBackupEnabled = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("isSparseDiskgroupEnabled", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.IsSparseDiskgroupEnabled = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lastUpdateHistoryEntryId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LastUpdateHistoryEntryId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("licenseModel", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LicenseModel = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("listenerPort", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.ListenerPort = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("memorySizeInGBs", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MemorySizeInGBs = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("nodeCount", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.NodeCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ocid", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Ocid = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ociResourceAnchorName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OciResourceAnchorName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ociUrl", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OciUrl = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("odbNetworkArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OdbNetworkArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("odbNetworkId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OdbNetworkId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("percentProgress", targetDepth))
                {
                    var unmarshaller = FloatUnmarshaller.Instance;
                    unmarshalledObject.PercentProgress = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("scanDnsName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ScanDnsName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("scanDnsRecordId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ScanDnsRecordId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("scanIpIds", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.ScanIpIds = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("shape", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Shape = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sshPublicKeys", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.SshPublicKeys = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("statusReason", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StatusReason = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("storageSizeInGBs", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.StorageSizeInGBs = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("systemVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SystemVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("timeZone", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TimeZone = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("vipIds", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.VipIds = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static CloudVmClusterUnmarshaller _instance = new CloudVmClusterUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CloudVmClusterUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}