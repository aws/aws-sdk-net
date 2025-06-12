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
    /// Container for the parameters to the CreateFargateProfile operation.
    /// Creates an Fargate profile for your Amazon EKS cluster. You must have at least one
    /// Fargate profile in a cluster to be able to run pods on Fargate.
    /// 
    ///  
    /// <para>
    /// The Fargate profile allows an administrator to declare which pods run on Fargate and
    /// specify which pods run on which Fargate profile. This declaration is done through
    /// the profile's selectors. Each profile can have up to five selectors that contain a
    /// namespace and labels. A namespace is required for every selector. The label field
    /// consists of multiple optional key-value pairs. Pods that match the selectors are scheduled
    /// on Fargate. If a to-be-scheduled pod matches any of the selectors in the Fargate profile,
    /// then that pod is run on Fargate.
    /// </para>
    ///  
    /// <para>
    /// When you create a Fargate profile, you must specify a pod execution role to use with
    /// the pods that are scheduled with the profile. This role is added to the cluster's
    /// Kubernetes <a href="https://kubernetes.io/docs/reference/access-authn-authz/rbac/">Role
    /// Based Access Control</a> (RBAC) for authorization so that the <c>kubelet</c> that
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
    /// If any Fargate profiles in a cluster are in the <c>DELETING</c> status, you must wait
    /// for that Fargate profile to finish deleting before you can create any other profiles
    /// in that cluster.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/fargate-profile.html">Fargate
    /// profile</a> in the <i>Amazon EKS User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateFargateProfileRequest : AmazonEKSRequest
    {
        private string _clientRequestToken;
        private string _clusterName;
        private string _fargateProfileName;
        private string _podExecutionRoleArn;
        private List<FargateProfileSelector> _selectors = AWSConfigs.InitializeCollections ? new List<FargateProfileSelector>() : null;
        private List<string> _subnets = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request.
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
        /// The name of your cluster.
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
        /// The Amazon Resource Name (ARN) of the <c>Pod</c> execution role to use for a <c>Pod</c>
        /// that matches the selectors in the Fargate profile. The <c>Pod</c> execution role allows
        /// Fargate infrastructure to register with your cluster as a node, and it provides read
        /// access to Amazon ECR image repositories. For more information, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/pod-execution-role.html">
        /// <c>Pod</c> execution role</a> in the <i>Amazon EKS User Guide</i>.
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
        /// The selectors to match for a <c>Pod</c> to use this Fargate profile. Each selector
        /// must have an associated Kubernetes <c>namespace</c>. Optionally, you can also specify
        /// <c>labels</c> for a <c>namespace</c>. You may specify up to five selectors in a Fargate
        /// profile.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FargateProfileSelector> Selectors
        {
            get { return this._selectors; }
            set { this._selectors = value; }
        }

        // Check to see if Selectors property is set
        internal bool IsSetSelectors()
        {
            return this._selectors != null && (this._selectors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Subnets. 
        /// <para>
        /// The IDs of subnets to launch a <c>Pod</c> into. A <c>Pod</c> running on Fargate isn't
        /// assigned a public IP address, so only private subnets (with no direct route to an
        /// Internet Gateway) are accepted for this parameter.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Subnets
        {
            get { return this._subnets; }
            set { this._subnets = value; }
        }

        // Check to see if Subnets property is set
        internal bool IsSetSubnets()
        {
            return this._subnets != null && (this._subnets.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Metadata that assists with categorization and organization. Each tag consists of a
        /// key and an optional value. You define both. Tags don't propagate to any other cluster
        /// or Amazon Web Services resources.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}