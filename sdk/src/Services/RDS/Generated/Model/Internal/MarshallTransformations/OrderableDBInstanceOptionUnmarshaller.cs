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
    /// Response Unmarshaller for OrderableDBInstanceOption Object
    /// </summary>  
    public class OrderableDBInstanceOptionUnmarshaller : IXmlUnmarshaller<OrderableDBInstanceOption, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public OrderableDBInstanceOption Unmarshall(XmlUnmarshallerContext context)
        {
            OrderableDBInstanceOption unmarshalledObject = new OrderableDBInstanceOption();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("AvailabilityZoneGroup", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.AvailabilityZoneGroup = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("AvailabilityZones/AvailabilityZone", targetDepth))
                    {
                        var unmarshaller = AvailabilityZoneUnmarshaller.Instance;
                        if (unmarshalledObject.AvailabilityZones == null)
                        {
                            unmarshalledObject.AvailabilityZones = new List<AvailabilityZone>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.AvailabilityZones.Add(item);
                        continue;
                    }
                    if (context.TestExpression("AvailableProcessorFeatures/AvailableProcessorFeature", targetDepth))
                    {
                        var unmarshaller = AvailableProcessorFeatureUnmarshaller.Instance;
                        if (unmarshalledObject.AvailableProcessorFeatures == null)
                        {
                            unmarshalledObject.AvailableProcessorFeatures = new List<AvailableProcessorFeature>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.AvailableProcessorFeatures.Add(item);
                        continue;
                    }
                    if (context.TestExpression("DBInstanceClass", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DBInstanceClass = unmarshaller.Unmarshall(context);
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
                    if (context.TestExpression("LicenseModel", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.LicenseModel = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("MaxIopsPerDbInstance", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.MaxIopsPerDbInstance = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("MaxIopsPerGib", targetDepth))
                    {
                        var unmarshaller = NullableDoubleUnmarshaller.Instance;
                        unmarshalledObject.MaxIopsPerGib = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("MaxStorageSize", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.MaxStorageSize = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("MaxStorageThroughputPerDbInstance", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.MaxStorageThroughputPerDbInstance = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("MaxStorageThroughputPerIops", targetDepth))
                    {
                        var unmarshaller = NullableDoubleUnmarshaller.Instance;
                        unmarshalledObject.MaxStorageThroughputPerIops = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("MinIopsPerDbInstance", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.MinIopsPerDbInstance = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("MinIopsPerGib", targetDepth))
                    {
                        var unmarshaller = NullableDoubleUnmarshaller.Instance;
                        unmarshalledObject.MinIopsPerGib = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("MinStorageSize", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.MinStorageSize = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("MinStorageThroughputPerDbInstance", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.MinStorageThroughputPerDbInstance = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("MinStorageThroughputPerIops", targetDepth))
                    {
                        var unmarshaller = NullableDoubleUnmarshaller.Instance;
                        unmarshalledObject.MinStorageThroughputPerIops = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("MultiAZCapable", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.MultiAZCapable = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("OutpostCapable", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.OutpostCapable = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ReadReplicaCapable", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.ReadReplicaCapable = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("StorageType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.StorageType = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SupportedActivityStreamModes/member", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (unmarshalledObject.SupportedActivityStreamModes == null)
                        {
                            unmarshalledObject.SupportedActivityStreamModes = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.SupportedActivityStreamModes.Add(item);
                        continue;
                    }
                    if (context.TestExpression("SupportedEngineModes/member", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (unmarshalledObject.SupportedEngineModes == null)
                        {
                            unmarshalledObject.SupportedEngineModes = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.SupportedEngineModes.Add(item);
                        continue;
                    }
                    if (context.TestExpression("SupportedNetworkTypes/member", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (unmarshalledObject.SupportedNetworkTypes == null)
                        {
                            unmarshalledObject.SupportedNetworkTypes = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.SupportedNetworkTypes.Add(item);
                        continue;
                    }
                    if (context.TestExpression("SupportsClusters", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.SupportsClusters = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SupportsDedicatedLogVolume", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.SupportsDedicatedLogVolume = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SupportsEnhancedMonitoring", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.SupportsEnhancedMonitoring = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SupportsGlobalDatabases", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.SupportsGlobalDatabases = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SupportsHttpEndpoint", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.SupportsHttpEndpoint = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SupportsIAMDatabaseAuthentication", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.SupportsIAMDatabaseAuthentication = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SupportsIops", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.SupportsIops = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SupportsKerberosAuthentication", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.SupportsKerberosAuthentication = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SupportsPerformanceInsights", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.SupportsPerformanceInsights = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SupportsStorageAutoscaling", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.SupportsStorageAutoscaling = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SupportsStorageEncryption", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.SupportsStorageEncryption = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SupportsStorageThroughput", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.SupportsStorageThroughput = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Vpc", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.Vpc = unmarshaller.Unmarshall(context);
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

        private static OrderableDBInstanceOptionUnmarshaller _instance = new OrderableDBInstanceOptionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static OrderableDBInstanceOptionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}