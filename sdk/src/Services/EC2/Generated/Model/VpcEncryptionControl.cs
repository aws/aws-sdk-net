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
    /// 
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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