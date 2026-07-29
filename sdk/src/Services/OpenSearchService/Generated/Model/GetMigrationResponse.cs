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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
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
        private string _applicationId;
        private DateTime? _createdAt;
        private MigrationError _error;
        private int? _exportedCount;
        private int? _importedCount;
        private string _migrationId;
        private MigrationSource _source;
        private string _status;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The unique identifier of the OpenSearch application associated with the migration.
        /// </para>
        /// </summary>
        public string ApplicationId
        {
            get { return this._applicationId; }
            set { this._applicationId = value; }
        }

        // Check to see if ApplicationId property is set
        internal bool IsSetApplicationId()
        {
            return this._applicationId != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time when the migration job was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// Error details if the migration failed or completed with errors.
        /// </para>
        /// </summary>
        public MigrationError Error
        {
            get { return this._error; }
            set { this._error = value; }
        }

        // Check to see if Error property is set
        internal bool IsSetError()
        {
            return this._error != null;
        }

        /// <summary>
        /// Gets and sets the property ExportedCount. 
        /// <para>
        /// The number of saved objects exported from the source data source.
        /// </para>
        /// </summary>
        public int? ExportedCount
        {
            get { return this._exportedCount; }
            set { this._exportedCount = value; }
        }

        // Check to see if ExportedCount property is set
        internal bool IsSetExportedCount()
        {
            return this._exportedCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ImportedCount. 
        /// <para>
        /// The number of saved objects successfully imported into the target workspace.
        /// </para>
        /// </summary>
        public int? ImportedCount
        {
            get { return this._importedCount; }
            set { this._importedCount = value; }
        }

        // Check to see if ImportedCount property is set
        internal bool IsSetImportedCount()
        {
            return this._importedCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MigrationId. 
        /// <para>
        /// The unique identifier of the migration job.
        /// </para>
        /// </summary>
        public string MigrationId
        {
            get { return this._migrationId; }
            set { this._migrationId = value; }
        }

        // Check to see if MigrationId property is set
        internal bool IsSetMigrationId()
        {
            return this._migrationId != null;
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The source configuration for the migration, including the data source ARN.
        /// </para>
        /// </summary>
        public MigrationSource Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the migration job. Valid values are <c>PENDING</c>, <c>IN_PROGRESS</c>,
        /// <c>SUCCEEDED</c>, and <c>FAILED</c>.
        /// </para>
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time when the migration job was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}