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

namespace Amazon.RedshiftServerless.Model
{
    /// <summary>
    /// Container for the parameters to the RestoreTableFromRecoveryPoint operation. Restores
    /// a table from a recovery point to your Amazon Redshift Serverless instance. You can't
    /// use this operation to restore tables with interleaved sort keys.
    /// </summary>
    public partial class RestoreTableFromRecoveryPointRequest : AmazonRedshiftServerlessRequest
    {
        /// <summary>
        /// Gets and sets the property ActivateCaseSensitiveIdentifier. 
        /// <para>
        /// Indicates whether name identifiers for database, schema, and table are case sensitive.
        /// If true, the names are case sensitive. If false, the names are not case sensitive.
        /// The default is false.
        /// </para>
        /// </summary>
        public bool? ActivateCaseSensitiveIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ActivateCaseSensitiveIdentifier property is set.
        /// </summary>
        internal bool IsSetActivateCaseSensitiveIdentifier() => this.ActivateCaseSensitiveIdentifier.HasValue;

        /// <summary>
        /// Gets and sets the property NamespaceName. 
        /// <para>
        /// Namespace of the recovery point to restore from.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string NamespaceName { get; set; }

        /// <summary>
        /// Checks to see if the NamespaceName property is set.
        /// </summary>
        internal bool IsSetNamespaceName() => this.NamespaceName != null;

        /// <summary>
        /// Gets and sets the property NewTableName. 
        /// <para>
        /// The name of the table to create from the restore operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string NewTableName { get; set; }

        /// <summary>
        /// Checks to see if the NewTableName property is set.
        /// </summary>
        internal bool IsSetNewTableName() => this.NewTableName != null;

        /// <summary>
        /// Gets and sets the property RecoveryPointId. 
        /// <para>
        /// The ID of the recovery point to restore the table from.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RecoveryPointId { get; set; }

        /// <summary>
        /// Checks to see if the RecoveryPointId property is set.
        /// </summary>
        internal bool IsSetRecoveryPointId() => this.RecoveryPointId != null;

        /// <summary>
        /// Gets and sets the property SourceDatabaseName. 
        /// <para>
        /// The name of the source database that contains the table being restored.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SourceDatabaseName { get; set; }

        /// <summary>
        /// Checks to see if the SourceDatabaseName property is set.
        /// </summary>
        internal bool IsSetSourceDatabaseName() => this.SourceDatabaseName != null;

        /// <summary>
        /// Gets and sets the property SourceSchemaName. 
        /// <para>
        /// The name of the source schema that contains the table being restored.
        /// </para>
        /// </summary>
        public string SourceSchemaName { get; set; }

        /// <summary>
        /// Checks to see if the SourceSchemaName property is set.
        /// </summary>
        internal bool IsSetSourceSchemaName() => this.SourceSchemaName != null;

        /// <summary>
        /// Gets and sets the property SourceTableName. 
        /// <para>
        /// The name of the source table being restored.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
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
        public string TargetSchemaName { get; set; }

        /// <summary>
        /// Checks to see if the TargetSchemaName property is set.
        /// </summary>
        internal bool IsSetTargetSchemaName() => this.TargetSchemaName != null;

        /// <summary>
        /// Gets and sets the property WorkgroupName. 
        /// <para>
        /// The workgroup to restore the table to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string WorkgroupName { get; set; }

        /// <summary>
        /// Checks to see if the WorkgroupName property is set.
        /// </summary>
        internal bool IsSetWorkgroupName() => this.WorkgroupName != null;
    }
}
