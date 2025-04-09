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
 * Do not modify this file. This file is generated from the meteringmarketplace-2016-01-14.normal.json service model.
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
namespace Amazon.AWSMarketplaceMetering.Model
{
    /// <summary>
    /// Container for the parameters to the RegisterUsage operation.
    /// Paid container software products sold through Amazon Web Services Marketplace must
    /// integrate with the Amazon Web Services Marketplace Metering Service and call the <c>RegisterUsage</c>
    /// operation for software entitlement and metering. Free and BYOL products for Amazon
    /// ECS or Amazon EKS aren't required to call <c>RegisterUsage</c>, but you may choose
    /// to do so if you would like to receive usage data in your seller reports. The sections
    /// below explain the behavior of <c>RegisterUsage</c>. <c>RegisterUsage</c> performs
    /// two primary functions: metering and entitlement.
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <i>Entitlement</i>: <c>RegisterUsage</c> allows you to verify that the customer running
    /// your paid software is subscribed to your product on Amazon Web Services Marketplace,
    /// enabling you to guard against unauthorized use. Your container image that integrates
    /// with <c>RegisterUsage</c> is only required to guard against unauthorized use at container
    /// startup, as such a <c>CustomerNotSubscribedException</c> or <c>PlatformNotSupportedException</c>
    /// will only be thrown on the initial call to <c>RegisterUsage</c>. Subsequent calls
    /// from the same Amazon ECS task instance (e.g. task-id) or Amazon EKS pod will not throw
    /// a <c>CustomerNotSubscribedException</c>, even if the customer unsubscribes while the
    /// Amazon ECS task or Amazon EKS pod is still running.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <i>Metering</i>: <c>RegisterUsage</c> meters software use per ECS task, per hour,
    /// or per pod for Amazon EKS with usage prorated to the second. A minimum of 1 minute
    /// of usage applies to tasks that are short lived. For example, if a customer has a 10
    /// node Amazon ECS or Amazon EKS cluster and a service configured as a Daemon Set, then
    /// Amazon ECS or Amazon EKS will launch a task on all 10 cluster nodes and the customer
    /// will be charged for 10 tasks. Software metering is handled by the Amazon Web Services
    /// Marketplace metering control plane—your software is not required to perform metering-specific
    /// actions other than to call <c>RegisterUsage</c> to commence metering. The Amazon Web
    /// Services Marketplace metering control plane will also bill customers for running ECS
    /// tasks and Amazon EKS pods, regardless of the customer's subscription state, which
    /// removes the need for your software to run entitlement checks at runtime. For containers,
    /// <c>RegisterUsage</c> should be called immediately at launch. If you don’t register
    /// the container within the first 6 hours of the launch, Amazon Web Services Marketplace
    /// Metering Service doesn’t provide any metering guarantees for previous months. Metering
    /// will continue, however, for the current month forward until the container ends. <c>RegisterUsage</c>
    /// is for metering paid hourly container products.
    /// </para>
    ///  
    /// <para>
    /// For Amazon Web Services Regions that support <c>RegisterUsage</c>, see <a href="https://docs.aws.amazon.com/marketplace/latest/APIReference/metering-regions.html#registerusage-region-support">RegisterUsage
    /// Region support</a>. 
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
        [AWSProperty(Max=255)]
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
        /// Product code is used to uniquely identify a product in Amazon Web Services Marketplace.
        /// The product code should be the same as the one used during the publishing of a new
        /// product.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
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
        /// Public Key Version provided by Amazon Web Services Marketplace
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public int? PublicKeyVersion
        {
            get { return this._publicKeyVersion; }
            set { this._publicKeyVersion = value; }
        }

        // Check to see if PublicKeyVersion property is set
        internal bool IsSetPublicKeyVersion()
        {
            return this._publicKeyVersion.HasValue; 
        }

    }
}