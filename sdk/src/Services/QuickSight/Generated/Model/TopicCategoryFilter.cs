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
    /// A structure that represents a category filter.
    /// </summary>
    public partial class TopicCategoryFilter
    {
        private CategoryFilterFunction _categoryFilterFunction;
        private CategoryFilterType _categoryFilterType;
        private TopicCategoryFilterConstant _constant;
        private bool? _inverse;

        /// <summary>
        /// Gets and sets the property CategoryFilterFunction. 
        /// <para>
        /// The category filter function. Valid values for this structure are <c>EXACT</c> and
        /// <c>CONTAINS</c>.
        /// </para>
        /// </summary>
        public CategoryFilterFunction CategoryFilterFunction
        {
            get { return this._categoryFilterFunction; }
            set { this._categoryFilterFunction = value; }
        }

        // Check to see if CategoryFilterFunction property is set
        internal bool IsSetCategoryFilterFunction()
        {
            return this._categoryFilterFunction != null;
        }

        /// <summary>
        /// Gets and sets the property CategoryFilterType. 
        /// <para>
        /// The category filter type. This element is used to specify whether a filter is a simple
        /// category filter or an inverse category filter.
        /// </para>
        /// </summary>
        public CategoryFilterType CategoryFilterType
        {
            get { return this._categoryFilterType; }
            set { this._categoryFilterType = value; }
        }

        // Check to see if CategoryFilterType property is set
        internal bool IsSetCategoryFilterType()
        {
            return this._categoryFilterType != null;
        }

        /// <summary>
        /// Gets and sets the property Constant. 
        /// <para>
        /// The constant used in a category filter.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public TopicCategoryFilterConstant Constant
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

    }
}