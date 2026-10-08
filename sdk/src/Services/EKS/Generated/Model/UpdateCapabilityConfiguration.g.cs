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

namespace Amazon.EKS.Model
{
    /// <summary>
    /// Configuration updates for a capability. The structure varies depending on the capability
    /// type.
    /// </summary>
    public partial class UpdateCapabilityConfiguration
    {
        /// <summary>
        /// Gets and sets the property Ack. 
        /// <para>
        /// Configuration updates specific to ACK (Amazon Web Services Controllers for Kubernetes)
        /// capabilities.
        /// </para>
        /// </summary>
        public UpdateAckConfig Ack { get; set; }

        /// <summary>
        /// Checks to see if the Ack property is set.
        /// </summary>
        internal bool IsSetAck() => this.Ack != null;

        /// <summary>
        /// Gets and sets the property ArgoCd. 
        /// <para>
        /// Configuration updates specific to Argo CD capabilities.
        /// </para>
        /// </summary>
        public UpdateArgoCdConfig ArgoCd { get; set; }

        /// <summary>
        /// Checks to see if the ArgoCd property is set.
        /// </summary>
        internal bool IsSetArgoCd() => this.ArgoCd != null;
    }
}
