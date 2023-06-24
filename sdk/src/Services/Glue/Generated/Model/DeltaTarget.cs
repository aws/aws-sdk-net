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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Specifies a Delta data store to crawl one or more Delta tables.
    /// </summary>
    public partial class DeltaTarget
    {
        private string _connectionName;
        private bool? _createNativeDeltaTable;
        private List<string> _deltaTables = new List<string>();
        private bool? _writeManifest;

        /// <summary>
        /// Gets and sets the property ConnectionName. 
        /// <para>
        /// The name of the connection to use to connect to the Delta table target.
        /// </para>
        /// </summary>
        public string ConnectionName
        {
            get { return this._connectionName; }
            set { this._connectionName = value; }
        }

        // Check to see if ConnectionName property is set
        internal bool IsSetConnectionName()
        {
            return this._connectionName != null;
        }

        /// <summary>
        /// Gets and sets the property CreateNativeDeltaTable. 
        /// <para>
        /// Specifies whether the crawler will create native tables, to allow integration with
        /// query engines that support querying of the Delta transaction log directly.
        /// </para>
        /// </summary>
        public bool CreateNativeDeltaTable
        {
            get { return this._createNativeDeltaTable.GetValueOrDefault(); }
            set { this._createNativeDeltaTable = value; }
        }

        // Check to see if CreateNativeDeltaTable property is set
        internal bool IsSetCreateNativeDeltaTable()
        {
            return this._createNativeDeltaTable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeltaTables. 
        /// <para>
        /// A list of the Amazon S3 paths to the Delta tables.
        /// </para>
        /// </summary>
        public List<string> DeltaTables
        {
            get { return this._deltaTables; }
            set { this._deltaTables = value; }
        }

        // Check to see if DeltaTables property is set
        internal bool IsSetDeltaTables()
        {
            return this._deltaTables != null && this._deltaTables.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property WriteManifest. 
        /// <para>
        /// Specifies whether to write the manifest files to the Delta table path.
        /// </para>
        /// </summary>
        public bool WriteManifest
        {
            get { return this._writeManifest.GetValueOrDefault(); }
            set { this._writeManifest = value; }
        }

        // Check to see if WriteManifest property is set
        internal bool IsSetWriteManifest()
        {
            return this._writeManifest.HasValue; 
        }

    }
}