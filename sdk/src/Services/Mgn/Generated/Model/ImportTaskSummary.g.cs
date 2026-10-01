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

namespace Amazon.Mgn.Model
{
    /// <summary>
    /// Import task summary.
    /// </summary>
    public partial class ImportTaskSummary
    {
        /// <summary>
        /// Gets and sets the property Applications. 
        /// <para>
        /// Import task summary applications.
        /// </para>
        /// </summary>
        public ImportTaskSummaryApplications Applications { get; set; }

        /// <summary>
        /// Checks to see if the Applications property is set.
        /// </summary>
        internal bool IsSetApplications() => this.Applications != null;

        /// <summary>
        /// Gets and sets the property Servers. 
        /// <para>
        /// Import task summary servers.
        /// </para>
        /// </summary>
        public ImportTaskSummaryServers Servers { get; set; }

        /// <summary>
        /// Checks to see if the Servers property is set.
        /// </summary>
        internal bool IsSetServers() => this.Servers != null;

        /// <summary>
        /// Gets and sets the property Waves. 
        /// <para>
        /// Import task summary waves.
        /// </para>
        /// </summary>
        public ImportTaskSummaryWaves Waves { get; set; }

        /// <summary>
        /// Checks to see if the Waves property is set.
        /// </summary>
        internal bool IsSetWaves() => this.Waves != null;
    }
}
