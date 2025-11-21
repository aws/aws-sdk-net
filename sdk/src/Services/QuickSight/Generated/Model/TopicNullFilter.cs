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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The structure that represents a null filter.
    /// </summary>
    public partial class TopicNullFilter
    {
        private TopicSingularFilterConstant _constant;
        private bool? _inverse;
        private NullFilterType _nullFilterType;

        /// <summary>
        /// Gets and sets the property Constant.
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public TopicSingularFilterConstant Constant
        {
            get { return this._constant; }
            set { this._constant = value; }
        }

        // Check to see if Constant property is set
        internal bool IsSetConstant()
        {
            return this._constant != null;
        }

        /// <summary>
        /// Gets and sets the property Inverse. 
        /// <para>
        /// A Boolean value that indicates if the filter is inverse.
        /// </para>
        /// </summary>
        public bool? Inverse
        {
            get { return this._inverse; }
            set { this._inverse = value; }
        }

        // Check to see if Inverse property is set
        internal bool IsSetInverse()
        {
            return this._inverse.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NullFilterType. 
        /// <para>
        /// The type of the null filter. Valid values for this type are <c>NULLS_ONLY</c>, <c>NON_NULLS_ONLY</c>,
        /// and <c>ALL_VALUES</c>.
        /// </para>
        /// </summary>
        public NullFilterType NullFilterType
        {
            get { return this._nullFilterType; }
            set { this._nullFilterType = value; }
        }

        // Check to see if NullFilterType property is set
        internal bool IsSetNullFilterType()
        {
            return this._nullFilterType != null;
        }

    }
}