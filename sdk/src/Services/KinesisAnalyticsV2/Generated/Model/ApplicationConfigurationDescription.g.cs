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
    /// Describes details about the application code and starting parameters for a Managed
    /// Service for Apache Flink application.
    /// </summary>
    public partial class ApplicationConfigurationDescription
    {
        /// <summary>
        /// Gets and sets the property ApplicationCodeConfigurationDescription. 
        /// <para>
        /// The details about the application code for a Managed Service for Apache Flink application.
        /// </para>
        /// </summary>
        public ApplicationCodeConfigurationDescription ApplicationCodeConfigurationDescription { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationCodeConfigurationDescription property is set.
        /// </summary>
        internal bool IsSetApplicationCodeConfigurationDescription() => this.ApplicationCodeConfigurationDescription != null;

        /// <summary>
        /// Gets and sets the property ApplicationEncryptionConfigurationDescription. 
        /// <para>
        /// Describes the encryption at rest configuration.
        /// </para>
        /// </summary>
        public ApplicationEncryptionConfigurationDescription ApplicationEncryptionConfigurationDescription { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationEncryptionConfigurationDescription property is set.
        /// </summary>
        internal bool IsSetApplicationEncryptionConfigurationDescription() => this.ApplicationEncryptionConfigurationDescription != null;

        /// <summary>
        /// Gets and sets the property ApplicationSnapshotConfigurationDescription. 
        /// <para>
        /// Describes whether snapshots are enabled for a Managed Service for Apache Flink application.
        /// </para>
        /// </summary>
        public ApplicationSnapshotConfigurationDescription ApplicationSnapshotConfigurationDescription { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationSnapshotConfigurationDescription property is set.
        /// </summary>
        internal bool IsSetApplicationSnapshotConfigurationDescription() => this.ApplicationSnapshotConfigurationDescription != null;

        /// <summary>
        /// Gets and sets the property ApplicationSystemRollbackConfigurationDescription. 
        /// <para>
        /// Describes whether system rollbacks are enabled for a Managed Service for Apache Flink
        /// application.
        /// </para>
        /// </summary>
        public ApplicationSystemRollbackConfigurationDescription ApplicationSystemRollbackConfigurationDescription { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationSystemRollbackConfigurationDescription property is set.
        /// </summary>
        internal bool IsSetApplicationSystemRollbackConfigurationDescription() => this.ApplicationSystemRollbackConfigurationDescription != null;

        /// <summary>
        /// Gets and sets the property EnvironmentPropertyDescriptions. 
        /// <para>
        /// Describes execution properties for a Managed Service for Apache Flink application.
        /// </para>
        /// </summary>
        public EnvironmentPropertyDescriptions EnvironmentPropertyDescriptions { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentPropertyDescriptions property is set.
        /// </summary>
        internal bool IsSetEnvironmentPropertyDescriptions() => this.EnvironmentPropertyDescriptions != null;

        /// <summary>
        /// Gets and sets the property FlinkApplicationConfigurationDescription. 
        /// <para>
        /// The details about a Managed Service for Apache Flink application.
        /// </para>
        /// </summary>
        public FlinkApplicationConfigurationDescription FlinkApplicationConfigurationDescription { get; set; }

        /// <summary>
        /// Checks to see if the FlinkApplicationConfigurationDescription property is set.
        /// </summary>
        internal bool IsSetFlinkApplicationConfigurationDescription() => this.FlinkApplicationConfigurationDescription != null;

        /// <summary>
        /// Gets and sets the property RunConfigurationDescription. 
        /// <para>
        /// The details about the starting properties for a Managed Service for Apache Flink application.
        /// </para>
        /// </summary>
        public RunConfigurationDescription RunConfigurationDescription { get; set; }

        /// <summary>
        /// Checks to see if the RunConfigurationDescription property is set.
        /// </summary>
        internal bool IsSetRunConfigurationDescription() => this.RunConfigurationDescription != null;

        /// <summary>
        /// Gets and sets the property SqlApplicationConfigurationDescription. 
        /// <para>
        /// The details about inputs, outputs, and reference data sources for a SQL-based Kinesis
        /// Data Analytics application.
        /// </para>
        /// </summary>
        public SqlApplicationConfigurationDescription SqlApplicationConfigurationDescription { get; set; }

        /// <summary>
        /// Checks to see if the SqlApplicationConfigurationDescription property is set.
        /// </summary>
        internal bool IsSetSqlApplicationConfigurationDescription() => this.SqlApplicationConfigurationDescription != null;

        /// <summary>
        /// Gets and sets the property VpcConfigurationDescriptions. 
        /// <para>
        /// The array of descriptions of VPC configurations available to the application.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<VpcConfigurationDescription> VpcConfigurationDescriptions { get; set; } = AWSConfigs.InitializeCollections ? new List<VpcConfigurationDescription>() : null;

        /// <summary>
        /// Checks to see if the VpcConfigurationDescriptions property is set.
        /// </summary>
        internal bool IsSetVpcConfigurationDescriptions() => this.VpcConfigurationDescriptions != null && (this.VpcConfigurationDescriptions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ZeppelinApplicationConfigurationDescription. 
        /// <para>
        /// The configuration parameters for a Managed Service for Apache Flink Studio notebook.
        /// </para>
        /// </summary>
        public ZeppelinApplicationConfigurationDescription ZeppelinApplicationConfigurationDescription { get; set; }

        /// <summary>
        /// Checks to see if the ZeppelinApplicationConfigurationDescription property is set.
        /// </summary>
        internal bool IsSetZeppelinApplicationConfigurationDescription() => this.ZeppelinApplicationConfigurationDescription != null;
    }
}
