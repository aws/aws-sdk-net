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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// A structure that represents a category filter.
    /// </summary>
    public partial class TopicCategoryFilter
    {
        /// <summary>
        /// Gets and sets the property CategoryFilterFunction. 
        /// <para>
        /// The category filter function. Valid values for this structure are <c>EXACT</c> and
        /// <c>CONTAINS</c>.
        /// </para>
        /// </summary>
        public CategoryFilterFunction CategoryFilterFunction { get; set; }

        /// <summary>
        /// Checks to see if the CategoryFilterFunction property is set.
        /// </summary>
        internal bool IsSetCategoryFilterFunction() => this.CategoryFilterFunction != null;

        /// <summary>
        /// Gets and sets the property CategoryFilterType. 
        /// <para>
        /// The category filter type. This element is used to specify whether a filter is a simple
        /// category filter or an inverse category filter.
        /// </para>
        /// </summary>
        public CategoryFilterType CategoryFilterType { get; set; }

        /// <summary>
        /// Checks to see if the CategoryFilterType property is set.
        /// </summary>
        internal bool IsSetCategoryFilterType() => this.CategoryFilterType != null;

        /// <summary>
        /// Gets and sets the property Constant. 
        /// <para>
        /// The constant used in a category filter.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public TopicCategoryFilterConstant Constant { get; set; }

        /// <summary>
        /// Checks to see if the Constant property is set.
        /// </summary>
        internal bool IsSetConstant() => this.Constant != null;

        /// <summary>
        /// Gets and sets the property Inverse. 
        /// <para>
        /// A Boolean value that indicates if the filter is inverse.
        /// </para>
        /// </summary>
        public bool? Inverse { get; set; }

        /// <summary>
        /// Checks to see if the Inverse property is set.
        /// </summary>
        internal bool IsSetInverse() => this.Inverse.HasValue;

        /// <summary>
        /// Gets and sets the property NullFilter. 
        /// <para>
        /// The <c>null</c> filter that is applied to the category filter.
        /// </para>
        /// </summary>
        public NullFilterType NullFilter { get; set; }

        /// <summary>
        /// Checks to see if the NullFilter property is set.
        /// </summary>
        internal bool IsSetNullFilter() => this.NullFilter != null;
    }
}
