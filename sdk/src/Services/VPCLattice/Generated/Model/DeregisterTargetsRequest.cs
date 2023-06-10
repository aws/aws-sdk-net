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
    /// Container for the parameters to the DeregisterTargets operation.
    /// Deregisters the specified targets from the specified target group.
    /// </summary>
    public partial class DeregisterTargetsRequest : AmazonVPCLatticeRequest
    {
        private string _targetGroupIdentifier;
        private List<Target> _targets = new List<Target>();

        /// <summary>
        /// Gets and sets the property TargetGroupIdentifier. 
        /// <para>
        /// The ID or Amazon Resource Name (ARN) of the target group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=17, Max=2048)]
        public string TargetGroupIdentifier
        {
            get { return this._targetGroupIdentifier; }
            set { this._targetGroupIdentifier = value; }
        }

        // Check to see if TargetGroupIdentifier property is set
        internal bool IsSetTargetGroupIdentifier()
        {
            return this._targetGroupIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Targets. 
        /// <para>
        /// The targets to deregister.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public List<Target> Targets
        {
            get { return this._targets; }
            set { this._targets = value; }
        }

        // Check to see if Targets property is set
        internal bool IsSetTargets()
        {
            return this._targets != null && this._targets.Count > 0; 
        }

    }
}