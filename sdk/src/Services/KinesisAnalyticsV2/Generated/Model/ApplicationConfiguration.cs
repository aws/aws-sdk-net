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
    /// Specifies the creation parameters for a Managed Service for Apache Flink application.
    /// </summary>
    public partial class ApplicationConfiguration
    {
        private ApplicationCodeConfiguration _applicationCodeConfiguration;
        private ApplicationEncryptionConfiguration _applicationEncryptionConfiguration;
        private ApplicationSnapshotConfiguration _applicationSnapshotConfiguration;
        private ApplicationSystemRollbackConfiguration _applicationSystemRollbackConfiguration;
        private EnvironmentProperties _environmentProperties;
        private FlinkApplicationConfiguration _flinkApplicationConfiguration;
        private SqlApplicationConfiguration _sqlApplicationConfiguration;
        private List<VpcConfiguration> _vpcConfigurations = AWSConfigs.InitializeCollections ? new List<VpcConfiguration>() : null;
        private ZeppelinApplicationConfiguration _zeppelinApplicationConfiguration;

        /// <summary>
        /// Gets and sets the property ApplicationCodeConfiguration. 
        /// <para>
        /// The code location and type parameters for a Managed Service for Apache Flink application.
        /// </para>
        /// </summary>
        public ApplicationCodeConfiguration ApplicationCodeConfiguration
        {
            get { return this._applicationCodeConfiguration; }
            set { this._applicationCodeConfiguration = value; }
        }

        // Check to see if ApplicationCodeConfiguration property is set
        internal bool IsSetApplicationCodeConfiguration()
        {
            return this._applicationCodeConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ApplicationEncryptionConfiguration. 
        /// <para>
        /// The configuration to manage encryption at rest.
        /// </para>
        /// </summary>
        public ApplicationEncryptionConfiguration ApplicationEncryptionConfiguration
        {
            get { return this._applicationEncryptionConfiguration; }
            set { this._applicationEncryptionConfiguration = value; }
        }

        // Check to see if ApplicationEncryptionConfiguration property is set
        internal bool IsSetApplicationEncryptionConfiguration()
        {
            return this._applicationEncryptionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ApplicationSnapshotConfiguration. 
        /// <para>
        /// Describes whether snapshots are enabled for a Managed Service for Apache Flink application.
        /// </para>
        /// </summary>
        public ApplicationSnapshotConfiguration ApplicationSnapshotConfiguration
        {
            get { return this._applicationSnapshotConfiguration; }
            set { this._applicationSnapshotConfiguration = value; }
        }

        // Check to see if ApplicationSnapshotConfiguration property is set
        internal bool IsSetApplicationSnapshotConfiguration()
        {
            return this._applicationSnapshotConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ApplicationSystemRollbackConfiguration. 
        /// <para>
        /// Describes whether system rollbacks are enabled for a Managed Service for Apache Flink
        /// application.
        /// </para>
        /// </summary>
        public ApplicationSystemRollbackConfiguration ApplicationSystemRollbackConfiguration
        {
            get { return this._applicationSystemRollbackConfiguration; }
            set { this._applicationSystemRollbackConfiguration = value; }
        }

        // Check to see if ApplicationSystemRollbackConfiguration property is set
        internal bool IsSetApplicationSystemRollbackConfiguration()
        {
            return this._applicationSystemRollbackConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentProperties. 
        /// <para>
        /// Describes execution properties for a Managed Service for Apache Flink application.
        /// </para>
        /// </summary>
        public EnvironmentProperties EnvironmentProperties
        {
            get { return this._environmentProperties; }
            set { this._environmentProperties = value; }
        }

        // Check to see if EnvironmentProperties property is set
        internal bool IsSetEnvironmentProperties()
        {
            return this._environmentProperties != null;
        }

        /// <summary>
        /// Gets and sets the property FlinkApplicationConfiguration. 
        /// <para>
        /// The creation and update parameters for a Managed Service for Apache Flink application.
        /// </para>
        /// </summary>
        public FlinkApplicationConfiguration FlinkApplicationConfiguration
        {
            get { return this._flinkApplicationConfiguration; }
            set { this._flinkApplicationConfiguration = value; }
        }

        // Check to see if FlinkApplicationConfiguration property is set
        internal bool IsSetFlinkApplicationConfiguration()
        {
            return this._flinkApplicationConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property SqlApplicationConfiguration. 
        /// <para>
        /// The creation and update parameters for a SQL-based Kinesis Data Analytics application.
        /// </para>
        /// </summary>
        public SqlApplicationConfiguration SqlApplicationConfiguration
        {
            get { return this._sqlApplicationConfiguration; }
            set { this._sqlApplicationConfiguration = value; }
        }

        // Check to see if SqlApplicationConfiguration property is set
        internal bool IsSetSqlApplicationConfiguration()
        {
            return this._sqlApplicationConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property VpcConfigurations. 
        /// <para>
        /// The array of descriptions of VPC configurations available to the application.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<VpcConfiguration> VpcConfigurations
        {
            get { return this._vpcConfigurations; }
            set { this._vpcConfigurations = value; }
        }

        // Check to see if VpcConfigurations property is set
        internal bool IsSetVpcConfigurations()
        {
            return this._vpcConfigurations != null && (this._vpcConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ZeppelinApplicationConfiguration. 
        /// <para>
        /// The configuration parameters for a Managed Service for Apache Flink Studio notebook.
        /// </para>
        /// </summary>
        public ZeppelinApplicationConfiguration ZeppelinApplicationConfiguration
        {
            get { return this._zeppelinApplicationConfiguration; }
            set { this._zeppelinApplicationConfiguration = value; }
        }

        // Check to see if ZeppelinApplicationConfiguration property is set
        internal bool IsSetZeppelinApplicationConfiguration()
        {
            return this._zeppelinApplicationConfiguration != null;
        }

    }
}