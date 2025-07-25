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
 * Do not modify this file. This file is generated from the eks-2017-11-01.normal.json service model.
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
namespace Amazon.EKS.Model
{
    /// <summary>
    /// An object representing the resources associated with the node group, such as Auto
    /// Scaling groups and security groups for remote access.
    /// </summary>
    public partial class NodegroupResources
    {
        private List<AutoScalingGroup> _autoScalingGroups = AWSConfigs.InitializeCollections ? new List<AutoScalingGroup>() : null;
        private string _remoteAccessSecurityGroup;

        /// <summary>
        /// Gets and sets the property AutoScalingGroups. 
        /// <para>
        /// The Auto Scaling groups associated with the node group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AutoScalingGroup> AutoScalingGroups
        {
            get { return this._autoScalingGroups; }
            set { this._autoScalingGroups = value; }
        }

        // Check to see if AutoScalingGroups property is set
        internal bool IsSetAutoScalingGroups()
        {
            return this._autoScalingGroups != null && (this._autoScalingGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RemoteAccessSecurityGroup. 
        /// <para>
        /// The remote access security group associated with the node group. This security group
        /// controls SSH access to the nodes.
        /// </para>
        /// </summary>
        public string RemoteAccessSecurityGroup
        {
            get { return this._remoteAccessSecurityGroup; }
            set { this._remoteAccessSecurityGroup = value; }
        }

        // Check to see if RemoteAccessSecurityGroup property is set
        internal bool IsSetRemoteAccessSecurityGroup()
        {
            return this._remoteAccessSecurityGroup != null;
        }

    }
}