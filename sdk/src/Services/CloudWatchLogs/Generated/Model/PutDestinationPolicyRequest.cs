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
    /// 
    ///  
    /// <para>
    /// If multiple AWS accounts are sending logs to this destination, each sender account
    /// must be listed separately in the policy. The policy does not support specifying <code>*</code>
    /// as the Principal or the use of the <code>aws:PrincipalOrgId</code> global key.
    /// </para>
    /// </summary>
    public partial class PutDestinationPolicyRequest : AmazonCloudWatchLogsRequest
    {
        private string _accessPolicy;
        private string _destinationName;

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

    }
}