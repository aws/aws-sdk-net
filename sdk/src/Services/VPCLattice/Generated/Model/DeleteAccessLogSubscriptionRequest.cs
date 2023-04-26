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
 * Do not modify this file. This file is generated from the vpc-lattice-2022-11-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.VPCLattice.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteAccessLogSubscription operation.
    /// Deletes the specified access log subscription.
    /// </summary>
    public partial class DeleteAccessLogSubscriptionRequest : AmazonVPCLatticeRequest
    {
        private string _accessLogSubscriptionIdentifier;

        /// <summary>
        /// Gets and sets the property AccessLogSubscriptionIdentifier. 
        /// <para>
        /// The ID or Amazon Resource Name (ARN) of the access log subscription.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=17, Max=2048)]
        public string AccessLogSubscriptionIdentifier
        {
            get { return this._accessLogSubscriptionIdentifier; }
            set { this._accessLogSubscriptionIdentifier = value; }
        }

        // Check to see if AccessLogSubscriptionIdentifier property is set
        internal bool IsSetAccessLogSubscriptionIdentifier()
        {
            return this._accessLogSubscriptionIdentifier != null;
        }

    }
}