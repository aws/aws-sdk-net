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
    /// An object representing an Fargate profile.
    /// </summary>
    public partial class FargateProfile
    {
        private string _clusterName;
        private DateTime? _createdAt;
        private string _fargateProfileArn;
        private string _fargateProfileName;
        private FargateProfileHealth _health;
        private string _podExecutionRoleArn;
        private List<FargateProfileSelector> _selectors = AWSConfigs.InitializeCollections ? new List<FargateProfileSelector>() : null;
        private FargateProfileStatus _status;
        private List<string> _subnets = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name of your cluster.
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
        /// The Unix epoch timestamp at object creation.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
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
        /// Gets and sets the property Health. 
        /// <para>
        /// The health status of the Fargate profile. If there are issues with your Fargate profile's
        /// health, they are listed here.
        /// </para>
        /// </summary>
        public FargateProfileHealth Health
        {
            get { return this._health; }
            set { this._health = value; }
        }

        // Check to see if Health property is set
        internal bool IsSetHealth()
        {
            return this._health != null;
        }

        /// <summary>
        /// Gets and sets the property PodExecutionRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the <c>Pod</c> execution role to use for any <c>Pod</c>
        /// that matches the selectors in the Fargate profile. For more information, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/pod-execution-role.html">
        /// <c>Pod</c> execution role</a> in the <i>Amazon EKS User Guide</i>.
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
        /// The selectors to match for a <c>Pod</c> to use this Fargate profile.
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
        /// The IDs of subnets to launch a <c>Pod</c> into.
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