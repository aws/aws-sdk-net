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
    /// A structure used to define a table.
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
        private TableIdentifier _targetTable;
        private string _viewExpandedText;
        private string _viewOriginalText;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the table.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
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
        /// The last time that the table was accessed.
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
        /// The last time that column statistics were computed for this table.
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
        /// The table name. For Hive compatibility, this is folded to lowercase when it is stored.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
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
        /// The table owner. Included for Apache Hive compatibility. Not used in the normal course
        /// of Glue operations.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// These key-value pairs define properties associated with the table.
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
        ///  
        /// <para>
        /// When you create a table used by Amazon Athena, and you do not specify any <code>partitionKeys</code>,
        /// you must at least set the value of <code>partitionKeys</code> to an empty list. For
        /// example:
        /// </para>
        ///  
        /// <para>
        ///  <code>"PartitionKeys": []</code> 
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
        /// The retention time for this table.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
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
        /// The type of this table. Glue will create tables with the <code>EXTERNAL_TABLE</code>
        /// type. Other services, such as Athena, may create tables with additional table types.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Glue related table types:
        /// </para>
        ///  <dl> <dt>EXTERNAL_TABLE</dt> <dd> 
        /// <para>
        /// Hive compatible attribute - indicates a non-Hive managed table.
        /// </para>
        ///  </dd> <dt>GOVERNED</dt> <dd> 
        /// <para>
        /// Used by Lake Formation. The Glue Data Catalog understands <code>GOVERNED</code>.
        /// </para>
        ///  </dd> </dl>
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

        /// <summary>
        /// Gets and sets the property TargetTable. 
        /// <para>
        /// A <code>TableIdentifier</code> structure that describes a target table for resource
        /// linking.
        /// </para>
        /// </summary>
        public TableIdentifier TargetTable
        {
            get { return this._targetTable; }
            set { this._targetTable = value; }
        }

        // Check to see if TargetTable property is set
        internal bool IsSetTargetTable()
        {
            return this._targetTable != null;
        }

        /// <summary>
        /// Gets and sets the property ViewExpandedText. 
        /// <para>
        /// Included for Apache Hive compatibility. Not used in the normal course of Glue operations.
        /// </para>
        /// </summary>
        [AWSProperty(Max=409600)]
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
        /// Included for Apache Hive compatibility. Not used in the normal course of Glue operations.
        /// If the table is a <code>VIRTUAL_VIEW</code>, certain Athena configuration encoded
        /// in base64.
        /// </para>
        /// </summary>
        [AWSProperty(Max=409600)]
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