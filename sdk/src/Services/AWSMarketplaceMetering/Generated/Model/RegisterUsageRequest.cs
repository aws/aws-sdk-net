/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the meteringmarketplace-2016-01-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AWSMarketplaceMetering.Model
{
    /// <summary>
    /// Container for the parameters to the RegisterUsage operation.
    /// Paid container software products sold through AWS Marketplace must integrate with
    /// the AWS Marketplace Metering Service and call the RegisterUsage operation for software
    /// entitlement and metering. Calling RegisterUsage from containers running outside of
    /// ECS is not currently supported. Free and BYOL products for ECS aren't required to
    /// call RegisterUsage, but you may choose to do so if you would like to receive usage
    /// data in your seller reports. The sections below explain the behavior of RegisterUsage.
    /// RegisterUsage performs two primary functions: metering and entitlement.
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <i>Entitlement</i>: RegisterUsage allows you to verify that the customer running
    /// your paid software is subscribed to your product on AWS Marketplace, enabling you
    /// to guard against unauthorized use. Your container image that integrates with RegisterUsage
    /// is only required to guard against unauthorized use at container startup, as such a
    /// CustomerNotSubscribedException/PlatformNotSupportedException will only be thrown on
    /// the initial call to RegisterUsage. Subsequent calls from the same Amazon ECS task
    /// instance (e.g. task-id) will not throw a CustomerNotSubscribedException, even if the
    /// customer unsubscribes while the Amazon ECS task is still running.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <i>Metering</i>: RegisterUsage meters software use per ECS task, per hour, with usage
    /// prorated to the second. A minimum of 1 minute of usage applies to tasks that are short
    /// lived. For example, if a customer has a 10 node ECS cluster and creates an ECS service
    /// configured as a Daemon Set, then ECS will launch a task on all 10 cluster nodes and
    /// the customer will be charged: (10 * hourly_rate). Metering for software use is automatically
    /// handled by the AWS Marketplace Metering Control Plane -- your software is not required
    /// to perform any metering specific actions, other than call RegisterUsage once for metering
    /// of software use to commence. The AWS Marketplace Metering Control Plane will also
    /// continue to bill customers for running ECS tasks, regardless of the customers subscription
    /// state, removing the need for your software to perform entitlement checks at runtime.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class RegisterUsageRequest : AmazonAWSMarketplaceMeteringRequest
    {
        private string _nonce;
        private string _productCode;
        private int? _publicKeyVersion;

        /// <summary>
        /// Gets and sets the property Nonce. 
        /// <para>
        /// (Optional) To scope down the registration to a specific running software instance
        /// and guard against replay attacks.
        /// </para>
        /// </summary>
        public string Nonce
        {
            get { return this._nonce; }
            set { this._nonce = value; }
        }

        // Check to see if Nonce property is set
        internal bool IsSetNonce()
        {
            return this._nonce != null;
        }

        /// <summary>
        /// Gets and sets the property ProductCode. 
        /// <para>
        /// Product code is used to uniquely identify a product in AWS Marketplace. The product
        /// code should be the same as the one used during the publishing of a new product.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property PublicKeyVersion. 
        /// <para>
        /// Public Key Version provided by AWS Marketplace
        /// </para>
        /// </summary>
        public int PublicKeyVersion
        {
            get { return this._publicKeyVersion.GetValueOrDefault(); }
            set { this._publicKeyVersion = value; }
        }

        // Check to see if PublicKeyVersion property is set
        internal bool IsSetPublicKeyVersion()
        {
            return this._publicKeyVersion.HasValue; 
        }

    }
}