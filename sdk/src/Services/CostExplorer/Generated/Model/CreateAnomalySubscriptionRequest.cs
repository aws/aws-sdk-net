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
    /// Adds an alert subscription to a cost anomaly detection monitor. You can use each subscription
    /// to define subscribers with email or SNS notifications. Email subscribers can set an
    /// absolute or percentage threshold and a time frequency for receiving notifications.
    /// </summary>
    public partial class CreateAnomalySubscriptionRequest : AmazonCostExplorerRequest
    {
        private AnomalySubscription _anomalySubscription;
        private List<ResourceTag> _resourceTags = new List<ResourceTag>();

        /// <summary>
        /// Gets and sets the property AnomalySubscription. 
        /// <para>
        /// The cost anomaly subscription object that you want to create. 
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

        /// <summary>
        /// Gets and sets the property ResourceTags. 
        /// <para>
        /// An optional list of tags to associate with the specified <a href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_AnomalySubscription.html">
        /// <code>AnomalySubscription</code> </a>. You can use resource tags to control access
        /// to your <code>subscription</code> using IAM policies.
        /// </para>
        ///  
        /// <para>
        /// Each tag consists of a key and a value, and each key must be unique for the resource.
        /// The following restrictions apply to resource tags:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Although the maximum number of array members is 200, you can assign a maximum of 50
        /// user-tags to one resource. The remaining are reserved for Amazon Web Services use
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The maximum length of a key is 128 characters
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The maximum length of a value is 256 characters
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Keys and values can only contain alphanumeric characters, spaces, and any of the following:
        /// <code>_.:/=+@-</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Keys and values are case sensitive
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Keys and values are trimmed for any leading or trailing whitespaces
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Don’t use <code>aws:</code> as a prefix for your keys. This prefix is reserved for
        /// Amazon Web Services use
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<ResourceTag> ResourceTags
        {
            get { return this._resourceTags; }
            set { this._resourceTags = value; }
        }

        // Check to see if ResourceTags property is set
        internal bool IsSetResourceTags()
        {
            return this._resourceTags != null && this._resourceTags.Count > 0; 
        }

    }
}