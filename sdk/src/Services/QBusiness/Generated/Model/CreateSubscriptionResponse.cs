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
 * Do not modify this file. This file is generated from the qbusiness-2023-11-27.normal.json service model.
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
namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// This is the response object from the CreateSubscription operation.
    /// </summary>
    public partial class CreateSubscriptionResponse : AmazonWebServiceResponse
    {
        private SubscriptionDetails _currentSubscription;
        private SubscriptionDetails _nextSubscription;
        private string _subscriptionArn;
        private string _subscriptionId;

        /// <summary>
        /// Gets and sets the property CurrentSubscription. 
        /// <para>
        /// The type of your current Amazon Q Business subscription.
        /// </para>
        /// </summary>
        public SubscriptionDetails CurrentSubscription
        {
            get { return this._currentSubscription; }
            set { this._currentSubscription = value; }
        }

        // Check to see if CurrentSubscription property is set
        internal bool IsSetCurrentSubscription()
        {
            return this._currentSubscription != null;
        }

        /// <summary>
        /// Gets and sets the property NextSubscription. 
        /// <para>
        /// The type of the Amazon Q Business subscription for the next month.
        /// </para>
        /// </summary>
        public SubscriptionDetails NextSubscription
        {
            get { return this._nextSubscription; }
            set { this._nextSubscription = value; }
        }

        // Check to see if NextSubscription property is set
        internal bool IsSetNextSubscription()
        {
            return this._nextSubscription != null;
        }

        /// <summary>
        /// Gets and sets the property SubscriptionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon Q Business subscription created.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=1224)]
        public string SubscriptionArn
        {
            get { return this._subscriptionArn; }
            set { this._subscriptionArn = value; }
        }

        // Check to see if SubscriptionArn property is set
        internal bool IsSetSubscriptionArn()
        {
            return this._subscriptionArn != null;
        }

        /// <summary>
        /// Gets and sets the property SubscriptionId. 
        /// <para>
        /// The identifier of the Amazon Q Business subscription created.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1224)]
        public string SubscriptionId
        {
            get { return this._subscriptionId; }
            set { this._subscriptionId = value; }
        }

        // Check to see if SubscriptionId property is set
        internal bool IsSetSubscriptionId()
        {
            return this._subscriptionId != null;
        }

    }
}