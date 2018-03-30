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
 * Do not modify this file. This file is generated from the greengrass-2017-06-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Greengrass.Model
{
    /// <summary>
    /// Container for the parameters to the CreateSubscriptionDefinitionVersion operation.
    /// Creates a version of a subscription definition which has already been defined.
    /// </summary>
    public partial class CreateSubscriptionDefinitionVersionRequest : AmazonGreengrassRequest
    {
        private string _amznClientToken;
        private string _subscriptionDefinitionId;
        private List<Subscription> _subscriptions = new List<Subscription>();

        /// <summary>
        /// Gets and sets the property AmznClientToken. A client token used to correlate requests
        /// and responses.
        /// </summary>
        public string AmznClientToken
        {
            get { return this._amznClientToken; }
            set { this._amznClientToken = value; }
        }

        // Check to see if AmznClientToken property is set
        internal bool IsSetAmznClientToken()
        {
            return this._amznClientToken != null;
        }

        /// <summary>
        /// Gets and sets the property SubscriptionDefinitionId. The ID of the subscription definition.
        /// </summary>
        public string SubscriptionDefinitionId
        {
            get { return this._subscriptionDefinitionId; }
            set { this._subscriptionDefinitionId = value; }
        }

        // Check to see if SubscriptionDefinitionId property is set
        internal bool IsSetSubscriptionDefinitionId()
        {
            return this._subscriptionDefinitionId != null;
        }

        /// <summary>
        /// Gets and sets the property Subscriptions. A list of subscriptions.
        /// </summary>
        public List<Subscription> Subscriptions
        {
            get { return this._subscriptions; }
            set { this._subscriptions = value; }
        }

        // Check to see if Subscriptions property is set
        internal bool IsSetSubscriptions()
        {
            return this._subscriptions != null && this._subscriptions.Count > 0; 
        }

    }
}