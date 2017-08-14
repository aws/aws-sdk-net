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
    /// Describes the physical storage of table data.
    /// </summary>
    public partial class StorageDescriptor
    {
        private List<string> _bucketColumns = new List<string>();
        private List<Column> _columns = new List<Column>();
        private bool? _compressed;
        private string _inputFormat;
        private string _location;
        private int? _numberOfBuckets;
        private string _outputFormat;
        private Dictionary<string, string> _parameters = new Dictionary<string, string>();
        private SerDeInfo _serdeInfo;
        private SkewedInfo _skewedInfo;
        private List<Order> _sortColumns = new List<Order>();
        private bool? _storedAsSubDirectories;

        /// <summary>
        /// Gets and sets the property BucketColumns. 
        /// <para>
        /// A list of reducer grouping columns, clustering columns, and bucketing columns in the
        /// table.
        /// </para>
        /// </summary>
        public List<string> BucketColumns
        {
            get { return this._bucketColumns; }
            set { this._bucketColumns = value; }
        }

        // Check to see if BucketColumns property is set
        internal bool IsSetBucketColumns()
        {
            return this._bucketColumns != null && this._bucketColumns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Columns. 
        /// <para>
        /// A list of the <code>Columns</code> in the table.
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
        /// Gets and sets the property Compressed. 
        /// <para>
        /// True if the data in the table is compressed, or False if not.
        /// </para>
        /// </summary>
        public bool Compressed
        {
            get { return this._compressed.GetValueOrDefault(); }
            set { this._compressed = value; }
        }

        // Check to see if Compressed property is set
        internal bool IsSetCompressed()
        {
            return this._compressed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InputFormat. 
        /// <para>
        /// The input format: <code>SequenceFileInputFormat</code> (binary), or <code>TextInputFormat</code>,
        /// or a custom format.
        /// </para>
        /// </summary>
        public string InputFormat
        {
            get { return this._inputFormat; }
            set { this._inputFormat = value; }
        }

        // Check to see if InputFormat property is set
        internal bool IsSetInputFormat()
        {
            return this._inputFormat != null;
        }

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The physical location of the table. By default this takes the form of the warehouse
        /// location, followed by the database location in the warehouse, followed by the table
        /// name.
        /// </para>
        /// </summary>
        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

        /// <summary>
        /// Gets and sets the property NumberOfBuckets. 
        /// <para>
        /// Must be specified if the table contains any dimension columns.
        /// </para>
        /// </summary>
        public int NumberOfBuckets
        {
            get { return this._numberOfBuckets.GetValueOrDefault(); }
            set { this._numberOfBuckets = value; }
        }

        // Check to see if NumberOfBuckets property is set
        internal bool IsSetNumberOfBuckets()
        {
            return this._numberOfBuckets.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OutputFormat. 
        /// <para>
        /// The output format: <code>SequenceFileOutputFormat</code> (binary), or <code>IgnoreKeyTextOutputFormat</code>,
        /// or a custom format.
        /// </para>
        /// </summary>
        public string OutputFormat
        {
            get { return this._outputFormat; }
            set { this._outputFormat = value; }
        }

        // Check to see if OutputFormat property is set
        internal bool IsSetOutputFormat()
        {
            return this._outputFormat != null;
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// User-supplied properties in key-value form.
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
        /// Gets and sets the property SerdeInfo. 
        /// <para>
        /// Serialization/deserialization (SerDe) information.
        /// </para>
        /// </summary>
        public SerDeInfo SerdeInfo
        {
            get { return this._serdeInfo; }
            set { this._serdeInfo = value; }
        }

        // Check to see if SerdeInfo property is set
        internal bool IsSetSerdeInfo()
        {
            return this._serdeInfo != null;
        }

        /// <summary>
        /// Gets and sets the property SkewedInfo. 
        /// <para>
        /// Information about values that appear very frequently in a column (skewed values).
        /// </para>
        /// </summary>
        public SkewedInfo SkewedInfo
        {
            get { return this._skewedInfo; }
            set { this._skewedInfo = value; }
        }

        // Check to see if SkewedInfo property is set
        internal bool IsSetSkewedInfo()
        {
            return this._skewedInfo != null;
        }

        /// <summary>
        /// Gets and sets the property SortColumns. 
        /// <para>
        /// A list specifying the sort order of each bucket in the table.
        /// </para>
        /// </summary>
        public List<Order> SortColumns
        {
            get { return this._sortColumns; }
            set { this._sortColumns = value; }
        }

        // Check to see if SortColumns property is set
        internal bool IsSetSortColumns()
        {
            return this._sortColumns != null && this._sortColumns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StoredAsSubDirectories. 
        /// <para>
        /// True if the table data is stored in subdirectories, or False if not.
        /// </para>
        /// </summary>
        public bool StoredAsSubDirectories
        {
            get { return this._storedAsSubDirectories.GetValueOrDefault(); }
            set { this._storedAsSubDirectories = value; }
        }

        // Check to see if StoredAsSubDirectories property is set
        internal bool IsSetStoredAsSubDirectories()
        {
            return this._storedAsSubDirectories.HasValue; 
        }

    }
}