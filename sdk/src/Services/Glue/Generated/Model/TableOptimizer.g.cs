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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Contains details about an optimizer associated with a table.
    /// </summary>
    public partial class TableOptimizer
    {
        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// A <c>TableOptimizerConfiguration</c> object that was specified when creating or updating
        /// a table optimizer.
        /// </para>
        /// </summary>
        public TableOptimizerConfiguration Configuration { get; set; }

        /// <summary>
        /// Checks to see if the Configuration property is set.
        /// </summary>
        internal bool IsSetConfiguration() => this.Configuration != null;

        /// <summary>
        /// Gets and sets the property ConfigurationSource. 
        /// <para>
        ///  Specifies the source of the optimizer configuration. This indicates how the table
        /// optimizer was configured and which entity or service initiated the configuration.
        /// 
        /// </para>
        /// </summary>
        public ConfigurationSource ConfigurationSource { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationSource property is set.
        /// </summary>
        internal bool IsSetConfigurationSource() => this.ConfigurationSource != null;

        /// <summary>
        /// Gets and sets the property LastRun. 
        /// <para>
        /// A <c>TableOptimizerRun</c> object representing the last run of the table optimizer.
        /// </para>
        /// </summary>
        public TableOptimizerRun LastRun { get; set; }

        /// <summary>
        /// Checks to see if the LastRun property is set.
        /// </summary>
        internal bool IsSetLastRun() => this.LastRun != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of table optimizer. The valid values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>compaction</c>: for managing compaction with a table optimizer.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>retention</c>: for managing the retention of snapshot with a table optimizer.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>orphan_file_deletion</c>: for managing the deletion of orphan files with a table
        /// optimizer.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public TableOptimizerType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
