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
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Container for the parameters to the RestoreTableFromClusterSnapshot operation.
    /// Creates a new table from a table in an Amazon Redshift cluster snapshot. You must
    /// create the new table within the Amazon Redshift cluster that the snapshot was taken
    /// from.
    /// 
    ///  
    /// <para>
    /// You cannot use <code>RestoreTableFromClusterSnapshot</code> to restore a table with
    /// the same name as an existing table in an Amazon Redshift cluster. That is, you cannot
    /// overwrite an existing table in a cluster with a restored table. If you want to replace
    /// your original table with a new, restored table, then rename or drop your original
    /// table before you call <code>RestoreTableFromClusterSnapshot</code>. When you have
    /// renamed your original table, then you can pass the original name of the table as the
    /// <code>NewTableName</code> parameter value in the call to <code>RestoreTableFromClusterSnapshot</code>.
    /// This way, you can replace the original table with the table created from the snapshot.
    /// </para>
    /// </summary>
    public partial class RestoreTableFromClusterSnapshotRequest : AmazonRedshiftRequest
    {
        private string _clusterIdentifier;
        private string _newTableName;
        private string _snapshotIdentifier;
        private string _sourceDatabaseName;
        private string _sourceSchemaName;
        private string _sourceTableName;
        private string _targetDatabaseName;
        private string _targetSchemaName;

        /// <summary>
        /// Gets and sets the property ClusterIdentifier. 
        /// <para>
        /// The identifier of the Amazon Redshift cluster to restore the table to.
        /// </para>
        /// </summary>
        public string ClusterIdentifier
        {
            get { return this._clusterIdentifier; }
            set { this._clusterIdentifier = value; }
        }

        // Check to see if ClusterIdentifier property is set
        internal bool IsSetClusterIdentifier()
        {
            return this._clusterIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property NewTableName. 
        /// <para>
        /// The name of the table to create as a result of the current request.
        /// </para>
        /// </summary>
        public string NewTableName
        {
            get { return this._newTableName; }
            set { this._newTableName = value; }
        }

        // Check to see if NewTableName property is set
        internal bool IsSetNewTableName()
        {
            return this._newTableName != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotIdentifier. 
        /// <para>
        /// The identifier of the snapshot to restore the table from. This snapshot must have
        /// been created from the Amazon Redshift cluster specified by the <code>ClusterIdentifier</code>
        /// parameter.
        /// </para>
        /// </summary>
        public string SnapshotIdentifier
        {
            get { return this._snapshotIdentifier; }
            set { this._snapshotIdentifier = value; }
        }

        // Check to see if SnapshotIdentifier property is set
        internal bool IsSetSnapshotIdentifier()
        {
            return this._snapshotIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property SourceDatabaseName. 
        /// <para>
        /// The name of the source database that contains the table to restore from.
        /// </para>
        /// </summary>
        public string SourceDatabaseName
        {
            get { return this._sourceDatabaseName; }
            set { this._sourceDatabaseName = value; }
        }

        // Check to see if SourceDatabaseName property is set
        internal bool IsSetSourceDatabaseName()
        {
            return this._sourceDatabaseName != null;
        }

        /// <summary>
        /// Gets and sets the property SourceSchemaName. 
        /// <para>
        /// The name of the source schema that contains the table to restore from.
        /// </para>
        /// </summary>
        public string SourceSchemaName
        {
            get { return this._sourceSchemaName; }
            set { this._sourceSchemaName = value; }
        }

        // Check to see if SourceSchemaName property is set
        internal bool IsSetSourceSchemaName()
        {
            return this._sourceSchemaName != null;
        }

        /// <summary>
        /// Gets and sets the property SourceTableName. 
        /// <para>
        /// The name of the source table to restore from.
        /// </para>
        /// </summary>
        public string SourceTableName
        {
            get { return this._sourceTableName; }
            set { this._sourceTableName = value; }
        }

        // Check to see if SourceTableName property is set
        internal bool IsSetSourceTableName()
        {
            return this._sourceTableName != null;
        }

        /// <summary>
        /// Gets and sets the property TargetDatabaseName. 
        /// <para>
        /// The name of the database to restore the table to.
        /// </para>
        /// </summary>
        public string TargetDatabaseName
        {
            get { return this._targetDatabaseName; }
            set { this._targetDatabaseName = value; }
        }

        // Check to see if TargetDatabaseName property is set
        internal bool IsSetTargetDatabaseName()
        {
            return this._targetDatabaseName != null;
        }

        /// <summary>
        /// Gets and sets the property TargetSchemaName. 
        /// <para>
        /// The name of the schema to restore the table to.
        /// </para>
        /// </summary>
        public string TargetSchemaName
        {
            get { return this._targetSchemaName; }
            set { this._targetSchemaName = value; }
        }

        // Check to see if TargetSchemaName property is set
        internal bool IsSetTargetSchemaName()
        {
            return this._targetSchemaName != null;
        }

    }
}