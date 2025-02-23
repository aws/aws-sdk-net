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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the EnableSnapshotBlockPublicAccess operation.
    /// Enables or modifies the <i>block public access for snapshots</i> setting at the account
    /// level for the specified Amazon Web Services Region. After you enable block public
    /// access for snapshots in a Region, users can no longer request public sharing for snapshots
    /// in that Region. Snapshots that are already publicly shared are either treated as private
    /// or they remain publicly shared, depending on the <b>State</b> that you specify.
    /// 
    ///  <important> 
    /// <para>
    /// Enabling block public access for snapshots in <i>block all sharing</i> mode does not
    /// change the permissions for snapshots that are already publicly shared. Instead, it
    /// prevents these snapshots from be publicly visible and publicly accessible. Therefore,
    /// the attributes for these snapshots still indicate that they are publicly shared, even
    /// though they are not publicly available.
    /// </para>
    ///  
    /// <para>
    /// If you later disable block public access or change the mode to <i>block new sharing</i>,
    /// these snapshots will become publicly available again.
    /// </para>
    ///  </important> 
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/ebs/latest/userguide/block-public-access-snapshots.html">
    /// Block public access for snapshots</a> in the <i>Amazon EBS User Guide</i>.
    /// </para>
    /// </summary>
    public partial class EnableSnapshotBlockPublicAccessRequest : AmazonEC2Request
    {
        private bool? _dryRun;
        private SnapshotBlockPublicAccessState _state;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The mode in which to enable block public access for snapshots for the Region. Specify
        /// one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>block-all-sharing</c> - Prevents all public sharing of snapshots in the Region.
        /// Users in the account will no longer be able to request new public sharing. Additionally,
        /// snapshots that are already publicly shared are treated as private and they are no
        /// longer publicly available.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>block-new-sharing</c> - Prevents only new public sharing of snapshots in the Region.
        /// Users in the account will no longer be able to request new public sharing. However,
        /// snapshots that are already publicly shared, remain publicly available.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <c>unblocked</c> is not a valid value for <b>EnableSnapshotBlockPublicAccess</b>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SnapshotBlockPublicAccessState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

    }
}