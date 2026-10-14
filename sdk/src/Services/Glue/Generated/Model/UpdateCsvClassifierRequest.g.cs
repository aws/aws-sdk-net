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
    /// Specifies a custom CSV classifier to be updated.
    /// </summary>
    public partial class UpdateCsvClassifierRequest
    {
        /// <summary>
        /// Gets and sets the property AllowSingleColumn. 
        /// <para>
        /// Enables the processing of files that contain only one column.
        /// </para>
        /// </summary>
        public bool? AllowSingleColumn { get; set; }

        /// <summary>
        /// Checks to see if the AllowSingleColumn property is set.
        /// </summary>
        internal bool IsSetAllowSingleColumn() => this.AllowSingleColumn.HasValue;

        /// <summary>
        /// Gets and sets the property ContainsHeader. 
        /// <para>
        /// Indicates whether the CSV file contains a header.
        /// </para>
        /// </summary>
        public CsvHeaderOption ContainsHeader { get; set; }

        /// <summary>
        /// Checks to see if the ContainsHeader property is set.
        /// </summary>
        internal bool IsSetContainsHeader() => this.ContainsHeader != null;

        /// <summary>
        /// Gets and sets the property CustomDatatypeConfigured. 
        /// <para>
        /// Specifies the configuration of custom datatypes.
        /// </para>
        /// </summary>
        public bool? CustomDatatypeConfigured { get; set; }

        /// <summary>
        /// Checks to see if the CustomDatatypeConfigured property is set.
        /// </summary>
        internal bool IsSetCustomDatatypeConfigured() => this.CustomDatatypeConfigured.HasValue;

        /// <summary>
        /// Gets and sets the property CustomDatatypes. 
        /// <para>
        /// Specifies a list of supported custom datatypes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> CustomDatatypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the CustomDatatypes property is set.
        /// </summary>
        internal bool IsSetCustomDatatypes() => this.CustomDatatypes != null && (this.CustomDatatypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Delimiter. 
        /// <para>
        /// A custom symbol to denote what separates each column entry in the row.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1)]
        public string Delimiter { get; set; }

        /// <summary>
        /// Checks to see if the Delimiter property is set.
        /// </summary>
        internal bool IsSetDelimiter() => this.Delimiter != null;

        /// <summary>
        /// Gets and sets the property DisableValueTrimming. 
        /// <para>
        /// Specifies not to trim values before identifying the type of column values. The default
        /// value is true.
        /// </para>
        /// </summary>
        public bool? DisableValueTrimming { get; set; }

        /// <summary>
        /// Checks to see if the DisableValueTrimming property is set.
        /// </summary>
        internal bool IsSetDisableValueTrimming() => this.DisableValueTrimming.HasValue;

        /// <summary>
        /// Gets and sets the property Header. 
        /// <para>
        /// A list of strings representing column names.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Header { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Header property is set.
        /// </summary>
        internal bool IsSetHeader() => this.Header != null && (this.Header.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the classifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property QuoteSymbol. 
        /// <para>
        /// A custom symbol to denote what combines content into a single column value. It must
        /// be different from the column delimiter.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1)]
        public string QuoteSymbol { get; set; }

        /// <summary>
        /// Checks to see if the QuoteSymbol property is set.
        /// </summary>
        internal bool IsSetQuoteSymbol() => this.QuoteSymbol != null;

        /// <summary>
        /// Gets and sets the property Serde. 
        /// <para>
        /// Sets the SerDe for processing CSV in the classifier, which will be applied in the
        /// Data Catalog. Valid values are <c>OpenCSVSerDe</c>, <c>LazySimpleSerDe</c>, and <c>None</c>.
        /// You can specify the <c>None</c> value when you want the crawler to do the detection.
        /// </para>
        /// </summary>
        public CsvSerdeOption Serde { get; set; }

        /// <summary>
        /// Checks to see if the Serde property is set.
        /// </summary>
        internal bool IsSetSerde() => this.Serde != null;
    }
}
