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
    /// A representation of a billing view.
    /// </summary>
    public partial class BillingViewListElement
    {
        private string _arn;
        private BillingViewType _billingViewType;
        private string _description;
        private BillingViewHealthStatus _healthStatus;
        private string _name;
        private string _ownerAccountId;
        private string _sourceAccountId;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that can be used to uniquely identify the billing view.
        /// 
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
        /// The type of billing view.
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
        ///  A list of names of the Billing view. 
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
        ///  The list of owners of the Billing view. 
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

    }
}