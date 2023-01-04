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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// Container for the parameters to the PutDestinationPolicy operation.
    /// Creates or updates an access policy associated with an existing destination. An access
    /// policy is an <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies_overview.html">IAM
    /// policy document</a> that is used to authorize claims to register a subscription filter
    /// against a given destination.
    /// </summary>
    public partial class PutDestinationPolicyRequest : AmazonCloudWatchLogsRequest
    {
        private string _accessPolicy;
        private string _destinationName;
        private bool? _forceUpdate;

        /// <summary>
        /// Gets and sets the property AccessPolicy. 
        /// <para>
        /// An IAM policy document that authorizes cross-account users to deliver their log events
        /// to the associated destination. This can be up to 5120 bytes.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string AccessPolicy
        {
            get { return this._accessPolicy; }
            set { this._accessPolicy = value; }
        }

        // Check to see if AccessPolicy property is set
        internal bool IsSetAccessPolicy()
        {
            return this._accessPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationName. 
        /// <para>
        /// A name for an existing destination.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string DestinationName
        {
            get { return this._destinationName; }
            set { this._destinationName = value; }
        }

        // Check to see if DestinationName property is set
        internal bool IsSetDestinationName()
        {
            return this._destinationName != null;
        }

        /// <summary>
        /// Gets and sets the property ForceUpdate. 
        /// <para>
        /// Specify true if you are updating an existing destination policy to grant permission
        /// to an organization ID instead of granting permission to individual AWS accounts. Before
        /// you update a destination policy this way, you must first update the subscription filters
        /// in the accounts that send logs to this destination. If you do not, the subscription
        /// filters might stop working. By specifying <code>true</code> for <code>forceUpdate</code>,
        /// you are affirming that you have already updated the subscription filters. For more
        /// information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/Cross-Account-Log_Subscription-Update.html">
        /// Updating an existing cross-account subscription</a> 
        /// </para>
        ///  
        /// <para>
        /// If you omit this parameter, the default of <code>false</code> is used.
        /// </para>
        /// </summary>
        public bool ForceUpdate
        {
            get { return this._forceUpdate.GetValueOrDefault(); }
            set { this._forceUpdate = value; }
        }

        // Check to see if ForceUpdate property is set
        internal bool IsSetForceUpdate()
        {
            return this._forceUpdate.HasValue; 
        }

    }
}