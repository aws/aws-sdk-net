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
    /// A datetime search condition for Search APIs.
    /// </summary>
    public partial class DateTimeCondition
    {
        /// <summary>
        /// Gets and sets the property ComparisonType. 
        /// <para>
        /// Datetime property comparison type.
        /// </para>
        /// </summary>
        public DateTimeComparisonType ComparisonType { get; set; }

        /// <summary>
        /// Checks to see if the ComparisonType property is set.
        /// </summary>
        internal bool IsSetComparisonType() => this.ComparisonType != null;

        /// <summary>
        /// Gets and sets the property FieldName. 
        /// <para>
        /// A name of the datetime property to be searched
        /// </para>
        /// </summary>
        public string FieldName { get; set; }

        /// <summary>
        /// Checks to see if the FieldName property is set.
        /// </summary>
        internal bool IsSetFieldName() => this.FieldName != null;

        /// <summary>
        /// Gets and sets the property MaxValue. 
        /// <para>
        /// A maximum value of the property.
        /// </para>
        /// </summary>
        public string MaxValue { get; set; }

        /// <summary>
        /// Checks to see if the MaxValue property is set.
        /// </summary>
        internal bool IsSetMaxValue() => this.MaxValue != null;

        /// <summary>
        /// Gets and sets the property MinValue. 
        /// <para>
        /// A minimum value of the property.
        /// </para>
        /// </summary>
        public string MinValue { get; set; }

        /// <summary>
        /// Checks to see if the MinValue property is set.
        /// </summary>
        internal bool IsSetMinValue() => this.MinValue != null;
    }
}
