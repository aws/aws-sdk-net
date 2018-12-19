/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// A multi-expression that searches for the specified resource or resources in a search.
    /// All resource objects that satisfy the expression's condition are included in the search
    /// results. You must specify at least one subexpression, filter, or nested filter. A
    /// <code>SearchExpression</code> can contain up to twenty elements.
    /// 
    ///  
    /// <para>
    /// A <code>SearchExpression</code> contains the following components:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// A list of <code>Filter</code> objects. Each filter defines a simple Boolean expression
    /// comprised of a resource property name, Boolean operator, and value.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A list of <code>NestedFilter</code> objects. Each nested filter defines a list of
    /// Boolean expressions using a list of resource properties. A nested filter is satisfied
    /// if a single object in the list satisfies all Boolean expressions.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A list of <code>SearchExpression</code> objects. A search expression object can be
    /// nested in a list of search expression objects.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A Boolean operator: <code>And</code> or <code>Or</code>.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class SearchExpression
    {
        private List<Filter> _filters = new List<Filter>();
        private List<NestedFilters> _nestedFilters = new List<NestedFilters>();
        private BooleanOperator _operator;
        private List<SearchExpression> _subExpressions = new List<SearchExpression>();

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// A list of filter objects.
        /// </para>
        /// </summary>
        public List<Filter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && this._filters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NestedFilters. 
        /// <para>
        /// A list of nested filter objects.
        /// </para>
        /// </summary>
        public List<NestedFilters> NestedFilters
        {
            get { return this._nestedFilters; }
            set { this._nestedFilters = value; }
        }

        // Check to see if NestedFilters property is set
        internal bool IsSetNestedFilters()
        {
            return this._nestedFilters != null && this._nestedFilters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Operator. 
        /// <para>
        /// A Boolean operator used to evaluate the search expression. If you want every conditional
        /// statement in all lists to be satisfied for the entire search expression to be true,
        /// specify <code>And</code>. If only a single conditional statement needs to be true
        /// for the entire search expression to be true, specify <code>Or</code>. The default
        /// value is <code>And</code>.
        /// </para>
        /// </summary>
        public BooleanOperator Operator
        {
            get { return this._operator; }
            set { this._operator = value; }
        }

        // Check to see if Operator property is set
        internal bool IsSetOperator()
        {
            return this._operator != null;
        }

        /// <summary>
        /// Gets and sets the property SubExpressions. 
        /// <para>
        /// A list of search expression objects.
        /// </para>
        /// </summary>
        public List<SearchExpression> SubExpressions
        {
            get { return this._subExpressions; }
            set { this._subExpressions = value; }
        }

        // Check to see if SubExpressions property is set
        internal bool IsSetSubExpressions()
        {
            return this._subExpressions != null && this._subExpressions.Count > 0; 
        }

    }
}