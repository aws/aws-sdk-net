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

namespace Amazon.LicenseManagerLinuxSubscriptions.Model
{
    /// <summary>
    /// This is the response object from the GetRegisteredSubscriptionProvider operation.
    /// </summary>
    public partial class GetRegisteredSubscriptionProviderResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property LastSuccessfulDataRetrievalTime. 
        /// <para>
        /// The timestamp from the last time License Manager retrieved subscription details from
        /// your registered third-party Linux subscription provider.
        /// </para>
        /// </summary>
        public string LastSuccessfulDataRetrievalTime { get; set; }

        /// <summary>
        /// Checks to see if the LastSuccessfulDataRetrievalTime property is set.
        /// </summary>
        internal bool IsSetLastSuccessfulDataRetrievalTime() => this.LastSuccessfulDataRetrievalTime != null;

        /// <summary>
        /// Gets and sets the property SecretArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the third-party access secret stored in Secrets
        /// Manager for the BYOL registration resource specified in the request.
        /// </para>
        /// </summary>
        public string SecretArn { get; set; }

        /// <summary>
        /// Checks to see if the SecretArn property is set.
        /// </summary>
        internal bool IsSetSecretArn() => this.SecretArn != null;

        /// <summary>
        /// Gets and sets the property SubscriptionProviderArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the BYOL registration resource specified in the
        /// request.
        /// </para>
        /// </summary>
        public string SubscriptionProviderArn { get; set; }

        /// <summary>
        /// Checks to see if the SubscriptionProviderArn property is set.
        /// </summary>
        internal bool IsSetSubscriptionProviderArn() => this.SubscriptionProviderArn != null;

        /// <summary>
        /// Gets and sets the property SubscriptionProviderSource. 
        /// <para>
        /// The subscription provider for the BYOL registration resource specified in the request.
        /// </para>
        /// </summary>
        public SubscriptionProviderSource SubscriptionProviderSource { get; set; }

        /// <summary>
        /// Checks to see if the SubscriptionProviderSource property is set.
        /// </summary>
        internal bool IsSetSubscriptionProviderSource() => this.SubscriptionProviderSource != null;

        /// <summary>
        /// Gets and sets the property SubscriptionProviderStatus. 
        /// <para>
        /// The status of the Linux subscription provider access token from the last successful
        /// subscription data request.
        /// </para>
        /// </summary>
        public SubscriptionProviderStatus SubscriptionProviderStatus { get; set; }

        /// <summary>
        /// Checks to see if the SubscriptionProviderStatus property is set.
        /// </summary>
        internal bool IsSetSubscriptionProviderStatus() => this.SubscriptionProviderStatus != null;

        /// <summary>
        /// Gets and sets the property SubscriptionProviderStatusMessage. 
        /// <para>
        /// The detailed message from your subscription provider token status.
        /// </para>
        /// </summary>
        public string SubscriptionProviderStatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the SubscriptionProviderStatusMessage property is set.
        /// </summary>
        internal bool IsSetSubscriptionProviderStatusMessage() => this.SubscriptionProviderStatusMessage != null;
    }
}
