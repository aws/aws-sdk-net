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
    /// Specifies an Amazon DocumentDB or MongoDB data store to crawl.
    /// </summary>
    public partial class MongoDBTarget
    {
        private string _connectionName;
        private string _path;
        private bool? _scanAll;

        /// <summary>
        /// Gets and sets the property ConnectionName. 
        /// <para>
        /// The name of the connection to use to connect to the Amazon DocumentDB or MongoDB target.
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
        /// Gets and sets the property Path. 
        /// <para>
        /// The path of the Amazon DocumentDB or MongoDB target (database/collection).
        /// </para>
        /// </summary>
        public string Path
        {
            get { return this._path; }
            set { this._path = value; }
        }

        // Check to see if Path property is set
        internal bool IsSetPath()
        {
            return this._path != null;
        }

        /// <summary>
        /// Gets and sets the property ScanAll. 
        /// <para>
        /// Indicates whether to scan all the records, or to sample rows from the table. Scanning
        /// all the records can take a long time when the table is not a high throughput table.
        /// </para>
        ///  
        /// <para>
        /// A value of <c>true</c> means to scan all records, while a value of <c>false</c> means
        /// to sample the records. If no value is specified, the value defaults to <c>true</c>.
        /// </para>
        /// </summary>
        public bool? ScanAll
        {
            get { return this._scanAll; }
            set { this._scanAll = value; }
        }

        // Check to see if ScanAll property is set
        internal bool IsSetScanAll()
        {
            return this._scanAll.HasValue; 
        }

    }
}