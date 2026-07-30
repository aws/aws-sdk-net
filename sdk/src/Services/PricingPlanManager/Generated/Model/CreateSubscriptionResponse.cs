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
 * Do not modify this file. This file is generated from the pricing-plan-manager-2025-08-05.normal.json service model.
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
namespace Amazon.PricingPlanManager.Model
{
    /// <summary>
    /// This is the response object from the CreateSubscription operation.
    /// </summary>
    public partial class CreateSubscriptionResponse : AmazonWebServiceResponse
    {
        private string _eTag;
        private Subscription _subscription;

        /// <summary>
        /// Gets and sets the property ETag. 
        /// <para>
        /// The entity tag for concurrency control. Use this value in the <c>If-Match</c> header
        /// for subsequent operations on this subscription.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ETag
        {
            get { return this._eTag; }
            set { this._eTag = value; }
        }

        // Check to see if ETag property is set
        internal bool IsSetETag()
        {
            return this._eTag != null;
        }

        /// <summary>
        /// Gets and sets the property Subscription. 
        /// <para>
        /// The details of the newly created subscription.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Subscription Subscription
        {
            get { return this._subscription; }
            set { this._subscription = value; }
        }

        // Check to see if Subscription property is set
        internal bool IsSetSubscription()
        {
            return this._subscription != null;
        }

    }
}