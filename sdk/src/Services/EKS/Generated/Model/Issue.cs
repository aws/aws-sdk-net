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
    /// An object representing an issue with an Amazon EKS resource.
    /// </summary>
    public partial class Issue
    {
        private NodegroupIssueCode _code;
        private string _message;
        private List<string> _resourceIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// A brief description of the error.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>AccessDenied</b>: Amazon EKS or one or more of your managed nodes is failing to
        /// authenticate or authorize with your Kubernetes cluster API server.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>AsgInstanceLaunchFailures</b>: Your Auto Scaling group is experiencing failures
        /// while attempting to launch instances.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>AutoScalingGroupNotFound</b>: We couldn't find the Auto Scaling group associated
        /// with the managed node group. You may be able to recreate an Auto Scaling group with
        /// the same settings to recover.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ClusterUnreachable</b>: Amazon EKS or one or more of your managed nodes is unable
        /// to to communicate with your Kubernetes cluster API server. This can happen if there
        /// are network disruptions or if API servers are timing out processing requests. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Ec2InstanceTypeDoesNotExist</b>: One or more of the supplied Amazon EC2 instance
        /// types do not exist. Amazon EKS checked for the instance types that you provided in
        /// this Amazon Web Services Region, and one or more aren't available.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Ec2LaunchTemplateNotFound</b>: We couldn't find the Amazon EC2 launch template
        /// for your managed node group. You may be able to recreate a launch template with the
        /// same settings to recover.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Ec2LaunchTemplateVersionMismatch</b>: The Amazon EC2 launch template version for
        /// your managed node group does not match the version that Amazon EKS created. You may
        /// be able to revert to the version that Amazon EKS created to recover.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Ec2SecurityGroupDeletionFailure</b>: We could not delete the remote access security
        /// group for your managed node group. Remove any dependencies from the security group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Ec2SecurityGroupNotFound</b>: We couldn't find the cluster security group for
        /// the cluster. You must recreate your cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Ec2SubnetInvalidConfiguration</b>: One or more Amazon EC2 subnets specified for
        /// a node group do not automatically assign public IP addresses to instances launched
        /// into it. If you want your instances to be assigned a public IP address, then you need
        /// to enable the <c>auto-assign public IP address</c> setting for the subnet. See <a
        /// href="https://docs.aws.amazon.com/vpc/latest/userguide/vpc-ip-addressing.html#subnet-public-ip">Modifying
        /// the public <c>IPv4</c> addressing attribute for your subnet</a> in the <i>Amazon VPC
        /// User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>IamInstanceProfileNotFound</b>: We couldn't find the IAM instance profile for
        /// your managed node group. You may be able to recreate an instance profile with the
        /// same settings to recover.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>IamNodeRoleNotFound</b>: We couldn't find the IAM role for your managed node group.
        /// You may be able to recreate an IAM role with the same settings to recover.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>InstanceLimitExceeded</b>: Your Amazon Web Services account is unable to launch
        /// any more instances of the specified instance type. You may be able to request an Amazon
        /// EC2 instance limit increase to recover.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>InsufficientFreeAddresses</b>: One or more of the subnets associated with your
        /// managed node group does not have enough available IP addresses for new nodes.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>InternalFailure</b>: These errors are usually caused by an Amazon EKS server-side
        /// issue.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>NodeCreationFailure</b>: Your launched instances are unable to register with your
        /// Amazon EKS cluster. Common causes of this failure are insufficient <a href="https://docs.aws.amazon.com/eks/latest/userguide/create-node-role.html">node
        /// IAM role</a> permissions or lack of outbound internet access for the nodes. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public NodegroupIssueCode Code
        {
            get { return this._code; }
            set { this._code = value; }
        }

        // Check to see if Code property is set
        internal bool IsSetCode()
        {
            return this._code != null;
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// The error message associated with the issue.
        /// </para>
        /// </summary>
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceIds. 
        /// <para>
        /// The Amazon Web Services resources that are afflicted by this issue.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ResourceIds
        {
            get { return this._resourceIds; }
            set { this._resourceIds = value; }
        }

        // Check to see if ResourceIds property is set
        internal bool IsSetResourceIds()
        {
            return this._resourceIds != null && (this._resourceIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}