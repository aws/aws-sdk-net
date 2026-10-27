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

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Container for the parameters to the ReloadReplicationTables operation. Reloads the
    /// target database table with the source data for a given DMS Serverless replication
    /// configuration. <para> You can only use this operation with a task in the RUNNING state,
    /// otherwise the service will throw an <c>InvalidResourceStateFault</c> exception. </para>
    /// </summary>
    public partial class ReloadReplicationTablesRequest : AmazonDatabaseMigrationServiceRequest
    {
        /// <summary>
        /// Gets and sets the property ReloadOption. 
        /// <para>
        /// Options for reload. Specify <c>data-reload</c> to reload the data and re-validate
        /// it if validation is enabled. Specify <c>validate-only</c> to re-validate the table.
        /// This option applies only when validation is enabled for the replication. 
        /// </para>
        /// </summary>
        public ReloadOptionValue ReloadOption { get; set; }

        /// <summary>
        /// Checks to see if the ReloadOption property is set.
        /// </summary>
        internal bool IsSetReloadOption() => this.ReloadOption != null;

        /// <summary>
        /// Gets and sets the property ReplicationConfigArn. 
        /// <para>
        /// The Amazon Resource Name of the replication config for which to reload tables.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ReplicationConfigArn { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationConfigArn property is set.
        /// </summary>
        internal bool IsSetReplicationConfigArn() => this.ReplicationConfigArn != null;

        /// <summary>
        /// Gets and sets the property TablesToReload. 
        /// <para>
        /// The list of tables to reload.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<TableToReload> TablesToReload { get; set; } = AWSConfigs.InitializeCollections ? new List<TableToReload>() : null;

        /// <summary>
        /// Checks to see if the TablesToReload property is set.
        /// </summary>
        internal bool IsSetTablesToReload() => this.TablesToReload != null && (this.TablesToReload.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
