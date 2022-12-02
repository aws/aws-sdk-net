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
 * Do not modify this file. This file is generated from the redshift-serverless-2021-04-21.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RedshiftServerless.Model
{
    /// <summary>
    /// Container for the parameters to the RestoreTableFromSnapshot operation.
    /// Restores a table from a snapshot to your Amazon Redshift Serverless instance.
    /// </summary>
    public partial class RestoreTableFromSnapshotRequest : AmazonRedshiftServerlessRequest
    {
        private bool? _activateCaseSensitiveIdentifier;
        private string _namespaceName;
        private string _newTableName;
        private string _snapshotName;
        private string _sourceDatabaseName;
        private string _sourceSchemaName;
        private string _sourceTableName;
        private string _targetDatabaseName;
        private string _targetSchemaName;
        private string _workgroupName;

        /// <summary>
        /// Gets and sets the property ActivateCaseSensitiveIdentifier. 
        /// <para>
        /// Indicates whether name identifiers for database, schema, and table are case sensitive.
        /// If true, the names are case sensitive. If false, the names are not case sensitive.
        /// The default is false.
        /// </para>
        /// </summary>
        public bool ActivateCaseSensitiveIdentifier
        {
            get { return this._activateCaseSensitiveIdentifier.GetValueOrDefault(); }
            set { this._activateCaseSensitiveIdentifier = value; }
        }

        // Check to see if ActivateCaseSensitiveIdentifier property is set
        internal bool IsSetActivateCaseSensitiveIdentifier()
        {
            return this._activateCaseSensitiveIdentifier.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NamespaceName. 
        /// <para>
        /// The namespace of the snapshot to restore from.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string NamespaceName
        {
            get { return this._namespaceName; }
            set { this._namespaceName = value; }
        }

        // Check to see if NamespaceName property is set
        internal bool IsSetNamespaceName()
        {
            return this._namespaceName != null;
        }

        /// <summary>
        /// Gets and sets the property NewTableName. 
        /// <para>
        /// The name of the table to create from the restore operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property SnapshotName. 
        /// <para>
        /// The name of the snapshot to restore the table from.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SnapshotName
        {
            get { return this._snapshotName; }
            set { this._snapshotName = value; }
        }

        // Check to see if SnapshotName property is set
        internal bool IsSetSnapshotName()
        {
            return this._snapshotName != null;
        }

        /// <summary>
        /// Gets and sets the property SourceDatabaseName. 
        /// <para>
        /// The name of the source database that contains the table being restored.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The name of the source schema that contains the table being restored.
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
        /// The name of the source table being restored.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

        /// <summary>
        /// Gets and sets the property WorkgroupName. 
        /// <para>
        /// The workgroup to restore the table to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string WorkgroupName
        {
            get { return this._workgroupName; }
            set { this._workgroupName = value; }
        }

        // Check to see if WorkgroupName property is set
        internal bool IsSetWorkgroupName()
        {
            return this._workgroupName != null;
        }

    }
}