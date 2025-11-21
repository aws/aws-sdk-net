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
 * Do not modify this file. This file is generated from the kinesisanalyticsv2-2018-05-23.normal.json service model.
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
        private ApplicationCodeConfigurationUpdate _applicationCodeConfigurationUpdate;
        private ApplicationEncryptionConfigurationUpdate _applicationEncryptionConfigurationUpdate;
        private ApplicationSnapshotConfigurationUpdate _applicationSnapshotConfigurationUpdate;
        private ApplicationSystemRollbackConfigurationUpdate _applicationSystemRollbackConfigurationUpdate;
        private EnvironmentPropertyUpdates _environmentPropertyUpdates;
        private FlinkApplicationConfigurationUpdate _flinkApplicationConfigurationUpdate;
        private SqlApplicationConfigurationUpdate _sqlApplicationConfigurationUpdate;
        private List<VpcConfigurationUpdate> _vpcConfigurationUpdates = AWSConfigs.InitializeCollections ? new List<VpcConfigurationUpdate>() : null;
        private ZeppelinApplicationConfigurationUpdate _zeppelinApplicationConfigurationUpdate;

        /// <summary>
        /// Gets and sets the property ApplicationCodeConfigurationUpdate. 
        /// <para>
        /// Describes updates to an application's code configuration.
        /// </para>
        /// </summary>
        public ApplicationCodeConfigurationUpdate ApplicationCodeConfigurationUpdate
        {
            get { return this._applicationCodeConfigurationUpdate; }
            set { this._applicationCodeConfigurationUpdate = value; }
        }

        // Check to see if ApplicationCodeConfigurationUpdate property is set
        internal bool IsSetApplicationCodeConfigurationUpdate()
        {
            return this._applicationCodeConfigurationUpdate != null;
        }

        /// <summary>
        /// Gets and sets the property ApplicationEncryptionConfigurationUpdate. 
        /// <para>
        /// Represents an update for encryption at rest configuration.
        /// </para>
        /// </summary>
        public ApplicationEncryptionConfigurationUpdate ApplicationEncryptionConfigurationUpdate
        {
            get { return this._applicationEncryptionConfigurationUpdate; }
            set { this._applicationEncryptionConfigurationUpdate = value; }
        }

        // Check to see if ApplicationEncryptionConfigurationUpdate property is set
        internal bool IsSetApplicationEncryptionConfigurationUpdate()
        {
            return this._applicationEncryptionConfigurationUpdate != null;
        }

        /// <summary>
        /// Gets and sets the property ApplicationSnapshotConfigurationUpdate. 
        /// <para>
        /// Describes whether snapshots are enabled for a Managed Service for Apache Flink application.
        /// </para>
        /// </summary>
        public ApplicationSnapshotConfigurationUpdate ApplicationSnapshotConfigurationUpdate
        {
            get { return this._applicationSnapshotConfigurationUpdate; }
            set { this._applicationSnapshotConfigurationUpdate = value; }
        }

        // Check to see if ApplicationSnapshotConfigurationUpdate property is set
        internal bool IsSetApplicationSnapshotConfigurationUpdate()
        {
            return this._applicationSnapshotConfigurationUpdate != null;
        }

        /// <summary>
        /// Gets and sets the property ApplicationSystemRollbackConfigurationUpdate. 
        /// <para>
        /// Describes whether system rollbacks are enabled for a Managed Service for Apache Flink
        /// application.
        /// </para>
        /// </summary>
        public ApplicationSystemRollbackConfigurationUpdate ApplicationSystemRollbackConfigurationUpdate
        {
            get { return this._applicationSystemRollbackConfigurationUpdate; }
            set { this._applicationSystemRollbackConfigurationUpdate = value; }
        }

        // Check to see if ApplicationSystemRollbackConfigurationUpdate property is set
        internal bool IsSetApplicationSystemRollbackConfigurationUpdate()
        {
            return this._applicationSystemRollbackConfigurationUpdate != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentPropertyUpdates. 
        /// <para>
        /// Describes updates to the environment properties for a Managed Service for Apache Flink
        /// application.
        /// </para>
        /// </summary>
        public EnvironmentPropertyUpdates EnvironmentPropertyUpdates
        {
            get { return this._environmentPropertyUpdates; }
            set { this._environmentPropertyUpdates = value; }
        }

        // Check to see if EnvironmentPropertyUpdates property is set
        internal bool IsSetEnvironmentPropertyUpdates()
        {
            return this._environmentPropertyUpdates != null;
        }

        /// <summary>
        /// Gets and sets the property FlinkApplicationConfigurationUpdate. 
        /// <para>
        /// Describes updates to a Managed Service for Apache Flink application's configuration.
        /// </para>
        /// </summary>
        public FlinkApplicationConfigurationUpdate FlinkApplicationConfigurationUpdate
        {
            get { return this._flinkApplicationConfigurationUpdate; }
            set { this._flinkApplicationConfigurationUpdate = value; }
        }

        // Check to see if FlinkApplicationConfigurationUpdate property is set
        internal bool IsSetFlinkApplicationConfigurationUpdate()
        {
            return this._flinkApplicationConfigurationUpdate != null;
        }

        /// <summary>
        /// Gets and sets the property SqlApplicationConfigurationUpdate. 
        /// <para>
        /// Describes updates to a SQL-based Kinesis Data Analytics application's configuration.
        /// </para>
        /// </summary>
        public SqlApplicationConfigurationUpdate SqlApplicationConfigurationUpdate
        {
            get { return this._sqlApplicationConfigurationUpdate; }
            set { this._sqlApplicationConfigurationUpdate = value; }
        }

        // Check to see if SqlApplicationConfigurationUpdate property is set
        internal bool IsSetSqlApplicationConfigurationUpdate()
        {
            return this._sqlApplicationConfigurationUpdate != null;
        }

        /// <summary>
        /// Gets and sets the property VpcConfigurationUpdates. 
        /// <para>
        /// Updates to the array of descriptions of VPC configurations available to the application.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<VpcConfigurationUpdate> VpcConfigurationUpdates
        {
            get { return this._vpcConfigurationUpdates; }
            set { this._vpcConfigurationUpdates = value; }
        }

        // Check to see if VpcConfigurationUpdates property is set
        internal bool IsSetVpcConfigurationUpdates()
        {
            return this._vpcConfigurationUpdates != null && (this._vpcConfigurationUpdates.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ZeppelinApplicationConfigurationUpdate. 
        /// <para>
        /// Updates to the configuration of a Managed Service for Apache Flink Studio notebook.
        /// </para>
        /// </summary>
        public ZeppelinApplicationConfigurationUpdate ZeppelinApplicationConfigurationUpdate
        {
            get { return this._zeppelinApplicationConfigurationUpdate; }
            set { this._zeppelinApplicationConfigurationUpdate = value; }
        }

        // Check to see if ZeppelinApplicationConfigurationUpdate property is set
        internal bool IsSetZeppelinApplicationConfigurationUpdate()
        {
            return this._zeppelinApplicationConfigurationUpdate != null;
        }

    }
}