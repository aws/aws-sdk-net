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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.VPCLattice.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteTargetGroup operation.
    /// Deletes a target group. You can't delete a target group if it is used in a listener
    /// rule or if the target group creation is in progress.
    /// </summary>
    public partial class DeleteTargetGroupRequest : AmazonVPCLatticeRequest
    {
        private string _targetGroupIdentifier;

        /// <summary>
        /// Gets and sets the property TargetGroupIdentifier. 
        /// <para>
        /// The ID or ARN of the target group.
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

    }
}