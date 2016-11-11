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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// Container for the parameters to the PutDestinationPolicy operation.
    /// Creates or updates an access policy associated with an existing destination. An access
    /// policy is an <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/policies_overview.html">IAM
    /// policy document</a> that is used to authorize claims to register a subscription filter
    /// against a given destination.
    /// </summary>
    public partial class PutDestinationPolicyRequest : AmazonCloudWatchLogsRequest
    {
        private string _accessPolicy;
        private string _destinationName;

        /// <summary>
        /// Gets and sets the property AccessPolicy. 
        /// <para>
        /// An IAM policy document that authorizes cross-account users to deliver their log events
        /// to the associated destination.
        /// </para>
        /// </summary>
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