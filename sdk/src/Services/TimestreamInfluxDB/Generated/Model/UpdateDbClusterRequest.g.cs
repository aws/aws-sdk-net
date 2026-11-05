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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.TimestreamInfluxDB.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateDbCluster operation. Updates a Timestream
    /// for InfluxDB cluster.
    /// </summary>
    public partial class UpdateDbClusterRequest : AmazonTimestreamInfluxDBRequest
    {
        /// <summary>
        /// Gets and sets the property DbBackupConfigurations. 
        /// <para>
        /// A list of backup configurations to update for the DB cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 4)]
        public List<DbBackupConfiguration> DbBackupConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<DbBackupConfiguration>() : null;

        /// <summary>
        /// Checks to see if the DbBackupConfigurations property is set.
        /// </summary>
        internal bool IsSetDbBackupConfigurations() => this.DbBackupConfigurations != null && (this.DbBackupConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DbClusterId. 
        /// <para>
        /// Service-generated unique identifier of the DB cluster to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 64)]
        public string DbClusterId { get; set; }

        /// <summary>
        /// Checks to see if the DbClusterId property is set.
        /// </summary>
        internal bool IsSetDbClusterId() => this.DbClusterId != null;

        /// <summary>
        /// Gets and sets the property DbInstanceType. 
        /// <para>
        /// Update the DB cluster to use the specified DB instance Type.
        /// </para>
        ///  
        /// <para>
        /// You can't specify both dbInstanceType and deploymentConfiguration in the same request.
        /// When you use deploymentConfiguration, the instance type is specified per node group.
        /// </para>
        /// </summary>
        public DbInstanceType DbInstanceType { get; set; }

        /// <summary>
        /// Checks to see if the DbInstanceType property is set.
        /// </summary>
        internal bool IsSetDbInstanceType() => this.DbInstanceType != null;

        /// <summary>
        /// Gets and sets the property DbParameterGroupIdentifier. 
        /// <para>
        /// Update the DB cluster to use the specified DB parameter group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 64)]
        public string DbParameterGroupIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DbParameterGroupIdentifier property is set.
        /// </summary>
        internal bool IsSetDbParameterGroupIdentifier() => this.DbParameterGroupIdentifier != null;

        /// <summary>
        /// Gets and sets the property DeploymentConfiguration. 
        /// <para>
        /// The updated compute topology for the cluster, defined as a set of node groups. Use
        /// deploymentConfiguration to change the cluster's topology or scale its compute in a
        /// single call. You can't specify both deploymentConfiguration and dbInstanceType in
        /// the same request. When you provide a deployment configuration, Timestream for InfluxDB
        /// ignores any node-count parameters in the associated DB parameter group.
        /// </para>
        /// </summary>
        public DeploymentConfiguration DeploymentConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentConfiguration property is set.
        /// </summary>
        internal bool IsSetDeploymentConfiguration() => this.DeploymentConfiguration != null;

        /// <summary>
        /// Gets and sets the property FailoverMode. 
        /// <para>
        /// Update the DB cluster's failover behavior.
        /// </para>
        /// </summary>
        public FailoverMode FailoverMode { get; set; }

        /// <summary>
        /// Checks to see if the FailoverMode property is set.
        /// </summary>
        internal bool IsSetFailoverMode() => this.FailoverMode != null;

        /// <summary>
        /// Gets and sets the property LogDeliveryConfiguration. 
        /// <para>
        /// The log delivery configuration to apply to the DB cluster.
        /// </para>
        /// </summary>
        public LogDeliveryConfiguration LogDeliveryConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the LogDeliveryConfiguration property is set.
        /// </summary>
        internal bool IsSetLogDeliveryConfiguration() => this.LogDeliveryConfiguration != null;

        /// <summary>
        /// Gets and sets the property MaintenanceSchedule. 
        /// <para>
        /// Specifies the maintenance schedule for the DB cluster, including the preferred maintenance
        /// window and timezone.
        /// </para>
        /// </summary>
        public MaintenanceSchedule MaintenanceSchedule { get; set; }

        /// <summary>
        /// Checks to see if the MaintenanceSchedule property is set.
        /// </summary>
        internal bool IsSetMaintenanceSchedule() => this.MaintenanceSchedule != null;

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// Update the DB cluster to use the specified port.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1024, Max = 65535)]
        public int? Port { get; set; }

        /// <summary>
        /// Checks to see if the Port property is set.
        /// </summary>
        internal bool IsSetPort() => this.Port.HasValue;
    }
}
