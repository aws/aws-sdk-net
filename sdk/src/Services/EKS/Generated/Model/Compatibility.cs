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
    /// Compatibility information.
    /// </summary>
    public partial class Compatibility
    {
        private string _clusterVersion;
        private bool? _defaultVersion;
        private List<string> _platformVersions = new List<string>();

        /// <summary>
        /// Gets and sets the property ClusterVersion. 
        /// <para>
        /// The supported Kubernetes version of the cluster.
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
        /// Gets and sets the property DefaultVersion. 
        /// <para>
        /// The supported default version.
        /// </para>
        /// </summary>
        public bool DefaultVersion
        {
            get { return this._defaultVersion.GetValueOrDefault(); }
            set { this._defaultVersion = value; }
        }

        // Check to see if DefaultVersion property is set
        internal bool IsSetDefaultVersion()
        {
            return this._defaultVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PlatformVersions. 
        /// <para>
        /// The supported compute platform.
        /// </para>
        /// </summary>
        public List<string> PlatformVersions
        {
            get { return this._platformVersions; }
            set { this._platformVersions = value; }
        }

        // Check to see if PlatformVersions property is set
        internal bool IsSetPlatformVersions()
        {
            return this._platformVersions != null && this._platformVersions.Count > 0; 
        }

    }
}