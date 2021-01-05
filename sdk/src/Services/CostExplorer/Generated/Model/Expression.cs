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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// Use <code>Expression</code> to filter by cost or by usage. There are two patterns:
    /// 
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Simple dimension values - You can set the dimension name and values for the filters
    /// that you plan to use. For example, you can filter for <code>REGION==us-east-1 OR REGION==us-west-1</code>.
    /// For <code>GetRightsizingRecommendation</code>, the Region is a full name (for example,
    /// <code>REGION==US East (N. Virginia)</code>. The <code>Expression</code> example looks
    /// like:
    /// </para>
    ///  
    /// <para>
    ///  <code>{ "Dimensions": { "Key": "REGION", "Values": [ "us-east-1", “us-west-1” ] }
    /// }</code> 
    /// </para>
    ///  
    /// <para>
    /// The list of dimension values are OR'd together to retrieve cost or usage data. You
    /// can create <code>Expression</code> and <code>DimensionValues</code> objects using
    /// either <code>with*</code> methods or <code>set*</code> methods in multiple lines.
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Compound dimension values with logical operations - You can use multiple <code>Expression</code>
    /// types and the logical operators <code>AND/OR/NOT</code> to create a list of one or
    /// more <code>Expression</code> objects. This allows you to filter on more advanced options.
    /// For example, you can filter on <code>((REGION == us-east-1 OR REGION == us-west-1)
    /// OR (TAG.Type == Type1)) AND (USAGE_TYPE != DataTransfer)</code>. The <code>Expression</code>
    /// for that looks like this:
    /// </para>
    ///  
    /// <para>
    ///  <code>{ "And": [ {"Or": [ {"Dimensions": { "Key": "REGION", "Values": [ "us-east-1",
    /// "us-west-1" ] }}, {"Tags": { "Key": "TagName", "Values": ["Value1"] } } ]}, {"Not":
    /// {"Dimensions": { "Key": "USAGE_TYPE", "Values": ["DataTransfer"] }}} ] } </code> 
    /// </para>
    ///  <note> 
    /// <para>
    /// Because each <code>Expression</code> can have only one operator, the service returns
    /// an error if more than one is specified. The following example shows an <code>Expression</code>
    /// object that creates an error.
    /// </para>
    ///  </note> 
    /// <para>
    ///  <code> { "And": [ ... ], "DimensionValues": { "Dimension": "USAGE_TYPE", "Values":
    /// [ "DataTransfer" ] } } </code> 
    /// </para>
    ///  </li> </ul> <note> 
    /// <para>
    /// For the <code>GetRightsizingRecommendation</code> action, a combination of OR and
    /// NOT is not supported. OR is not supported between different dimensions, or dimensions
    /// and tags. NOT operators aren't supported. Dimensions are also limited to <code>LINKED_ACCOUNT</code>,
    /// <code>REGION</code>, or <code>RIGHTSIZING_TYPE</code>.
    /// </para>
    ///  
    /// <para>
    /// For the <code>GetReservationPurchaseRecommendation</code> action, only NOT is supported.
    /// AND and OR are not supported. Dimensions are limited to <code>LINKED_ACCOUNT</code>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class Expression
    {
        private List<Expression> _and = new List<Expression>();
        private CostCategoryValues _costCategories;
        private DimensionValues _dimensions;
        private Expression _not;
        private List<Expression> _or = new List<Expression>();
        private TagValues _tags;

        /// <summary>
        /// Gets and sets the property And. 
        /// <para>
        /// Return results that match both <code>Dimension</code> objects.
        /// </para>
        /// </summary>
        public List<Expression> And
        {
            get { return this._and; }
            set { this._and = value; }
        }

        // Check to see if And property is set
        internal bool IsSetAnd()
        {
            return this._and != null && this._and.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CostCategories. 
        /// <para>
        /// The filter based on <code>CostCategory</code> values.
        /// </para>
        /// </summary>
        public CostCategoryValues CostCategories
        {
            get { return this._costCategories; }
            set { this._costCategories = value; }
        }

        // Check to see if CostCategories property is set
        internal bool IsSetCostCategories()
        {
            return this._costCategories != null;
        }

        /// <summary>
        /// Gets and sets the property Dimensions. 
        /// <para>
        /// The specific <code>Dimension</code> to use for <code>Expression</code>.
        /// </para>
        /// </summary>
        public DimensionValues Dimensions
        {
            get { return this._dimensions; }
            set { this._dimensions = value; }
        }

        // Check to see if Dimensions property is set
        internal bool IsSetDimensions()
        {
            return this._dimensions != null;
        }

        /// <summary>
        /// Gets and sets the property Not. 
        /// <para>
        /// Return results that don't match a <code>Dimension</code> object.
        /// </para>
        /// </summary>
        public Expression Not
        {
            get { return this._not; }
            set { this._not = value; }
        }

        // Check to see if Not property is set
        internal bool IsSetNot()
        {
            return this._not != null;
        }

        /// <summary>
        /// Gets and sets the property Or. 
        /// <para>
        /// Return results that match either <code>Dimension</code> object.
        /// </para>
        /// </summary>
        public List<Expression> Or
        {
            get { return this._or; }
            set { this._or = value; }
        }

        // Check to see if Or property is set
        internal bool IsSetOr()
        {
            return this._or != null && this._or.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The specific <code>Tag</code> to use for <code>Expression</code>.
        /// </para>
        /// </summary>
        public TagValues Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null;
        }

    }
}