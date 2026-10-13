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
    /// Configuration that defines per-field overrides for filter behavior, allowing individual
    /// fields to customize how filter operations are applied.
    /// </summary>
    public partial class FilterOverrides
    {
        /// <summary>
        /// Gets and sets the property BetweenConfiguration. 
        /// <para>
        /// Field-specific configuration for handling BETWEEN range filter operations.
        /// </para>
        /// </summary>
        public BetweenConfiguration BetweenConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the BetweenConfiguration property is set.
        /// </summary>
        internal bool IsSetBetweenConfiguration() => this.BetweenConfiguration != null;

        /// <summary>
        /// Gets and sets the property DateTimeFormat. 
        /// <para>
        /// The date and time format for filter expressions on this field, overriding the global
        /// <c>DateTimeFormat</c>. Accepts Java <c>DateTimeFormatter</c> patterns (for example,
        /// <c>EEE, d MMM yyyy HH:mm:ss Z</c>), <c>EPOCH_SECONDS</c> for Unix epoch seconds, or
        /// <c>EPOCH_MILLIS</c> for Unix epoch milliseconds.
        /// </para>
        /// </summary>
        public string DateTimeFormat { get; set; }

        /// <summary>
        /// Checks to see if the DateTimeFormat property is set.
        /// </summary>
        internal bool IsSetDateTimeFormat() => this.DateTimeFormat != null;

        /// <summary>
        /// Gets and sets the property FieldName. 
        /// <para>
        /// An override for the field name to use in filter expressions, if different from the
        /// schema field name.
        /// </para>
        /// </summary>
        public string FieldName { get; set; }

        /// <summary>
        /// Checks to see if the FieldName property is set.
        /// </summary>
        internal bool IsSetFieldName() => this.FieldName != null;

        /// <summary>
        /// Gets and sets the property OperatorMappings. 
        /// <para>
        /// A map of logical filter operators to their field-specific API representations, overriding
        /// the global operator mappings. Supported operator keys are: <c>EQUAL_TO</c>, <c>NOT_EQUAL_TO</c>,
        /// <c>LESS_THAN</c>, <c>GREATER_THAN</c>, <c>LESS_THAN_OR_EQUAL_TO</c>, <c>GREATER_THAN_OR_EQUAL_TO</c>,
        /// <c>CONTAINS</c>, <c>BETWEEN</c>, <c>AND</c>, and <c>OR</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> OperatorMappings { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the OperatorMappings property is set.
        /// </summary>
        internal bool IsSetOperatorMappings() => this.OperatorMappings != null && (this.OperatorMappings.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
