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
 * Do not modify this file. This file is generated from the rbin-2021-06-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RecycleBin.Model
{
    /// <summary>
    /// Information about a Recycle Bin retention rule.
    /// </summary>
    public partial class RuleSummary
    {
        private string _description;
        private string _identifier;
        private LockState _lockState;
        private RetentionPeriod _retentionPeriod;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The retention rule description.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The unique ID of the retention rule.
        /// </para>
        /// </summary>
        public string Identifier
        {
            get { return this._identifier; }
            set { this._identifier = value; }
        }

        // Check to see if Identifier property is set
        internal bool IsSetIdentifier()
        {
            return this._identifier != null;
        }

        /// <summary>
        /// Gets and sets the property LockState. 
        /// <para>
        /// The lock state for the retention rule.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>locked</code> - The retention rule is locked and can't be modified or deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>pending_unlock</code> - The retention rule has been unlocked but it is still
        /// within the unlock delay period. The retention rule can be modified or deleted only
        /// after the unlock delay period has expired.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>unlocked</code> - The retention rule is unlocked and it can be modified or
        /// deleted by any user with the required permissions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>null</code> - The retention rule has never been locked. Once a retention rule
        /// has been locked, it can transition between the <code>locked</code> and <code>unlocked</code>
        /// states only; it can never transition back to <code>null</code>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public LockState LockState
        {
            get { return this._lockState; }
            set { this._lockState = value; }
        }

        // Check to see if LockState property is set
        internal bool IsSetLockState()
        {
            return this._lockState != null;
        }

        /// <summary>
        /// Gets and sets the property RetentionPeriod. 
        /// <para>
        /// Information about the retention period for which the retention rule is to retain resources.
        /// </para>
        /// </summary>
        public RetentionPeriod RetentionPeriod
        {
            get { return this._retentionPeriod; }
            set { this._retentionPeriod = value; }
        }

        // Check to see if RetentionPeriod property is set
        internal bool IsSetRetentionPeriod()
        {
            return this._retentionPeriod != null;
        }

    }
}