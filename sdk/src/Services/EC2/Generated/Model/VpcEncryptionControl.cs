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
    /// Describes the configuration and state of VPC encryption controls.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/vpc-encryption-controls.html">Enforce
    /// VPC encryption in transit</a> in the <i>Amazon VPC User Guide</i>.
    /// </para>
    /// </summary>
    public partial class VpcEncryptionControl
    {
        private VpcEncryptionControlMode _mode;
        private VpcEncryptionControlExclusions _resourceExclusions;
        private VpcEncryptionControlState _state;
        private string _stateMessage;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _vpcEncryptionControlId;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// The encryption mode for the VPC Encryption Control configuration.
        /// </para>
        /// </summary>
        public VpcEncryptionControlMode Mode
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
        /// Gets and sets the property ResourceExclusions. 
        /// <para>
        /// Information about resource exclusions for the VPC Encryption Control configuration.
        /// </para>
        /// </summary>
        public VpcEncryptionControlExclusions ResourceExclusions
        {
            get { return this._resourceExclusions; }
            set { this._resourceExclusions = value; }
        }

        // Check to see if ResourceExclusions property is set
        internal bool IsSetResourceExclusions()
        {
            return this._resourceExclusions != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the VPC Encryption Control configuration.
        /// </para>
        /// </summary>
        public VpcEncryptionControlState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property StateMessage. 
        /// <para>
        /// A message providing additional information about the encryption control state.
        /// </para>
        /// </summary>
        public string StateMessage
        {
            get { return this._stateMessage; }
            set { this._stateMessage = value; }
        }

        // Check to see if StateMessage property is set
        internal bool IsSetStateMessage()
        {
            return this._stateMessage != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags assigned to the VPC Encryption Control configuration.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VpcEncryptionControlId. 
        /// <para>
        /// The ID of the VPC Encryption Control configuration.
        /// </para>
        /// </summary>
        public string VpcEncryptionControlId
        {
            get { return this._vpcEncryptionControlId; }
            set { this._vpcEncryptionControlId = value; }
        }

        // Check to see if VpcEncryptionControlId property is set
        internal bool IsSetVpcEncryptionControlId()
        {
            return this._vpcEncryptionControlId != null;
        }

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the VPC associated with the encryption control configuration.
        /// </para>
        /// </summary>
        public string VpcId
        {
            get { return this._vpcId; }
            set { this._vpcId = value; }
        }

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this._vpcId != null;
        }

    }
}