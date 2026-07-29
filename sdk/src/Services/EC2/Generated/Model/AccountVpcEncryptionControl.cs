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
    /// Describes the account-level VPC Encryption Control configuration, including its mode,
    /// state, and exclusions.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/vpc-encryption-controls.html">Enforce
    /// VPC encryption in transit</a> in the <i>Amazon VPC User Guide</i>.
    /// </para>
    /// </summary>
    public partial class AccountVpcEncryptionControl
    {
        private AccountVpcEncryptionControlExclusions _exclusions;
        private DateTime? _lastUpdateTimestamp;
        private ManagedBy _managedBy;
        private AccountVpcEncryptionControlMode _mode;
        private AccountVpcEncryptionControlState _state;

        /// <summary>
        /// Gets and sets the property Exclusions. 
        /// <para>
        /// Information about the traffic exclusions for the account-level VPC Encryption Control
        /// configuration.
        /// </para>
        /// </summary>
        public AccountVpcEncryptionControlExclusions Exclusions
        {
            get { return this._exclusions; }
            set { this._exclusions = value; }
        }

        // Check to see if Exclusions property is set
        internal bool IsSetExclusions()
        {
            return this._exclusions != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdateTimestamp. 
        /// <para>
        /// The date and time when the account-level VPC Encryption Control configuration was
        /// last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdateTimestamp
        {
            get { return this._lastUpdateTimestamp; }
            set { this._lastUpdateTimestamp = value; }
        }

        // Check to see if LastUpdateTimestamp property is set
        internal bool IsSetLastUpdateTimestamp()
        {
            return this._lastUpdateTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ManagedBy. 
        /// <para>
        /// The entity that manages the account-level VPC Encryption Control configuration.
        /// </para>
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
        /// Gets and sets the property Mode. 
        /// <para>
        /// The encryption mode for the account-level VPC Encryption Control configuration.
        /// </para>
        /// </summary>
        public AccountVpcEncryptionControlMode Mode
        {
            get { return this._mode; }
            set { this._mode = value; }
        }

        // Check to see if Mode property is set
        internal bool IsSetMode()
        {
            return this._mode != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the account-level VPC Encryption Control configuration.
        /// </para>
        /// </summary>
        public AccountVpcEncryptionControlState State
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