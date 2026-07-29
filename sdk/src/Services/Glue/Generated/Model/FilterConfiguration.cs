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
    /// Configuration that defines how filter predicates are applied to REST API requests,
    /// supporting both query parameter and filter string strategies.
    /// </summary>
    public partial class FilterConfiguration
    {
        private BetweenConfiguration _betweenConfiguration;
        private string _dateTimeFormat;
        private FilterMode _filterMode;
        private FilterStringConfiguration _filterStringConfiguration;
        private Dictionary<string, string> _operatorMappings = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private bool? _stripQuotes;

        /// <summary>
        /// Gets and sets the property BetweenConfiguration. 
        /// <para>
        /// Configuration for handling BETWEEN range filter operations.
        /// </para>
        /// </summary>
        public BetweenConfiguration BetweenConfiguration
        {
            get { return this._betweenConfiguration; }
            set { this._betweenConfiguration = value; }
        }

        // Check to see if BetweenConfiguration property is set
        internal bool IsSetBetweenConfiguration()
        {
            return this._betweenConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property DateTimeFormat. 
        /// <para>
        /// The global date and time format for filter expressions. Accepts Java <c>DateTimeFormatter</c>
        /// patterns (for example, <c>EEE, d MMM yyyy HH:mm:ss Z</c>), <c>EPOCH_SECONDS</c> for
        /// Unix epoch seconds, or <c>EPOCH_MILLIS</c> for Unix epoch milliseconds. If not specified,
        /// values are passed as-is in ISO-8601 format.
        /// </para>
        /// </summary>
        public string DateTimeFormat
        {
            get { return this._dateTimeFormat; }
            set { this._dateTimeFormat = value; }
        }

        // Check to see if DateTimeFormat property is set
        internal bool IsSetDateTimeFormat()
        {
            return this._dateTimeFormat != null;
        }

        /// <summary>
        /// Gets and sets the property FilterMode. 
        /// <para>
        /// The strategy for applying filters to requests. Use <c>QUERY_PARAMS</c> to pass filters
        /// as individual query parameters, or <c>FILTER_STRING</c> to construct a single filter
        /// expression string.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FilterMode FilterMode
        {
            get { return this._filterMode; }
            set { this._filterMode = value; }
        }

        // Check to see if FilterMode property is set
        internal bool IsSetFilterMode()
        {
            return this._filterMode != null;
        }

        /// <summary>
        /// Gets and sets the property FilterStringConfiguration. 
        /// <para>
        /// Configuration for constructing filter expressions when <c>FilterMode</c> is set to
        /// <c>FILTER_STRING</c>.
        /// </para>
        /// </summary>
        public FilterStringConfiguration FilterStringConfiguration
        {
            get { return this._filterStringConfiguration; }
            set { this._filterStringConfiguration = value; }
        }

        // Check to see if FilterStringConfiguration property is set
        internal bool IsSetFilterStringConfiguration()
        {
            return this._filterStringConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property OperatorMappings. 
        /// <para>
        /// A map of logical filter operators to their API-specific string representations. Supported
        /// operator keys are: <c>EQUAL_TO</c>, <c>NOT_EQUAL_TO</c>, <c>LESS_THAN</c>, <c>GREATER_THAN</c>,
        /// <c>LESS_THAN_OR_EQUAL_TO</c>, <c>GREATER_THAN_OR_EQUAL_TO</c>, <c>CONTAINS</c>, <c>BETWEEN</c>,
        /// <c>AND</c>, and <c>OR</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> OperatorMappings
        {
            get { return this._operatorMappings; }
            set { this._operatorMappings = value; }
        }

        // Check to see if OperatorMappings property is set
        internal bool IsSetOperatorMappings()
        {
            return this._operatorMappings != null && (this._operatorMappings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StripQuotes. 
        /// <para>
        /// Indicates whether surrounding double quotes should be stripped from filter values
        /// before processing.
        /// </para>
        /// </summary>
        public bool? StripQuotes
        {
            get { return this._stripQuotes; }
            set { this._stripQuotes = value; }
        }

        // Check to see if StripQuotes property is set
        internal bool IsSetStripQuotes()
        {
            return this._stripQuotes.HasValue; 
        }

    }
}