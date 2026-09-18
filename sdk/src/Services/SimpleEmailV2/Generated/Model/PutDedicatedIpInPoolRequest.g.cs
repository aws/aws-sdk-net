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

namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// Container for the parameters to the PutDedicatedIpInPool operation. Move a dedicated
    /// IP address to an existing dedicated IP pool. <note> <para> The dedicated IP address
    /// that you specify must already exist, and must be associated with your Amazon Web Services
    /// account. </para> <para> The dedicated IP pool you specify must already exist. You
    /// can create a new pool by using the <c>CreateDedicatedIpPool</c> operation. </para>
    /// </note>
    /// </summary>
    public partial class PutDedicatedIpInPoolRequest : AmazonSimpleEmailServiceV2Request
    {
        /// <summary>
        /// Gets and sets the property DestinationPoolName. 
        /// <para>
        /// The name of the IP pool that you want to add the dedicated IP address to. You have
        /// to specify an IP pool that already exists.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DestinationPoolName { get; set; }

        /// <summary>
        /// Checks to see if the DestinationPoolName property is set.
        /// </summary>
        internal bool IsSetDestinationPoolName() => this.DestinationPoolName != null;

        /// <summary>
        /// Gets and sets the property Ip. 
        /// <para>
        /// The IP address that you want to move to the dedicated IP pool. The value you specify
        /// has to be a dedicated IP address that's associated with your Amazon Web Services account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Ip { get; set; }

        /// <summary>
        /// Checks to see if the Ip property is set.
        /// </summary>
        internal bool IsSetIp() => this.Ip != null;
    }
}
