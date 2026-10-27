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
 * Do not modify this file. This file is generated from the elasticache-2015-02-02.normal.json service model.
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
namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// Provides a summary of the current migration status for a serverless cache.
    /// </summary>
    public partial class MigrationSummary
    {
        private string _cutoverMode;
        private Endpoint _migrationEndpoint;
        private string _status;

        /// <summary>
        /// Gets and sets the property CutoverMode. 
        /// <para>
        /// The cutover configuration for the migration.
        /// </para>
        /// </summary>
        public string CutoverMode
        {
            get { return this._cutoverMode; }
            set { this._cutoverMode = value; }
        }

        // Check to see if CutoverMode property is set
        internal bool IsSetCutoverMode()
        {
            return this._cutoverMode != null;
        }

        /// <summary>
        /// Gets and sets the property MigrationEndpoint. 
        /// <para>
        /// The migration endpoint, which is the standard endpoint of the serverless cache. Point
        /// your application at this endpoint during the migration. Until cutover, ElastiCache
        /// routes requests on this endpoint to your source.
        /// </para>
        /// </summary>
        public Endpoint MigrationEndpoint
        {
            get { return this._migrationEndpoint; }
            set { this._migrationEndpoint = value; }
        }

        // Check to see if MigrationEndpoint property is set
        internal bool IsSetMigrationEndpoint()
        {
            return this._migrationEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the migration.
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