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

namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// This is the response object from the GetMigration operation.
    /// </summary>
    public partial class GetMigrationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The unique identifier of the OpenSearch application associated with the migration.
        /// </para>
        /// </summary>
        public string ApplicationId { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationId property is set.
        /// </summary>
        internal bool IsSetApplicationId() => this.ApplicationId != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time when the migration job was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// Error details if the migration failed or completed with errors.
        /// </para>
        /// </summary>
        public MigrationError Error { get; set; }

        /// <summary>
        /// Checks to see if the Error property is set.
        /// </summary>
        internal bool IsSetError() => this.Error != null;

        /// <summary>
        /// Gets and sets the property ExportedCount. 
        /// <para>
        /// The number of saved objects exported from the source data source.
        /// </para>
        /// </summary>
        public int? ExportedCount { get; set; }

        /// <summary>
        /// Checks to see if the ExportedCount property is set.
        /// </summary>
        internal bool IsSetExportedCount() => this.ExportedCount.HasValue;

        /// <summary>
        /// Gets and sets the property ImportedCount. 
        /// <para>
        /// The number of saved objects successfully imported into the target workspace.
        /// </para>
        /// </summary>
        public int? ImportedCount { get; set; }

        /// <summary>
        /// Checks to see if the ImportedCount property is set.
        /// </summary>
        internal bool IsSetImportedCount() => this.ImportedCount.HasValue;

        /// <summary>
        /// Gets and sets the property MigrationId. 
        /// <para>
        /// The unique identifier of the migration job.
        /// </para>
        /// </summary>
        public string MigrationId { get; set; }

        /// <summary>
        /// Checks to see if the MigrationId property is set.
        /// </summary>
        internal bool IsSetMigrationId() => this.MigrationId != null;

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The source configuration for the migration, including the data source ARN.
        /// </para>
        /// </summary>
        public MigrationSource Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the migration job. Valid values are <c>PENDING</c>, <c>IN_PROGRESS</c>,
        /// <c>SUCCEEDED</c>, and <c>FAILED</c>.
        /// </para>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time when the migration job was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
