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
    /// The metadata associated to the billing view.
    /// </summary>
    public partial class BillingViewElement
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) that can be used to uniquely identify the billing
        /// view. 
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property BillingViewType. 
        /// <para>
        /// The type of billing group. 
        /// </para>
        /// </summary>
        public BillingViewType BillingViewType { get; set; }

        /// <summary>
        /// Checks to see if the BillingViewType property is set.
        /// </summary>
        internal bool IsSetBillingViewType() => this.BillingViewType != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time when the billing view was created. 
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DataFilterExpression. 
        /// <para>
        ///  See <a href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_billing_Expression.html">Expression</a>.
        /// Billing view only supports <c>LINKED_ACCOUNT</c>, <c>Tags</c>, and <c>CostCategories</c>.
        /// 
        /// </para>
        /// </summary>
        public Expression DataFilterExpression { get; set; }

        /// <summary>
        /// Checks to see if the DataFilterExpression property is set.
        /// </summary>
        internal bool IsSetDataFilterExpression() => this.DataFilterExpression != null;

        /// <summary>
        /// Gets and sets the property DerivedViewCount. 
        /// <para>
        ///  The number of billing views that use this billing view as a source. 
        /// </para>
        /// </summary>
        public int? DerivedViewCount { get; set; }

        /// <summary>
        /// Checks to see if the DerivedViewCount property is set.
        /// </summary>
        internal bool IsSetDerivedViewCount() => this.DerivedViewCount.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  The description of the billing view. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property HealthStatus. 
        /// <para>
        ///  The current health status of the billing view. 
        /// </para>
        /// </summary>
        public BillingViewHealthStatus HealthStatus { get; set; }

        /// <summary>
        /// Checks to see if the HealthStatus property is set.
        /// </summary>
        internal bool IsSetHealthStatus() => this.HealthStatus != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The account name of the billing view. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OwnerAccountId. 
        /// <para>
        /// The account owner of the billing view. 
        /// </para>
        /// </summary>
        public string OwnerAccountId { get; set; }

        /// <summary>
        /// Checks to see if the OwnerAccountId property is set.
        /// </summary>
        internal bool IsSetOwnerAccountId() => this.OwnerAccountId != null;

        /// <summary>
        /// Gets and sets the property SourceAccountId. 
        /// <para>
        ///  The Amazon Web Services account ID that owns the source billing view, if this is
        /// a derived billing view. 
        /// </para>
        /// </summary>
        public string SourceAccountId { get; set; }

        /// <summary>
        /// Checks to see if the SourceAccountId property is set.
        /// </summary>
        internal bool IsSetSourceAccountId() => this.SourceAccountId != null;

        /// <summary>
        /// Gets and sets the property SourceViewCount. 
        /// <para>
        ///  The number of source views associated with this billing view. 
        /// </para>
        /// </summary>
        public int? SourceViewCount { get; set; }

        /// <summary>
        /// Checks to see if the SourceViewCount property is set.
        /// </summary>
        internal bool IsSetSourceViewCount() => this.SourceViewCount.HasValue;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The time when the billing view was last updated. 
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property ViewDefinitionLastUpdatedAt. 
        /// <para>
        ///  The timestamp of when the billing view definition was last updated. 
        /// </para>
        /// </summary>
        public DateTime? ViewDefinitionLastUpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the ViewDefinitionLastUpdatedAt property is set.
        /// </summary>
        internal bool IsSetViewDefinitionLastUpdatedAt() => this.ViewDefinitionLastUpdatedAt.HasValue;
    }
}
