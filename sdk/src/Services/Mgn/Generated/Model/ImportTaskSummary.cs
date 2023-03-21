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
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Mgn.Model
{
    /// <summary>
    /// Import task summary.
    /// </summary>
    public partial class ImportTaskSummary
    {
        private ImportTaskSummaryApplications _applications;
        private ImportTaskSummaryServers _servers;
        private ImportTaskSummaryWaves _waves;

        /// <summary>
        /// Gets and sets the property Applications. 
        /// <para>
        /// Import task summary applications.
        /// </para>
        /// </summary>
        public ImportTaskSummaryApplications Applications
        {
            get { return this._applications; }
            set { this._applications = value; }
        }

        // Check to see if Applications property is set
        internal bool IsSetApplications()
        {
            return this._applications != null;
        }

        /// <summary>
        /// Gets and sets the property Servers. 
        /// <para>
        /// Import task summary servers.
        /// </para>
        /// </summary>
        public ImportTaskSummaryServers Servers
        {
            get { return this._servers; }
            set { this._servers = value; }
        }

        // Check to see if Servers property is set
        internal bool IsSetServers()
        {
            return this._servers != null;
        }

        /// <summary>
        /// Gets and sets the property Waves. 
        /// <para>
        /// Import task summary waves.
        /// </para>
        /// </summary>
        public ImportTaskSummaryWaves Waves
        {
            get { return this._waves; }
            set { this._waves = value; }
        }

        // Check to see if Waves property is set
        internal bool IsSetWaves()
        {
            return this._waves != null;
        }

    }
}