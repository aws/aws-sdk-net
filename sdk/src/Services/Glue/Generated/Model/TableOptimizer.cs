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
        /// The type of table optimizer. Currently, the only valid value is <c>compaction</c>.
        /// </para>
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