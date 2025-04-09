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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Represents the total number of matching results and indicates how accurate that count
    /// is.
    /// 
    ///  
    /// <para>
    /// The <c>Value</c> field provides the count, which may be exact or estimated. The <c>Relation</c>
    /// field indicates whether it's an exact figure or a lower bound. This helps understand
    /// the full scope of search results, especially when dealing with large result sets.
    /// </para>
    /// </summary>
    public partial class TotalHits
    {
        private Relation _relation;
        private long? _value;

        /// <summary>
        /// Gets and sets the property Relation. 
        /// <para>
        /// Indicates the relationship between the returned <c>Value</c> and the actual total
        /// number of matching results. Possible values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>EqualTo</c>: The <c>Value</c> is the exact count of matching results.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>GreaterThanOrEqualTo</c>: The <c>Value</c> is a lower bound of the actual count
        /// of matching results.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public Relation Relation
        {
            get { return this._relation; }
            set { this._relation = value; }
        }

        // Check to see if Relation property is set
        internal bool IsSetRelation()
        {
            return this._relation != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The total number of matching results. This value may be exact or an estimate, depending
        /// on the <c>Relation</c> field.
        /// </para>
        /// </summary>
        public long? Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value.HasValue; 
        }

    }
}