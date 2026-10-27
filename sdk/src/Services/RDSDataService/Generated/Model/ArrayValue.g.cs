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

namespace Amazon.RDSDataService.Model
{
    /// <summary>
    /// Contains an array.
    /// </summary>
    public partial class ArrayValue
    {
        /// <summary>
        /// Gets and sets the property ArrayValues. 
        /// <para>
        /// An array of arrays. Can contain null values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ArrayValue> ArrayValues { get; set; } = AWSConfigs.InitializeCollections ? new List<ArrayValue>() : null;

        /// <summary>
        /// Checks to see if the ArrayValues property is set.
        /// </summary>
        internal bool IsSetArrayValues() => this.ArrayValues != null && (this.ArrayValues.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property BooleanValues. 
        /// <para>
        /// An array of Boolean values. Can contain null values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<bool?> BooleanValues { get; set; } = AWSConfigs.InitializeCollections ? new List<bool?>() : null;

        /// <summary>
        /// Checks to see if the BooleanValues property is set.
        /// </summary>
        internal bool IsSetBooleanValues() => this.BooleanValues != null && (this.BooleanValues.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DoubleValues. 
        /// <para>
        /// An array of floating-point numbers. Can contain null values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<double?> DoubleValues { get; set; } = AWSConfigs.InitializeCollections ? new List<double?>() : null;

        /// <summary>
        /// Checks to see if the DoubleValues property is set.
        /// </summary>
        internal bool IsSetDoubleValues() => this.DoubleValues != null && (this.DoubleValues.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LongValues. 
        /// <para>
        /// An array of integers. Can contain null values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<long?> LongValues { get; set; } = AWSConfigs.InitializeCollections ? new List<long?>() : null;

        /// <summary>
        /// Checks to see if the LongValues property is set.
        /// </summary>
        internal bool IsSetLongValues() => this.LongValues != null && (this.LongValues.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StringValues. 
        /// <para>
        /// An array of strings. Can contain null values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> StringValues { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the StringValues property is set.
        /// </summary>
        internal bool IsSetStringValues() => this.StringValues != null && (this.StringValues.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
