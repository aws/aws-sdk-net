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

namespace Amazon.Wickr.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateGuestUser operation. Updates the block status
    /// of a guest user in a Wickr network. This operation allows you to block or unblock
    /// a guest user from accessing the network.
    /// </summary>
    public partial class UpdateGuestUserRequest : AmazonWickrRequest
    {
        /// <summary>
        /// Gets and sets the property Block. 
        /// <para>
        /// Set to true to block the guest user or false to unblock them.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? Block { get; set; }

        /// <summary>
        /// Checks to see if the Block property is set.
        /// </summary>
        internal bool IsSetBlock() => this.Block.HasValue;

        /// <summary>
        /// Gets and sets the property NetworkId. 
        /// <para>
        /// The ID of the Wickr network where the guest user's status will be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 8, Max = 8)]
        public string NetworkId { get; set; }

        /// <summary>
        /// Checks to see if the NetworkId property is set.
        /// </summary>
        internal bool IsSetNetworkId() => this.NetworkId != null;

        /// <summary>
        /// Gets and sets the property UsernameHash. 
        /// <para>
        /// The username hash (unique identifier) of the guest user to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string UsernameHash { get; set; }

        /// <summary>
        /// Checks to see if the UsernameHash property is set.
        /// </summary>
        internal bool IsSetUsernameHash() => this.UsernameHash != null;
    }
}
