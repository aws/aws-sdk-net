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
 * Do not modify this file. This file is generated from the workdocs-2016-05-01.normal.json service model.
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
namespace Amazon.WorkDocs.Model
{
    /// <summary>
    /// Describes a subscription.
    /// </summary>
    public partial class Subscription
    {
        private string _endPoint;
        private SubscriptionProtocolType _protocol;
        private string _subscriptionId;

        /// <summary>
        /// Gets and sets the property EndPoint. 
        /// <para>
        /// The endpoint of the subscription.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string EndPoint
        {
            get { return this._endPoint; }
            set { this._endPoint = value; }
        }

        // Check to see if EndPoint property is set
        internal bool IsSetEndPoint()
        {
            return this._endPoint != null;
        }

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The protocol of the subscription.
        /// </para>
        /// </summary>
        public SubscriptionProtocolType Protocol
        {
            get { return this._protocol; }
            set { this._protocol = value; }
        }

        // Check to see if Protocol property is set
        internal bool IsSetProtocol()
        {
            return this._protocol != null;
        }

        /// <summary>
        /// Gets and sets the property SubscriptionId. 
        /// <para>
        /// The ID of the subscription.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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