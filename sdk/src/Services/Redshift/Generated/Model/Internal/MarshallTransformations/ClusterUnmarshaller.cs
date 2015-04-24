/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
namespace Amazon.Redshift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Cluster Object
    /// </summary>  
    public class ClusterUnmarshaller : IUnmarshaller<Cluster, XmlUnmarshallerContext>, IUnmarshaller<Cluster, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public Cluster Unmarshall(XmlUnmarshallerContext context)
        {
            Cluster unmarshalledObject = new Cluster();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("AllowVersionUpgrade", targetDepth))
                    {
                        var unmarshaller = BoolUnmarshaller.Instance;
                        unmarshalledObject.AllowVersionUpgrade = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("AutomatedSnapshotRetentionPeriod", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        unmarshalledObject.AutomatedSnapshotRetentionPeriod = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("AvailabilityZone", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.AvailabilityZone = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ClusterCreateTime", targetDepth))
                    {
                        var unmarshaller = DateTimeUnmarshaller.Instance;
                        unmarshalledObject.ClusterCreateTime = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ClusterIdentifier", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ClusterIdentifier = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ClusterNodes/member", targetDepth))
                    {
                        var unmarshaller = ClusterNodeUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.ClusterNodes.Add(item);
                        continue;
                    }
                    if (context.TestExpression("ClusterParameterGroups/ClusterParameterGroup", targetDepth))
                    {
                        var unmarshaller = ClusterParameterGroupStatusUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.ClusterParameterGroups.Add(item);
                        continue;
                    }
                    if (context.TestExpression("ClusterPublicKey", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ClusterPublicKey = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ClusterRevisionNumber", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ClusterRevisionNumber = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ClusterSecurityGroups/ClusterSecurityGroup", targetDepth))
                    {
                        var unmarshaller = ClusterSecurityGroupMembershipUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.ClusterSecurityGroups.Add(item);
                        continue;
                    }
                    if (context.TestExpression("ClusterSnapshotCopyStatus", targetDepth))
                    {
                        var unmarshaller = ClusterSnapshotCopyStatusUnmarshaller.Instance;
                        unmarshalledObject.ClusterSnapshotCopyStatus = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ClusterStatus", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ClusterStatus = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ClusterSubnetGroupName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ClusterSubnetGroupName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ClusterVersion", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ClusterVersion = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DBName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DBName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ElasticIpStatus", targetDepth))
                    {
                        var unmarshaller = ElasticIpStatusUnmarshaller.Instance;
                        unmarshalledObject.ElasticIpStatus = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Encrypted", targetDepth))
                    {
                        var unmarshaller = BoolUnmarshaller.Instance;
                        unmarshalledObject.Encrypted = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Endpoint", targetDepth))
                    {
                        var unmarshaller = EndpointUnmarshaller.Instance;
                        unmarshalledObject.Endpoint = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("HsmStatus", targetDepth))
                    {
                        var unmarshaller = HsmStatusUnmarshaller.Instance;
                        unmarshalledObject.HsmStatus = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("KmsKeyId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.KmsKeyId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("MasterUsername", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.MasterUsername = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ModifyStatus", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ModifyStatus = unmarshaller.Unmarshall(context);
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
                        var unmarshaller = IntUnmarshaller.Instance;
                        unmarshalledObject.NumberOfNodes = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("PendingModifiedValues", targetDepth))
                    {
                        var unmarshaller = PendingModifiedValuesUnmarshaller.Instance;
                        unmarshalledObject.PendingModifiedValues = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("PreferredMaintenanceWindow", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.PreferredMaintenanceWindow = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("PubliclyAccessible", targetDepth))
                    {
                        var unmarshaller = BoolUnmarshaller.Instance;
                        unmarshalledObject.PubliclyAccessible = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("RestoreStatus", targetDepth))
                    {
                        var unmarshaller = RestoreStatusUnmarshaller.Instance;
                        unmarshalledObject.RestoreStatus = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Tags/Tag", targetDepth))
                    {
                        var unmarshaller = TagUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Tags.Add(item);
                        continue;
                    }
                    if (context.TestExpression("VpcId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.VpcId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("VpcSecurityGroups/VpcSecurityGroup", targetDepth))
                    {
                        var unmarshaller = VpcSecurityGroupMembershipUnmarshaller.Instance;
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

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public Cluster Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }


        private static ClusterUnmarshaller _instance = new ClusterUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ClusterUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}