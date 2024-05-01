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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
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
        private string _description;
        private bool? _fmsCanRemediate;
        private ActionTarget _vpc;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Brief description of this remediation action. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property FMSCanRemediate. 
        /// <para>
        /// Indicates whether it is possible for Firewall Manager to perform this remediation
        /// action. A false value indicates that auto remediation is disabled or Firewall Manager
        /// is unable to perform the action due to a conflict of some kind.
        /// </para>
        /// </summary>
        public bool? FMSCanRemediate
        {
            get { return this._fmsCanRemediate; }
            set { this._fmsCanRemediate = value; }
        }

        // Check to see if FMSCanRemediate property is set
        internal bool IsSetFMSCanRemediate()
        {
            return this._fmsCanRemediate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Vpc. 
        /// <para>
        /// The VPC that's associated with the remediation action.
        /// </para>
        /// </summary>
        public ActionTarget Vpc
        {
            get { return this._vpc; }
            set { this._vpc = value; }
        }

        // Check to see if Vpc property is set
        internal bool IsSetVpc()
        {
            return this._vpc != null;
        }

    }
}