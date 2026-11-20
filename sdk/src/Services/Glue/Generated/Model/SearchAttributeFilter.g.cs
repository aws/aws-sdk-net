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
    /// A filter that compares an attribute value using an operator.
    /// </summary>
    public partial class SearchAttributeFilter
    {
        /// <summary>
        /// Gets and sets the property Attribute. 
        /// <para>
        /// The attribute name to filter on.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string Attribute { get; set; }

        /// <summary>
        /// Checks to see if the Attribute property is set.
        /// </summary>
        internal bool IsSetAttribute() => this.Attribute != null;

        /// <summary>
        /// Gets and sets the property Comparator. 
        /// <para>
        /// The comparison operator. Valid values are <c>EQUALS</c>, <c>GREATER_THAN</c>, <c>GREATER_THAN_OR_EQUALS</c>,
        /// <c>LESS_THAN</c>, <c>LESS_THAN_OR_EQUALS</c>, and <c>NOT_EXISTS</c>. This field is
        /// required.
        /// </para>
        /// </summary>
        public SearchFilterComparator Comparator { get; set; }

        /// <summary>
        /// Checks to see if the Comparator property is set.
        /// </summary>
        internal bool IsSetComparator() => this.Comparator != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value to compare against.
        /// </para>
        /// </summary>
        public SearchFilterValue Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}
