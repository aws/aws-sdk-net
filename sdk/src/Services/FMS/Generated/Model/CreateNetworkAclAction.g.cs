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

namespace Amazon.FMS.Model
{
    /// <summary>
    /// Information about the <c>CreateNetworkAcl</c> action in Amazon EC2. This is a remediation
    /// option in <c>RemediationAction</c>.
    /// </summary>
    public partial class CreateNetworkAclAction
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Brief description of this remediation action. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property FMSCanRemediate. 
        /// <para>
        /// Indicates whether it is possible for Firewall Manager to perform this remediation
        /// action. A false value indicates that auto remediation is disabled or Firewall Manager
        /// is unable to perform the action due to a conflict of some kind.
        /// </para>
        /// </summary>
        public bool? FMSCanRemediate { get; set; }

        /// <summary>
        /// Checks to see if the FMSCanRemediate property is set.
        /// </summary>
        internal bool IsSetFMSCanRemediate() => this.FMSCanRemediate.HasValue;

        /// <summary>
        /// Gets and sets the property Vpc. 
        /// <para>
        /// The VPC that's associated with the remediation action.
        /// </para>
        /// </summary>
        public ActionTarget Vpc { get; set; }

        /// <summary>
        /// Checks to see if the Vpc property is set.
        /// </summary>
        internal bool IsSetVpc() => this.Vpc != null;
    }
}
