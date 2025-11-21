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
 * Do not modify this file. This file is generated from the billing-2023-09-07.normal.json service model.
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
        private string _arn;
        private BillingViewType _billingViewType;
        private DateTime? _createdAt;
        private Expression _dataFilterExpression;
        private int? _derivedViewCount;
        private string _description;
        private BillingViewHealthStatus _healthStatus;
        private string _name;
        private string _ownerAccountId;
        private string _sourceAccountId;
        private int? _sourceViewCount;
        private DateTime? _updatedAt;
        private DateTime? _viewDefinitionLastUpdatedAt;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) that can be used to uniquely identify the billing
        /// view. 
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property BillingViewType. 
        /// <para>
        /// The type of billing group. 
        /// </para>
        /// </summary>
        public BillingViewType BillingViewType
        {
            get { return this._billingViewType; }
            set { this._billingViewType = value; }
        }

        // Check to see if BillingViewType property is set
        internal bool IsSetBillingViewType()
        {
            return this._billingViewType != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time when the billing view was created. 
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DataFilterExpression. 
        /// <para>
        ///  See <a href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_billing_Expression.html">Expression</a>.
        /// Billing view only supports <c>LINKED_ACCOUNT</c> and <c>Tags</c>. 
        /// </para>
        /// </summary>
        public Expression DataFilterExpression
        {
            get { return this._dataFilterExpression; }
            set { this._dataFilterExpression = value; }
        }

        // Check to see if DataFilterExpression property is set
        internal bool IsSetDataFilterExpression()
        {
            return this._dataFilterExpression != null;
        }

        /// <summary>
        /// Gets and sets the property DerivedViewCount. 
        /// <para>
        ///  The number of billing views that use this billing view as a source. 
        /// </para>
        /// </summary>
        public int? DerivedViewCount
        {
            get { return this._derivedViewCount; }
            set { this._derivedViewCount = value; }
        }

        // Check to see if DerivedViewCount property is set
        internal bool IsSetDerivedViewCount()
        {
            return this._derivedViewCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  The description of the billing view. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=1024)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property HealthStatus. 
        /// <para>
        ///  The current health status of the billing view. 
        /// </para>
        /// </summary>
        public BillingViewHealthStatus HealthStatus
        {
            get { return this._healthStatus; }
            set { this._healthStatus = value; }
        }

        // Check to see if HealthStatus property is set
        internal bool IsSetHealthStatus()
        {
            return this._healthStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The account name of the billing view. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=128)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property OwnerAccountId. 
        /// <para>
        /// The account owner of the billing view. 
        /// </para>
        /// </summary>
        public string OwnerAccountId
        {
            get { return this._ownerAccountId; }
            set { this._ownerAccountId = value; }
        }

        // Check to see if OwnerAccountId property is set
        internal bool IsSetOwnerAccountId()
        {
            return this._ownerAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property SourceAccountId. 
        /// <para>
        ///  The Amazon Web Services account ID that owns the source billing view, if this is
        /// a derived billing view. 
        /// </para>
        /// </summary>
        public string SourceAccountId
        {
            get { return this._sourceAccountId; }
            set { this._sourceAccountId = value; }
        }

        // Check to see if SourceAccountId property is set
        internal bool IsSetSourceAccountId()
        {
            return this._sourceAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property SourceViewCount. 
        /// <para>
        ///  The number of source views associated with this billing view. 
        /// </para>
        /// </summary>
        public int? SourceViewCount
        {
            get { return this._sourceViewCount; }
            set { this._sourceViewCount = value; }
        }

        // Check to see if SourceViewCount property is set
        internal bool IsSetSourceViewCount()
        {
            return this._sourceViewCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The time when the billing view was last updated. 
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ViewDefinitionLastUpdatedAt. 
        /// <para>
        ///  The timestamp of when the billing view definition was last updated. 
        /// </para>
        /// </summary>
        public DateTime? ViewDefinitionLastUpdatedAt
        {
            get { return this._viewDefinitionLastUpdatedAt; }
            set { this._viewDefinitionLastUpdatedAt = value; }
        }

        // Check to see if ViewDefinitionLastUpdatedAt property is set
        internal bool IsSetViewDefinitionLastUpdatedAt()
        {
            return this._viewDefinitionLastUpdatedAt.HasValue; 
        }

    }
}