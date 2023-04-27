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

namespace Amazon.Kafka.Model
{
    /// <summary>
    /// This is the response object from the DescribeVpcConnection operation.
    /// </summary>
    public partial class DescribeVpcConnectionResponse : AmazonWebServiceResponse
    {
        private string _authentication;
        private DateTime? _creationTime;
        private List<string> _securityGroups = new List<string>();
        private VpcConnectionState _state;
        private List<string> _subnets = new List<string>();
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private string _targetClusterArn;
        private string _vpcConnectionArn;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property Authentication.             
        /// <para>
        /// The authentication type of VPC connection.
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
        /// The creation time of the VPC connection.
        /// </para>
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SecurityGroups.             
        /// <para>
        /// The list of security groups for the VPC connection.
        /// </para>
        /// </summary>
        public List<string> SecurityGroups
        {
            get { return this._securityGroups; }
            set { this._securityGroups = value; }
        }

        // Check to see if SecurityGroups property is set
        internal bool IsSetSecurityGroups()
        {
            return this._securityGroups != null && this._securityGroups.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property State.             
        /// <para>
        /// The state of VPC connection.
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
        /// Gets and sets the property Subnets.             
        /// <para>
        /// The list of subnets for the VPC connection.
        /// </para>
        /// </summary>
        public List<string> Subnets
        {
            get { return this._subnets; }
            set { this._subnets = value; }
        }

        // Check to see if Subnets property is set
        internal bool IsSetSubnets()
        {
            return this._subnets != null && this._subnets.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Tags.             
        /// <para>
        /// A map of tags for the VPC connection.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TargetClusterArn.             
        /// <para>
        /// The Amazon Resource Name (ARN) that uniquely identifies an MSK cluster.
        /// </para>
        /// </summary>
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
        /// The Amazon Resource Name (ARN) that uniquely identifies a MSK VPC connection.
        /// </para>
        /// </summary>
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
        /// The VPC Id for the VPC connection.
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