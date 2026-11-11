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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Defines validation rules for data table attribute values. Based on JSON Schema Draft
    /// 2020-12 with additional Connect-specific validations. Validation rules ensure data
    /// integrity and consistency across the data table.
    /// </summary>
    public partial class Validation
    {
        /// <summary>
        /// Gets and sets the property Enum. 
        /// <para>
        /// Defines enumeration constraints for attribute values. Can specify a list of allowed
        /// values and whether custom values are permitted beyond the enumerated list.
        /// </para>
        /// </summary>
        public ValidationEnum Enum { get; set; }

        /// <summary>
        /// Checks to see if the Enum property is set.
        /// </summary>
        internal bool IsSetEnum() => this.Enum != null;

        /// <summary>
        /// Gets and sets the property ExclusiveMaximum. 
        /// <para>
        /// The largest exclusive numeric value for NUMBER value type. Can be provided alongside
        /// Maximum where both operate independently. Must be greater than ExclusiveMinimum and
        /// Minimum. Applies to NUMBER and values within NUMBER_LIST.
        /// </para>
        /// </summary>
        public double? ExclusiveMaximum { get; set; }

        /// <summary>
        /// Checks to see if the ExclusiveMaximum property is set.
        /// </summary>
        internal bool IsSetExclusiveMaximum() => this.ExclusiveMaximum.HasValue;

        /// <summary>
        /// Gets and sets the property ExclusiveMinimum. 
        /// <para>
        /// The smallest exclusive numeric value for NUMBER value type. Can be provided alongside
        /// Minimum where both operate independently. Must be less than ExclusiveMaximum and Maximum.
        /// Applies to NUMBER and values within NUMBER_LIST.
        /// </para>
        /// </summary>
        public double? ExclusiveMinimum { get; set; }

        /// <summary>
        /// Checks to see if the ExclusiveMinimum property is set.
        /// </summary>
        internal bool IsSetExclusiveMinimum() => this.ExclusiveMinimum.HasValue;

        /// <summary>
        /// Gets and sets the property IgnoreCase. 
        /// <para>
        /// Boolean that defaults to false. Applies to text lists and text primary attributes.
        /// When true, enforces case-insensitive uniqueness for primary attributes and allows
        /// case-insensitive lookups.
        /// </para>
        /// </summary>
        public bool? IgnoreCase { get; set; }

        /// <summary>
        /// Checks to see if the IgnoreCase property is set.
        /// </summary>
        internal bool IsSetIgnoreCase() => this.IgnoreCase.HasValue;

        /// <summary>
        /// Gets and sets the property MaxLength. 
        /// <para>
        /// The maximum number of characters a text value can contain. Applies to TEXT value type
        /// and values within a TEXT_LIST. Must be greater than or equal to MinLength.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public int? MaxLength { get; set; }

        /// <summary>
        /// Checks to see if the MaxLength property is set.
        /// </summary>
        internal bool IsSetMaxLength() => this.MaxLength.HasValue;

        /// <summary>
        /// Gets and sets the property MaxValues. 
        /// <para>
        /// The maximum number of values in a list. Must be an integer greater than or equal to
        /// 0 and greater than or equal to MinValues. Applies to all list types.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public int? MaxValues { get; set; }

        /// <summary>
        /// Checks to see if the MaxValues property is set.
        /// </summary>
        internal bool IsSetMaxValues() => this.MaxValues.HasValue;

        /// <summary>
        /// Gets and sets the property Maximum. 
        /// <para>
        /// The largest inclusive numeric value for NUMBER value type. Can be provided alongside
        /// ExclusiveMaximum where both operate independently. Must be greater than or equal to
        /// Minimum and greater than ExclusiveMinimum. Applies to NUMBER and values within NUMBER_LIST.
        /// </para>
        /// </summary>
        public double? Maximum { get; set; }

        /// <summary>
        /// Checks to see if the Maximum property is set.
        /// </summary>
        internal bool IsSetMaximum() => this.Maximum.HasValue;

        /// <summary>
        /// Gets and sets the property MinLength. 
        /// <para>
        /// The minimum number of characters a text value can contain. Applies to TEXT value type
        /// and values within a TEXT_LIST. Must be less than or equal to MaxLength.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public int? MinLength { get; set; }

        /// <summary>
        /// Checks to see if the MinLength property is set.
        /// </summary>
        internal bool IsSetMinLength() => this.MinLength.HasValue;

        /// <summary>
        /// Gets and sets the property MinValues. 
        /// <para>
        /// The minimum number of values in a list. Must be an integer greater than or equal to
        /// 0 and less than or equal to MaxValues. Applies to all list types.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public int? MinValues { get; set; }

        /// <summary>
        /// Checks to see if the MinValues property is set.
        /// </summary>
        internal bool IsSetMinValues() => this.MinValues.HasValue;

        /// <summary>
        /// Gets and sets the property Minimum. 
        /// <para>
        /// The smallest inclusive numeric value for NUMBER value type. Cannot be provided when
        /// ExclusiveMinimum is also provided. Must be less than or equal to Maximum and less
        /// than ExclusiveMaximum. Applies to NUMBER and values within NUMBER_LIST.
        /// </para>
        /// </summary>
        public double? Minimum { get; set; }

        /// <summary>
        /// Checks to see if the Minimum property is set.
        /// </summary>
        internal bool IsSetMinimum() => this.Minimum.HasValue;

        /// <summary>
        /// Gets and sets the property MultipleOf. 
        /// <para>
        /// Specifies that numeric values must be multiples of this number. Must be greater than
        /// 0. The result of dividing a value by this multiple must result in an integer. Applies
        /// to NUMBER and values within NUMBER_LIST.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public double? MultipleOf { get; set; }

        /// <summary>
        /// Checks to see if the MultipleOf property is set.
        /// </summary>
        internal bool IsSetMultipleOf() => this.MultipleOf.HasValue;
    }
}
