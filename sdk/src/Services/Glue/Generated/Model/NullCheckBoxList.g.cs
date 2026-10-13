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
    /// Represents whether certain values are recognized as null values for removal.
    /// </summary>
    public partial class NullCheckBoxList
    {
        /// <summary>
        /// Gets and sets the property IsEmpty. 
        /// <para>
        /// Specifies that an empty string is considered as a null value.
        /// </para>
        /// </summary>
        public bool? IsEmpty { get; set; }

        /// <summary>
        /// Checks to see if the IsEmpty property is set.
        /// </summary>
        internal bool IsSetIsEmpty() => this.IsEmpty.HasValue;

        /// <summary>
        /// Gets and sets the property IsNegOne. 
        /// <para>
        /// Specifies that an integer value of -1 is considered as a null value.
        /// </para>
        /// </summary>
        public bool? IsNegOne { get; set; }

        /// <summary>
        /// Checks to see if the IsNegOne property is set.
        /// </summary>
        internal bool IsSetIsNegOne() => this.IsNegOne.HasValue;

        /// <summary>
        /// Gets and sets the property IsNullString. 
        /// <para>
        /// Specifies that a value spelling out the word 'null' is considered as a null value.
        /// </para>
        /// </summary>
        public bool? IsNullString { get; set; }

        /// <summary>
        /// Checks to see if the IsNullString property is set.
        /// </summary>
        internal bool IsSetIsNullString() => this.IsNullString.HasValue;
    }
}
