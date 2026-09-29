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

namespace Amazon.ConnectHealth.Model
{
    /// <summary>
    /// Container for the parameters to the ActivateSubscription operation. Activates a Subscription
    /// to enable billing for a user.
    /// </summary>
    public partial class ActivateSubscriptionRequest : AmazonConnectHealthRequest
    {
        /// <summary>
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The unique identifier of the parent Domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 25)]
        public string DomainId { get; set; }

        /// <summary>
        /// Checks to see if the DomainId property is set.
        /// </summary>
        internal bool IsSetDomainId() => this.DomainId != null;

        /// <summary>
        /// Gets and sets the property SubscriptionId. 
        /// <para>
        /// The unique identifier of the Subscription.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 25, Max = 25)]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// Checks to see if the SubscriptionId property is set.
        /// </summary>
        internal bool IsSetSubscriptionId() => this.SubscriptionId != null;
    }
}
