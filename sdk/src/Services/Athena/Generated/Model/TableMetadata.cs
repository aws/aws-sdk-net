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
 * Do not modify this file. This file is generated from the athena-2017-05-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Athena.Model
{
    /// <summary>
    /// Contains metadata for a table.
    /// </summary>
    public partial class TableMetadata
    {
        private List<Column> _columns = new List<Column>();
        private DateTime? _createTime;
        private DateTime? _lastAccessTime;
        private string _name;
        private Dictionary<string, string> _parameters = new Dictionary<string, string>();
        private List<Column> _partitionKeys = new List<Column>();
        private string _tableType;

        /// <summary>
        /// Gets and sets the property Columns. 
        /// <para>
        /// A list of the columns in the table.
        /// </para>
        /// </summary>
        public List<Column> Columns
        {
            get { return this._columns; }
            set { this._columns = value; }
        }

        // Check to see if Columns property is set
        internal bool IsSetColumns()
        {
            return this._columns != null && this._columns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The time that the table was created.
        /// </para>
        /// </summary>
        public DateTime CreateTime
        {
            get { return this._createTime.GetValueOrDefault(); }
            set { this._createTime = value; }
        }

        // Check to see if CreateTime property is set
        internal bool IsSetCreateTime()
        {
            return this._createTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastAccessTime. 
        /// <para>
        /// The last time the table was accessed.
        /// </para>
        /// </summary>
        public DateTime LastAccessTime
        {
            get { return this._lastAccessTime.GetValueOrDefault(); }
            set { this._lastAccessTime = value; }
        }

        // Check to see if LastAccessTime property is set
        internal bool IsSetLastAccessTime()
        {
            return this._lastAccessTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// A set of custom key/value pairs for table properties.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && this._parameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PartitionKeys. 
        /// <para>
        /// A list of the partition keys in the table.
        /// </para>
        /// </summary>
        public List<Column> PartitionKeys
        {
            get { return this._partitionKeys; }
            set { this._partitionKeys = value; }
        }

        // Check to see if PartitionKeys property is set
        internal bool IsSetPartitionKeys()
        {
            return this._partitionKeys != null && this._partitionKeys.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TableType. 
        /// <para>
        /// The type of table. In Athena, only <code>EXTERNAL_TABLE</code> is supported.
        /// </para>
        /// </summary>
        [AWSProperty(Max=255)]
        public string TableType
        {
            get { return this._tableType; }
            set { this._tableType = value; }
        }

        // Check to see if TableType property is set
        internal bool IsSetTableType()
        {
            return this._tableType != null;
        }

    }
}