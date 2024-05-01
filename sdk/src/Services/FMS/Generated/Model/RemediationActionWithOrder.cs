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
    /// An ordered list of actions you can take to remediate a violation.
    /// </summary>
    public partial class RemediationActionWithOrder
    {
        private int? _order;
        private RemediationAction _remediationAction;

        /// <summary>
        /// Gets and sets the property Order. 
        /// <para>
        /// The order of the remediation actions in the list.
        /// </para>
        /// </summary>
        [AWSProperty(Min=-2147483648, Max=2147483647)]
        public int? Order
        {
            get { return this._order; }
            set { this._order = value; }
        }

        // Check to see if Order property is set
        internal bool IsSetOrder()
        {
            return this._order.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RemediationAction. 
        /// <para>
        /// Information about an action you can take to remediate a violation.
        /// </para>
        /// </summary>
        public RemediationAction RemediationAction
        {
            get { return this._remediationAction; }
            set { this._remediationAction = value; }
        }

        // Check to see if RemediationAction property is set
        internal bool IsSetRemediationAction()
        {
            return this._remediationAction != null;
        }

    }
}