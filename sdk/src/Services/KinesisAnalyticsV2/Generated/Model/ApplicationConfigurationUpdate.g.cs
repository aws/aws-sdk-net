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

namespace Amazon.KinesisAnalyticsV2.Model
{
    /// <summary>
    /// Describes updates to an application's configuration.
    /// </summary>
    public partial class ApplicationConfigurationUpdate
    {
        /// <summary>
        /// Gets and sets the property ApplicationCodeConfigurationUpdate. 
        /// <para>
        /// Describes updates to an application's code configuration.
        /// </para>
        /// </summary>
        public ApplicationCodeConfigurationUpdate ApplicationCodeConfigurationUpdate { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationCodeConfigurationUpdate property is set.
        /// </summary>
        internal bool IsSetApplicationCodeConfigurationUpdate() => this.ApplicationCodeConfigurationUpdate != null;

        /// <summary>
        /// Gets and sets the property ApplicationEncryptionConfigurationUpdate. 
        /// <para>
        /// Represents an update for encryption at rest configuration.
        /// </para>
        /// </summary>
        public ApplicationEncryptionConfigurationUpdate ApplicationEncryptionConfigurationUpdate { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationEncryptionConfigurationUpdate property is set.
        /// </summary>
        internal bool IsSetApplicationEncryptionConfigurationUpdate() => this.ApplicationEncryptionConfigurationUpdate != null;

        /// <summary>
        /// Gets and sets the property ApplicationSnapshotConfigurationUpdate. 
        /// <para>
        /// Describes whether snapshots are enabled for a Managed Service for Apache Flink application.
        /// </para>
        /// </summary>
        public ApplicationSnapshotConfigurationUpdate ApplicationSnapshotConfigurationUpdate { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationSnapshotConfigurationUpdate property is set.
        /// </summary>
        internal bool IsSetApplicationSnapshotConfigurationUpdate() => this.ApplicationSnapshotConfigurationUpdate != null;

        /// <summary>
        /// Gets and sets the property ApplicationSystemRollbackConfigurationUpdate. 
        /// <para>
        /// Describes whether system rollbacks are enabled for a Managed Service for Apache Flink
        /// application.
        /// </para>
        /// </summary>
        public ApplicationSystemRollbackConfigurationUpdate ApplicationSystemRollbackConfigurationUpdate { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationSystemRollbackConfigurationUpdate property is set.
        /// </summary>
        internal bool IsSetApplicationSystemRollbackConfigurationUpdate() => this.ApplicationSystemRollbackConfigurationUpdate != null;

        /// <summary>
        /// Gets and sets the property EnvironmentPropertyUpdates. 
        /// <para>
        /// Describes updates to the environment properties for a Managed Service for Apache Flink
        /// application.
        /// </para>
        /// </summary>
        public EnvironmentPropertyUpdates EnvironmentPropertyUpdates { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentPropertyUpdates property is set.
        /// </summary>
        internal bool IsSetEnvironmentPropertyUpdates() => this.EnvironmentPropertyUpdates != null;

        /// <summary>
        /// Gets and sets the property FlinkApplicationConfigurationUpdate. 
        /// <para>
        /// Describes updates to a Managed Service for Apache Flink application's configuration.
        /// </para>
        /// </summary>
        public FlinkApplicationConfigurationUpdate FlinkApplicationConfigurationUpdate { get; set; }

        /// <summary>
        /// Checks to see if the FlinkApplicationConfigurationUpdate property is set.
        /// </summary>
        internal bool IsSetFlinkApplicationConfigurationUpdate() => this.FlinkApplicationConfigurationUpdate != null;

        /// <summary>
        /// Gets and sets the property SqlApplicationConfigurationUpdate. 
        /// <para>
        /// Describes updates to a SQL-based Kinesis Data Analytics application's configuration.
        /// </para>
        /// </summary>
        public SqlApplicationConfigurationUpdate SqlApplicationConfigurationUpdate { get; set; }

        /// <summary>
        /// Checks to see if the SqlApplicationConfigurationUpdate property is set.
        /// </summary>
        internal bool IsSetSqlApplicationConfigurationUpdate() => this.SqlApplicationConfigurationUpdate != null;

        /// <summary>
        /// Gets and sets the property VpcConfigurationUpdates. 
        /// <para>
        /// Updates to the array of descriptions of VPC configurations available to the application.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<VpcConfigurationUpdate> VpcConfigurationUpdates { get; set; } = AWSConfigs.InitializeCollections ? new List<VpcConfigurationUpdate>() : null;

        /// <summary>
        /// Checks to see if the VpcConfigurationUpdates property is set.
        /// </summary>
        internal bool IsSetVpcConfigurationUpdates() => this.VpcConfigurationUpdates != null && (this.VpcConfigurationUpdates.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ZeppelinApplicationConfigurationUpdate. 
        /// <para>
        /// Updates to the configuration of a Managed Service for Apache Flink Studio notebook.
        /// </para>
        /// </summary>
        public ZeppelinApplicationConfigurationUpdate ZeppelinApplicationConfigurationUpdate { get; set; }

        /// <summary>
        /// Checks to see if the ZeppelinApplicationConfigurationUpdate property is set.
        /// </summary>
        internal bool IsSetZeppelinApplicationConfigurationUpdate() => this.ZeppelinApplicationConfigurationUpdate != null;
    }
}
