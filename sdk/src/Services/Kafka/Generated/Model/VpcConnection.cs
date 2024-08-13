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
 * Do not modify this file. This file is generated from the kafka-2018-11-14.normal.json service model.
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
namespace Amazon.Kafka.Model
{
    /// <summary>
    /// The VPC connection object.
    /// </summary>
    public partial class VpcConnection
    {
        private string _authentication;
        private DateTime? _creationTime;
        private VpcConnectionState _state;
        private string _targetClusterArn;
        private string _vpcConnectionArn;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property Authentication.             
        /// <para>
        /// Information about the auth scheme of Vpc Connection.
        /// </para>
        /// </summary>
        public string Authentication
        {
            get { return this._authentication; }
            set { this._authentication = value; }
        }

        // Check to see if Authentication property is set
        internal bool IsSetAuthentication()
        {
            return this._authentication != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime.             
        /// <para>
        /// Creation time of the Vpc Connection.
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property State.             
        /// <para>
        /// State of the Vpc Connection.
        /// </para>
        /// </summary>
        public VpcConnectionState State
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
        /// Gets and sets the property TargetClusterArn.             
        /// <para>
        /// The ARN that identifies the Cluster which the Vpc Connection belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TargetClusterArn
        {
            get { return this._targetClusterArn; }
            set { this._targetClusterArn = value; }
        }

        // Check to see if TargetClusterArn property is set
        internal bool IsSetTargetClusterArn()
        {
            return this._targetClusterArn != null;
        }

        /// <summary>
        /// Gets and sets the property VpcConnectionArn.             
        /// <para>
        /// The ARN that identifies the Vpc Connection.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string VpcConnectionArn
        {
            get { return this._vpcConnectionArn; }
            set { this._vpcConnectionArn = value; }
        }

        // Check to see if VpcConnectionArn property is set
        internal bool IsSetVpcConnectionArn()
        {
            return this._vpcConnectionArn != null;
        }

        /// <summary>
        /// Gets and sets the property VpcId.             
        /// <para>
        /// The vpcId that belongs to the Vpc Connection.
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