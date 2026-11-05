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

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Container for the parameters to the RestoreTableFromClusterSnapshot operation. Creates
    /// a new table from a table in an Amazon Redshift cluster snapshot. You must create the
    /// new table within the Amazon Redshift cluster that the snapshot was taken from. <para>
    /// You cannot use <c>RestoreTableFromClusterSnapshot</c> to restore a table with the
    /// same name as an existing table in an Amazon Redshift cluster. That is, you cannot
    /// overwrite an existing table in a cluster with a restored table. If you want to replace
    /// your original table with a new, restored table, then rename or drop your original
    /// table before you call <c>RestoreTableFromClusterSnapshot</c>. When you have renamed
    /// your original table, then you can pass the original name of the table as the <c>NewTableName</c>
    /// parameter value in the call to <c>RestoreTableFromClusterSnapshot</c>. This way, you
    /// can replace the original table with the table created from the snapshot. </para> <para>
    /// You can't use this operation to restore tables with <a href="https://docs.aws.amazon.com/redshift/latest/dg/t_Sorting_data.html#t_Sorting_data-interleaved">interleaved
    /// sort keys</a>. </para>
    /// </summary>
    public partial class RestoreTableFromClusterSnapshotRequest : AmazonRedshiftRequest
    {
        /// <summary>
        /// Gets and sets the property ClusterIdentifier. 
        /// <para>
        /// The identifier of the Amazon Redshift cluster to restore the table to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 2147483647)]
        public string ClusterIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ClusterIdentifier property is set.
        /// </summary>
        internal bool IsSetClusterIdentifier() => this.ClusterIdentifier != null;

        /// <summary>
        /// Gets and sets the property EnableCaseSensitiveIdentifier. 
        /// <para>
        /// Indicates whether name identifiers for database, schema, and table are case sensitive.
        /// If <c>true</c>, the names are case sensitive. If <c>false</c> (default), the names
        /// are not case sensitive.
        /// </para>
        /// </summary>
        public bool? EnableCaseSensitiveIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the EnableCaseSensitiveIdentifier property is set.
        /// </summary>
        internal bool IsSetEnableCaseSensitiveIdentifier() => this.EnableCaseSensitiveIdentifier.HasValue;

        /// <summary>
        /// Gets and sets the property NewTableName. 
        /// <para>
        /// The name of the table to create as a result of the current request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 2147483647)]
        public string NewTableName { get; set; }

        /// <summary>
        /// Checks to see if the NewTableName property is set.
        /// </summary>
        internal bool IsSetNewTableName() => this.NewTableName != null;

        /// <summary>
        /// Gets and sets the property SnapshotIdentifier. 
        /// <para>
        /// The identifier of the snapshot to restore the table from. This snapshot must have
        /// been created from the Amazon Redshift cluster specified by the <c>ClusterIdentifier</c>
        /// parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 2147483647)]
        public string SnapshotIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotIdentifier property is set.
        /// </summary>
        internal bool IsSetSnapshotIdentifier() => this.SnapshotIdentifier != null;

        /// <summary>
        /// Gets and sets the property SourceDatabaseName. 
        /// <para>
        /// The name of the source database that contains the table to restore from.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 2147483647)]
        public string SourceDatabaseName { get; set; }

        /// <summary>
        /// Checks to see if the SourceDatabaseName property is set.
        /// </summary>
        internal bool IsSetSourceDatabaseName() => this.SourceDatabaseName != null;

        /// <summary>
        /// Gets and sets the property SourceSchemaName. 
        /// <para>
        /// The name of the source schema that contains the table to restore from. If you do not
        /// specify a <c>SourceSchemaName</c> value, the default is <c>public</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string SourceSchemaName { get; set; }

        /// <summary>
        /// Checks to see if the SourceSchemaName property is set.
        /// </summary>
        internal bool IsSetSourceSchemaName() => this.SourceSchemaName != null;

        /// <summary>
        /// Gets and sets the property SourceTableName. 
        /// <para>
        /// The name of the source table to restore from.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 2147483647)]
        public string SourceTableName { get; set; }

        /// <summary>
        /// Checks to see if the SourceTableName property is set.
        /// </summary>
        internal bool IsSetSourceTableName() => this.SourceTableName != null;

        /// <summary>
        /// Gets and sets the property TargetDatabaseName. 
        /// <para>
        /// The name of the database to restore the table to.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string TargetDatabaseName { get; set; }

        /// <summary>
        /// Checks to see if the TargetDatabaseName property is set.
        /// </summary>
        internal bool IsSetTargetDatabaseName() => this.TargetDatabaseName != null;

        /// <summary>
        /// Gets and sets the property TargetSchemaName. 
        /// <para>
        /// The name of the schema to restore the table to.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string TargetSchemaName { get; set; }

        /// <summary>
        /// Checks to see if the TargetSchemaName property is set.
        /// </summary>
        internal bool IsSetTargetSchemaName() => this.TargetSchemaName != null;
    }
}
