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
    /// Represents whether certain values are recognized as null values for removal.
    /// </summary>
    public partial class NullCheckBoxList
    {
        private bool? _isEmpty;
        private bool? _isNegOne;
        private bool? _isNullString;

        /// <summary>
        /// Gets and sets the property IsEmpty. 
        /// <para>
        /// Specifies that an empty string is considered as a null value.
        /// </para>
        /// </summary>
        public bool? IsEmpty
        {
            get { return this._isEmpty; }
            set { this._isEmpty = value; }
        }

        // Check to see if IsEmpty property is set
        internal bool IsSetIsEmpty()
        {
            return this._isEmpty.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsNegOne. 
        /// <para>
        /// Specifies that an integer value of -1 is considered as a null value.
        /// </para>
        /// </summary>
        public bool? IsNegOne
        {
            get { return this._isNegOne; }
            set { this._isNegOne = value; }
        }

        // Check to see if IsNegOne property is set
        internal bool IsSetIsNegOne()
        {
            return this._isNegOne.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsNullString. 
        /// <para>
        /// Specifies that a value spelling out the word 'null' is considered as a null value.
        /// </para>
        /// </summary>
        public bool? IsNullString
        {
            get { return this._isNullString; }
            set { this._isNullString = value; }
        }

        // Check to see if IsNullString property is set
        internal bool IsSetIsNullString()
        {
            return this._isNullString.HasValue; 
        }

    }
}