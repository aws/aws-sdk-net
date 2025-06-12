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
 * Do not modify this file. This file is generated from the bcm-pricing-calculator-2024-06-19.normal.json service model.
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
namespace Amazon.BCMPricingCalculator.Model
{
    /// <summary>
    /// Represents a complex filtering expression for cost and usage data.
    /// </summary>
    public partial class Expression
    {
        private List<Expression> _and = AWSConfigs.InitializeCollections ? new List<Expression>() : null;
        private ExpressionFilter _costCategories;
        private ExpressionFilter _dimensions;
        private Expression _not;
        private List<Expression> _or = AWSConfigs.InitializeCollections ? new List<Expression>() : null;
        private ExpressionFilter _tags;

        /// <summary>
        /// Gets and sets the property And. 
        /// <para>
        ///  A list of expressions to be combined with AND logic. 
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
        ///  Filters based on cost categories. 
        /// </para>
        /// </summary>
        public ExpressionFilter CostCategories
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
        ///  Filters based on dimensions (e.g., service, operation). 
        /// </para>
        /// </summary>
        public ExpressionFilter Dimensions
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
        ///  An expression to be negated. 
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
        ///  A list of expressions to be combined with OR logic. 
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
        ///  Filters based on resource tags. 
        /// </para>
        /// </summary>
        public ExpressionFilter Tags
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