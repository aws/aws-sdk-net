/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Structure used to create or update the table.
    /// </summary>
    public partial class TableInput
    {
        private string _description;
        private DateTime? _lastAccessTime;
        private DateTime? _lastAnalyzedTime;
        private string _name;
        private string _owner;
        private Dictionary<string, string> _parameters = new Dictionary<string, string>();
        private List<Column> _partitionKeys = new List<Column>();
        private int? _retention;
        private StorageDescriptor _storageDescriptor;
        private string _tableType;
        private string _viewExpandedText;
        private string _viewOriginalText;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Description of the table.
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
        /// Gets and sets the property LastAccessTime. 
        /// <para>
        /// Last time the table was accessed.
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
        /// Gets and sets the property LastAnalyzedTime. 
        /// <para>
        /// Last time column statistics were computed for this table.
        /// </para>
        /// </summary>
        public DateTime LastAnalyzedTime
        {
            get { return this._lastAnalyzedTime.GetValueOrDefault(); }
            set { this._lastAnalyzedTime = value; }
        }

        // Check to see if LastAnalyzedTime property is set
        internal bool IsSetLastAnalyzedTime()
        {
            return this._lastAnalyzedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Name of the table. For Hive compatibility, this is folded to lowercase when it is
        /// stored.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Owner. 
        /// <para>
        /// Owner of the table.
        /// </para>
        /// </summary>
        public string Owner
        {
            get { return this._owner; }
            set { this._owner = value; }
        }

        // Check to see if Owner property is set
        internal bool IsSetOwner()
        {
            return this._owner != null;
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// Properties associated with this table, as a list of key-value pairs.
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
        /// A list of columns by which the table is partitioned. Only primitive types are supported
        /// as partition keys.
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
        /// Gets and sets the property Retention. 
        /// <para>
        /// Retention time for this table.
        /// </para>
        /// </summary>
        public int Retention
        {
            get { return this._retention.GetValueOrDefault(); }
            set { this._retention = value; }
        }

        // Check to see if Retention property is set
        internal bool IsSetRetention()
        {
            return this._retention.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StorageDescriptor. 
        /// <para>
        /// A storage descriptor containing information about the physical storage of this table.
        /// </para>
        /// </summary>
        public StorageDescriptor StorageDescriptor
        {
            get { return this._storageDescriptor; }
            set { this._storageDescriptor = value; }
        }

        // Check to see if StorageDescriptor property is set
        internal bool IsSetStorageDescriptor()
        {
            return this._storageDescriptor != null;
        }

        /// <summary>
        /// Gets and sets the property TableType. 
        /// <para>
        /// The type of this table (<code>EXTERNAL_TABLE</code>, <code>VIRTUAL_VIEW</code>, etc.).
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property ViewExpandedText. 
        /// <para>
        /// If the table is a view, the expanded text of the view; otherwise <code>null</code>.
        /// </para>
        /// </summary>
        public string ViewExpandedText
        {
            get { return this._viewExpandedText; }
            set { this._viewExpandedText = value; }
        }

        // Check to see if ViewExpandedText property is set
        internal bool IsSetViewExpandedText()
        {
            return this._viewExpandedText != null;
        }

        /// <summary>
        /// Gets and sets the property ViewOriginalText. 
        /// <para>
        /// If the table is a view, the original text of the view; otherwise <code>null</code>.
        /// </para>
        /// </summary>
        public string ViewOriginalText
        {
            get { return this._viewOriginalText; }
            set { this._viewOriginalText = value; }
        }

        // Check to see if ViewOriginalText property is set
        internal bool IsSetViewOriginalText()
        {
            return this._viewOriginalText != null;
        }

    }
}