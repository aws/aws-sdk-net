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
    /// This is the response object from the StartMigration operation.
    /// </summary>
    public partial class StartMigrationResponse : AmazonWebServiceResponse
    {
        private string _migrationId;
        private string _status;

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
        /// Gets and sets the property Status. 
        /// <para>
        /// The initial status of the migration job. The status is <c>PENDING</c> when a migration
        /// is first created.
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