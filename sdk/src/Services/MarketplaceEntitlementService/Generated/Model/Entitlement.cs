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
 * Do not modify this file. This file is generated from the entitlement.marketplace-2017-01-11.normal.json service model.
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
namespace Amazon.MarketplaceEntitlementService.Model
{
    /// <summary>
    /// An entitlement represents capacity in a product owned by the customer. For example,
    /// a customer might own some number of users or seats in an SaaS application or some
    /// amount of data capacity in a multi-tenant database.
    /// </summary>
    public partial class Entitlement
    {
        private string _customerAWSAccountId;
        private string _customerIdentifier;
        private string _dimension;
        private DateTime? _expirationDate;
        private string _productCode;
        private EntitlementValue _value;

        /// <summary>
        /// Gets and sets the property CustomerAWSAccountId. 
        /// <para>
        ///  The <c>CustomerAWSAccountID</c> parameter specifies the AWS account ID of the buyer.
        /// 
        /// </para>
        /// </summary>
        public string CustomerAWSAccountId
        {
            get { return this._customerAWSAccountId; }
            set { this._customerAWSAccountId = value; }
        }

        // Check to see if CustomerAWSAccountId property is set
        internal bool IsSetCustomerAWSAccountId()
        {
            return this._customerAWSAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property CustomerIdentifier. 
        /// <para>
        /// The customer identifier is a handle to each unique customer in an application. Customer
        /// identifiers are obtained through the ResolveCustomer operation in AWS Marketplace
        /// Metering Service.
        /// </para>
        /// </summary>
        public string CustomerIdentifier
        {
            get { return this._customerIdentifier; }
            set { this._customerIdentifier = value; }
        }

        // Check to see if CustomerIdentifier property is set
        internal bool IsSetCustomerIdentifier()
        {
            return this._customerIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Dimension. 
        /// <para>
        /// The dimension for which the given entitlement applies. Dimensions represent categories
        /// of capacity in a product and are specified when the product is listed in AWS Marketplace.
        /// </para>
        /// </summary>
        public string Dimension
        {
            get { return this._dimension; }
            set { this._dimension = value; }
        }

        // Check to see if Dimension property is set
        internal bool IsSetDimension()
        {
            return this._dimension != null;
        }

        /// <summary>
        /// Gets and sets the property ExpirationDate. 
        /// <para>
        /// The expiration date represents the minimum date through which this entitlement is
        /// expected to remain valid. For contractual products listed on AWS Marketplace, the
        /// expiration date is the date at which the customer will renew or cancel their contract.
        /// Customers who are opting to renew their contract will still have entitlements with
        /// an expiration date.
        /// </para>
        /// </summary>
        public DateTime? ExpirationDate
        {
            get { return this._expirationDate; }
            set { this._expirationDate = value; }
        }

        // Check to see if ExpirationDate property is set
        internal bool IsSetExpirationDate()
        {
            return this._expirationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProductCode. 
        /// <para>
        /// The product code for which the given entitlement applies. Product codes are provided
        /// by AWS Marketplace when the product listing is created.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string ProductCode
        {
            get { return this._productCode; }
            set { this._productCode = value; }
        }

        // Check to see if ProductCode property is set
        internal bool IsSetProductCode()
        {
            return this._productCode != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The EntitlementValue represents the amount of capacity that the customer is entitled
        /// to for the product.
        /// </para>
        /// </summary>
        public EntitlementValue Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}