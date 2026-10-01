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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name of your cluster.
        /// </para>
        /// </summary>
        public string ClusterName { get; set; }

        /// <summary>
        /// Checks to see if the ClusterName property is set.
        /// </summary>
        internal bool IsSetClusterName() => this.ClusterName != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The Unix epoch timestamp at object creation.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property FargateProfileArn. 
        /// <para>
        /// The full Amazon Resource Name (ARN) of the Fargate profile.
        /// </para>
        /// </summary>
        public string FargateProfileArn { get; set; }

        /// <summary>
        /// Checks to see if the FargateProfileArn property is set.
        /// </summary>
        internal bool IsSetFargateProfileArn() => this.FargateProfileArn != null;

        /// <summary>
        /// Gets and sets the property FargateProfileName. 
        /// <para>
        /// The name of the Fargate profile.
        /// </para>
        /// </summary>
        public string FargateProfileName { get; set; }

        /// <summary>
        /// Checks to see if the FargateProfileName property is set.
        /// </summary>
        internal bool IsSetFargateProfileName() => this.FargateProfileName != null;

        /// <summary>
        /// Gets and sets the property Health. 
        /// <para>
        /// The health status of the Fargate profile. If there are issues with your Fargate profile's
        /// health, they are listed here.
        /// </para>
        /// </summary>
        public FargateProfileHealth Health { get; set; }

        /// <summary>
        /// Checks to see if the Health property is set.
        /// </summary>
        internal bool IsSetHealth() => this.Health != null;

        /// <summary>
        /// Gets and sets the property PodExecutionRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the <c>Pod</c> execution role to use for any <c>Pod</c>
        /// that matches the selectors in the Fargate profile. For more information, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/pod-execution-role.html">
        /// <c>Pod</c> execution role</a> in the <i>Amazon EKS User Guide</i>.
        /// </para>
        /// </summary>
        public string PodExecutionRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the PodExecutionRoleArn property is set.
        /// </summary>
        internal bool IsSetPodExecutionRoleArn() => this.PodExecutionRoleArn != null;

        /// <summary>
        /// Gets and sets the property Selectors. 
        /// <para>
        /// The selectors to match for a <c>Pod</c> to use this Fargate profile.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FargateProfileSelector> Selectors { get; set; } = AWSConfigs.InitializeCollections ? new List<FargateProfileSelector>() : null;

        /// <summary>
        /// Checks to see if the Selectors property is set.
        /// </summary>
        internal bool IsSetSelectors() => this.Selectors != null && (this.Selectors.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the Fargate profile.
        /// </para>
        /// </summary>
        public FargateProfileStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Subnets. 
        /// <para>
        /// The IDs of subnets to launch a <c>Pod</c> into.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Subnets { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Subnets property is set.
        /// </summary>
        internal bool IsSetSubnets() => this.Subnets != null && (this.Subnets.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Metadata that assists with categorization and organization. Each tag consists of a
        /// key and an optional value. You define both. Tags don't propagate to any other cluster
        /// or Amazon Web Services resources.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
