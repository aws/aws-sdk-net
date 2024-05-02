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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
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
namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Describes a cluster version, including the parameter group family and description
    /// of the version.
    /// </summary>
    public partial class ClusterVersion
    {
        private string _clusterParameterGroupFamily;
        private string _description;
        private string _version;

        /// <summary>
        /// Gets and sets the property ClusterParameterGroupFamily. 
        /// <para>
        /// The name of the cluster parameter group family for the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string ClusterParameterGroupFamily
        {
            get { return this._clusterParameterGroupFamily; }
            set { this._clusterParameterGroupFamily = value; }
        }

        // Check to see if ClusterParameterGroupFamily property is set
        internal bool IsSetClusterParameterGroupFamily()
        {
            return this._clusterParameterGroupFamily != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the cluster version.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version number used by the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

    }
}