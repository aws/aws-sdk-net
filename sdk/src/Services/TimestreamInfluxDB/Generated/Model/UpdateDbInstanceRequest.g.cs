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
    /// Container for the parameters to the UpdateDbInstance operation. Updates a Timestream
    /// for InfluxDB DB instance.
    /// </summary>
    public partial class UpdateDbInstanceRequest : AmazonTimestreamInfluxDBRequest
    {
        /// <summary>
        /// Gets and sets the property AllocatedStorage. 
        /// <para>
        /// The amount of storage to allocate for your DB storage type (in gibibytes).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 15360)]
        public int? AllocatedStorage { get; set; }

        /// <summary>
        /// Checks to see if the AllocatedStorage property is set.
        /// </summary>
        internal bool IsSetAllocatedStorage() => this.AllocatedStorage.HasValue;

        /// <summary>
        /// Gets and sets the property DbBackupConfigurations. 
        /// <para>
        /// A list of backup configurations to update for the DB instance.
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
        /// Gets and sets the property DbInstanceType. 
        /// <para>
        /// The Timestream for InfluxDB DB instance type to run InfluxDB on.
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
        /// The id of the DB parameter group to assign to your DB instance. DB parameter groups
        /// specify how the database is configured. For example, DB parameter groups can specify
        /// the limit for query concurrency.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 64)]
        public string DbParameterGroupIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DbParameterGroupIdentifier property is set.
        /// </summary>
        internal bool IsSetDbParameterGroupIdentifier() => this.DbParameterGroupIdentifier != null;

        /// <summary>
        /// Gets and sets the property DbStorageType. 
        /// <para>
        /// The Timestream for InfluxDB DB storage type that InfluxDB stores data on.
        /// </para>
        /// </summary>
        public DbStorageType DbStorageType { get; set; }

        /// <summary>
        /// Checks to see if the DbStorageType property is set.
        /// </summary>
        internal bool IsSetDbStorageType() => this.DbStorageType != null;

        /// <summary>
        /// Gets and sets the property DeploymentType. 
        /// <para>
        /// Specifies whether the DB instance will be deployed as a standalone instance or with
        /// a Multi-AZ standby for high availability.
        /// </para>
        /// </summary>
        public DeploymentType DeploymentType { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentType property is set.
        /// </summary>
        internal bool IsSetDeploymentType() => this.DeploymentType != null;

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The id of the DB instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 64)]
        public string Identifier { get; set; }

        /// <summary>
        /// Checks to see if the Identifier property is set.
        /// </summary>
        internal bool IsSetIdentifier() => this.Identifier != null;

        /// <summary>
        /// Gets and sets the property LogDeliveryConfiguration. 
        /// <para>
        /// Configuration for sending InfluxDB engine logs to send to specified S3 bucket.
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
        /// Specifies the maintenance schedule for the DB instance, including the preferred maintenance
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
        /// The port number on which InfluxDB accepts connections.
        /// </para>
        ///  
        /// <para>
        /// If you change the Port value, your database restarts immediately.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: 1024-65535
        /// </para>
        ///  
        /// <para>
        /// Default: 8086
        /// </para>
        ///  
        /// <para>
        /// Constraints: The value can't be 2375-2376, 7788-7799, 8090, or 51678-51680
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
