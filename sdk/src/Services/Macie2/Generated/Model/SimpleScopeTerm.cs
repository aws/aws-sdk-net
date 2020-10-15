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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Specifies a property-based condition that determines whether an object is included
    /// or excluded from a classification job.
    /// </summary>
    public partial class SimpleScopeTerm
    {
        private JobComparator _comparator;
        private ScopeFilterKey _key;
        private List<string> _values = new List<string>();

        /// <summary>
        /// Gets and sets the property Comparator. 
        /// <para>
        /// The operator to use in the condition. Valid operators for each supported property
        /// (key) are:
        /// </para>
        ///  <ul><li>
        /// <para>
        /// OBJECT_EXTENSION - EQ (equals) or NE (not equals)
        /// </para>
        /// </li> <li>
        /// <para>
        /// OBJECT_LAST_MODIFIED_DATE - Any operator except CONTAINS
        /// </para>
        /// </li> <li>
        /// <para>
        /// OBJECT_SIZE - Any operator except CONTAINS
        /// </para>
        /// </li> <li>
        /// <para>
        /// TAG - EQ (equals) or NE (not equals)
        /// </para>
        /// </li></ul>
        /// </summary>
        public JobComparator Comparator
        {
            get { return this._comparator; }
            set { this._comparator = value; }
        }

        // Check to see if Comparator property is set
        internal bool IsSetComparator()
        {
            return this._comparator != null;
        }

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The object property to use in the condition.
        /// </para>
        /// </summary>
        public ScopeFilterKey Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// An array that lists the values to use in the condition. If the value for the key property
        /// is OBJECT_EXTENSION, this array can specify multiple values and Amazon Macie uses
        /// an OR operator to join the values. Otherwise, this array can specify only one value.
        /// Valid values for each supported property (key) are:
        /// </para>
        ///  <ul><li>
        /// <para>
        /// OBJECT_EXTENSION - A string that represents the file name extension of an object.
        /// For example: doc, docx, pdf
        /// </para>
        /// </li> <li>
        /// <para>
        /// OBJECT_LAST_MODIFIED_DATE - The date and time (in UTC and extended ISO 8601 format)
        /// when an object was created or last changed, whichever is latest. For example: 2020-09-28T14:31:13Z
        /// </para>
        /// </li> <li>
        /// <para>
        /// OBJECT_SIZE - An integer that represents the storage size (in bytes) of an object.
        /// </para>
        /// </li> <li>
        /// <para>
        /// TAG - A string that represents a tag key for an object. For advanced options, use
        /// a TagScopeTerm object, instead of a SimpleScopeTerm object, to define a tag-based
        /// condition for the job.
        /// </para>
        /// </li></ul>
        /// </summary>
        public List<string> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null && this._values.Count > 0; 
        }

    }
}