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

namespace Amazon.Budgets.Model
{
    /// <summary>
    /// Use Expression to filter in various Budgets APIs.
    /// </summary>
    public partial class Expression
    {
        /// <summary>
        /// Gets and sets the property And. 
        /// <para>
        /// Return results that match both Dimension objects.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Expression> And { get; set; } = AWSConfigs.InitializeCollections ? new List<Expression>() : null;

        /// <summary>
        /// Checks to see if the And property is set.
        /// </summary>
        internal bool IsSetAnd() => this.And != null && (this.And.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CostCategories. 
        /// <para>
        /// The filter that's based on CostCategoryValues.
        /// </para>
        /// </summary>
        public CostCategoryValues CostCategories { get; set; }

        /// <summary>
        /// Checks to see if the CostCategories property is set.
        /// </summary>
        internal bool IsSetCostCategories() => this.CostCategories != null;

        /// <summary>
        /// Gets and sets the property Dimensions. 
        /// <para>
        /// The specific Dimension to use for Expression.
        /// </para>
        /// </summary>
        public ExpressionDimensionValues Dimensions { get; set; }

        /// <summary>
        /// Checks to see if the Dimensions property is set.
        /// </summary>
        internal bool IsSetDimensions() => this.Dimensions != null;

        /// <summary>
        /// Gets and sets the property Not. 
        /// <para>
        /// Return results that don't match a Dimension object.
        /// </para>
        /// </summary>
        public Expression Not { get; set; }

        /// <summary>
        /// Checks to see if the Not property is set.
        /// </summary>
        internal bool IsSetNot() => this.Not != null;

        /// <summary>
        /// Gets and sets the property Or. 
        /// <para>
        /// Return results that match either Dimension object.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Expression> Or { get; set; } = AWSConfigs.InitializeCollections ? new List<Expression>() : null;

        /// <summary>
        /// Checks to see if the Or property is set.
        /// </summary>
        internal bool IsSetOr() => this.Or != null && (this.Or.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ProductAttributes. 
        /// <para>
        /// The filter that limits results based on the values of specific product attributes.
        /// </para>
        /// </summary>
        public ProductAttributeValues ProductAttributes { get; set; }

        /// <summary>
        /// Checks to see if the ProductAttributes property is set.
        /// </summary>
        internal bool IsSetProductAttributes() => this.ProductAttributes != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The specific Tag to use for Expression.
        /// </para>
        /// </summary>
        public TagValues Tags { get; set; }

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null;
    }
}
