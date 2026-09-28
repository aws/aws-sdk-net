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

namespace Amazon.DataZone.Model
{
    /// <summary>
    /// A search filter in Amazon DataZone.
    /// </summary>
    public partial class Filter
    {
        /// <summary>
        /// Gets and sets the property Attribute. 
        /// <para>
        /// A search filter attribute in Amazon DataZone.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string Attribute { get; set; }

        /// <summary>
        /// Checks to see if the Attribute property is set.
        /// </summary>
        internal bool IsSetAttribute() => this.Attribute != null;

        /// <summary>
        /// Gets and sets the property IntValue. 
        /// <para>
        /// A search filter integer value in Amazon DataZone.
        /// </para>
        /// </summary>
        public long? IntValue { get; set; }

        /// <summary>
        /// Checks to see if the IntValue property is set.
        /// </summary>
        internal bool IsSetIntValue() => this.IntValue.HasValue;

        /// <summary>
        /// Gets and sets the property Operator. 
        /// <para>
        /// Specifies the search filter operator.
        /// </para>
        /// </summary>
        public FilterOperator Operator { get; set; }

        /// <summary>
        /// Checks to see if the Operator property is set.
        /// </summary>
        internal bool IsSetOperator() => this.Operator != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// A search filter string value in Amazon DataZone.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 128)]
        public string Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}
