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
    /// Options for configuring a data migration, including whether to enable CloudWatch logs,
    /// and the selection rules to use to include or exclude database objects from the migration.
    /// </summary>
    public partial class DataMigrationSettings
    {
        private bool? _cloudwatchLogsEnabled;
        private int? _numberOfJobs;
        private string _selectionRules;

        /// <summary>
        /// Gets and sets the property CloudwatchLogsEnabled. 
        /// <para>
        /// Whether to enable CloudWatch logging for the data migration.
        /// </para>
        /// </summary>
        public bool? CloudwatchLogsEnabled
        {
            get { return this._cloudwatchLogsEnabled; }
            set { this._cloudwatchLogsEnabled = value; }
        }

        // Check to see if CloudwatchLogsEnabled property is set
        internal bool IsSetCloudwatchLogsEnabled()
        {
            return this._cloudwatchLogsEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberOfJobs. 
        /// <para>
        /// The number of parallel jobs that trigger parallel threads to unload the tables from
        /// the source, and then load them to the target.
        /// </para>
        /// </summary>
        public int? NumberOfJobs
        {
            get { return this._numberOfJobs; }
            set { this._numberOfJobs = value; }
        }

        // Check to see if NumberOfJobs property is set
        internal bool IsSetNumberOfJobs()
        {
            return this._numberOfJobs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SelectionRules. 
        /// <para>
        /// A JSON-formatted string that defines what objects to include and exclude from the
        /// migration.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string SelectionRules
        {
            get { return this._selectionRules; }
            set { this._selectionRules = value; }
        }

        // Check to see if SelectionRules property is set
        internal bool IsSetSelectionRules()
        {
            return this._selectionRules != null;
        }

    }
}