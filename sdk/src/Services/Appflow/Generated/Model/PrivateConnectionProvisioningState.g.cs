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

namespace Amazon.Appflow.Model
{
    /// <summary>
    /// Specifies the private connection provisioning state.
    /// </summary>
    public partial class PrivateConnectionProvisioningState
    {
        /// <summary>
        /// Gets and sets the property FailureCause. 
        /// <para>
        ///  Specifies the private connection provisioning failure cause. 
        /// </para>
        /// </summary>
        public PrivateConnectionProvisioningFailureCause FailureCause { get; set; }

        /// <summary>
        /// Checks to see if the FailureCause property is set.
        /// </summary>
        internal bool IsSetFailureCause() => this.FailureCause != null;

        /// <summary>
        /// Gets and sets the property FailureMessage. 
        /// <para>
        ///  Specifies the private connection provisioning failure reason. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string FailureMessage { get; set; }

        /// <summary>
        /// Checks to see if the FailureMessage property is set.
        /// </summary>
        internal bool IsSetFailureMessage() => this.FailureMessage != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  Specifies the private connection provisioning status. 
        /// </para>
        /// </summary>
        public PrivateConnectionProvisioningStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
