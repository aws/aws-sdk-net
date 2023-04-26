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
    /// Describes the action for a rule. Each rule must include exactly one of the following
    /// types of actions: <code>forward </code>or <code>fixed-response</code>, and it must
    /// be the last action to be performed.
    /// </summary>
    public partial class RuleAction
    {
        private FixedResponseAction _fixedResponse;
        private ForwardAction _forward;

        /// <summary>
        /// Gets and sets the property FixedResponse. 
        /// <para>
        ///  Describes the rule action that returns a custom HTTP response. 
        /// </para>
        /// </summary>
        public FixedResponseAction FixedResponse
        {
            get { return this._fixedResponse; }
            set { this._fixedResponse = value; }
        }

        // Check to see if FixedResponse property is set
        internal bool IsSetFixedResponse()
        {
            return this._fixedResponse != null;
        }

        /// <summary>
        /// Gets and sets the property Forward. 
        /// <para>
        /// The forward action. Traffic that matches the rule is forwarded to the specified target
        /// groups.
        /// </para>
        /// </summary>
        public ForwardAction Forward
        {
            get { return this._forward; }
            set { this._forward = value; }
        }

        // Check to see if Forward property is set
        internal bool IsSetForward()
        {
            return this._forward != null;
        }

    }
}