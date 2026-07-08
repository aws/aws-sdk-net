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
    /// Container for the parameters to the StartMigration operation.
    /// Initiates a migration job to migrate saved objects from a data source to an Amazon
    /// OpenSearch Service application workspace. Saved objects include dashboards, visualizations,
    /// index patterns, and searches. You can specify export filters to control the scope
    /// of the migration and a conflict resolution strategy for handling existing objects
    /// in the target workspace.
    /// </summary>
    public partial class StartMigrationRequest : AmazonOpenSearchServiceRequest
    {
        private string _applicationId;
        private string _clientToken;
        private MigrationOptions _migrationOptions;

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The unique identifier of the OpenSearch application to migrate saved objects into.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure that the operation completes no more
        /// than one time. If this token matches a previous request, Amazon OpenSearch Service
        /// ignores the request but does not return an error.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property MigrationOptions. 
        /// <para>
        /// The configuration options for the migration, including the source data source, target
        /// workspace, export filters, and conflict resolution strategy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MigrationOptions MigrationOptions
        {
            get { return this._migrationOptions; }
            set { this._migrationOptions = value; }
        }

        // Check to see if MigrationOptions property is set
        internal bool IsSetMigrationOptions()
        {
            return this._migrationOptions != null;
        }

    }
}