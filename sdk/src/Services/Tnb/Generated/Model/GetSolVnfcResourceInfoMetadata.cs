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
 * Do not modify this file. This file is generated from the tnb-2008-10-21.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Tnb.Model
{
    /// <summary>
    /// The metadata of a network function.
    /// 
    ///  
    /// <para>
    /// A network instance is a single network created in Amazon Web Services TNB that can
    /// be deployed and on which life-cycle operations (like terminate, update, and delete)
    /// can be performed.
    /// </para>
    /// </summary>
    public partial class GetSolVnfcResourceInfoMetadata
    {
        private string _cluster;
        private string _helmChart;
        private string _nodeGroup;

        /// <summary>
        /// Gets and sets the property Cluster. 
        /// <para>
        /// Information about the cluster.
        /// </para>
        /// </summary>
        public string Cluster
        {
            get { return this._cluster; }
            set { this._cluster = value; }
        }

        // Check to see if Cluster property is set
        internal bool IsSetCluster()
        {
            return this._cluster != null;
        }

        /// <summary>
        /// Gets and sets the property HelmChart. 
        /// <para>
        /// Information about the helm chart.
        /// </para>
        /// </summary>
        public string HelmChart
        {
            get { return this._helmChart; }
            set { this._helmChart = value; }
        }

        // Check to see if HelmChart property is set
        internal bool IsSetHelmChart()
        {
            return this._helmChart != null;
        }

        /// <summary>
        /// Gets and sets the property NodeGroup. 
        /// <para>
        /// Information about the node group.
        /// </para>
        /// </summary>
        public string NodeGroup
        {
            get { return this._nodeGroup; }
            set { this._nodeGroup = value; }
        }

        // Check to see if NodeGroup property is set
        internal bool IsSetNodeGroup()
        {
            return this._nodeGroup != null;
        }

    }
}