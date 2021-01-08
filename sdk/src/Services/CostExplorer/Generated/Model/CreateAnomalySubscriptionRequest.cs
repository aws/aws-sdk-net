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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// Container for the parameters to the CreateAnomalySubscription operation.
    /// Adds a subscription to a cost anomaly detection monitor. You can use each subscription
    /// to define subscribers with email or SNS notifications. Email subscribers can set a
    /// dollar threshold and a time frequency for receiving notifications.
    /// </summary>
    public partial class CreateAnomalySubscriptionRequest : AmazonCostExplorerRequest
    {
        private AnomalySubscription _anomalySubscription;

        /// <summary>
        /// Gets and sets the property AnomalySubscription. 
        /// <para>
        ///  The cost anomaly subscription object that you want to create. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AnomalySubscription AnomalySubscription
        {
            get { return this._anomalySubscription; }
            set { this._anomalySubscription = value; }
        }

        // Check to see if AnomalySubscription property is set
        internal bool IsSetAnomalySubscription()
        {
            return this._anomalySubscription != null;
        }

    }
}