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
    /// A classifier for custom <code>CSV</code> content.
    /// </summary>
    public partial class CsvClassifier
    {
        private bool? _allowSingleColumn;
        private CsvHeaderOption _containsHeader;
        private DateTime? _creationTime;
        private bool? _customDatatypeConfigured;
        private List<string> _customDatatypes = new List<string>();
        private string _delimiter;
        private bool? _disableValueTrimming;
        private List<string> _header = new List<string>();
        private DateTime? _lastUpdated;
        private string _name;
        private string _quoteSymbol;
        private long? _version;

        /// <summary>
        /// Gets and sets the property AllowSingleColumn. 
        /// <para>
        /// Enables the processing of files that contain only one column.
        /// </para>
        /// </summary>
        public bool AllowSingleColumn
        {
            get { return this._allowSingleColumn.GetValueOrDefault(); }
            set { this._allowSingleColumn = value; }
        }

        // Check to see if AllowSingleColumn property is set
        internal bool IsSetAllowSingleColumn()
        {
            return this._allowSingleColumn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ContainsHeader. 
        /// <para>
        /// Indicates whether the CSV file contains a header.
        /// </para>
        /// </summary>
        public CsvHeaderOption ContainsHeader
        {
            get { return this._containsHeader; }
            set { this._containsHeader = value; }
        }

        // Check to see if ContainsHeader property is set
        internal bool IsSetContainsHeader()
        {
            return this._containsHeader != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time that this classifier was registered.
        /// </para>
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CustomDatatypeConfigured. 
        /// <para>
        /// Enables the custom datatype to be configured.
        /// </para>
        /// </summary>
        public bool CustomDatatypeConfigured
        {
            get { return this._customDatatypeConfigured.GetValueOrDefault(); }
            set { this._customDatatypeConfigured = value; }
        }

        // Check to see if CustomDatatypeConfigured property is set
        internal bool IsSetCustomDatatypeConfigured()
        {
            return this._customDatatypeConfigured.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CustomDatatypes. 
        /// <para>
        /// A list of custom datatypes including "BINARY", "BOOLEAN", "DATE", "DECIMAL", "DOUBLE",
        /// "FLOAT", "INT", "LONG", "SHORT", "STRING", "TIMESTAMP".
        /// </para>
        /// </summary>
        public List<string> CustomDatatypes
        {
            get { return this._customDatatypes; }
            set { this._customDatatypes = value; }
        }

        // Check to see if CustomDatatypes property is set
        internal bool IsSetCustomDatatypes()
        {
            return this._customDatatypes != null && this._customDatatypes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Delimiter. 
        /// <para>
        /// A custom symbol to denote what separates each column entry in the row.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public string Delimiter
        {
            get { return this._delimiter; }
            set { this._delimiter = value; }
        }

        // Check to see if Delimiter property is set
        internal bool IsSetDelimiter()
        {
            return this._delimiter != null;
        }

        /// <summary>
        /// Gets and sets the property DisableValueTrimming. 
        /// <para>
        /// Specifies not to trim values before identifying the type of column values. The default
        /// value is <code>true</code>.
        /// </para>
        /// </summary>
        public bool DisableValueTrimming
        {
            get { return this._disableValueTrimming.GetValueOrDefault(); }
            set { this._disableValueTrimming = value; }
        }

        // Check to see if DisableValueTrimming property is set
        internal bool IsSetDisableValueTrimming()
        {
            return this._disableValueTrimming.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Header. 
        /// <para>
        /// A list of strings representing column names.
        /// </para>
        /// </summary>
        public List<string> Header
        {
            get { return this._header; }
            set { this._header = value; }
        }

        // Check to see if Header property is set
        internal bool IsSetHeader()
        {
            return this._header != null && this._header.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdated. 
        /// <para>
        /// The time that this classifier was last updated.
        /// </para>
        /// </summary>
        public DateTime LastUpdated
        {
            get { return this._lastUpdated.GetValueOrDefault(); }
            set { this._lastUpdated = value; }
        }

        // Check to see if LastUpdated property is set
        internal bool IsSetLastUpdated()
        {
            return this._lastUpdated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the classifier.
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
        /// Gets and sets the property QuoteSymbol. 
        /// <para>
        /// A custom symbol to denote what combines content into a single column value. It must
        /// be different from the column delimiter.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public string QuoteSymbol
        {
            get { return this._quoteSymbol; }
            set { this._quoteSymbol = value; }
        }

        // Check to see if QuoteSymbol property is set
        internal bool IsSetQuoteSymbol()
        {
            return this._quoteSymbol != null;
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of this classifier.
        /// </para>
        /// </summary>
        public long Version
        {
            get { return this._version.GetValueOrDefault(); }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version.HasValue; 
        }

    }
}