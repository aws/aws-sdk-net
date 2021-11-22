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
    /// An object representing an Fargate profile.
    /// </summary>
    public partial class FargateProfile
    {
        private string _clusterName;
        private DateTime? _createdAt;
        private string _fargateProfileArn;
        private string _fargateProfileName;
        private string _podExecutionRoleArn;
        private List<FargateProfileSelector> _selectors = new List<FargateProfileSelector>();
        private FargateProfileStatus _status;
        private List<string> _subnets = new List<string>();
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name of the Amazon EKS cluster that the Fargate profile belongs to.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The Unix epoch timestamp in seconds for when the Fargate profile was created.
        /// </para>
        /// </summary>
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FargateProfileArn. 
        /// <para>
        /// The full Amazon Resource Name (ARN) of the Fargate profile.
        /// </para>
        /// </summary>
        public string FargateProfileArn
        {
            get { return this._fargateProfileArn; }
            set { this._fargateProfileArn = value; }
        }

        // Check to see if FargateProfileArn property is set
        internal bool IsSetFargateProfileArn()
        {
            return this._fargateProfileArn != null;
        }

        /// <summary>
        /// Gets and sets the property FargateProfileName. 
        /// <para>
        /// The name of the Fargate profile.
        /// </para>
        /// </summary>
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
        /// the selectors in the Fargate profile. For more information, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/pod-execution-role.html">Pod
        /// Execution Role</a> in the <i>Amazon EKS User Guide</i>.
        /// </para>
        /// </summary>
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
        /// The selectors to match for pods to use this Fargate profile.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the Fargate profile.
        /// </para>
        /// </summary>
        public FargateProfileStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Subnets. 
        /// <para>
        /// The IDs of subnets to launch pods into.
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
        /// The metadata applied to the Fargate profile to assist with categorization and organization.
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