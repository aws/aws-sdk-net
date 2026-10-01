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
    /// Contains details about a specific EKS cluster version.
    /// </summary>
    public partial class ClusterVersionInformation
    {
        /// <summary>
        /// Gets and sets the property ClusterType. 
        /// <para>
        /// The type of cluster this version is for.
        /// </para>
        /// </summary>
        public string ClusterType { get; set; }

        /// <summary>
        /// Checks to see if the ClusterType property is set.
        /// </summary>
        internal bool IsSetClusterType() => this.ClusterType != null;

        /// <summary>
        /// Gets and sets the property ClusterVersion. 
        /// <para>
        /// The Kubernetes version for the cluster.
        /// </para>
        /// </summary>
        public string ClusterVersion { get; set; }

        /// <summary>
        /// Checks to see if the ClusterVersion property is set.
        /// </summary>
        internal bool IsSetClusterVersion() => this.ClusterVersion != null;

        /// <summary>
        /// Gets and sets the property ControlPlaneComponentConfig. 
        /// <para>
        /// The default control plane component configuration and constraints for this Kubernetes
        /// version.
        /// </para>
        /// </summary>
        public ControlPlaneConfigInfo ControlPlaneComponentConfig { get; set; }

        /// <summary>
        /// Checks to see if the ControlPlaneComponentConfig property is set.
        /// </summary>
        internal bool IsSetControlPlaneComponentConfig() => this.ControlPlaneComponentConfig != null;

        /// <summary>
        /// Gets and sets the property ControlPlaneScalingTiers. 
        /// <para>
        /// The available provisioned control plane scaling tiers and their capabilities for this
        /// Kubernetes version.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<ControlPlaneScalingTierInfo> ControlPlaneScalingTiers { get; set; } = AWSConfigs.InitializeCollections ? new List<ControlPlaneScalingTierInfo>() : null;

        /// <summary>
        /// Checks to see if the ControlPlaneScalingTiers property is set.
        /// </summary>
        internal bool IsSetControlPlaneScalingTiers() => this.ControlPlaneScalingTiers != null && (this.ControlPlaneScalingTiers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DefaultPlatformVersion. 
        /// <para>
        /// Default platform version for this Kubernetes version.
        /// </para>
        /// </summary>
        public string DefaultPlatformVersion { get; set; }

        /// <summary>
        /// Checks to see if the DefaultPlatformVersion property is set.
        /// </summary>
        internal bool IsSetDefaultPlatformVersion() => this.DefaultPlatformVersion != null;

        /// <summary>
        /// Gets and sets the property DefaultVersion. 
        /// <para>
        /// Indicates if this is a default version.
        /// </para>
        /// </summary>
        public bool? DefaultVersion { get; set; }

        /// <summary>
        /// Checks to see if the DefaultVersion property is set.
        /// </summary>
        internal bool IsSetDefaultVersion() => this.DefaultVersion.HasValue;

        /// <summary>
        /// Gets and sets the property EndOfExtendedSupportDate. 
        /// <para>
        /// Date when extended support ends for this version.
        /// </para>
        /// </summary>
        public DateTime? EndOfExtendedSupportDate { get; set; }

        /// <summary>
        /// Checks to see if the EndOfExtendedSupportDate property is set.
        /// </summary>
        internal bool IsSetEndOfExtendedSupportDate() => this.EndOfExtendedSupportDate.HasValue;

        /// <summary>
        /// Gets and sets the property EndOfStandardSupportDate. 
        /// <para>
        /// Date when standard support ends for this version.
        /// </para>
        /// </summary>
        public DateTime? EndOfStandardSupportDate { get; set; }

        /// <summary>
        /// Checks to see if the EndOfStandardSupportDate property is set.
        /// </summary>
        internal bool IsSetEndOfStandardSupportDate() => this.EndOfStandardSupportDate.HasValue;

        /// <summary>
        /// Gets and sets the property KubernetesPatchVersion. 
        /// <para>
        /// The patch version of Kubernetes for this cluster version.
        /// </para>
        /// </summary>
        public string KubernetesPatchVersion { get; set; }

        /// <summary>
        /// Checks to see if the KubernetesPatchVersion property is set.
        /// </summary>
        internal bool IsSetKubernetesPatchVersion() => this.KubernetesPatchVersion != null;

        /// <summary>
        /// Gets and sets the property ReleaseDate. 
        /// <para>
        /// The release date of this cluster version.
        /// </para>
        /// </summary>
        public DateTime? ReleaseDate { get; set; }

        /// <summary>
        /// Checks to see if the ReleaseDate property is set.
        /// </summary>
        internal bool IsSetReleaseDate() => this.ReleaseDate.HasValue;

        /// <summary>
        /// Gets and sets the property Status. <important> 
        /// <para>
        /// This field is deprecated. Use <c>versionStatus</c> instead, as that field matches
        /// for input and output of this action.
        /// </para>
        ///  </important> 
        /// <para>
        /// Current status of this cluster version.
        /// </para>
        /// </summary>
        public ClusterVersionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property VersionStatus. 
        /// <para>
        /// Current status of this cluster version.
        /// </para>
        /// </summary>
        public VersionStatus VersionStatus { get; set; }

        /// <summary>
        /// Checks to see if the VersionStatus property is set.
        /// </summary>
        internal bool IsSetVersionStatus() => this.VersionStatus != null;
    }
}
