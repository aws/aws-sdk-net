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

namespace Amazon.EKS.Model
{
    /// <summary>
    /// Container for the parameters to the CreateFargateProfile operation.
    /// Creates an Fargate profile for your Amazon EKS cluster. You must have at least one
    /// Fargate profile in a cluster to be able to run pods on Fargate.
    /// 
    ///  
    /// <para>
    /// The Fargate profile allows an administrator to declare which pods run on Fargate and
    /// specify which pods run on which Fargate profile. This declaration is done through
    /// the profile’s selectors. Each profile can have up to five selectors that contain a
    /// namespace and labels. A namespace is required for every selector. The label field
    /// consists of multiple optional key-value pairs. Pods that match the selectors are scheduled
    /// on Fargate. If a to-be-scheduled pod matches any of the selectors in the Fargate profile,
    /// then that pod is run on Fargate.
    /// </para>
    ///  
    /// <para>
    /// When you create a Fargate profile, you must specify a pod execution role to use with
    /// the pods that are scheduled with the profile. This role is added to the cluster's
    /// Kubernetes <a href="https://kubernetes.io/docs/admin/authorization/rbac/">Role Based
    /// Access Control</a> (RBAC) for authorization so that the <code>kubelet</code> that
    /// is running on the Fargate infrastructure can register with your Amazon EKS cluster
    /// so that it can appear in your cluster as a node. The pod execution role also provides
    /// IAM permissions to the Fargate infrastructure to allow read access to Amazon ECR image
    /// repositories. For more information, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/pod-execution-role.html">Pod
    /// Execution Role</a> in the <i>Amazon EKS User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// Fargate profiles are immutable. However, you can create a new updated profile to replace
    /// an existing profile and then delete the original after the updated profile has finished
    /// creating.
    /// </para>
    ///  
    /// <para>
    /// If any Fargate profiles in a cluster are in the <code>DELETING</code> status, you
    /// must wait for that Fargate profile to finish deleting before you can create any other
    /// profiles in that cluster.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/fargate-profile.html">Fargate
    /// Profile</a> in the <i>Amazon EKS User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateFargateProfileRequest : AmazonEKSRequest
    {
        private string _clientRequestToken;
        private string _clusterName;
        private string _fargateProfileName;
        private string _podExecutionRoleArn;
        private List<FargateProfileSelector> _selectors = new List<FargateProfileSelector>();
        private List<string> _subnets = new List<string>();
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request.
        /// </para>
        /// </summary>
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name of the Amazon EKS cluster to apply the Fargate profile to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ClusterName
        {
            get { return this._clusterName; }
            set { this._clusterName = value; }
        }

        // Check to see if ClusterName property is set
        internal bool IsSetClusterName()
        {
            return this._clusterName != null;
        }

        /// <summary>
        /// Gets and sets the property FargateProfileName. 
        /// <para>
        /// The name of the Fargate profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FargateProfileName
        {
            get { return this._fargateProfileName; }
            set { this._fargateProfileName = value; }
        }

        // Check to see if FargateProfileName property is set
        internal bool IsSetFargateProfileName()
        {
            return this._fargateProfileName != null;
        }

        /// <summary>
        /// Gets and sets the property PodExecutionRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the pod execution role to use for pods that match
        /// the selectors in the Fargate profile. The pod execution role allows Fargate infrastructure
        /// to register with your cluster as a node, and it provides read access to Amazon ECR
        /// image repositories. For more information, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/pod-execution-role.html">Pod
        /// Execution Role</a> in the <i>Amazon EKS User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PodExecutionRoleArn
        {
            get { return this._podExecutionRoleArn; }
            set { this._podExecutionRoleArn = value; }
        }

        // Check to see if PodExecutionRoleArn property is set
        internal bool IsSetPodExecutionRoleArn()
        {
            return this._podExecutionRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Selectors. 
        /// <para>
        /// The selectors to match for pods to use this Fargate profile. Each selector must have
        /// an associated namespace. Optionally, you can also specify labels for a namespace.
        /// You may specify up to five selectors in a Fargate profile.
        /// </para>
        /// </summary>
        public List<FargateProfileSelector> Selectors
        {
            get { return this._selectors; }
            set { this._selectors = value; }
        }

        // Check to see if Selectors property is set
        internal bool IsSetSelectors()
        {
            return this._selectors != null && this._selectors.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Subnets. 
        /// <para>
        /// The IDs of subnets to launch your pods into. At this time, pods running on Fargate
        /// are not assigned public IP addresses, so only private subnets (with no direct route
        /// to an Internet Gateway) are accepted for this parameter.
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
        /// The metadata to apply to the Fargate profile to assist with categorization and organization.
        /// Each tag consists of a key and an optional value. You define both. Fargate profile
        /// tags do not propagate to any other resources associated with the Fargate profile,
        /// such as the pods that are scheduled with it.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
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

    }
}