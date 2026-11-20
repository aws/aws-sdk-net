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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.APIPortal.Model
{
    /// <summary>
    /// The state of API discovery for one discovery source.
    /// </summary>
    public partial class DiscoveryStatus
    {
        /// <summary>
        /// Gets and sets the property AccountId. The AWS account ID the status applies to.
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property DiscoverySource.
        /// </summary>
        [AWSProperty(Required = true)]
        public DiscoverySource DiscoverySource { get; set; }

        /// <summary>
        /// Checks to see if the DiscoverySource property is set.
        /// </summary>
        internal bool IsSetDiscoverySource() => this.DiscoverySource != null;

        /// <summary>
        /// Gets and sets the property FailureReason. Typed reason for failure, present only when
        /// `status` is `FAILED`
        /// </summary>
        public DiscoveryFailureReason FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property Status. The current state of discovery for this source.
        /// </summary>
        [AWSProperty(Required = true)]
        public DiscoveryStatusValue Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
