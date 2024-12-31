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
    /// This is the response object from the GetSnapshotBlockPublicAccessState operation.
    /// </summary>
    public partial class GetSnapshotBlockPublicAccessStateResponse : AmazonWebServiceResponse
    {
        private ManagedBy _managedBy;
        private SnapshotBlockPublicAccessState _state;

        /// <summary>
        /// Gets and sets the property ManagedBy. 
        /// <para>
        /// The entity that manages the state for block public access for snapshots. Possible
        /// values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>account</c> - The state is managed by the account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>declarative-policy</c> - The state is managed by a declarative policy and can't
        /// be modified by the account.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ManagedBy ManagedBy
        {
            get { return this._managedBy; }
            set { this._managedBy = value; }
        }

        // Check to see if ManagedBy property is set
        internal bool IsSetManagedBy()
        {
            return this._managedBy != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of block public access for snapshots. Possible values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>block-all-sharing</c> - All public sharing of snapshots is blocked. Users in the
        /// account can't request new public sharing. Additionally, snapshots that were already
        /// publicly shared are treated as private and are not publicly available.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>block-new-sharing</c> - Only new public sharing of snapshots is blocked. Users
        /// in the account can't request new public sharing. However, snapshots that were already
        /// publicly shared, remain publicly available.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>unblocked</c> - Public sharing is not blocked. Users can publicly share snapshots.
        /// </para>
        ///  </li> </ul>
        /// </summary>
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