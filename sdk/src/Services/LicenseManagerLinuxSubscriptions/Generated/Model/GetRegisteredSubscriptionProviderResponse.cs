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
    /// This is the response object from the GetRegisteredSubscriptionProvider operation.
    /// </summary>
    public partial class GetRegisteredSubscriptionProviderResponse : AmazonWebServiceResponse
    {
        private string _lastSuccessfulDataRetrievalTime;
        private string _secretArn;
        private string _subscriptionProviderArn;
        private SubscriptionProviderSource _subscriptionProviderSource;
        private SubscriptionProviderStatus _subscriptionProviderStatus;
        private string _subscriptionProviderStatusMessage;

        /// <summary>
        /// Gets and sets the property LastSuccessfulDataRetrievalTime. 
        /// <para>
        /// The timestamp from the last time License Manager retrieved subscription details from
        /// your registered third-party Linux subscription provider.
        /// </para>
        /// </summary>
        public string LastSuccessfulDataRetrievalTime
        {
            get { return this._lastSuccessfulDataRetrievalTime; }
            set { this._lastSuccessfulDataRetrievalTime = value; }
        }

        // Check to see if LastSuccessfulDataRetrievalTime property is set
        internal bool IsSetLastSuccessfulDataRetrievalTime()
        {
            return this._lastSuccessfulDataRetrievalTime != null;
        }

        /// <summary>
        /// Gets and sets the property SecretArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the third-party access secret stored in Secrets
        /// Manager for the BYOL registration resource specified in the request.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property SubscriptionProviderArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the BYOL registration resource specified in the
        /// request.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property SubscriptionProviderSource. 
        /// <para>
        /// The subscription provider for the BYOL registration resource specified in the request.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property SubscriptionProviderStatus. 
        /// <para>
        /// The status of the Linux subscription provider access token from the last successful
        /// subscription data request.
        /// </para>
        /// </summary>
        public SubscriptionProviderStatus SubscriptionProviderStatus
        {
            get { return this._subscriptionProviderStatus; }
            set { this._subscriptionProviderStatus = value; }
        }

        // Check to see if SubscriptionProviderStatus property is set
        internal bool IsSetSubscriptionProviderStatus()
        {
            return this._subscriptionProviderStatus != null;
        }

        /// <summary>
        /// Gets and sets the property SubscriptionProviderStatusMessage. 
        /// <para>
        /// The detailed message from your subscription provider token status.
        /// </para>
        /// </summary>
        public string SubscriptionProviderStatusMessage
        {
            get { return this._subscriptionProviderStatusMessage; }
            set { this._subscriptionProviderStatusMessage = value; }
        }

        // Check to see if SubscriptionProviderStatusMessage property is set
        internal bool IsSetSubscriptionProviderStatusMessage()
        {
            return this._subscriptionProviderStatusMessage != null;
        }

    }
}