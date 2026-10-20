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

namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// A reference to a table within Databricks.
    /// </summary>
    public partial class DatabricksTableReference
    {
        /// <summary>
        /// Gets and sets the property ConnectionType. 
        /// <para>
        /// Type of the connector to be used for connecting to Databricks. Supported connector:
        /// Delta Sharing
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DatabricksConnectionType ConnectionType { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionType property is set.
        /// </summary>
        internal bool IsSetConnectionType() => this.ConnectionType != null;

        /// <summary>
        /// Gets and sets the property SchemaName. 
        /// <para>
        /// Name of the Schema within Databricks.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string SchemaName { get; set; }

        /// <summary>
        /// Checks to see if the SchemaName property is set.
        /// </summary>
        internal bool IsSetSchemaName() => this.SchemaName != null;

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// Name of the Table within Databricks.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string TableName { get; set; }

        /// <summary>
        /// Checks to see if the TableName property is set.
        /// </summary>
        internal bool IsSetTableName() => this.TableName != null;

        /// <summary>
        /// Gets and sets the property WorkspaceUrl. 
        /// <para>
        /// URL for the Databricks Workspace.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 256)]
        public string WorkspaceUrl { get; set; }

        /// <summary>
        /// Checks to see if the WorkspaceUrl property is set.
        /// </summary>
        internal bool IsSetWorkspaceUrl() => this.WorkspaceUrl != null;
    }
}
