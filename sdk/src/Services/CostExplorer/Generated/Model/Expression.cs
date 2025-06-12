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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// Use <c>Expression</c> to filter in various Cost Explorer APIs.
    /// 
    ///  
    /// <para>
    /// Not all <c>Expression</c> types are supported in each API. Refer to the documentation
    /// for each specific API to see what is supported.
    /// </para>
    ///  
    /// <para>
    /// There are two patterns:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Simple dimension values.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// There are three types of simple dimension values: <c>CostCategories</c>, <c>Tags</c>,
    /// and <c>Dimensions</c>.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Specify the <c>CostCategories</c> field to define a filter that acts on Cost Categories.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Specify the <c>Tags</c> field to define a filter that acts on Cost Allocation Tags.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Specify the <c>Dimensions</c> field to define a filter that acts on the <a href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_DimensionValues.html">
    /// <c>DimensionValues</c> </a>.
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    /// For each filter type, you can set the dimension name and values for the filters that
    /// you plan to use.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// For example, you can filter for <c>REGION==us-east-1 OR REGION==us-west-1</c>. For
    /// <c>GetRightsizingRecommendation</c>, the Region is a full name (for example, <c>REGION==US
    /// East (N. Virginia)</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The corresponding <c>Expression</c> for this example is as follows: <c>{ "Dimensions":
    /// { "Key": "REGION", "Values": [ "us-east-1", "us-west-1" ] } }</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// As shown in the previous example, lists of dimension values are combined with <c>OR</c>
    /// when applying the filter.
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    /// You can also set different match options to further control how the filter behaves.
    /// Not all APIs support match options. Refer to the documentation for each specific API
    /// to see what is supported.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// For example, you can filter for linked account names that start with "a".
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The corresponding <c>Expression</c> for this example is as follows: <c>{ "Dimensions":
    /// { "Key": "LINKED_ACCOUNT_NAME", "MatchOptions": [ "STARTS_WITH" ], "Values": [ "a"
    /// ] } }</c> 
    /// </para>
    ///  </li> </ul> </li> </ul> </li> <li> 
    /// <para>
    /// Compound <c>Expression</c> types with logical operations.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// You can use multiple <c>Expression</c> types and the logical operators <c>AND/OR/NOT</c>
    /// to create a list of one or more <c>Expression</c> objects. By doing this, you can
    /// filter by more advanced options.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For example, you can filter by <c>((REGION == us-east-1 OR REGION == us-west-1) OR
    /// (TAG.Type == Type1)) AND (USAGE_TYPE != DataTransfer)</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The corresponding <c>Expression</c> for this example is as follows: <c>{ "And": [
    /// {"Or": [ {"Dimensions": { "Key": "REGION", "Values": [ "us-east-1", "us-west-1" ]
    /// }}, {"Tags": { "Key": "TagName", "Values": ["Value1"] } } ]}, {"Not": {"Dimensions":
    /// { "Key": "USAGE_TYPE", "Values": ["DataTransfer"] }}} ] } </c> 
    /// </para>
    ///  </li> </ul> <note> 
    /// <para>
    /// Because each <c>Expression</c> can have only one operator, the service returns an
    /// error if more than one is specified. The following example shows an <c>Expression</c>
    /// object that creates an error: <c> { "And": [ ... ], "Dimensions": { "Key": "USAGE_TYPE",
    /// "Values": [ "DataTransfer" ] } } </c> 
    /// </para>
    ///  
    /// <para>
    /// The following is an example of the corresponding error message: <c>"Expression has
    /// more than one roots. Only one root operator is allowed for each expression: And, Or,
    /// Not, Dimensions, Tags, CostCategories"</c> 
    /// </para>
    ///  </note> </li> </ul> <note> 
    /// <para>
    /// For the <c>GetRightsizingRecommendation</c> action, a combination of OR and NOT isn't
    /// supported. OR isn't supported between different dimensions, or dimensions and tags.
    /// NOT operators aren't supported. Dimensions are also limited to <c>LINKED_ACCOUNT</c>,
    /// <c>REGION</c>, or <c>RIGHTSIZING_TYPE</c>.
    /// </para>
    ///  
    /// <para>
    /// For the <c>GetReservationPurchaseRecommendation</c> action, only NOT is supported.
    /// AND and OR aren't supported. Dimensions are limited to <c>LINKED_ACCOUNT</c>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class Expression
    {
        private List<Expression> _and = AWSConfigs.InitializeCollections ? new List<Expression>() : null;
        private CostCategoryValues _costCategories;
        private DimensionValues _dimensions;
        private Expression _not;
        private List<Expression> _or = AWSConfigs.InitializeCollections ? new List<Expression>() : null;
        private TagValues _tags;

        /// <summary>
        /// Gets and sets the property And. 
        /// <para>
        /// Return results that match both <c>Dimension</c> objects.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Expression> And
        {
            get { return this._and; }
            set { this._and = value; }
        }

        // Check to see if And property is set
        internal bool IsSetAnd()
        {
            return this._and != null && (this._and.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CostCategories. 
        /// <para>
        /// The filter that's based on <c>CostCategory</c> values.
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
        /// The specific <c>Dimension</c> to use for <c>Expression</c>.
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
        /// Return results that don't match a <c>Dimension</c> object.
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
        /// Return results that match either <c>Dimension</c> object.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Expression> Or
        {
            get { return this._or; }
            set { this._or = value; }
        }

        // Check to see if Or property is set
        internal bool IsSetOr()
        {
            return this._or != null && (this._or.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The specific <c>Tag</c> to use for <c>Expression</c>.
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