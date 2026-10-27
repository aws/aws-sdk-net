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

namespace Amazon.MarketplaceEntitlementService.Model
{
    /// <summary>
    /// An entitlement represents capacity in a product owned by the customer. For example,
    /// a customer might own some number of users or seats in an SaaS application or some
    /// amount of data capacity in a multi-tenant database.
    /// </summary>
    public partial class Entitlement
    {
        /// <summary>
        /// Gets and sets the property CustomerAWSAccountId. 
        /// <para>
        ///  The <c>CustomerAWSAccountId</c> parameter specifies the AWS account ID of the buyer.
        /// 
        /// </para>
        /// </summary>
        public string CustomerAWSAccountId { get; set; }

        /// <summary>
        /// Checks to see if the CustomerAWSAccountId property is set.
        /// </summary>
        internal bool IsSetCustomerAWSAccountId() => this.CustomerAWSAccountId != null;

        /// <summary>
        /// Gets and sets the property CustomerIdentifier. 
        /// <para>
        /// The customer identifier is a handle to each unique customer in an application. Customer
        /// identifiers are obtained through the ResolveCustomer operation in AWS Marketplace
        /// Metering Service.
        /// </para>
        /// </summary>
        public string CustomerIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the CustomerIdentifier property is set.
        /// </summary>
        internal bool IsSetCustomerIdentifier() => this.CustomerIdentifier != null;

        /// <summary>
        /// Gets and sets the property Dimension. 
        /// <para>
        /// The dimension for which the given entitlement applies. Dimensions represent categories
        /// of capacity in a product and are specified when the product is listed in AWS Marketplace.
        /// </para>
        /// </summary>
        public string Dimension { get; set; }

        /// <summary>
        /// Checks to see if the Dimension property is set.
        /// </summary>
        internal bool IsSetDimension() => this.Dimension != null;

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
        public DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// Checks to see if the ExpirationDate property is set.
        /// </summary>
        internal bool IsSetExpirationDate() => this.ExpirationDate.HasValue;

        /// <summary>
        /// Gets and sets the property LicenseArn. 
        /// <para>
        /// The <c>LicenseArn</c> is a unique identifier for a specific granted license. These
        /// are used for software purchased through AWS Marketplace.
        /// </para>
        /// </summary>
        public string LicenseArn { get; set; }

        /// <summary>
        /// Checks to see if the LicenseArn property is set.
        /// </summary>
        internal bool IsSetLicenseArn() => this.LicenseArn != null;

        /// <summary>
        /// Gets and sets the property ProductCode. 
        /// <para>
        /// The product code for which the given entitlement applies. Product codes are provided
        /// by AWS Marketplace when the product listing is created.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string ProductCode { get; set; }

        /// <summary>
        /// Checks to see if the ProductCode property is set.
        /// </summary>
        internal bool IsSetProductCode() => this.ProductCode != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The EntitlementValue represents the amount of capacity that the customer is entitled
        /// to for the product.
        /// </para>
        /// </summary>
        public EntitlementValue Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}
