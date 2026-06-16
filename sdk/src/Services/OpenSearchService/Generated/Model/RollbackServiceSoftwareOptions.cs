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
    /// Details about the rollback options for a service software update.
    /// </summary>
    public partial class RollbackServiceSoftwareOptions
    {
        private string _currentVersion;
        private string _description;
        private string _newVersion;
        private bool? _rollbackAvailable;

        /// <summary>
        /// Gets and sets the property CurrentVersion. 
        /// <para>
        /// The current service software version on the domain.
        /// </para>
        /// </summary>
        public string CurrentVersion
        {
            get { return this._currentVersion; }
            set { this._currentVersion = value; }
        }

        // Check to see if CurrentVersion property is set
        internal bool IsSetCurrentVersion()
        {
            return this._currentVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the rollback status.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property NewVersion. 
        /// <para>
        /// The service software version that the domain will roll back to.
        /// </para>
        /// </summary>
        public string NewVersion
        {
            get { return this._newVersion; }
            set { this._newVersion = value; }
        }

        // Check to see if NewVersion property is set
        internal bool IsSetNewVersion()
        {
            return this._newVersion != null;
        }

        /// <summary>
        /// Gets and sets the property RollbackAvailable. 
        /// <para>
        /// Whether a service software rollback is available for the domain.
        /// </para>
        /// </summary>
        public bool? RollbackAvailable
        {
            get { return this._rollbackAvailable; }
            set { this._rollbackAvailable = value; }
        }

        // Check to see if RollbackAvailable property is set
        internal bool IsSetRollbackAvailable()
        {
            return this._rollbackAvailable.HasValue; 
        }

    }
}