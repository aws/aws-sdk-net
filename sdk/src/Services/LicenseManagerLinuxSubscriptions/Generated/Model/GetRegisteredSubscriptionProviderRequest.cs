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
    /// Container for the parameters to the GetRegisteredSubscriptionProvider operation.
    /// Get details for a Bring Your Own License (BYOL) subscription that's registered to
    /// your account.
    /// </summary>
    public partial class GetRegisteredSubscriptionProviderRequest : AmazonLicenseManagerLinuxSubscriptionsRequest
    {
        private string _subscriptionProviderArn;

        /// <summary>
        /// Gets and sets the property SubscriptionProviderArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the BYOL registration resource to get details for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SubscriptionProviderArn
        {
            get { return this._subscriptionProviderArn; }
            set { this._subscriptionProviderArn = value; }
        }

        // Check to see if SubscriptionProviderArn property is set
        internal bool IsSetSubscriptionProviderArn()
        {
            return this._subscriptionProviderArn != null;
        }

    }
}