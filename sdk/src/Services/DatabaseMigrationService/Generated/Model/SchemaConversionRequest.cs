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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
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
    /// Provides information about a schema conversion action.
    /// </summary>
    public partial class SchemaConversionRequest
    {
        private ErrorDetails _error;
        private ExportSqlDetails _exportSqlDetails;
        private string _migrationProjectArn;
        private string _requestIdentifier;
        private string _status;

        /// <summary>
        /// Gets and sets the property Error.
        /// </summary>
        public ErrorDetails Error
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
        /// Gets and sets the property ExportSqlDetails.
        /// </summary>
        public ExportSqlDetails ExportSqlDetails
        {
            get { return this._exportSqlDetails; }
            set { this._exportSqlDetails = value; }
        }

        // Check to see if ExportSqlDetails property is set
        internal bool IsSetExportSqlDetails()
        {
            return this._exportSqlDetails != null;
        }

        /// <summary>
        /// Gets and sets the property MigrationProjectArn. 
        /// <para>
        /// The migration project ARN.
        /// </para>
        /// </summary>
        public string MigrationProjectArn
        {
            get { return this._migrationProjectArn; }
            set { this._migrationProjectArn = value; }
        }

        // Check to see if MigrationProjectArn property is set
        internal bool IsSetMigrationProjectArn()
        {
            return this._migrationProjectArn != null;
        }

        /// <summary>
        /// Gets and sets the property RequestIdentifier. 
        /// <para>
        /// The identifier for the schema conversion action.
        /// </para>
        /// </summary>
        public string RequestIdentifier
        {
            get { return this._requestIdentifier; }
            set { this._requestIdentifier = value; }
        }

        // Check to see if RequestIdentifier property is set
        internal bool IsSetRequestIdentifier()
        {
            return this._requestIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The schema conversion action status.
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

    }
}