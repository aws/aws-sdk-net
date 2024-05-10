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
    /// Container for the parameters to the CreateVpcConnection operation.
    /// Creates a new MSK VPC connection.
    /// </summary>
    public partial class CreateVpcConnectionRequest : AmazonKafkaRequest
    {
        private string _authentication;
        private List<string> _clientSubnets = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _securityGroups = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _targetClusterArn;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property Authentication.             
        /// <para>
        /// The authentication type of VPC connection.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property ClientSubnets.             
        /// <para>
        /// The list of client subnets.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> ClientSubnets
        {
            get { return this._clientSubnets; }
            set { this._clientSubnets = value; }
        }

        // Check to see if ClientSubnets property is set
        internal bool IsSetClientSubnets()
        {
            return this._clientSubnets != null && (this._clientSubnets.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SecurityGroups.             
        /// <para>
        /// The list of security groups.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> SecurityGroups
        {
            get { return this._securityGroups; }
            set { this._securityGroups = value; }
        }

        // Check to see if SecurityGroups property is set
        internal bool IsSetSecurityGroups()
        {
            return this._securityGroups != null && (this._securityGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
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
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TargetClusterArn.             
        /// <para>
        /// The cluster Amazon Resource Name (ARN) for the VPC connection.
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
        /// Gets and sets the property VpcId.             
        /// <para>
        /// The VPC ID of VPC connection.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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