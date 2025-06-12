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
 * Do not modify this file. This file is generated from the license-manager-linux-subscriptions-2018-05-10.normal.json service model.
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
namespace Amazon.LicenseManagerLinuxSubscriptions.Model
{
    /// <summary>
    /// Container for the parameters to the RegisterSubscriptionProvider operation.
    /// Register the supported third-party subscription provider for your Bring Your Own License
    /// (BYOL) subscription.
    /// </summary>
    public partial class RegisterSubscriptionProviderRequest : AmazonLicenseManagerLinuxSubscriptionsRequest
    {
        private string _secretArn;
        private SubscriptionProviderSource _subscriptionProviderSource;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property SecretArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the secret where you've stored your subscription
        /// provider's access token. For RHEL subscriptions managed through the Red Hat Subscription
        /// Manager (RHSM), the secret contains your Red Hat Offline token.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SecretArn
        {
            get { return this._secretArn; }
            set { this._secretArn = value; }
        }

        // Check to see if SecretArn property is set
        internal bool IsSetSecretArn()
        {
            return this._secretArn != null;
        }

        /// <summary>
        /// Gets and sets the property SubscriptionProviderSource. 
        /// <para>
        /// The supported Linux subscription provider to register.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SubscriptionProviderSource SubscriptionProviderSource
        {
            get { return this._subscriptionProviderSource; }
            set { this._subscriptionProviderSource = value; }
        }

        // Check to see if SubscriptionProviderSource property is set
        internal bool IsSetSubscriptionProviderSource()
        {
            return this._subscriptionProviderSource != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The metadata tags to assign to your registered Linux subscription provider resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}