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

namespace Amazon.Billing.Model
{
    /// <summary>
    /// See <a href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_billing_Expression.html">Expression</a>.
    /// Billing view only supports <c>LINKED_ACCOUNT</c>, <c>Tags</c>, and <c>CostCategories</c>.
    /// </summary>
    public partial class Expression
    {
        /// <summary>
        /// Gets and sets the property CostCategories. 
        /// <para>
        ///  The filter that's based on <c>CostCategory</c> values. 
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
        ///  The specific <c>Dimension</c> to use for <c>Expression</c>. 
        /// </para>
        /// </summary>
        public DimensionValues Dimensions { get; set; }

        /// <summary>
        /// Checks to see if the Dimensions property is set.
        /// </summary>
        internal bool IsSetDimensions() => this.Dimensions != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        ///  The specific <c>Tag</c> to use for <c>Expression</c>. 
        /// </para>
        /// </summary>
        public TagValues Tags { get; set; }

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null;

        /// <summary>
        /// Gets and sets the property TimeRange. 
        /// <para>
        ///  Specifies a time range filter for the billing view data. 
        /// </para>
        /// </summary>
        public TimeRange TimeRange { get; set; }

        /// <summary>
        /// Checks to see if the TimeRange property is set.
        /// </summary>
        internal bool IsSetTimeRange() => this.TimeRange != null;
    }
}
