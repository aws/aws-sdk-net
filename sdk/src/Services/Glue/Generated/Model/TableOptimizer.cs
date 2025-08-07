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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
        private TableOptimizerConfiguration _configuration;
        private ConfigurationSource _configurationSource;
        private TableOptimizerRun _lastRun;
        private TableOptimizerType _type;

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// A <c>TableOptimizerConfiguration</c> object that was specified when creating or updating
        /// a table optimizer.
        /// </para>
        /// </summary>
        public TableOptimizerConfiguration Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null;
        }

        /// <summary>
        /// Gets and sets the property ConfigurationSource. 
        /// <para>
        ///  Specifies the source of the optimizer configuration. This indicates how the table
        /// optimizer was configured and which entity or service initiated the configuration.
        /// 
        /// </para>
        /// </summary>
        public ConfigurationSource ConfigurationSource
        {
            get { return this._configurationSource; }
            set { this._configurationSource = value; }
        }

        // Check to see if ConfigurationSource property is set
        internal bool IsSetConfigurationSource()
        {
            return this._configurationSource != null;
        }

        /// <summary>
        /// Gets and sets the property LastRun. 
        /// <para>
        /// A <c>TableOptimizerRun</c> object representing the last run of the table optimizer.
        /// </para>
        /// </summary>
        public TableOptimizerRun LastRun
        {
            get { return this._lastRun; }
            set { this._lastRun = value; }
        }

        // Check to see if LastRun property is set
        internal bool IsSetLastRun()
        {
            return this._lastRun != null;
        }

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
        public TableOptimizerType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}