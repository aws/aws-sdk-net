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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// A multi-expression that searches for the specified resource or resources in a search.
    /// All resource objects that satisfy the expression's condition are included in the search
    /// results. You must specify at least one subexpression, filter, or nested filter. A
    /// <c>SearchExpression</c> can contain up to twenty elements.
    /// 
    ///  
    /// <para>
    /// A <c>SearchExpression</c> contains the following components:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// A list of <c>Filter</c> objects. Each filter defines a simple Boolean expression comprised
    /// of a resource property name, Boolean operator, and value.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A list of <c>NestedFilter</c> objects. Each nested filter defines a list of Boolean
    /// expressions using a list of resource properties. A nested filter is satisfied if a
    /// single object in the list satisfies all Boolean expressions.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A list of <c>SearchExpression</c> objects. A search expression object can be nested
    /// in a list of search expression objects.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A Boolean operator: <c>And</c> or <c>Or</c>.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class SearchExpression
    {
        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// A list of filter objects.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public List<Filter> Filters { get; set; } = AWSConfigs.InitializeCollections ? new List<Filter>() : null;

        /// <summary>
        /// Checks to see if the Filters property is set.
        /// </summary>
        internal bool IsSetFilters() => this.Filters != null && (this.Filters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NestedFilters. 
        /// <para>
        /// A list of nested filter objects.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public List<NestedFilters> NestedFilters { get; set; } = AWSConfigs.InitializeCollections ? new List<NestedFilters>() : null;

        /// <summary>
        /// Checks to see if the NestedFilters property is set.
        /// </summary>
        internal bool IsSetNestedFilters() => this.NestedFilters != null && (this.NestedFilters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Operator. 
        /// <para>
        /// A Boolean operator used to evaluate the search expression. If you want every conditional
        /// statement in all lists to be satisfied for the entire search expression to be true,
        /// specify <c>And</c>. If only a single conditional statement needs to be true for the
        /// entire search expression to be true, specify <c>Or</c>. The default value is <c>And</c>.
        /// </para>
        /// </summary>
        public BooleanOperator Operator { get; set; }

        /// <summary>
        /// Checks to see if the Operator property is set.
        /// </summary>
        internal bool IsSetOperator() => this.Operator != null;

        /// <summary>
        /// Gets and sets the property SubExpressions. 
        /// <para>
        /// A list of search expression objects.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public List<SearchExpression> SubExpressions { get; set; } = AWSConfigs.InitializeCollections ? new List<SearchExpression>() : null;

        /// <summary>
        /// Checks to see if the SubExpressions property is set.
        /// </summary>
        internal bool IsSetSubExpressions() => this.SubExpressions != null && (this.SubExpressions.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
