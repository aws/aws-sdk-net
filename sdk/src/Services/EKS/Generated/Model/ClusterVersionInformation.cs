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
    /// Contains details about a specific EKS cluster version.
    /// </summary>
    public partial class ClusterVersionInformation
    {
        private string _clusterType;
        private string _clusterVersion;
        private string _defaultPlatformVersion;
        private bool? _defaultVersion;
        private DateTime? _endOfExtendedSupportDate;
        private DateTime? _endOfStandardSupportDate;
        private string _kubernetesPatchVersion;
        private DateTime? _releaseDate;
        private ClusterVersionStatus _status;
        private VersionStatus _versionStatus;

        /// <summary>
        /// Gets and sets the property ClusterType. 
        /// <para>
        /// The type of cluster this version is for.
        /// </para>
        /// </summary>
        public string ClusterType
        {
            get { return this._clusterType; }
            set { this._clusterType = value; }
        }

        // Check to see if ClusterType property is set
        internal bool IsSetClusterType()
        {
            return this._clusterType != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterVersion. 
        /// <para>
        /// The Kubernetes version for the cluster.
        /// </para>
        /// </summary>
        public string ClusterVersion
        {
            get { return this._clusterVersion; }
            set { this._clusterVersion = value; }
        }

        // Check to see if ClusterVersion property is set
        internal bool IsSetClusterVersion()
        {
            return this._clusterVersion != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultPlatformVersion. 
        /// <para>
        /// Default platform version for this Kubernetes version.
        /// </para>
        /// </summary>
        public string DefaultPlatformVersion
        {
            get { return this._defaultPlatformVersion; }
            set { this._defaultPlatformVersion = value; }
        }

        // Check to see if DefaultPlatformVersion property is set
        internal bool IsSetDefaultPlatformVersion()
        {
            return this._defaultPlatformVersion != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultVersion. 
        /// <para>
        /// Indicates if this is a default version.
        /// </para>
        /// </summary>
        public bool? DefaultVersion
        {
            get { return this._defaultVersion; }
            set { this._defaultVersion = value; }
        }

        // Check to see if DefaultVersion property is set
        internal bool IsSetDefaultVersion()
        {
            return this._defaultVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndOfExtendedSupportDate. 
        /// <para>
        /// Date when extended support ends for this version.
        /// </para>
        /// </summary>
        public DateTime? EndOfExtendedSupportDate
        {
            get { return this._endOfExtendedSupportDate; }
            set { this._endOfExtendedSupportDate = value; }
        }

        // Check to see if EndOfExtendedSupportDate property is set
        internal bool IsSetEndOfExtendedSupportDate()
        {
            return this._endOfExtendedSupportDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndOfStandardSupportDate. 
        /// <para>
        /// Date when standard support ends for this version.
        /// </para>
        /// </summary>
        public DateTime? EndOfStandardSupportDate
        {
            get { return this._endOfStandardSupportDate; }
            set { this._endOfStandardSupportDate = value; }
        }

        // Check to see if EndOfStandardSupportDate property is set
        internal bool IsSetEndOfStandardSupportDate()
        {
            return this._endOfStandardSupportDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KubernetesPatchVersion. 
        /// <para>
        /// The patch version of Kubernetes for this cluster version.
        /// </para>
        /// </summary>
        public string KubernetesPatchVersion
        {
            get { return this._kubernetesPatchVersion; }
            set { this._kubernetesPatchVersion = value; }
        }

        // Check to see if KubernetesPatchVersion property is set
        internal bool IsSetKubernetesPatchVersion()
        {
            return this._kubernetesPatchVersion != null;
        }

        /// <summary>
        /// Gets and sets the property ReleaseDate. 
        /// <para>
        /// The release date of this cluster version.
        /// </para>
        /// </summary>
        public DateTime? ReleaseDate
        {
            get { return this._releaseDate; }
            set { this._releaseDate = value; }
        }

        // Check to see if ReleaseDate property is set
        internal bool IsSetReleaseDate()
        {
            return this._releaseDate.HasValue; 
        }

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
        public ClusterVersionStatus Status
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
        /// Gets and sets the property VersionStatus. 
        /// <para>
        /// Current status of this cluster version.
        /// </para>
        /// </summary>
        public VersionStatus VersionStatus
        {
            get { return this._versionStatus; }
            set { this._versionStatus = value; }
        }

        // Check to see if VersionStatus property is set
        internal bool IsSetVersionStatus()
        {
            return this._versionStatus != null;
        }

    }
}